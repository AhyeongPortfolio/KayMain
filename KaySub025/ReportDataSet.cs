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
    /// --Form Name           : 재직증명서 / 경력증명서 DataSet
    /// --최근작성 정보
    /// 2. 2021-09-14              권아영             신규생성(새로만듬)
    /// **********************************************************************
    /// </summary>
    /// 
    // 재직증명서 DataSet
    class ReportDataSet
    {
        public ReportDataSet() { }
        public ReportDataSet(string name, string empno, string resno, string addr, string sts, string pos, string dept,
            string entdate, string resdate, string cont)
        {
            this.BAS_NAME = name;
            this.BAS_EMPNO = empno;
            this.BAS_RESNO = resno;
            this.BAS_ADDR = addr;
            this.BAS_STS = sts;
            this.BAS_POS = pos;
            this.BAS_DEPT = dept;
            this.BAS_ENTDATE = entdate;
            this.BAS_RESDATE = resdate;
            this.BAS_CONT = cont;
        }
        private string Name;
        public string BAS_NAME
        {
            get { return Name; }
            set { Name = value; }
        }
        private string Empno;
        public string BAS_EMPNO
        {
            get { return Empno; }
            set { Empno = value; }
        }
        private string Resno;
        public string BAS_RESNO
        {
            get { return Resno; }
            set { Resno = value; }
        }
        private string Addr;
        public string BAS_ADDR
        {
            get { return Addr; }
            set { Addr = value; }
        }
        private string Sts;
        public string BAS_STS
        {
            get { return Sts; }
            set { Sts = value; }
        }
        private string Pos;
        public string BAS_POS
        {
            get { return Pos; }
            set { Pos = value; }
        }
        private string Dept;
        public string BAS_DEPT
        {
            get { return Dept; }
            set { Dept = value; }
        }
        private string Entdate;
        public string BAS_ENTDATE
        {
            get { return Entdate; }
            set { Entdate = value; }
        }
        private string ResDate;
        public string BAS_RESDATE
        {
            get { return ResDate; }
            set { ResDate = value; }
        }
        private string Cont;
        public string BAS_CONT
        {
            get { return Cont; }
            set { Cont = value; }
        }

    }

    // 경력증명서 DataSet
    class ReportDataSet2
    {
        public ReportDataSet2() { }
        public ReportDataSet2(string name, string empno, string resno, string addr, string sts, string pos, string dept,
            string entdate, string resdate, string dut)
        {
            Name = name;
            Empno = empno;
            Resno = resno;
            Addr = addr;
            Pos = pos;
            Dept = dept;
            Entdate = entdate;
            ResDate = resdate;
            Dut = dut;
        }
        private string Name;
        public string BAS_NAME
        {
            get { return Name; }
            set { Name = value; }
        }
        private string Empno;
        public string BAS_EMPNO
        {
            get { return Empno; }
            set { Empno = value; }
        }
        private string Resno;
        public string BAS_RESNO
        {
            get { return Resno; }
            set { Resno = value; }
        }
        private string Addr;
        public string BAS_ADDR
        {
            get { return Addr; }
            set { Addr = value; }
        }
        private string Pos;
        public string PAPP_POS
        {
            get { return Pos; }
            set { Pos = value; }
        }
        private string Dept;
        public string PAPP_DEPT
        {
            get { return Dept; }
            set { Dept = value; }
        }
        private string Entdate;
        public string PAPP_ENTDATE
        {
            get { return Entdate; }
            set { Entdate = value; }
        }
        private string ResDate;
        public string PAPP_RESDATE
        {
            get { return ResDate; }
            set { ResDate = value; }
        }
        private string Dut;
        public string PAPP_DUT
        {
            get { return Dut; }
            set { Dut = value; }
        }
    }

    // 영문 재직증명서 DataSet
    class ReportDataSet3
    {

    }

    // 영문 경력증명서 DataSet
    class ReportDataSet4
    {

    }
}
