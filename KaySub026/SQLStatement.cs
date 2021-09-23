using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaySub026
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 부서별 통계쿼리문
    /// --최근작성 정보
    /// 2. 2021-09-13              권아영             신규생성
    /// **********************************************************************
    /// </summary>
    class SQLStatement
    {

        //**********************************************************************
        //**현재시점 부서별 인원 수
        //**********************************************************************
        public static string
            SelectSQL = @"SELECT B.dept_name , nvl(A.남자, 0) as 남자, nvl(A.여자, 0) as 여자, nvl(A.합계, 0) as 총인원수
                            FROM (                            
                            SELECT A.bas_dept as 부서명
                            ,sum(decode(bas_fix, '남', 1, 0)) as 남자 
                            ,sum(decode(bas_fix, '여', 1, 0)) as 여자
                            ,COUNT(A.bas_fix) 합계 
                            from kay_insa_bas A
                            where A.bas_wsta like :bas_wsta
                            group by A.bas_dept, A.bas_wsta
                            ) A, kay_insa_dept B
                            where A.부서명(+) = B.dept_code
                            order by B.dept_seq";

        //**********************************************************************
        //**특정시점 부서별 인원 수
        //**********************************************************************



        //************************************************************************
        //** 부서검색박스 채우기
        //************************************************************************
        public static string
            SelectSQL1 = @"SELECT dept_name as code
                            FROM kay_insa_dept 
                            WHERE dept_use = 'Y'";

    }
}
