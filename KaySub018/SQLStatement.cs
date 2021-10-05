﻿using System;
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
            SelectSQL = @"SELECT a.evalm_year ,a.evalm_no ,a.evalm_tee ,a.evalm_stage ,a.evalm_tor
                                ,a.evalm_type ,a.evalm_period ,b.bas_name as tee_name ,c.bas_name as tor_name
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