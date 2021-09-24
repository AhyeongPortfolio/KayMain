using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub026
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 부서별 통계쿼리문
    /// --최근작성 정보
    /// 2. 2021-09-13              권아영             신규생성
    /// **********************************************************************
    /// </summary>
    class SQLStatement
    {

        //**********************************************************************
        //**현재시점 부서별 인원 수
        //**********************************************************************
        public static string
            SelectSQL = @"SELECT nvl(B.dept_name, '퇴사자') as 부서명 
                            , nvl(A.남자, 0) as 남자, nvl(A.여자, 0) as 여자, nvl(A.합계, 0) as 총인원수
                            FROM (                            
                            SELECT A.bas_dept as 부서명
                            ,sum(decode(bas_fix, '남', 1, 0)) as 남자 
                            ,sum(decode(bas_fix, '여', 1, 0)) as 여자
                            ,COUNT(A.bas_fix) 합계 
                            from kay_insa_bas A
                            group by A.bas_dept, A.bas_wsta
                            ) A, kay_insa_dept B
                            where A.부서명(+) = B.dept_code                            
                            ";

        //**********************************************************************
        //**특정시점 부서별 인원 수
        //**********************************************************************
        public static string
            SelectSQL2 = @"SELECT 
                             D.dept_name as 부서명
                            ,nvl(sum(decode(C.bas_fix, '남', 1, 0)),0) as 남자 
                            ,nvl(sum(decode(C.bas_fix, '여', 1, 0)),0) as 여자
                            ,nvl(count(C.bas_fix),0) as 총인원수
                           FROM
                            (SELECT papp_empno,papp_date, papp_pap,papp_content, papp_dept_nm FROM
                            (SELECT a.*, ROW_NUMBER() OVER (PARTITION BY papp_empno ORDER BY papp_date desc) AS rank
                             FROM kay_insa_papp a
                             where papp_date <= :papp_date)
                             where rank = 1
                             and papp_pap = '01' OR papp_pap = '06' OR papp_pap = '31'
                             )B, kay_insa_bas C, kay_insa_dept D
                             WHERE B.papp_empno = C.bas_empno(+)
                             and B.papp_dept_nm(+) = D.dept_name
                             group by D.dept_name
                           ";
        

        //************************************************************************
        //** 부서검색박스 채우기
        //************************************************************************
        public static string
            SelectSQL1 = @"SELECT dept_name as code
                            FROM kay_insa_dept 
                            WHERE dept_use = 'Y'";

    }
}
