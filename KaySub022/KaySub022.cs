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
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 증명서발급대장 
    /// --최근작성 정보
    /// 1. 2021-08-31              권아영             신규생성
    /// 2. 2021-09-09              권아영             코드수정
    /// 3. 2021-09-10              권아영             채번생성/
    /// **********************************************************************
    /// </summary>
    public partial class KaySub022 : Form
    {
        #region 초기설정
        List<KaySub022Empolyee> empolyeeList;
        List<KaySub022Career> careerList;

        OracleConnection con = null;
        public string UserNm { get; set; }  // 사용자 이름
        private string Empno { get; set; } // 사번
        private string Kind { get; set; } // 증명서 종류
        private string Date { get; set; } // 발급일자
        private string Cnt { get; set; } // 발급부수
        private string DocName { get; set; } // 발급번호
        private string Rkind { get; set; } // 제출용도
        
        public KaySub022()
        {
            InitializeComponent();
        }

        private void KaySub022_popup_Load(object sender, EventArgs e)
        {
            CreateReport();
            this.reportViewer1.RefreshReport();
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
                reportViewer1.LocalReport.ReportEmbeddedResource = "KaySub022.CeriRei.rdlc";                
                Car_Data_GetSet();
            }
            if (Kind == "재직")
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "KaySub022.CareerRei.rdlc";
                Ceri_Data_GetSet();
            }

            // PreView 형태로 보여주기
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report          
        }


        #region 리포트 연결

        //*--------리포트 연결--------------------------------------------------
        private void Car_Data_GetSet() // 경력
        {
            try
            {                
                DataTable dt;
                using (con = Utility.SetOracleConnection())
                {
                    OracleCommand cmd = con.CreateCommand();
                    DataSet ds = new DataSet();
                    cmd.CommandText = SQLStatement.SelectSQL1;
                    cmd.BindByName = true;
                    cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = Empno;
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(ds);
                    dt = ds.Tables[0];
                }

                careerList = new List<KaySub022Career>();
                var byteArray = Encoding.UTF8.GetBytes(resnoBox.Text);
                string endDate = DateTime.Now.ToString("yyyy-MM-dd");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KaySub022Career VM = new KaySub022Career();
                    VM.BAS_EMPNO = Empno;
                    VM.BAS_NAME = dt.Rows[i]["bas_name"].ToString();
                    resnoBox.Text = Utility.AESDecrypt128(dt.Rows[i]["bas_resno"].ToString(), byteArray.ToString());
                    VM.BAS_RESNO = resnoBox.Text;
                    VM.BAS_ADDR = dt.Rows[i]["bas_addr"].ToString() + dt.Rows[i]["bas_anaddr"].ToString();
                    VM.PAPP_POS = dt.Rows[i]["papp_pos_nm"].ToString();
                    VM.PAPP_DUT = dt.Rows[i]["papp_dut_nm"].ToString();
                    VM.PAPP_DEPT = dt.Rows[i]["papp_dept_nm"].ToString();
                    ct_date.Text = dt.Rows[i]["papp_date"].ToString();
                    VM.PAPP_ENTDATE = ct_date.Text;
                    if (i < dt.Rows.Count && i > 1)
                    {
                        ct_date2.Text = dt.Rows[i + 1]["papp_date"].ToString();
                        VM.PAPP_RESDATE = ct_date2.Text; 
                    }
                    if (i == dt.Rows.Count || i + 1 == dt.Rows.Count) VM.PAPP_RESDATE = endDate;
                    careerList.Add(VM);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            ReportDataSource rds = new ReportDataSource("CarDataSet", careerList);
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            ReportParameter reportParameter = new ReportParameter();

          //  reportViewer1.LocalReport.SetParameters(new ReportParameter("reportNum", ));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("reportMaker", UserNm));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("reportDate", Date));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("reportKind", Rkind));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("reportName", Kind + "증명서"));
        }

        private void Ceri_Data_GetSet() // 재직Microsoft.Reporting.WinForms.LocalProcessingException: '로컬 보고서를 처리하는 
        {
            try
            {
                DataTable dt;
                using (con = Utility.SetOracleConnection())
                {
                    OracleCommand cmd = con.CreateCommand();
                    DataSet ds = new DataSet();
                    cmd.CommandText = SQLStatement.SelectSQL;
                    cmd.BindByName = true;
                    cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = Empno;
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(ds);
                    dt = ds.Tables[0];
                }

                empolyeeList = new List<KaySub022Empolyee>();
                var byteArray = Encoding.UTF8.GetBytes(resnoBox.Text);
                string endDate = DateTime.Now.ToString("yyyy-MM-dd");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    KaySub022Empolyee VM = new KaySub022Empolyee();
                    VM.BAS_EMPNO = dt.Rows[i]["bas_empno"].ToString();
                    VM.BAS_NAME = dt.Rows[i]["bas_name"].ToString();
                    resnoBox.Text = Utility.AESDecrypt128(dt.Rows[i]["bas_resno"].ToString(), byteArray.ToString());
                    VM.BAS_RESNO = resnoBox.Text;
                    VM.BAS_ADDR = dt.Rows[i]["bas_addr"].ToString() + dt.Rows[i]["bas_anaddr"].ToString();
                    VM.BAS_CONT = dt.Rows[i]["bas_cont"].ToString();
                    
                    ct_date.Text = dt.Rows[i]["bas_entdate"].ToString();
                    VM.BAS_ENTDATE = ct_date.Text;
                    ct_date2.Text = dt.Rows[i]["bas_levdate"].ToString();
                    VM.BAS_RESDATE = ct_date2.Text;

                    VM.BAS_STS = dt.Rows[i]["sts"].ToString();
                    VM.BAS_POS = dt.Rows[i]["pos"].ToString();
                    VM.BAS_DEPT = dt.Rows[i]["dept"].ToString();
                    empolyeeList.Add(VM);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            ReportDataSource rds = new ReportDataSource("CeriDataSet", empolyeeList);
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.LocalReport.SetParameters(new ReportParameter("reportNum", "번호"));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("reportMaker", "이름"));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("reportDate", Date));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("reportKind", Rkind));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("reportName", Kind + "증명서"));
        }
        #endregion
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
