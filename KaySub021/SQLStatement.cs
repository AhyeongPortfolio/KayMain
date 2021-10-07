using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub021
{
    class SQLStatement
    {
        public static string
            SelectSQL = @"SELECT a.*,b.bas_name as tee_name ,c.bas_name as tor_name
                         FROM kay_insa_evalm a,
                              (SELECT bas_name, bas_empno FROM kay_insa_bas) b,
                              (SELECT bas_name, bas_empno FROM kay_insa_bas) c
                         WHERE a.evalm_tee = b.bas_empno(+)
                         AND a.evalm_tor = c.bas_empno(+)
                         AND a.evalm_year LIKE :evalm_year
                         AND a.evalm_no LIKE :evalm_no
                         AND a.evalm_tor LIKE :evalm_tor
                         AND a.evalm_type LIKE :evalm_type";

        //*--사원 번호 검색---------------------------------------------------------------------
        public static string
            SelectSQL2 = @"SELECT bas_empno FROM kay_insa_bas WHERE bas_name = :bas_name";

        //*--평가 유형 검색----------------------------------------------------------------------
        public static string
            SelectSQL3 = @"SELECT DISTINCT evali_type FROM kay_insa_evali";
    }
}
