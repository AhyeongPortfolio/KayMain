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
    /// 2. 2021-09-09              권아영             신규생성
    /// **********************************************************************
    /// </summary>
    class SQLStatement
    {
        public static string
                   SelectSQL = @"SELECT a.bas_empno, a.bas_name
                                , a.bas_resno
                                , a.bas_fix
                                , a.bas_wsta
                                , a.bas_addr
                                , a.bas_anaddr
                                , a.bas_cont
                                ,a.bas_entdate
                                ,a.bas_levdate
                                ,FN_GETCODENM_KAY('POS', bas.bas_pos) as pos 
                                ,FN_GETCODE_KAY('DUT', bas.bas_dut) as sts 
                                ,FN_GETCODE_KAY('STS', bas.bas_sts) as dept 
                                FROM kay_insa_bas a
                                WHERE a.bas_empno = :empno";

    }
}
