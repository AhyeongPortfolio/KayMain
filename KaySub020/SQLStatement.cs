using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub020
{
    class SQLStatement
    {
        //*---그리드 조회-------------------------------------------------------------------
        public static string
            SelectSQL = @"SELECT a.evalm_year, a.evalm_no, a.evalm_type, a.evalm_period,
                            a.evalm_dut_tor, a.evalm_dept_tor, a.evalm_pos_tor,
                            d.bas_name as tor_name, COUNT(evalm_tee) as tee_count, COUNT(evalm_findate) as tee_fincount,
                            MAX(evalm_findate) as evalm_findate , c.eval_edate, a.evalm_tor
                          FROM kay_insa_evalm a, 
                            kay_insa_bas d,
                            kay_insa_evalp c
                          WHERE a.evalm_year = c.eval_year(+)
                            AND a.evalm_no = c.eval_no
                            AND a.evalm_period = c.eval_period
                            AND a.evalm_tor = d.bas_empno
                            AND a.evalm_year LIKE :evalm_year
                            AND a.evalm_no LIKE :evalm_no
                            AND a.evalm_tor LIKE :evalm_tor
                            AND a.evalm_type LIKE :evalm_type                          
                          GROUP BY a.evalm_year, a.evalm_no, a.evalm_type, a.evalm_dut_tor, a.evalm_dept_tor, 
                                   a.evalm_pos_tor, d.bas_name, c.eval_edate, a.evalm_tor, a.evalm_period";

        //*---평가유형 검색----------------------------------------------------------------
        public static string
            SelectSQL2 = @"SELECT DISTINCT evali_type FROM kay_insa_evali";

        //*--사원 번호 검색---------------------------------------------------------------------
        public static string
            SelectSQL3 = @"SELECT bas_empno FROM kay_insa_bas WHERE bas_name = :bas_name";

    }
}
