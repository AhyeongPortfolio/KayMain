using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using KayLibrary;
using Microsoft.Reporting.WinForms;

namespace KaySub022
{
    public partial class KaySub022_popup : Form
    {
        #region 초기설정
        List<KaySub022Empolyee> empolyeeList;
        List<KaySub022Career> careerList;

        OracleConnection con = null;
        private string Empno { get; set; } // 사번
        private string Kind { get; set; } // 증명서 종류
        private string Date { get; set; } // 발급일자
        private string Cnt { get; set; } // 발급부수
        private string DocName { get; set; } // 발급번호
        private string Rkind { get; set; } // 제출용도
        public KaySub022_popup()
        {
            InitializeComponent();
        }

        private void KaySub022_popup_Load(object sender, EventArgs e)
        {
            CreateReport();
            this.reportViewer1.RefreshReport();
        }
        #endregion

        #region ReportView 띄우기
        private void CreateReport()
        {
            // 레포트 파일 연결
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = reportViewer1.LocalReport;

            // Add Data
            if (Kind == "경력")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "KaySub022.CareerReport.rdlc";
                //Car_Data_GetSet();
            }
            if (Kind == "재직")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "KaySub022.CeriReport.rdlc";
                //Ceri_Data_GetSet();
            }

            // PreView 형태로 보여주기
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report          
        }

        #endregion

        #region SetActiveValue 설정
        public void SetActiveValue(string _empno, string _kind, string _date, string _cnt, string _rkind)
        {
            Empno = _empno;
            Kind = _kind;
            Date = _date;
            Cnt = _cnt;
            Rkind = _rkind;
        }

        #endregion



    }
}
