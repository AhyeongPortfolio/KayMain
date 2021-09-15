using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub025
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 증명서 발급대장 
    /// --최근작성 정보
    /// 2. 2021-09-09              권아영             신규생성
    /// **********************************************************************
    /// </summary>
    /// 
    class SQLStatement
    {
        #region 조회
        //******************************
        //--기본정보 조회
        //******************************

        public static string
            SelectSQL = @"SELECT 
                             A.CERI_EMPNO
                            ,A.CERI_KIND
                            ,A.CERI_DATE
                            ,A.CERI_LANG
                            ,A.CERI_NUM
                            ,A.CERI_CNT
                            ,A.CERI_SAU
                            ,B.BAS_NAME
                            FROM kay_insa_cerl A ,kay_insa_bas B
                            WHERE A.ceri_empno = B.bas_empno
                            AND A.CERI_EMPNO LIKE :CERI_EMPNO
                            AND B.BAS_NAME LIKE :bas_name";

        #endregion

        #region 증명서 사용 할 데이터

        //*****************************************
        // --재직 증명서
        //*****************************************
        public static string
            SelectSQL1 = @"SELECT a.bas_empno
                                ,a.bas_name
                                ,a.bas_resno
                                ,a.bas_addr
                                ,a.bas_anaddr
                                ,a.bas_cont
                                ,a.bas_entdate
                                ,a.bas_levdate
                                ,FN_GETCODENM_KAY('POS', a.bas_pos) as pos 
                                ,FN_GETDEPTNM_KAY(a.bas_dept) as dept
                                ,FN_GETCODENM_KAY('STS', a.bas_sts) as sts 
                                FROM kay_insa_bas a
                                WHERE a.bas_empno = :bas_empno";

        //*****************************************
        // --경력 증명서
        //*****************************************
        public static string
            SelectSQL2 = @"SELECT a.bas_name
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

        //*****************************************
        // --영문 재직 증명서
        //*****************************************
        public static string
            SelectSQL3 = @"SELECT a.bas_empno
                                ,a.bas_ename
                                ,a.bas_resno
                                ,a.bas_eaddr
                                ,a.bas_cont
                                ,a.bas_entdate
                                ,a.bas_levdate
                                ,FN_GETCODENM_KAY2('POS', a.bas_pos) as pos 
                                ,FN_GETDEPTNM_KAY2(a.bas_dept) as dept
                                ,FN_GETCODENM_KAY2('STS', a.bas_sts) as sts 
                                FROM kay_insa_bas a
                                WHERE a.bas_empno = :bas_empno";

        //*****************************************
        // --영문 경력 증명서
        //*****************************************
        public static string
            SelectSQL4 = @"SELECT a.bas_ename
                                    ,a.bas_empno
                                    ,a.bas_resno
                                    ,a.bas_eaddr
                                    ,b.papp_date
                                    ,b.papp_pos_enm
                                    ,b.papp_dut_enm
                                    ,b.papp_dept_enm 
                                    FROM KAY_INSA_BAS a, KAY_INSA_PAPP b 
                                    WHERE a.bas_empno = b.papp_empno(+) 
                                    AND a.bas_empno = :bas_empno ";
        #endregion

    }
}
