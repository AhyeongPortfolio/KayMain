using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub028
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 재직인원 추이 쿼리문
    /// --최근작성 정보
    /// 1. 2021-09-15              권아영             신규생성
    /// **********************************************************************
    /// </summary>
    class SQLStatement
    {
        //******************************************************************
        //**---전체 인원 수 / 월별
        //******************************************************************
        public static string
            SelectSQL = @"SELECT SUBSTR(CAL_DATE,0,7) AS 날짜, COUNT(*) AS 인원수 FROM(
                            SELECT DISTINCT CAL_DATE CAL_DATE, PAPP_EMPNO FROM KAY_INSA_PAPP, PKH_INSA_CAL
                                WHERE(CAL_DATE, PAPP_EMPNO, PAPP_APPNO, TO_DATE(PAPP_DATE, 'YYYYMMDD')) IN (
                                 (SELECT CAL_DATE, PAPP_EMPNO, MAX(PAPP_APPNO), MAX(TO_DATE(PAPP_DATE, 'YYYYMMDD')) PAPP_APPNO
                                   FROM KAY_INSA_PAPP,(
                                    SELECT MAX(CAL_DATE) CAL_DATE FROM PKH_INSA_CAL
                                        WHERE CAL_DATE BETWEEN :cal_date1 AND :cal_date2
                                        GROUP BY SUBSTR(CAL_DATE, 0, 7))
                                   WHERE TO_DATE(PAPP_DATE, 'YYYYMMDD') <= CAL_DATE GROUP BY CAL_DATE, PAPP_EMPNO
                                   )
                                )
                                AND PAPP_PAP NOT IN('55','53')
                            )
                        GROUP BY CAL_DATE
                        ORDER BY CAL_DATE";

        //******************************************************************
        //**---전체 인원 수 / 년도별
        //******************************************************************
        public static string
            SelectSQL2 = @"SELECT SUBSTR(CAL_DATE,0,4) AS 날짜, COUNT(*) AS 인원수 FROM(
                            SELECT DISTINCT CAL_DATE CAL_DATE, PAPP_EMPNO FROM KAY_INSA_PAPP, PKH_INSA_CAL
                                WHERE(CAL_DATE, PAPP_EMPNO, PAPP_APPNO, TO_DATE(PAPP_DATE, 'YYYYMMDD')) IN (
                                 (SELECT CAL_DATE, PAPP_EMPNO, MAX(PAPP_APPNO), MAX(TO_DATE(PAPP_DATE, 'YYYYMMDD')) PAPP_APPNO
                                   FROM KAY_INSA_PAPP,(
                                    SELECT MAX(CAL_DATE) CAL_DATE FROM PKH_INSA_CAL
                                        WHERE CAL_DATE BETWEEN :cal_date1 AND :cal_date2 
                                        GROUP BY SUBSTR(CAL_DATE, 0, 4))
                                   WHERE TO_DATE(PAPP_DATE, 'YYYYMMDD') <= CAL_DATE GROUP BY CAL_DATE, PAPP_EMPNO
                                   )
                                )
                                AND PAPP_PAP NOT IN('55','53')
                            )
                        GROUP BY CAL_DATE
                        ORDER BY CAL_DATE";

        //******************************************************************
        //**---사직인원 추이 / 월별, 년도별
        //******************************************************************
        public static string
            SelectSQL3 = @"Select DISTINCT CAL_MONTH AS CAL_DATE
                            ,'-'||COUNT(BAS_EMPNO) AS BAS_EMPNO
                          from KAY_INSA_BAS, PKH_INSA_CAL
                          where CAL_DATE between :cal_date1 and :cal_date2
                          AND BAS_RESDATE(+) = CAL_DATE2
                          GROUP BY CAL_MONTH 
                          ORDER BY CAL_DATE";
        public static string
            SelectSQL4 = @"Select DISTINCT CAL_YEAR AS CAL_DATE
                            ,'-'||COUNT(BAS_EMPNO) AS BAS_EMPNO
                           from KAY_INSA_BAS, PKH_INSA_CAL
                           where CAL_DATE between :cal_date1 and :cal_date2
                           AND BAS_RESDATE(+) = CAL_DATE2
                           GROUP BY CAL_YEAR  
                           ORDER BY CAL_DATE";

        //******************************************************************
        //**---입사인원 추이 / 월별, 년도별
        //******************************************************************
        public static string
            SelectSQL5 = @"Select DISTINCT CAL_MONTH AS CAL_DATE
                            ,COUNT(BAS_EMPNO) AS BAS_EMPNO
                          FROM KAY_INSA_BAS, PKH_INSA_CAL
                          WHERE CAL_DATE between :cal_date1 and :cal_date2
                          AND BAS_ENTDATE(+) = CAL_DATE2
                          GROUP BY CAL_MONTH 
                          ORDER BY CAL_DATE";
        public static string
            SelectSQL6 = @"Select DISTINCT CAL_YEAR AS CAL_DATE
                            ,COUNT(BAS_EMPNO) AS BAS_EMPNO
                           from KAY_INSA_BAS, PKH_INSA_CAL
                           where CAL_DATE between :cal_date1 and :cal_date2
                           AND BAS_ENTDATE(+) = CAL_DATE2
                           GROUP BY CAL_YEAR  
                           ORDER BY CAL_DATE";
    }
}
