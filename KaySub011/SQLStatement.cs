using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub011
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 언어 자격증 관리 SQL 
    /// --최근작성 정보
    /// 1. 2021-09-07              권아영             신규생성
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
            SelectSQL = @"SELECT bas.bas_empno
                           ,bas.bas_name
                           ,FN_GETCODE_KAY('POS', bas.bas_pos) as pos
                           ,FN_GETDEPT_KAY(bas.bas_dept) as dept
                            FROM kay_insa_bas bas
                            WHERE bas.bas_empno LIKE :bas_empno
                            AND bas.bas_name LIKE :bas_name
                            AND bas.bas_wsta = '재직'";

        //******************************
        //--경력사항 조회
        //******************************
        public static string
            SelectSQL1 = @"SELECT *                       
                            FROM kay_insa_forl
                            WHERE FORL_EMPNO = :bas_empno";

        #endregion
        #region 추가
        //******************************
        //--추가
        //******************************
        public static string
            InsertSQL = @"INSERT INTO kay_insa_forl
                           (
                                FORL_EMPNO
                                ,FORL_NAME
                                ,FORL_SCORE
                                ,FORL_ACQDATE
                                ,FORL_ORGAN
                                ,DATASYS2
                                ,DATASYS3
                                ,DATASYS4
                           )
                            VALUES  
                           (
                               :FORL_EMPNO
                               , :FORL_NAME
                               , :FORL_SCORE
                               , :FORL_ACQDATE
                               , :FORL_ORGAN
                               , 'A'
                               , :DATASYS3
                               , :DATASYS4
                           ) ";
        #endregion
        #region 수정
        //******************************
        //--수정
        //******************************
        public static string
            UpdateSQL = @"UPDATE kay_insa_forl SET
                               FORL_EMPNO       = :FORL_EMPNO
                               ,FORL_NAME       = :FORL_NAME
                               ,FORL_SCORE      = :FORL_SCORE
                               ,FORL_ACQDATE    = :FORL_ACQDATE
                               ,FORL_ORGAN      = :FORL_ORGAN
                               ,DATASYS2        = 'U'
                               ,DATASYS3        = :DATASYS3
                               ,DATASYS4        = :DATASYS4
                            WHERE FORL_EMPNO = :Key1
                            AND FORL_NAME = :Key2";
        #endregion
        #region 삭제
        //******************************
        //--삭제
        //******************************
        public static string
            DeleteSQL = @"DELETE FROM kay_insa_FORL WHERE FORL_EMPNO = :Key1 AND FORL_NAME = :Key2";

        #endregion
        #region 콤보박스 
        //******************************
        //--콤보박스 쿼리(LIC)
        //******************************
        public static string
            SelectSQL2 = @"SELECT cd_codnm as code 
                            FROM kay_insa_cd 
                            WHERE cd_grpcd = 'FOR'
                            AND cd_use = 'Y'";

        ////******************************
        ////--콤보박스 쿼리(DEPT)
        ////******************************
        //public static string
        //    SelectSQL3 = @"SELECT dept_code||':'||dept_name as code
        //                     FROM kay_insa_dept 
        //                     WHERE dept_use = 'Y'";



        #endregion
    }
}
