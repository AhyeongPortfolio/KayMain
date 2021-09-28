using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub029
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 입사추이 통계 쿼리문
    /// --최근작성 정보
    /// 1. 2021-09-16              권아영             신규생성
    /// **********************************************************************
    /// </summary>
    class SQLStatement
    {

        //******************************************************************
        //**---전체 인원 수 / 월별
        //******************************************************************
        public static string
            SelectSQL = @"Select DISTINCT CAL_MONTH AS CAL_DATE
                            ,COUNT(BAS_EMPNO) AS BAS_EMPNO
                          FROM KAY_INSA_BAS, PKH_INSA_CAL
                          WHERE CAL_DATE between :cal_date1 and :cal_date2
                          AND BAS_ENTDATE(+) = CAL_DATE2
                          GROUP BY CAL_MONTH 
                          ORDER BY CAL_DATE";

        //******************************************************************
        //**---전체 인원 수 / 년도별
        //******************************************************************
        public static string
            SelectSQL2 = @"Select DISTINCT CAL_YEAR AS CAL_DATE
                            ,COUNT(BAS_EMPNO) AS BAS_EMPNO
                           from KAY_INSA_BAS, PKH_INSA_CAL
                           where CAL_DATE between :cal_date1 and :cal_date2
                           AND BAS_ENTDATE(+) = CAL_DATE2
                           GROUP BY CAL_YEAR  
                           ORDER BY CAL_DATE";

    }
}
