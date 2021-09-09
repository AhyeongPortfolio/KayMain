using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub015
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 발령조회 쿼리문
    /// --최근작성 정보
    /// 2. 2021-09-09              권아영             신규생성
    /// **********************************************************************
    /// </summary>
    /// 
    class SQLStatement
    {

        //******************************
        //--기본정보 조회
        //******************************

        public static string
            SelectSQL = @"SELECT * FROM kay_insa_papr 
                            WHERE papr_appno LIKE :papr_appno 
                            AND papr_date BETWEEN :papr_date1 AND :papr_date2";

        //*---가족정보 조회
        public static string
            SelectSQL1 = @"SELECT 
                            PAPP_EMPNO
                            ,PAPP_APPNO
                            ,PAPP_DATE
                            ,FN_GETCODENM_KAY('PAP', papp_pap) as PAPP_PAP
                            ,PAPP_CONTENT
                            ,PAPP_AUTH
                            ,PAPP_BASIS
                            ,PAPP_RMK
                            ,PAPP_CONT
                            ,PAPP_POS_CD  
                            ,PAPP_DUT_CD  
                            ,PAPP_DEPT_CD 
                            ,PAPP_POS_NM
                            ,PAPP_DUT_NM
                            ,PAPP_DEPT_NM
                            ,FN_GETCODENM_KAY('STS', papp_sts) as PAPP_STS
                            FROM kay_insa_papp 
                            WHERE papp_appno = :papp_appno
                            ";

    }
}
