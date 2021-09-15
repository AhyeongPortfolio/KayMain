using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub004
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 인사정보관리
    /// --최근작성 정보
    /// 1. 2021-09-02              권아영             신규생성
    /// **********************************************************************
    /// </summary>
    class SQLStatement
    {
        #region 조회
        //******************************
        //--조회
        //******************************
        public static string
            SelectSQL = @"SELECT bas.*
                            ,FN_GETCODE_KAY('POS', bas.bas_pos) as pos
                            ,FN_GETCODE_KAY('DUT', bas.bas_dut) as dut
                            ,FN_GETCODE_KAY('STS', bas.bas_sts) as sts
                            ,FN_GETDEPT_KAY(bas.bas_dept) as dept
                            FROM kay_insa_bas bas        
                            WHERE 
                            bas.bas_empno LIKE :bas_empno 
                            AND bas.bas_name LIKE :bas_name
                          ";

        #endregion
        #region 추가
        //******************************
        //--추가
        //******************************
        public static string
            InsertSQL = $@"INSERT INTO kay_insa_bas( 
                             BAS_EMPNO                              ,BAS_RESNO      ,BAS_NAME     ,BAS_CNAME       ,BAS_ENAME    ,BAS_FIX
                            ,BAS_ZIP        ,BAS_ADDR        ,BAS_ANADDR    ,BAS_HDPNO      ,BAS_TELNO 
                            ,BAS_EMAIL      ,BAS_MIL_STA     ,BAS_MIL_MIL   ,BAS_MIL_RNK    ,BAS_MAR 
                            ,BAS_ACC_BANK   ,BAS_ACC_NAME    ,BAS_ACC_NO    ,BAS_CONT       
                            ,BAS_RMK        ,DATASYS2        ,DATASYS3      ,DATASYS4       ,BAS_EADDR
                            ) VALUES
                            ( '{System.DateTime.Now.ToString("yyyy")}' + IPSA_SEQ_KAY.NEXTVAL    ,:BAS_RESNO      ,:BAS_NAME    ,:BAS_CNAME     ,:BAS_ENAME  ,:BAS_FIX
                            ,:BAS_ZIP       ,:BAS_ADDR       ,:BAS_ANADDR  ,:BAS_HDPNO     ,:BAS_TELNO  
                            ,:BAS_EMAIL     ,:BAS_MIL_STA    ,:BAS_MIL_MIL ,:BAS_MIL_RNK   ,:BAS_MAR 
                            ,:BAS_ACC_BANK  ,:BAS_ACC_NAME   ,:BAS_ACC_NO  ,:BAS_CONT      ,:BAS_RMK
                            ,:DATASYS2      ,:DATASYS3      ,:DATASYS4     ,:BAS_EADDR)";

        //*---로그인 관리-------------------------------------
        public static string
              LoginSQL = $@" INSERT INTO KAY_USER
                              ( USER_ID                             ,USER_NAME                              ,USER_PSWD
                               ,USER_TYPE                               ,USER_PSWD_DAT                               ,USER_EMAIL                               
                               ,DATASYS2                               ,DATASYS3                                     ,DATASYS4
                               ) VALUES
                             ( 
                                 '{System.DateTime.Now.ToString("yyyy")}'  + IPSA_SEQ_KAY.CURRVAL  ,:USER_NAME_KAY    ,:USER_PSWD
                                ,'4'                          ,sysdate                                       ,:USER_EMAIL                                
                                ,'A'                                   ,:DATASYS3                                     ,:DATASYS4
                             )"; 
                

        //*---이미지 추가-------------------------------------
        public static string
            ImageSQL = "INSERT INTO kay_insa_uimg VALUES :empno + IPSA_SEQ_KAY.CURRVAL, :img";

        #endregion
        #region 수정
        //******************************
        //--수정
        //******************************
        public static string
            UpdateSQL = @"UPDATE kay_insa_bas SET
                             BAS_EMPNO    = :BAS_EMPNO    
                            ,BAS_RESNO    = :BAS_RESNO    
                            ,BAS_NAME     = :BAS_NAME     
                            ,BAS_CNAME    = :BAS_CNAME    
                            ,BAS_ENAME    = :BAS_ENAME    
                            ,BAS_FIX      = :BAS_FIX      
                            ,BAS_ZIP      = :BAS_ZIP      
                            ,BAS_ADDR     = :BAS_ADDR     
                            ,BAS_ANADDR   = :BAS_ANADDR   
                            ,BAS_HDPNO    = :BAS_HDPNO    
                            ,BAS_TELNO    = :BAS_TELNO    
                            ,BAS_EMAIL    = :BAS_EMAIL    
                            ,BAS_MIL_STA  = :BAS_MIL_STA  
                            ,BAS_MIL_MIL  = :BAS_MIL_MIL  
                            ,BAS_MIL_RNK  = :BAS_MIL_RNK  
                            ,BAS_MAR      = :BAS_MAR      
                            ,BAS_ACC_BANK = :BAS_ACC_BANK 
                            ,BAS_ACC_NAME = :BAS_ACC_NAME 
                            ,BAS_ACC_NO   = :BAS_ACC_NO   
                            ,BAS_CONT     = :BAS_CONT                               
                            ,BAS_RMK      = :BAS_RMK      
                            ,DATASYS2     = 'U'   
                            ,DATASYS3     = :DATASYS3 
                            ,DATASYS4     = :DATASYS4
                            ,BAS_EADDR    = :BAS_EADDR
                        WHERE BAS_EMPNO = :key1";

        //*---이미지 수정
        public static string
            ImageSQL2 = @"UPDATE kay_insa_uimg SET
                            uimg_img = :img
                           ,uimg_empno = :empno";

        #endregion
        #region 콤보박스 채우기
        //************************************************************************
        //** 부서검색박스 채우기
        //************************************************************************
        public static string
            SelectSQL1 = @"SELECT dept_code||':'||dept_name as code
                            FROM kay_insa_dept 
                            WHERE dept_use = 'Y'";

        //************************************************************************
        //** 직급검색박스 채우기
        //************************************************************************
        public static string
            SelectSQL2 = @"SELECT cd_code||':'||cd_codnm as code 
                            FROM kay_insa_cd 
                            WHERE cd_grpcd = 'POS'
                            AND cd_use = 'Y'";

        //************************************************************************
        //** 군별박스 채우기
        //************************************************************************
        public static string
            SelectSQL3 = @"SELECT cd_codnm as code 
                            FROM kay_insa_cd 
                            WHERE cd_grpcd = 'MIL'
                            AND cd_use = 'Y'";

        //************************************************************************
        //** 계급박스 채우기
        //************************************************************************
        public static string
            SelectSQL4 = @"SELECT cd_codnm as code 
                            FROM kay_insa_cd 
                            WHERE cd_grpcd = 'RNK'
                            AND cd_use = 'Y'";


        //************************************************************************
        //** 은행이름박스 채우기
        //************************************************************************
        public static string
            SelectSQL5 = @"SELECT cd_codnm as code 
                            FROM kay_insa_cd 
                            WHERE cd_grpcd = 'BNK'
                            AND cd_use = 'Y'";


        #endregion
    }
}
