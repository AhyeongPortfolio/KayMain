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
        //******************************
        //--조회
        //******************************
        public static string
            SelectSQL = @"
                          ";

        //******************************
        //--추가
        //******************************
        public static string
            InsertSQL = @"INSERT INTO kay_insa_dept  
                           ( dept_code, dept_name, dept_names, dept_seq, dept_upp, dept_sdate, dept_edate, dept_use, datasys2, datasys3 ) 
                            VALUES  
                           ( :dept_code, :dept_name, :dept_names, :dept_seq, :dept_upp, :dept_sdate, :dept_edate, :dept_use, 'A', :datasys3 ) ";


        //******************************
        //--수정
        //******************************
        public static string
            UpdateSQL = @"UPDATE kay_insa_dept SET
                          dept_code = :dept_code,
                          dept_name = :dept_name,
                          dept_names = :dept_names,
                          dept_seq = :dept_seq,
                          dept_upp = :dept_upp,
                          dept_sdate = :dept_sdate,
                          dept_edate = :dept_edate,
                          dept_use = :dept_use,
                          datasys2 = 'U',
                          datasys3 = :datasys3
                          WHERE
                          dept_code = :key1";

        //******************************
        //--삭제
        //******************************
        public static string
            DeleteSQL = @"DELETE FROM kay_insa_dept WHERE dept_code = :dept_code";
    }
}
