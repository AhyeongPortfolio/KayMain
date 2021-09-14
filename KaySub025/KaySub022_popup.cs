using KayLibrary;
using Microsoft.Reporting.WinForms;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaySub025
{
    public partial class KaySub022_popup : Form
    {
        #region 초기설정
        OracleConnection con = null;
        //private bool select_sw = false;
        //private bool query_sw = false;
        private string empno { get; set; } // 사번
        private string kind { get; set; } // 증명서 종류
        private string date { get; set; } // 발급일자
        private string lang { get; set; } // 영문증명서는 차후
        private string cnt { get; set; } // 발급부수
        private string dname { get; set; } // 발급번호
        private string rkind { get; set; } // 제출용도
        //************************************************************
        // 메인메뉴로부터 초기 설정값 넘겨 받기
        //************************************************************
        public Button[] MainBtn { get; set; }           // 메인기능 버튼
        public string UserId { get; set; }              // 사용자 ID
        public Label Info_Count { get; set; }           // 검색건수
        public Label Info_Message { get; set; }         // 하단 메세지
        public string last_button_status { get; set; }  // 버튼 최종상태
        public string UserNm { get; set; }              // 사용자 이름
        //************************************************************
        // DataSet 리스트
        //************************************************************
        List<ReportDataSet> employeeList;
        List<ReportDataSet2> careerList;
        public KaySub022_popup()
        {
            InitializeComponent();
        }

        private void KaySub022_popup_Load(object sender, EventArgs e)
        {
            CreateReport();
        }
        #endregion

        #region Report 연결
        //******************************************
        // 데이터 get , set
        // Career : 경력 
        // Empolyee : 재직
        //******************************************
        private void CreateReport()
        {
            // 레포트 파일 연결
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            // 증명서 종류 구분
            if (Kind.Equals("경력"))
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "KaySub025.Report.CareerReport.rdlc";              
                
                Career_Data_GetSet();
            }

            if (Kind.Equals("재직"))
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "KaySub025.Report.EmpolyeeReport.rdlc";
                
                Empolyee_Data_GetSet();
            }

        }

        private void Empolyee_Data_GetSet()
        {
            using (con = Utility.SetOracleConnection())
            {
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL1;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = Empno;
                try
                {
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];

                    employeeList = new List<ReportDataSet>();
                    var byteArray = Encoding.UTF8.GetBytes(qt_resno.Text);
                    string endDate = DateTime.Now.ToString("yyyy-MM-dd");

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ReportDataSet VM = new ReportDataSet();
                        VM.BAS_EMPNO = Empno;
                        qt_resno.Text = Utility.AESDecrypt128(dt.Rows[i]["bas_resno"].ToString(), byteArray.ToString());
                        VM.BAS_RESNO = qt_resno.Text;
                        VM.BAS_NAME = dt.Rows[i]["bas_name"].ToString();
                        VM.BAS_ADDR = dt.Rows[i]["bas_addr"].ToString() + dt.Rows[i]["bas_anaddr"].ToString();
                        VM.BAS_POS = dt.Rows[i]["pos"].ToString();
                        VM.BAS_DEPT = dt.Rows[i]["dept"].ToString();
                        VM.BAS_STS = dt.Rows[i]["sts"].ToString();
                        qt_date.Text = dt.Rows[i]["bas_entdate"].ToString();
                        VM.BAS_ENTDATE = qt_date.Text;
                        if (string.IsNullOrEmpty(dt.Rows[i]["bas_levdate"].ToString()))
                        {
                            qt_date1.Text = endDate;
                        }
                        else
                        {
                            qt_date1.Text = dt.Rows[i]["bas_levdate"].ToString();
                        }
                        VM.BAS_RESDATE = qt_date1.Text;
                        VM.BAS_CONT = dt.Rows[i]["bas_cont"].ToString();

                        employeeList.Add(VM);
                    }

                    ReportDataSource rds = new ReportDataSource("DataSet2", employeeList);
                    this.reportViewer1.LocalReport.DataSources.Add(rds);

                    reportViewer1.LocalReport.SetParameters(new ReportParameter("reportNum", DocName));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("reportMaker", UserNm));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("reportDate", Date));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("reportKind", Rkind));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("reportName", Kind + "증명서"));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }                
            }
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report

        }

        private void Career_Data_GetSet()
        {
            using (con = Utility.SetOracleConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = SQLStatement.SelectSQL2;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = Empno;

                try
                {
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];

                    careerList = new List<ReportDataSet2>();
                    var byteArray = Encoding.UTF8.GetBytes(qt_resno.Text);
                    string endDate = DateTime.Now.ToString("yyyy-MM-dd");

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ReportDataSet2 VM = new ReportDataSet2();
                        VM.BAS_EMPNO = Empno;
                        qt_resno.Text = Utility.AESDecrypt128(dt.Rows[i]["bas_resno"].ToString(), byteArray.ToString());
                        VM.BAS_RESNO = qt_resno.Text;
                        VM.BAS_NAME = dt.Rows[i]["bas_name"].ToString();
                        VM.BAS_ADDR = dt.Rows[i]["bas_addr"].ToString() + dt.Rows[i]["bas_anaddr"].ToString();
                        VM.PAPP_POS = dt.Rows[i]["papp_pos_nm"].ToString();
                        VM.PAPP_DUT = dt.Rows[i]["papp_dut_nm"].ToString();
                        VM.PAPP_DEPT = dt.Rows[i]["papp_dept_nm"].ToString();
                        qt_date.Text = dt.Rows[i]["papp_date"].ToString();
                        VM.PAPP_ENTDATE = qt_date.Text;
                        if (i < dt.Rows.Count && i > 1)
                        {
                            qt_date1.Text = dt.Rows[i + 1]["papp_date"].ToString();
                            VM.PAPP_RESDATE = qt_date1.Text;
                        }
                        if (i == dt.Rows.Count || i + 1 == dt.Rows.Count) VM.PAPP_RESDATE = endDate;
                        careerList.Add(VM);
                    }

                    ReportDataSource rds = new ReportDataSource("DataSet1", careerList);
                    this.reportViewer1.LocalReport.DataSources.Add(rds);

                    reportViewer1.LocalReport.SetParameters(new ReportParameter("reportNum", DocName));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("reportMaker", UserNm));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("reportDate", Date));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("reportKind", Rkind));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("reportName", Kind + "증명서"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                
            }
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report
        }

        #endregion



        #region Parameter Value Set
        public void SetActiveValue(string _empno, string _kind, string _date, string _dname, string _rkind)
        {
            Empno = _empno;
            Kind = _kind;
            Date = _date;
            DocName = _dname;
            Rkind = _rkind;
        }


        private string Empno { get; set; } // 사번
        private string Kind { get; set; } // 증명서 종류
        private string Date { get; set; } // 발급일자
        private string DocName { get; set; } // 발급번호
        private string Rkind { get; set; } // 제출용도
        #endregion
    }
}
