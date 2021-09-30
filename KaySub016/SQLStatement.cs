using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub016
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Program name        : 업무평가항목 및 기준 관리
    /// --최근작성 정보
    /// 1. 2021-09-29              권아영             신규생성
    /// **********************************************************************
    /// </summary>
    class SQLStatement
    {
        #region SELECT

        public static string
            SelectSQL = "SELECT * FROM kay_insa_evalp WHERE eval_year = :eval_year";
        #endregion

        #region 추가&수정&삭제
        public static string
            InsertSQL = @"INSERT INTO kay_insa_evalp(EVAL_YEAR
                                                     ,EVAL_NO
                                                     ,EVAL_PERIOD
                                                     ,EVAL_SDATE
                                                     ,EVAL_EDATE
                                                     ,DATASYS2
                                                     ,DATASYS3
                                                     ,DATASYS4) 
                                             VALUES (:EVAL_YEAR
                                                    ,:EVAL_NO
                                                    ,:EVAL_PERIOD
                                                    ,:EVAL_SDATE
                                                    ,:EVAL_EDATE
                                                    ,'A'
                                                    ,:DATASYS3
                                                    ,:DATASYS4)";

        public static string
            UpdateSQL = @"UPDATE kay_insa_evalp SET
                          EVAL_YEAR     = :EVAL_YEAR
                          ,EVAL_NO      = :EVAL_NO
                          ,EVAL_PERIOD  = :EVAL_PERIOD
                          ,EVAL_SDATE   = :EVAL_SDATE
                          ,EVAL_EDATE   = :EVAL_EDATE
                          ,DATASYS2     = 'U'
                          ,DATASYS3     = :DATASYS3
                          ,DATASYS4    = :DATASYS4";


        public static string
            DeleteSQL = @"DELETE FROM kay_insa_evalp
                          WHERE eval_year = :eval_year
                          AND eval_no = :eval_no";
        #endregion

    }
}
