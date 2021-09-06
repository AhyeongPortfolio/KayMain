using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub006
{
     /// <summary>
     /// **********************************************************************
     /// --Project             : 인사관리시스템(ver2)
     /// --Form Name           : 가족사항 관리 SQL 
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
            SelectSQL1 = @"SELECT kay_insa_fam.*
                            ,FN_GETCODE_KAY('REL', fam_rel) as rel
                            FROM kay_insa_fam 
                            WHERE fam_empno = :bas_empno";

        #endregion
        #region 추가

        //******************************
        //--추가
        //******************************
        public static string
            InsertSQL = @"INSERT INTO kay_insa_fam
                           (FAM_EMPNO       ,FAM_REL           ,FAM_NAME
                            ,FAM_BTH        ,FAM_LTG           ,DATASYS3
                            ,DATASYS2       ,DATASYS4)
                            VALUES  
                           (:FAM_EMPNO      ,:FAM_REL          ,:FAM_NAME
                            ,:FAM_BTH       ,:FAM_LTG          ,'A'
                            ,:DATASYS3      ,:DATASYS4) ";
        #endregion
        #region 수정

        //******************************
        //--수정
        //******************************
        public static string
            UpdateSQL = @"UPDATE kay_insa_fam SET
                         FAM_EMPNO = :FAM_EMPNO
                        ,FAM_REL   = :FAM_REL
                        ,FAM_NAME  = :FAM_NAME
                        ,FAM_BTH   = :FAM_BTH
                        ,FAM_LTG   = :FAM_LTG
                        ,DATASYS2  = 'U'
                        ,DATASYS3  = :DATASYS3        
                        ,DATASYS4  = :DATASYS4
                        WHERE FAM_EMPNO = :Key1
                        AND FAM_REL = :Key2
                        AND FAM_NAME = :Key3 ";
        #endregion
        #region 삭제

        //******************************
        //--삭제
        //******************************
        public static string
            DeleteSQL = @"DELETE FROM kay_insa_fam WHERE fam_empno = :Key1 AND fam_rel = :Key2 AND fam_name = :Key3";

        #endregion
        #region 콤보박스 
        //******************************
        //--콤보박스 쿼리(가족관계)
        //******************************
        public static string
            SelectSQL2 = @"SELECT cd_code||':'||cd_codnm as cd FROM kay_insa_cd WHERE cd_grpcd = 'REL'";

        #endregion
    }
}
