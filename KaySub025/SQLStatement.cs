using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub025
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 증명서 발급대장 
    /// --최근작성 정보
    /// 2. 2021-09-09              권아영             신규생성
    /// **********************************************************************
    /// </summary>
    /// 
    class SQLStatement
    {
        #region 조회
        //******************************
        //--기본정보 조회
        //******************************

        public static string
            SelectSQL = @"SELECT 
                             A.CERI_EMPNO
                            ,A.CERI_KIND
                            ,A.CERI_DATE
                            ,A.CERI_LANG
                            ,A.CERI_NUM
                            ,A.CERI_CNT
                            ,A.CERI_SAU
                            ,B.BAS_NAME
                            FROM kay_insa_cerl A ,kay_insa_bas B
                            WHERE A.ceri_empno = B.bas_empno
                            AND A.CERI_EMPNO LIKE :CERI_EMPNO
                            AND B.BAS_NAME LIKE :bas_name";

        #endregion

        

    }
}
