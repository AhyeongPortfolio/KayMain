using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub005
{
    class SQLStatement
    {
        /// <summary>
        /// **********************************************************************
        /// --Project             : 인사관리시스템(ver2)
        /// --Form Name           : 인사정보관리
        /// --최근작성 정보
        /// 1. 2021-09-06              권아영             신규생성
        /// **********************************************************************
        /// </summary>
       
            #region 조회
            //******************************
            //--조회
            //******************************
            public static string
                SelectSQL = @"SELECT bas.*
                            FROM kay_insa_bas bas        
                            WHERE 
                            bas.bas_empno LIKE :bas_empno 
                            AND bas.bas_name LIKE :bas_name";

            #endregion
           
            #region 수정
            //******************************
            //--수정
            //******************************
            public static string
                UpdateSQL = @"UPDATE kay_insa_bas SET     
                            BAS_CONT     = :BAS_CONT            
                            ,BAS_EMP_SDATE = :BAS_EMP_SDATE
                            ,BAS_EMP_EDATE = :BAS_EMP_EDATE
                            ,BAS_ENTDATE   = :BAS_ENTDATE 
                            ,BAS_RESDATE   = :BAS_RESDATE 
                            ,BAS_LEVDATE   = :BAS_LEVDATE
                            ,BAS_REIDATE   = :BAS_REIDATE   
                            ,BAS_DPTDATE   = :BAS_DPTDATE
                            ,BAS_JKDATE    = :BAS_JKDATE
                            ,BAS_POSDATE   = :BAS_POSDATE 
                            ,BAS_WSTA      = :BAS_WSTA 
                            ,BAS_STS       = :BAS_STS     
                            ,BAS_POS       = :BAS_POS
                            ,BAS_DUT       = :BAS_DUT
                            ,BAS_DEPT      = :BAS_DEPT
                            ,DATASYS2     = 'U'   
                            ,DATASYS3     = :DATASYS3 
                            ,DATASYS4     = :DATASYS4
                        WHERE BAS_EMPNO = :bas_empno";


            #endregion
            
        }
    }
