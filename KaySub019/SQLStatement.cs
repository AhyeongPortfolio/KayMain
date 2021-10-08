using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub019
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Program name        : 업무평가 등록(온라인으로 해야하지만 그냥 프로그램에서 하게되었음)
    /// --최근작성 정보
    /// 1. 2021-10-05              권아영             신규생성
    /// **********************************************************************
    /// </summary>
    class SQLStatement
    {
        #region 검색
        //*---DataGridView1 채우는 용도---------
        //*---진행여부 
        public static string
            SelectSQL = @"SELECT a.* ,b.bas_name as tee_name ,c.bas_name as tor_name
                         FROM kay_insa_evalm a,
                              (SELECT bas_name, bas_empno FROM kay_insa_bas) b,
                              (SELECT bas_name, bas_empno FROM kay_insa_bas) c
                         WHERE a.evalm_tee = b.bas_empno(+)
                         AND a.evalm_tor = c.bas_empno(+)
                         AND a.evalm_tor = :evalm_tor
                         AND a.evalm_tee = :evalm_tee";

        

        //*--사원 번호 검색---------------------------------------------------------------------
        public static string
            SelectSQL4 = @"SELECT bas_empno FROM kay_insa_bas WHERE bas_name = :bas_name";

        //*--평가 유형 검색----------------------------------------------------------------------
        public static string
            SelectSQL5 = @"SELECT DISTINCT evali_type FROM kay_insa_evali";

        
        public static string
            SelectSQL6 = @"SELECT count(evali_type) FROM kay_insa_evali WHERE evali_type = :evali_type";


        //*--업무 평가 데이터 추출----------------------------------------------------------------
        public static string
            SelectSQL_type = @"SELECT * FROM kay_insa_evali a,
                                (SELECT evals_score, evals_grade, evals_itemno FROM kay_insa_evals
                               WHERE evals_year = :evals_year AND evals_no = :evals_no
                               AND evals_tee = :evals_tee AND evals_stage = :evals_stage) b
                               WHERE evali_type = :evali_type AND a.evali_itemno = b.evals_itemno(+)
                               ORDER BY a.evali_itemno";

        #endregion
        #region 저장
        //*--평가 내용 저장-------------------------------
        public static string
            UpdateSQL = @"UPDATE kay_insa_evalm SET
                         evalm_findate  = to_char(sysdate, 'yyyyMMdd')
                        ,evalm_total    = :evalm_total
                        ,evalm_merit    = :evalm_merit
                        ,evalm_weak     = :evalm_weak
                        ,datasys2       = 'U'
                        ,datasys3       = :datasys3
                        ,datasys4       = :datasys4 
                        WHERE evalm_year = :key1 
                        and evalm_no = :key2 
                        and evalm_tee = :key3
                        and evalm_stage = :key4";

        public static string
            InsertSQL = @"INSERT INTO kay_insa_evals(
                            evals_year ,evals_no ,evals_tee ,evals_stage ,evals_itemno
                            ,evals_grade ,evals_score ,evals_sum
                            ,ipaddr ,datasys2 ,datasys3
                          ) 
                        VALUES (
                        :evals_year ,:evals_no ,:evals_tee ,:evals_stage ,:evals_itemno
                        ,:evals_grade ,:evals_score ,:evals_sum
                        ,:ipaddr ,:datasys2 ,:datasys3
                        )";
        public static string
            UpdateSQL2 = @"UPDATE kay_insa_evals SET
                             evals_year   = :evals_year
                            ,evals_no     = :evals_no
                            ,evals_tee    = :evals_tee
                            ,evals_stage  = :evals_stage
                            ,evals_itemno = :evals_itemno
                            ,evals_grade  = :evals_grade
                            ,evals_score  = :evals_score
                            ,evals_sum    = :evals_sum
                            ,ipaddr       = :ipaddr
                            ,datasys2     = :datasys2
                            ,datasys3     = :datasys3
                          WHERE evals_year = :evals_year AND evals_no = :evals_no AND evals_tee = :evals_tee";

        #endregion
    }
}
