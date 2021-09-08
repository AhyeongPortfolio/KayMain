using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub013
{
    /// <summary>
 /// **********************************************************************
 /// --Project             : 인사관리시스템(ver2)
 /// --Form Name           : 인사발령대장
 /// --최근작성 정보
 /// 1. 2021-09-08             권아영             신규생성
 /// **********************************************************************
 /// </summary>
    class SQLStatement
    {
        #region 조회
        //******************************
        //--조회
        //******************************
        public static string
            SelectSQL = @" SELECT * FROM kay_insa_papr 
                            WHERE papr_appno LIKE :papr_appno 
                            AND papr_date BETWEEN :papr_date1 AND :papr_date2";

        //******************************
        //--삭제 할 수 있는지 확인 select
        //--Scalar로 확인
        //******************************
        public static string
            CheckSQL = @"SELECT COUNT(papp_appno) FROM kay_insa_papp
                            WHERE papp_appno = :papr_appno";

        #endregion
        #region 추가
        //******************************
        //--추가
        //******************************
        public static string
            InsertSQL = $@"INSERT INTO kay_insa_papr( 
                                PAPR_APPNO                                ,PAPR_DATE                                ,PAPR_CONTENT
                                ,PAPR_NUM                                ,DATASYS2                                ,DATASYS3
                                ,DATASYS4
                            ) VALUES
                            ( '{System.DateTime.Now.ToString("yyyy")}'||'-'|| PAPR_SEQ_KAY.NEXTVAL             
                               ,:PAPR_DATE                               ,:PAPR_CONTENT                               ,:PAPR_NUM
                               ,'A'                               ,:DATASYS3                               ,:DATASYS4)";

        #endregion
        #region 수정
        //******************************
        //--수정
        //******************************
        public static string
            UpdateSQL = @"UPDATE kay_insa_papr SET 
                            ,PAPR_CONTENT= :PAPR_CONTENT
                            ,PAPR_NUM    = :PAPR_NUM
                            ,DATASYS2    = 'U'
                            ,DATASYS3    = :DATASYS3
                            ,DATASYS4    = :DATASYS4
                            WHERE PAPR_APPNO  = :PAPR_APPNO
                            AND PAPR_DATE   = :PAPR_DATE";

        #endregion
        #region 삭제
        //******************************
        //--삭제
        //******************************
        
        public static string
            DeleteSQL = @"DELETE FROM kay_insa_papr 
                            WHERE papr_appno = :papr_appno
                            AND papr_date = :papr_date";

        #endregion
        #region 콤보박스 채우기

        #endregion
    }
}
