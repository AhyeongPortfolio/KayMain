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
          SelectSQL = @"select papp_pos_nm, count(papp_empno) FROM kay_insa_papp
                            WHERE TO_DATE(papp_date, 'YYYYMMDD') <= :papp_date
                            AND papp_pos_cd LIKE :pos_cd
                            GROUP BY papp_pos_nm";

        //************************************************************************
        //** 부서검색박스 채우기
        //************************************************************************
        public static string
            SelectSQL1 = @"SELECT cd_code, cd_codnm FROM kay_insa_cd WHERE cd_grpcd = 'POS' AND cd_use = 'Y'";

    }
}
