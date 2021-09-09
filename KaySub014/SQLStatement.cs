using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub014
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 인사발령등록 
    /// --최근작성 정보
    /// 1. 2021-09-08              권아영             신규생성
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
            SelectSQL = @"SELECT 
                            PAPP_EMPNO
                            ,PAPP_APPNO
                            ,PAPP_DATE
                            ,FN_GETCODE_KAY('PAP', papp_pap) as PAPP_PAP
                            ,PAPP_CONTENT
                            ,PAPP_AUTH
                            ,PAPP_BASIS
                            ,PAPP_RMK
                            ,PAPP_CONT
                            ,PAPP_POS_CD||':'||PAPP_POS_NM as PAPP_POS
                            ,PAPP_DUT_CD||':'||PAPP_DUT_NM as PAPP_DUT
                            ,PAPP_DEPT_CD||':'||PAPP_DEPT_NM as PAPP_DEPT
                            ,FN_GETCODE_KAY('STS', papp_sts) as PAPP_STS
                            FROM kay_insa_papp 
                            WHERE papp_appno LIKE :papp_appno
                            AND papp_date BETWEEN :papp_date1 AND :papp_date2
                            AND papp_empno LIKE :papp_empno
                            ";
        //******************************
        //--발령번호 검색 쿼리
        //******************************
        public static string
            SelectSQL1 = @"SELECT papr_appno, papr_date, papr_content FROM kay_insa_papr 
                            WHERE papr_content LIKE :condition ";

        #endregion
        #region 추가(입력)
        //******************************
        //--추가
        //******************************
        public static string
            InsertSQL = @"INSERT INTO kay_insa_cd 
                          ( PAPP_EMPNO                            ,PAPP_APPNO                            ,PAPP_DATE                            ,PAPP_PAP
                            ,PAPP_CONTENT                            ,PAPP_AUTH                            ,PAPP_BASIS                            ,PAPP_RMK
                            ,PAPP_CONT                            ,PAPP_POS_CD                            ,PAPP_DUT_CD                            ,PAPP_DEPT_CD
                            ,PAPP_POS_NM                            ,PAPP_DUT_NM                            ,PAPP_DEPT_NM                            ,DATASYS2
                            ,DATASYS3                            ,PAPP_STS                            ,DATASYS4) 
                            VALUES  
                          (  :PAPP_EMPNO                            ,:PAPP_APPNO                            ,:PAPP_DATE                            ,:PAPP_PAP
                            ,:PAPP_CONTENT                            ,:PAPP_AUTH                            ,:PAPP_BASIS                            ,:PAPP_RMK
                            ,:PAPP_CONT                            ,:PAPP_POS_CD                            ,:PAPP_DUT_CD                            ,:PAPP_DEPT_CD
                            ,:PAPP_POS_NM                            ,:PAPP_DUT_NM                            ,:PAPP_DEPT_NM                            ,'A'
                            ,:DATASYS3                            ,:PAPP_STS                            ,:DATASYS4) ";


        #endregion
        #region 수정
        //******************************
        //--수정
        //******************************
        public static string
            UpdateSQL = @"UPDATE kay_insa_cd SET
                          PAPP_CONTENT = :PAPP_CONTENT
                          ,PAPP_AUTH = :PAPP_AUTH
                          ,PAPP_BASIS = :PAPP_BASIS
                          ,PAPP_RMK = :PAPP_RMK
                          ,PAPP_CONT = :PAPP_CONT
                          ,PAPP_POS_CD = :PAPP_POS_CD
                          ,PAPP_DUT_CD = :PAPP_DUT_CD
                          ,PAPP_DEPT_CD = :PAPP_DEPT_CD
                          ,PAPP_POS_NM = :PAPP_POS_NM
                          ,PAPP_DUT_NM = :PAPP_DUT_NM
                          ,PAPP_DEPT_NM = :PAPP_DEPT_NM
                          ,DATASYS2 = 'U'
                          ,DATASYS3 = :DATASYS3
                          ,PAPP_STS = :PAPP_STS
                          ,DATASYS4= :DATASYS4
                          WHERE PAPP_EMPNO = :PAPP_EMPNO
                         AND PAPP_APPNO = :PAPP_APPNO
                         AND PAPP_DATE = :PAPP_DATE
                         AND PAPP_PAP = :PAPP_PAP";
        #endregion
        #region 삭제
        //******************************
        //--삭제
        //******************************
        public static string
            DeleteSQL = @"DELETE FROM kay_insa_papp   WHERE  PAPP_EMPNO = :Key1
                                                         AND PAPP_APPNO = :Key2
                                                         AND PAPP_DATE = :Key3
                                                         AND PAPP_PAP = :Key4";

        #endregion
        #region 코드조회

        //************************************************************************
        //** 부서 콤보박스 채우기(DEPT)
        //************************************************************************
        public static string
            SelectSQL3 = @"SELECT dept_code||':'||dept_name as code
                            FROM kay_insa_dept 
                            WHERE dept_use = 'Y'";

        //************************************************************************
        //** 직급 콤보박스 채우기(POS)
        //************************************************************************
        public static string
            SelectSQL4 = @"SELECT cd_code||':'||cd_codnm as code 
                            FROM kay_insa_cd 
                            WHERE cd_grpcd = 'POS'
                            AND cd_use = 'Y'";

        //************************************************************************
        //** 직책 콤보박스 채우기(DUT)
        //************************************************************************
        public static string
            SelectSQL5 = @"SELECT cd_code||':'||cd_codnm as code 
                            FROM kay_insa_cd 
                            WHERE cd_grpcd = 'DUT'
                            AND cd_use = 'Y'";

        //************************************************************************
        //** 발령 콤보박스 채우기(PAP)
        //************************************************************************
        public static string
            SelectSQL6 = @"SELECT cd_code||':'||cd_codnm as code 
                            FROM kay_insa_cd 
                            WHERE cd_grpcd = 'PAP'
                            AND cd_use = 'Y'";

        //************************************************************************
        //** 신분구분 콤보박스 채우기(STS)
        //************************************************************************
        public static string
            SelectSQL7 = @"SELECT cd_code||':'||cd_codnm as code 
                            FROM kay_insa_cd 
                            WHERE cd_grpcd = 'STS'
                            AND cd_use = 'Y'";
        #endregion


    }
}
