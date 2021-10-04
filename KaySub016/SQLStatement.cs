using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub016
{
    class SQLStatement
    {
        #region 검색
        //*---DataGridView1 채우는 용도---------
        public static string
            SelectSQL = @"SELECT * FROM kay_insa_evali
                          WHERE evali_type LIKE :evali_type ";

        //*---콤보박스 채우는 용도-------------
        public static string
            SelectSQL2 = @"SELECT DISTINCT evali_type FROM kay_insa_evali";
        #endregion

        #region 추가
        public static string
            InsertSQL = @"INSERT INTO kay_insa_evalp(EVALI_TYPE
                                                    ,EVALI_ITMENO
                                                    ,EVALI_ITEM_L
                                                    ,EVALI_ITEM_S
                                                    ,EVALI_POINTS
                                                    ,EVALI_GAP
                                                    ,DATASYS2
                                                    ,DATASYS3
                                                    ,DATASYS4
                                                    ) VALUES
                                                    (:EVALI_TYPE
                                                    ,:EVALI_ITEMNO
                                                    ,:EVALI_ITMENO
                                                    ,:EVALI_ITEM_L
                                                    ,:EVALI_ITEM_S
                                                    ,:EVALI_POINTS
                                                    ,:EVALI_GAP
                                                    ,'A'
                                                    ,:DATASYS3
                                                    ,:DATASYS4)";

        #endregion
        #region 수정
        public static string
            UpdateSQL = @"UPDATE kay_insa_evali SET
                          EVALI_TYPE = :EVALI_TYPE
                          ,EVALI_ITMENO = :EVALI_ITMENO
                          ,EVALI_ITEM_L = :EVALI_ITEM_L
                          ,EVALI_ITEM_S = :EVALI_ITEM_S
                          ,EVALI_POINTS = :EVALI_POINTS
                          ,EVALI_GAP = :EVALI_GAP
                          ,DATASYS2 = 'A'
                          ,DATASYS3 = :DATASYS3
                          ,DATASYS4 = :DATASYS4
                          WHERE EVALI_TYPE = :Key1
                          AND EVALI_ITMENO = :Key2";
        #endregion
        #region 삭제
        public static string
            DeleteSQL = @"DELETE FROM kay_insa_evali 
                          WHERE evali_type = :Key1 
                          AND evali_itemno = :Key2";

        #endregion
    }
}
