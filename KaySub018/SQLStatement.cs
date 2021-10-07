using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub018
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Program name        : 업무평가대상자 관리
    /// --최근작성 정보
    /// 1. 2021-10-04              권아영             신규생성
    /// **********************************************************************
    /// </summary>
    class SQLStatement
    {
        #region 검색
        //*---DataGridView1 채우는 용도---------
        public static string
            SelectSQL = @"SELECT a.*,b.bas_name as tee_name ,c.bas_name as tor_name
                         FROM kay_insa_evalm a,
                              (SELECT bas_name, bas_empno FROM kay_insa_bas) b,
                              (SELECT bas_name, bas_empno FROM kay_insa_bas) c
                         WHERE a.evalm_tee = b.bas_empno(+)
                         AND a.evalm_tor = c.bas_empno(+)
                         AND a.evalm_year LIKE :evalm_year
                         AND a.evalm_no LIKE :evalm_no
                         AND a.evalm_tee LIKE :evalm_tee
                         AND a.evalm_tor LIKE :evalm_tor
                         AND a.evalm_type = :evalm_type";

        //*--사원 번호 검색---------------------------------------------------------------------
        public static string
            SelectSQL2 = @"SELECT bas_empno FROM kay_insa_bas WHERE bas_name = :bas_name";

        //*--평가 유형 검색----------------------------------------------------------------------
        public static string
            SelectSQL3 = @"SELECT DISTINCT evali_type FROM kay_insa_evali";

        //*--부서 검색--------------------------------------------------------------------------
        public static string
            SelectSQL_dept = @"SELECT dept_name FROM kay_insa_dept";

        //*--평가자 검색-----------------------------------------------------------------------
        public static string
            SelectSQL_tor = @"SELECT bas.bas_empno, bas.bas_name, bas.bas_pos, bas.bas_dut, bas.bas_dept
                              ,FN_GETCODENM_KAY('POS', bas.bas_pos) as pos_name
                              ,FN_GETCODENM_KAY('DUT', bas.bas_dut) as dut_name
                              ,FN_GETDEPTNM_KAY(bas.bas_dept) as dept_name
                              FROM kay_insa_bas bas WHERE bas.bas_dut LIKE '%'";

        //*--피평가자 검색(직급이 없음)----------------------------------------------------------
        public static string
            SelectSQL_tee = @"SELECT bas.bas_empno, bas.bas_name, bas.bas_pos, bas.bas_dept
                              ,FN_GETCODENM_KAY('POS', bas.bas_pos) as pos_name
                              ,FN_GETDEPTNM_KAY(bas.bas_dept) as dept_name
                              FROM kay_insa_bas bas";
        #endregion

        #region 추가
        public static string
            InsertSQL = @"INSERT INTO kay_insa_evalm(EVALM_YEAR
                                                    ,EVALM_NO
                                                    ,EVALM_TEE
                                                    ,EVALM_STAGE
                                                    ,EVALM_TOR
                                                    ,EVALM_TYPE
                                                    ,EVALM_PERIOD
                                                    ,evalm_dept_tee
                                                    ,evalm_pos_tee
                                                    ,evalm_dept_tor
                                                    ,evalm_pos_tor
                                                    ,evalm_dut_tor
                                                    , DATASYS2
                                                    , DATASYS3
                                                    , DATASYS4
                                                    ) VALUES
                                                    (:EVALM_YEAR
                                                    ,:EVALM_NO
                                                    ,:EVALM_TEE
                                                    ,:EVALM_STAGE
                                                    ,:EVALM_TOR
                                                    ,:EVALM_TYPE
                                                    ,:EVALM_PERIOD
                                                    ,:evalm_dept_tee
                                                    ,:evalm_pos_tee
                                                    ,:evalm_dept_tor
                                                    ,:evalm_pos_tor
                                                    ,:evalm_dut_tor
                                                    ,'A'
                                                    ,:DATASYS3
                                                    ,:DATASYS4)";

        #endregion
        #region 수정
        public static string
            UpdateSQL  = @"UPDATE kay_insa_evalm SET
                          ,EVALM_YEAR = :EVALM_YEAR
                          ,EVALM_NO = :EVALM_NO
                          ,EVALM_TEE = :EVALM_TEE
                          ,EVALM_STAGE
                          ,EVALM_TOR
                          ,EVALM_TYPE
                          ,EVALM_PERIOD
                          ,DATASYS2 = 'A'
                          ,DATASYS3 = :DATASYS3
                          ,DATASYS4 = :DATASYS4
                          ,evalm_dept_tee = :evalm_dept_tee
                          ,evalm_pos_tee = :evalm_pos_tee
                          ,evalm_dept_tor = :evalm_dept_tor
                          ,evalm_pos_tor = :evalm_pos_tor
                          ,evalm_dut_tor = :evalm_dut_tor
                          WHERE EVALM_YEAR = :Key1
                          AND EVALM_NO = :Key2
                          AND EVALM_TEE = :Key3
                          AND EVALM_STAGE = :Key4";


        #endregion
        #region 삭제
        public static string
            DeleteSQL = @"DELETE FROM kay_insa_evalm 
                          WHERE evalm_year = :Key1 
                          AND evalm_no = :Key2
                          AND evalm_tee = :Key3
                          AND evalm_stage = :Key4";

        #endregion
    }
}
