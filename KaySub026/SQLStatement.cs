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
        public static string
            SelectSQL = @"SELECT papp_dept_nm, count(papp_empno) FROM kay_insa_papp
                            WHERE TO_DATE(papp_date, 'YYYYMMDD') <= :papp_date
                            AND papp_pap = '01' OR papp_pap = '06' OR papp_pap = '31'
                            AND papp_dept_nm LIKE :dept_nm
                            GROUP BY papp_dept_nm";

        //************************************************************************
        //** 부서검색박스 채우기
        //************************************************************************
        public static string
            SelectSQL1 = @"SELECT dept_name as code
                            FROM kay_insa_dept 
                            WHERE dept_use = 'Y'";

    }
}
