using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub012
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 통합조회 쿼리문
    /// --최근작성 정보
    /// 2. 2021-09-07              권아영             신규생성
    /// **********************************************************************
    /// </summary>
    class SQLStatement
    {
        //******************************
        //--기본정보 조회
        //******************************

        public static string
            SelectSQL = @"SELECT 
                            bas_empno
                            ,BAS_RESNO
                            ,BAS_NAME
                            ,BAS_CNAME
                            ,BAS_ENAME
                            ,BAS_FIX
                            ,BAS_ZIP
                            ,BAS_ADDR ||''|| BAS_ANADDR as bas_addr
                            ,BAS_HDPNO 
                            ,BAS_TELNO
                            ,BAS_EMAIL
                            ,BAS_MIL_STA
                            ,BAS_MIL_MIL
                            ,BAS_MIL_RNK
                            ,BAS_MAR
                            ,BAS_ACC_BANK
                            ,BAS_ACC_NAME
                            ,BAS_ACC_NO
                            ,BAS_CONT
                            ,BAS_EMP_SDATE
                            ,BAS_EMP_EDATE
                            ,BAS_ENTDATE
                            ,BAS_RESDATE
                            ,BAS_LEVDATE
                            ,BAS_REIDATE
                            ,BAS_DPTDATE
                            ,BAS_JKDATE
                            ,BAS_POSDATE
                            ,BAS_WSTA
                            ,FN_GETCODENM_KAY('STS', BAS_STS) as bas_sts
                            ,FN_GETCODENM_KAY('DUT',BAS_DUT) as bas_dut
                            ,BAS_RMK
                            ,FN_GETCODENM_KAY('POS', bas_pos) as bas_pos
                            ,FN_GETDEPTNM_KAY(bas_dept) as bas_dept
                         FROM kay_insa_bas
                         WHERE bas_empno LIKE :bas_empno
                         AND bas_name LIKE :bas_name
                         AND bas_wsta LIKE :bas_wsta";

        //*---가족정보 조회
        public static string
            SelectSQL1 = @"SELECT fam_empno as col1, fam_name as col2, fam_bth as col3, fam_ltg as col4 ,FN_GETCODENM_KAY('REL', fam_rel) as col5 ,
                                    null  as col6  , null as col7 ,null as col8    ,null as col9  ,null  as col10     ,
                                    'FAM' as type
                            FROM kay_insa_fam 
                           WHERE fam_empno = :bas_empno
                           
                            UNION ALL                           

                            SELECT edu_empno  ,EDU_LOE    ,edu_entdate    ,edu_gradate   ,edu_schnm   ,
                                   edu_dept   ,edu_degree ,TO_CHAR(edu_grade) as edu_grade      ,edu_gra       ,edu_last    ,
                                   'EDU' as type
                            FROM kay_insa_edu
                            WHERE edu_empno = :bas_empno
                            
                             UNION ALL


                            SELECT award_empno    ,award_date       ,AWARD_NO         ,AWARD_ORGAN      ,AWARD_CONTENT    ,
                                   AWARD_KIND     ,AWARD_INOUT  ,FN_GETCODENM_KAY('POS', award_pos) as award_pos ,FN_GETDEPTNM_KAY(award_dept) as award_dept    ,null,
                                   'AWARD' as type
                            FROM kay_insa_award 
                            WHERE award_empno = :bas_empno
                            
                             UNION ALL

                            SELECT 
                                        CAR_EMPNO            ,CAR_COM            ,CAR_REGION            ,CAR_YYYYMM_F            ,CAR_YYYYMM_T
                                        ,CAR_POS            ,CAR_DEPT            ,CAR_REASON            ,null                    ,null      ,
                                        'CAR' as type
                            FROM kay_insa_car 
                            WHERE CAR_EMPNO = :bas_empno
                            
                             UNION ALL
                             
                            SELECT LIC_EMPNO       ,LIC_NAME       ,LIC_GRADE      ,LIC_ACQDATE        ,LIC_ORGAN     ,
                                    null           ,null           ,null           ,null                ,null         ,
                                    'LIC' as type
                            FROM kay_insa_LIC 
                          WHERE LIC_EMPNO = :bas_empno
                          
                            UNION ALL
                            
                            SELECT FORL_EMPNO      ,FORL_NAME      ,FORL_SCORE     ,FORL_ACQDATE       ,FORL_ORGAN     ,
                                    null           ,null           ,null           ,null               ,null            ,
                                    'FORL' as type
                            FROM kay_insa_forl 
                          WHERE FORL_EMPNO = :bas_empno
                            ";


        //*---사진 조회
        public static string
            SelectPic = @"SELECT uimg_img FROM kay_insa_uimg
                           WHERE uimg_empno = :empno";
        #region SAMPLE
        public static string
            SelectSQL2 = @"
                SELECT fam_empno, fam_name, fam_bth, fam_ltg, FN_GETCODE_KAY('REL', fam_rel) as fam_rel
                                    FROM kay_insa_fam
                                   WHERE fam_empno = :bas_empno
                                    UNION ALL
                                    SELECT NULL AS fam_empno, NULL AS fam_name, NULL AS fam_bth, NULL AS fam_ltg , NULL AS fam_rel
                                    FROM kay_insa_fam
                                    WHERE NOT EXISTS(SELECT fam_empno, fam_name, fam_bth, fam_ltg , FN_GETCODE_KAY('REL', fam_rel) as fam_rel
                                                        FROM kay_insa_fam
                                                       WHERE fam_empno = :bas_empno
                                                        )
                                    AND ROWNUM = 1;
                     SELECT edu_empno, EDU_LOE, edu_entdate, edu_gradate, edu_schnm,
                            edu_dept, edu_degree, edu_grade, edu_gra, edu_last
                                         FROM kay_insa_edu
                                         --WHERE edu_empno = :bas_empno
                                          UNION ALL
                                         SELECT NULL AS edu_empno, NULL AS EDU_LOE, NULL AS edu_entdate, NULL AS edu_gradate , NULL AS edu_schnm ,
                                                NULL AS edu_dept   ,NULL AS edu_degree ,NULL AS edu_grade      ,NULL AS edu_gra       ,NULL AS edu_last
                                         FROM kay_insa_fam
                                         WHERE NOT EXISTS(SELECT edu_empno, EDU_LOE    , edu_entdate    , edu_gradate   , edu_schnm   ,
                                                                  edu_dept   , edu_degree , edu_grade      , edu_gra       , edu_last
                                                           FROM kay_insa_edu
                                                           --WHERE edu_empno = :bas_empno
                                                             )
                                         AND ROWNUM = 1;
                     SELECT award_empno, award_date, AWARD_NO, AWARD_ORGAN, AWARD_CONTENT,
                            AWARD_KIND, AWARD_INOUT, FN_GETCODE_KAY('POS', award_pos) as award_pos ,FN_GETDEPT_KAY(award_dept) as award_dept
                FROM kay_insa_award 
                                         --WHERE award_empno = :bas_empno
                                          UNION ALL
                                         SELECT NULL AS award_empno, NULL AS award_date, NULL AS AWARD_NO, NULL AS AWARD_ORGAN , NULL AS AWARD_CONTENT,
                                                NULL AS AWARD_KIND ,NULL AS AWARD_INOUT  ,NULL AS award_pos ,NULL AS award_dept
                                         FROM kay_insa_fam
                                         WHERE NOT EXISTS(SELECT award_empno, award_date       , AWARD_NO         , AWARD_ORGAN      , AWARD_CONTENT    ,
                                                                    AWARD_KIND     , AWARD_INOUT  , FN_GETCODE_KAY('POS', award_pos) as award_pos ,FN_GETDEPT_KAY(award_dept) as award_dept
                                                               FROM kay_insa_award 
                                                             --WHERE award_empno = :bas_empno
                                                             )
                                         AND ROWNUM = 1;

                     SELECT
                                 CAR_EMPNO, CAR_COM, CAR_REGION, CAR_YYYYMM_F, CAR_YYYYMM_T
                                 , CAR_POS, CAR_DEPT, CAR_REASON
                                         FROM kay_insa_car 
                                         --WHERE CAR_EMPNO = :bas_empno
                                          UNION ALL
                                         SELECT NULL AS CAR_EMPNO            ,NULL AS CAR_COM            ,NULL AS CAR_REGION            ,NULL AS CAR_YYYYMM_F            ,NULL AS CAR_YYYYMM_T
                                                ,NULL AS CAR_POS            ,NULL AS CAR_DEPT            ,NULL AS CAR_REASON
                                         FROM kay_insa_fam
                                         WHERE NOT EXISTS(SELECT CAR_EMPNO, CAR_COM            , CAR_REGION            , CAR_YYYYMM_F            , CAR_YYYYMM_T
                                                                 , CAR_POS            , CAR_DEPT            , CAR_REASON
                                                         FROM kay_insa_car
                                                         --WHERE CAR_EMPNO = :bas_empno
                                                         )
                                         AND ROWNUM = 1;

                     SELECT LIC_EMPNO, LIC_NAME, LIC_GRADE, LIC_ACQDATE, LIC_ORGAN
                                         FROM kay_insa_LIC 
                                       WHERE LIC_EMPNO = :bas_empno
                                         UNION ALL
                                         SELECT NULL AS LIC_EMPNO       ,NULL AS LIC_NAME       ,NULL AS LIC_GRADE      ,NULL AS LIC_ACQDATE        ,NULL AS LIC_ORGAN
                                         FROM kay_insa_fam
                                         WHERE NOT EXISTS(SELECT LIC_EMPNO, LIC_NAME       , LIC_GRADE      , LIC_ACQDATE        , LIC_ORGAN
                                                             FROM kay_insa_LIC
                                                            WHERE LIC_EMPNO = :bas_empno
                                                             )
                                         AND ROWNUM = 1;

                     SELECT FORL_EMPNO, FORL_NAME, FORL_SCORE, FORL_ACQDATE, FORL_ORGAN
                                         FROM kay_insa_forl 
                                       --WHERE FORL_EMPNO = :bas_empno
                                        UNION ALL
                                         SELECT NULL AS FORL_EMPNO      , NULL AS FORL_NAME      , NULL AS FORL_SCORE     , NULL AS FORL_ACQDATE       , NULL AS FORL_ORGAN
                                         FROM kay_insa_fam
                                         WHERE NOT EXISTS(SELECT FORL_EMPNO, FORL_NAME      , FORL_SCORE     , FORL_ACQDATE       , FORL_ORGAN
                                                             FROM kay_insa_forl
                                                           --WHERE FORL_EMPNO = :bas_empno
                                                             )
                                         AND ROWNUM = 1;
                            ";

        #endregion
    }
}
