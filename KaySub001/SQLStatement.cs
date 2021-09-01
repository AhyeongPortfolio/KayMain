using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub001
{
    /// <summary>
     /// **********************************************************************
     /// --Project             : 인사관리시스템(ver2)
     /// --최근작성 정보
     /// 1. 2021-08-31              권아영             신규생성
     /// **********************************************************************
     /// </summary>
    class SQLStatement
    {
        //******************************
        //--조회
        //******************************

        public static string
            SelectSQL = @"SELECT* FROM kay_insa_cdg 
                            WHERE cdg_grpcd LIKE :cdg_grpcd 
                            AND cdg_grpnm LIKE :cdg_grpnm
                            AND cdg_use LIKE :cdg_use
                            AND cdg_kind LIKE :cdg_kind";

        //******************************
        //--추가
        //******************************
        public static string
            InsertSQL = @"INSERT INTO kay_insa_cdg
                           ( cdg_grpcd, cdg_grpnm, cdg_digit, cdg_length, cdg_use, cdg_kind ) 
                            VALUES  
                           ( :cdg_grpcd, :cdg_grpnm, :cdg_digit, :cdg_length, :cdg_use, :cdg_kind ) ";


        //******************************
        //--수정
        //******************************
        public static string
            UpdateSQL = @"UPDATE kay_insa_cdg SET
                          cdg_grpcd = :cdg_grpcd,
                          cdg_grpnm = :cdg_grpnm,
                          cdg_digit = :cdg_digit,
                          cdg_length = :cdg_length,
                          cdg_use = :cdg_use,
                          cdg_kind = :cdg_kind
                          WHERE
                          cdg_grpcd = :key1";

        //******************************
        //--삭제
        //******************************
        public static string
            DeleteSQL = @"DELETE FROM kay_insa_cdg WHERE cdg_grpcd = :key1";

    }
}
