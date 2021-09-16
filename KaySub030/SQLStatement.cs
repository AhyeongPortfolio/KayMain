using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub030
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 사직인원추이 통계 쿼리문
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
            SelectSQL = @"SELECT CAL_DATE as 날짜, SUM(NVL2(PAPP_EMPNO, 1, 0)) as 인원수 FROM(
                            SELECT DISTINCT SUBSTR(CAL_DATE, 0, 7) CAL_DATE, PAPP_EMPNO FROM KAY_INSA_PAPP, PKH_INSA_CAL
                                WHERE(CAL_DATE, PAPP_EMPNO, PAPP_APPNO, TO_DATE(PAPP_DATE, 'YYYYMMDD')) IN ((
                                    SELECT CAL_DATE, PAPP_EMPNO, MAX(PAPP_APPNO), MAX(CAL_DATE) PAPP_APPNO FROM KAY_INSA_PAPP, PKH_INSA_CAL
                                    WHERE CAL_DATE BETWEEN :cal_date1 AND :cal_date2
                                    AND PAPP_PAP = '55'
                                    AND TO_DATE(PAPP_DATE, 'YYYYMMDD') = CAL_DATE
                                    GROUP BY CAL_DATE, PAPP_EMPNO
                                    )
                             )
    
                            UNION
    
                            SELECT DISTINCT SUBSTR(CAL_DATE, 0, 7) CAL_DATE, PAPP_EMPNO FROM(
                                SELECT CAL_DATE, PAPP_EMPNO, MAX(PAPP_APPNO), MAX(CAL_DATE) PAPP_APPNO FROM KAY_INSA_PAPP, PKH_INSA_CAL
                                WHERE CAL_DATE BETWEEN :cal_date1 AND :cal_date2
                                AND PAPP_PAP IS NULL AND PAPP_DATE(+) = CAL_DATE
                                GROUP BY CAL_DATE, PAPP_EMPNO
                                )
                            )
                            GROUP BY CAL_DATE
                            ORDER BY CAL_DATE";

        //******************************************************************
        //**---전체 인원 수 / 년도별
        //******************************************************************
        public static string
            SelectSQL2 = @"SELECT CAL_DATE as 날짜, SUM(NVL2(PAPP_EMPNO, 1, 0)) as 인원수 FROM(
                            SELECT DISTINCT SUBSTR(CAL_DATE, 0, 4) CAL_DATE, PAPP_EMPNO FROM KAY_INSA_PAPP, PKH_INSA_CAL
                                WHERE(CAL_DATE, PAPP_EMPNO, PAPP_APPNO, TO_DATE(PAPP_DATE, 'YYYYMMDD')) IN ((
                                    SELECT CAL_DATE, PAPP_EMPNO, MAX(PAPP_APPNO), MAX(CAL_DATE) PAPP_APPNO FROM KAY_INSA_PAPP, PKH_INSA_CAL
                                    WHERE CAL_DATE BETWEEN :cal_date1 AND :cal_date2
                                    AND PAPP_PAP = '55'
                                    AND TO_DATE(PAPP_DATE, 'YYYYMMDD') = CAL_DATE
                                    GROUP BY CAL_DATE, PAPP_EMPNO
                                    )
                             )
    
                            UNION
    
                            SELECT DISTINCT SUBSTR(CAL_DATE, 0, 4) CAL_DATE, PAPP_EMPNO FROM(
                                SELECT CAL_DATE, PAPP_EMPNO, MAX(PAPP_APPNO), MAX(CAL_DATE) PAPP_APPNO FROM KAY_INSA_PAPP, PKH_INSA_CAL
                                WHERE CAL_DATE BETWEEN :cal_date1 AND :cal_date2
                                AND PAPP_PAP IS NULL AND PAPP_DATE(+) = CAL_DATE
                                GROUP BY CAL_DATE, PAPP_EMPNO
                                )
                            )
                            GROUP BY CAL_DATE
                            ORDER BY CAL_DATE";

    }
}
