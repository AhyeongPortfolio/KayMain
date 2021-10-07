using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub021
{
    class SQLStatement
    {

        //*--사원 번호 검색---------------------------------------------------------------------
        public static string
            SelectSQL2 = @"SELECT bas_empno FROM kay_insa_bas WHERE bas_name = :bas_name";

        //*--평가 유형 검색----------------------------------------------------------------------
        public static string
            SelectSQL3 = @"SELECT DISTINCT evali_type FROM kay_insa_evali";
    }
}
