using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub027
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 직급별 통계쿼리문
    /// --최근작성 정보
    /// 1. 2021-09-13              권아영             신규생성
    /// 2. 2021-09-14              권아영             콤보박스 채울 쿼리문 생성
    /// **********************************************************************
    /// </summary>
    class SQLStatement
    {
        public static string
          SelectSQL = @"SELECT B.cd_codnm as 직급명, nvl(A.남자, 0) as 남자, nvl(A.여자, 0) as 여자, nvl(A.합계, 0) as 총인원수
                            FROM (                            
                                SELECT A.bas_pos as 직급명, sum(decode(bas_fix, '남', 1, 0)) as 남자, sum(decode(bas_fix, '여', 1, 0)) as 여자, COUNT(A.bas_fix) 합계 
                                from kay_insa_bas A
                                where bas_wsta = '재직'
                                group by A.bas_pos, A.bas_wsta
                            ) A, kay_insa_cd B
                            where A.직급명(+) = B.cd_code
                            and cd_grpcd = 'POS'
                            order by cd_seq desc";

        //************************************************************************
        //** 직급 시점별 검색
        //************************************************************************
        public static string
            SelectSQL2 = @"SELECT D.cd_codnm as 직급명
                            ,nvl(sum(decode(C.bas_fix, '남', 1, 0)),0) as 남자 
                            ,nvl(sum(decode(C.bas_fix, '여', 1, 0)),0) as 여자
                            ,nvl(count(C.bas_fix),0) as 총인원수 
                          FROM (                             
                             SELECT papp_empno,papp_date, papp_pap, 
                             papp_pos_nm, papp_pos_cd FROM
                                (SELECT a.*, ROW_NUMBER() OVER (PARTITION BY papp_empno ORDER BY papp_date desc) AS rank
                                 FROM kay_insa_papp a
                                 where papp_date <= :papp_date
                              )
                            where rank = 1
                            AND papp_pap in ('01','07','08','32')
                          )B, kay_insa_bas C, kay_insa_cd D
                          WHERE B.papp_empno = C.bas_empno(+)
                          AND B.papp_pos_cd(+)= D.cd_code
                          AND D.cd_grpcd = 'POS'
                          group by D.cd_codnm,D.cd_seq
                          order by D.cd_seq desc";



        //************************************************************************
        //** 부서검색박스 채우기
        //************************************************************************
        public static string
            SelectSQL1 = @"SELECT cd_code||':'||cd_codnm FROM kay_insa_cd WHERE cd_grpcd = 'POS' AND cd_use = 'Y'";

    }
}
