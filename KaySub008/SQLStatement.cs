using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub008
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 수상내역 관리 SQL 
    /// --최근작성 정보
    /// 1. 2021-09-06              권아영             신규생성
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
        //--수상경력사항 조회
        //******************************
        public static string
            SelectSQL1 = @"SELECT *,
                            ,FN_GETCODE_KAY('POS', award_pos) as pos1
                            ,FN_GETDEPT_KAY(award_dept) as dept1                           
                            FROM kay_insa_award 
                            WHERE award_empno = :bas_empno";

        #endregion
        #region 추가
        //******************************
        //--추가
        //******************************
        public static string
            InsertSQL = @"INSERT INTO kay_insa_award
                           (
                                AWARD_EMPNO
                                ,AWARD_DATE
                                ,AWARD_NO
                                ,AWARD_KIND
                                ,AWARD_ORGAN
                                ,AWARD_CONTENT
                                ,AWARD_INOUT
                                ,AWARD_POS
                                ,AWARD_DEPT
                                ,DATASYS2
                                ,DATASYS3
                                ,DATASYS4
                           )
                            VALUES  
                           (
                                :AWARD_EMPNO
                               ,:AWARD_DATE
                               ,:AWARD_NO
                               ,:AWARD_KIND
                               ,:AWARD_ORGAN
                               ,:AWARD_CONTENT
                               ,:AWARD_INOUT
                               ,:AWARD_POS
                               ,:AWARD_DEPT
                               ,'A'
                               ,:DATASYS3
                               ,:DATASYS4
                           ) ";
        #endregion
        #region 수정
        //******************************
        //--수정
        //******************************
        public static string
            UpdateSQL = @"UPDATE kay_insa_award SET
                             AWARD_EMPNO   =:AWARD_EMPNO
                            ,AWARD_DATE    =:AWARD_DATE
                            ,AWARD_NO      =:AWARD_NO
                            ,AWARD_KIND    =:AWARD_KIND
                            ,AWARD_ORGAN   =:AWARD_ORGAN
                            ,AWARD_CONTENT =:AWARD_CONTENT
                            ,AWARD_INOUT   =:AWARD_INOUT
                            ,AWARD_POS     =:AWARD_POS
                            ,AWARD_DEPT    =:AWARD_DEPT
                            ,DATASYS2      =:DATASYS2
                            ,DATASYS3      =:DATASYS3
                            ,DATASYS4      =:DATASYS4";
        #endregion
        #region 삭제
        //******************************
        //--삭제
        //******************************
        public static string
            DeleteSQL = @"DELETE FROM kay_insa_award WHERE award_empno = :Key1 AND award_date = :Key2 AND award_no = :Key3";

        #endregion
        #region 콤보박스 
        //******************************
        //--콤보박스 쿼리(POS)
        //******************************
        public static string
            SelectSQL2 = @"SELECT cd_code||':'||cd_codnm as code 
                            FROM kay_insa_cd 
                            WHERE cd_grpcd = 'POS'
                            AND cd_use = 'Y'";

        //******************************
        //--콤보박스 쿼리(DEPT)
        //******************************
        public static string
            SelectSQL3 = @"SELECT dept_code||':'||dept_name as code
                             FROM kay_insa_dept 
                             WHERE dept_use = 'Y'";



        #endregion
    }
}
