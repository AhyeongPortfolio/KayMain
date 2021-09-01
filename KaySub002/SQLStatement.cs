using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub002
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 세부코드 관리 SQL 
    /// --최근작성 정보
    /// 1. 2021-09-01              권아영             신규생성
    /// **********************************************************************
    /// </summary>
    /// 
    class SQLStatement
    {
        //******************************
        //--조회
        //******************************

        public static string
            SelectSQL = @"SELECT* FROM kay_insa_cd 
                            WHERE cd_grpcd LIKE :cd_grpcd
                            AND cd_use LIKE :cd_use
                            AND ROWNUM <= 30";

        //******************************
        //--추가
        //******************************
        public static string
            InsertSQL = @"INSERT INTO kay_insa_cd VALUES (
                           ( cd_grpcd, cd_code, cd_seq, cd_codnms, cd_addinfo, cd_upper, cd_use, cd_sdate, cd_edate, datasys2, datasys3) 
                            VALUES  
                           ( :cd_grpcd, :cd_code, :cd_seq, :cd_codnms, :cd_addinfo, :cd_upper, :cd_use, ;cd_sdate, :cd_edate, 'A', :datasys3 ) ";


        //******************************
        //--수정
        //******************************
        public static string
            UpdateSQL = @"UPDATE kay_insa_cdg SET
                          cd_code = :cd_code,
                          cd_seq = :cd_seq,
                          cd_codnms = :cd_codnms,
                          cd_addinfo = :cd_addinfo,
                          cd_upper = :cd_upper,
                          cd_use = :cd_use,
                          cd_sdate = :cd_sdate,
                          cd_edate = :cd_edate,
                          datasys3 = :datasys3,
                          WHERE
                          cd_grpcd = :cd_grpcd
                          AND cd_code = :key1";

        //******************************
        //--삭제
        //******************************
        public static string
            DeleteSQL = @"DELETE FROM kay_insa_cdg WHERE cd_grpcd = :cd_grpcd AND cd_code = :key1";


        //******************************
        //--코드 검색 쿼리
        //******************************
        public static string
            SelectSQL1 = @"SELECT cdg_grpcd as CODEKEY, cdg_grpnm as CODENM FROM kay_insa_cdg
                            WHERE cdg_use = 'Y' ";

        //******************************
        //--그룹코드 콤보박스
        //******************************
        public static string
            SelectSQL2 = @"SELECT cdg_grpcd||':'||cdg_grpnm as grpcd FROM kay_insa_cdg WHERE cdg_use = 'Y'";

    }
}
