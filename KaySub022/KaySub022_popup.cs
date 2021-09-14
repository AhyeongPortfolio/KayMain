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

namespace KaySub022
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 증명서 발급 팝업창(신규발급) 
    /// --Memo                : 재증명서발급페이지에서 DB에 정보를 저장 후 인쇄 전 미리보기 용도로 사용
    /// --최근작성 정보
    /// 2. 2021-09-14              권아영             신규생성(새로만듬)
    /// **********************************************************************
    /// </summary>
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateReport();
            this.reportViewer1.RefreshReport();
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
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            
                // 증명서 종류 구분
                if (Kind.Equals("경력"))
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "KaySub022.CareerReport.rdlc";
                //    reportViewer1.LocalReport.EnableExternalImages = true;
                    Career_Data_GetSet();
                }

                if (Kind.Equals("재직"))
                {
                    reportViewer1.LocalReport.ReportPath = "KaySub022.EmpolyeeReport.rdlc";
                    reportViewer1.ProcessingMode = ProcessingMode.Local;
                    Empolyee_Data_GetSet();
                }
            

            // preview 형태로 보여주기
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report
        }

        private void Empolyee_Data_GetSet()
        {
            using (con = Utility.SetOracleConnection())
            {
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL;
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
                        qt_date1.Text = dt.Rows[i]["bas_levdate"]?.ToString() ?? endDate;
                        VM.BAS_RESDATE = qt_date1.Text;
                        VM.BAS_CONT = dt.Rows[i]["bas_cont"].ToString();

                        employeeList.Add(VM);
                    }

                    ReportDataSource rds = new ReportDataSource("DataSet2", employeeList);
                    this.reportViewer1.LocalReport.DataSources.Add(rds);

                    reportViewer1.LocalReport.SetParameters(new ReportParameter("@reportNum", DocName + "aa"));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("@reportMaker", "관리자"));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("@reportDate", Date));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("@reportKind", Rkind));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("@reportName", Kind + "증명서"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        }

        private void Career_Data_GetSet()
        {
            using (con = Utility.SetOracleConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = SQLStatement.SelectSQL1;
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

                    var reportParameter = new ReportParameterCollection();
                    //reportParameter.Add(new ReportParameter("reportNum", DocName + "aa"));
                    reportParameter.Add(new ReportParameter("reportMaker", "관리자"));
                    reportParameter.Add(new ReportParameter("reportDate", Date));
                    reportParameter.Add(new ReportParameter("reportKind", Rkind));
                    reportParameter.Add(new ReportParameter("reportName", Kind + "증명서"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
           
        }

        #endregion



        #region Parameter Value Set
        public void SetActiveValue(string _empno, string _kind, string _date, string _dname,  string _rkind )
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
