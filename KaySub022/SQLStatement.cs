using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub022
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 재직증명서 
    /// --최근작성 정보
    /// 2. 2021-09-14              권아영             신규생성(새로만듬)
    /// **********************************************************************
    /// </summary>

    class SQLStatement
    {
        //***-----재직증명서----------------------------------------------------
        public static string
                   SelectSQL = @"SELECT a.bas_empno
                                ,a.bas_name
                                ,a.bas_resno
                                ,a.bas_addr
                                ,a.bas_anaddr
                                ,a.bas_cont
                                ,a.bas_entdate
                                ,a.bas_levdate
                                ,FN_GETCODENM_KAY('POS', a.bas_pos) as pos 
                                ,FN_GETDEPT_KAY(a.bas_dept) as dept
                                ,FN_GETCODE_KAY('STS', a.bas_sts) as sts 
                                FROM kay_insa_bas a
                                WHERE a.bas_empno = :bas_empno";

        //***----경력증명서------------------------------------------------------
        public static string
                   SelectSQL1 = @"SELECT a.bas_name
                                    ,a.bas_empno
                                    ,a.bas_resno
                                    ,a.bas_addr
                                    ,a.bas_anaddr
                                    ,b.papp_date
                                    ,b.papp_pos_nm
                                    ,b.papp_dut_nm
                                    ,b.papp_dept_nm 
                                    FROM KAY_INSA_BAS a, KAY_INSA_PAPP b 
                                    WHERE a.bas_empno = b.papp_empno(+) 
                                    AND a.bas_empno = :bas_empno ";

       
    }
}
