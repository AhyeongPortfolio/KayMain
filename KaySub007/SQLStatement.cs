using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub007
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 학력사항 관리 SQL 
    /// --최근작성 정보
    /// 1. 2021-09-06              권아영             신규생성
    /// **********************************************************************
    /// </summary>
    /// 
    class SQLStatement
    {
        #region 조회
        //******************************
        //--조회
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

        public static string
            SelectSQL1 = @"SELECT *
                            FROM kay_insa_edu 
                            WHERE edu_empno = :bas_empno";

        #endregion
        #region 추가
        //******************************
        //--추가
        //******************************
        public static string
            InsertSQL = @"INSERT INTO kay_insa_edu
                           (
                             EDU_EMPNO
                            ,EDU_LOE
                            ,EDU_ENTDATE
                            ,EDU_GRADATE
                            ,EDU_SCHNM
                            ,EDU_DEPT
                            ,EDU_DEGREE
                            ,EDU_GRADE
                            ,EDU_GRA
                            ,EDU_LAST
                            ,DATASYS2
                            ,DATASYS3
                            ,DATASYS4
                           )
                            VALUES  
                           (
                             :EDU_EMPNO
                            ,:EDU_LOE
                            ,:EDU_ENTDATE
                            ,:EDU_GRADATE
                            ,:EDU_SCHNM
                            ,:EDU_DEPT
                            ,:EDU_DEGREE
                            ,:EDU_GRADE
                            ,:EDU_GRA
                            ,:EDU_LAST
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
            UpdateSQL = @"UPDATE kay_insa_edu SET
                         EDU_EMPNO = :EDU_EMPNO
                        ,EDU_LOE = :EDU_LOE 
                        ,EDU_ENTDATE = :EDU_ENTDATE
                        ,EDU_GRADATE = :EDU_GRADATE
                        ,EDU_SCHNM = :EDU_SCHNM
                        ,EDU_DEPT = :EDU_DEPT
                        ,EDU_DEGREE = :EDU_DEGREE
                        ,EDU_GRADE = :EDU_GRADE
                        ,EDU_GRA = :EDU_GRA
                        ,EDU_LAST = :EDU_LAST                        
                        ,DATASYS2 = 'U'
                        ,DATASYS3 = :DATASYS3
                        ,DATASYS4 = :DATASYS4
                        WHERE EDU_EMPNO = :Key1
                        AND EDU_LOE = :Key2
                        AND EDU_ENTDATE = :Key3 ";
        #endregion
        #region 삭제
        //******************************
        //--삭제
        //******************************
        public static string
            DeleteSQL = @"DELETE FROM kay_insa_edu WHERE edu_empno = :Key1 AND edu_loe = :Key2 AND edu_entdate = :Key3";

        #endregion
        #region 콤보박스 
        //******************************
        //--콤보박스 쿼리(가족관계)
        //******************************
        //public static string
        //    SelectSQL2 = @"SELECT cd_code||':'||cd_codnm as cd FROM kay_insa_cd WHERE cd_grpcd = 'REL'";

        #endregion
    }
}
