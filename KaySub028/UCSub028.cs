using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using Oracle.ManagedDataAccess.Client;
using KayLibrary;

namespace KaySub028
{
    public partial class UserControl1: UserControl
    {
        #region 초기설정

        OracleConnection con = null;
        private bool select_sw = false;
        private bool query_sw = false;
        //************************************************************
        // 메인메뉴로부터 초기 설정값 넘겨 받기
        //************************************************************
        public Button[] MainBtn { get; set; }           // 메인기능 버튼
        public string UserId { get; set; }              // 사용자 ID
        public Label Info_Count { get; set; }           // 검색건수
        public Label Info_Message { get; set; }         // 하단 메세지
        public string last_button_status { get; set; }  // 버튼 최종상태
        public string UserNm { get; set; }              // 사용자 이름

        public UserControl1()
        {
            InitializeComponent();

            //dataGridView2.SelectionChanged += DataList_SelectionChanged;
            //dataGridView1.ReadOnly = true;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //*---부서 검색 콤보박스 채우기----------------------------------------
            //Utility.SetComboWithCdnm(searchDept, SQLStatement.SelectSQL1);
            //*---날짜 초기화----------------------------------------------------
            DateTime today = DateTime.Now.Date;
            qt_cal_date1.Value = System.DateTime.Now.AddYears(-1);
            qt_cal_date2.Value = System.DateTime.Now;
            last_button_status = Utility.SetFuncBtn(MainBtn, "0");
            //Utility.DataGridView_Scrolling_SpeedUp(dataGridView1);
        }
        #endregion
        #region 기능버튼(조회) Click
        //************************************************************
        //** 조회 버튼 Click
        //************************************************************
        public void BtnSearch_Click()
        {
            Utility.BusyIndicator(true);

            Dictionary<string, double> slice = new Dictionary<string, double>(); //재직인원
            Dictionary<string, double> slice2 = new Dictionary<string, double>(); //입사인원
            Dictionary<string, double> slice3 = new Dictionary<string, double>(); //퇴사인원

            int rowIdx = 0;
            int hap = 0;

            //--DB Handling(Start)-------------------------------------
            try
            {                
                using (con = Utility.SetOracleConnection())
                {
                    slice = AddDictionary(SQLStatement.SelectSQL, SQLStatement.SelectSQL2, con);
                    slice2 = AddDictionary(SQLStatement.SelectSQL3, SQLStatement.SelectSQL4, con);
                    slice3 = AddDictionary(SQLStatement.SelectSQL5, SQLStatement.SelectSQL6, con);
                }
                               

                query_sw = true; //*---SelectionChanged Event 발생을 회피하기 위해 (On)
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            finally
            {
                query_sw = false; //*---SelectionChanged Event 발생을 회피하기 위해 (Off)
                Utility.BusyIndicator(false);
            }
            //--DB Handling(End)-------------------------------------
            //var recCnt = null;
            //Info_Count.Text = recCnt.ToString();
            
            //this.DataList_SelectionChanged(null, null);   //선택된 첫줄을 Control에 표시하기

            // Chart
            cartesianChart2.Series.Clear();
            cartesianChart2.AxisX.Clear();
            //PieSeries series = new PieSeries();
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1})", chartPoint.Y, chartPoint.Participation);

            cartesianChart2.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "재직인원수",
                    Values = new ChartValues<double>(slice.Values),
                    DataLabels = true,
                    LabelPoint = labelPoint
                }    ,
                new LineSeries
                {
                    Title = "사직인원수",
                    Values = new ChartValues<double>(slice2.Values),
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new LineSeries
                {
                    Title = "입사인원수",
                    Values = new ChartValues<double>(slice3.Values),
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            cartesianChart2.AxisX.Add(new Axis
            {
                Title = "날짜",
                Labels = slice.Keys.ToList(),
                Separator = new Separator
                {
                    Step = 1,
                    IsEnabled = false
                }
            }) ;
            

            cartesianChart2.LegendLocation = LegendLocation.Bottom;
            Info_Message.Text = "자료가 정상적으로 조회 되었습니다.";
            
        }
        #endregion
        #region 기능버튼(입력) Click
        //************************************************************
        //** 입력 버튼 Click 
        //************************************************************
        public void BtnInsert_Click()
        {
            return;
        }
        #endregion
        #region 기능버튼(수정) Click
        //************************************************************
        //** 수정 버튼 Click 
        //************************************************************
        public void BtnUpdate_Click()
        {
            MessageBox.Show(this.Name + " 수정버튼 사용하지 않음");
        }
        #endregion
        #region 기능버튼(삭제) Click
        //************************************************************
        //** 삭제 버튼 Click 
        //************************************************************
        public void BtnDelete_Click()
        {
            return;
        }
        #endregion
        #region 기능버튼(저장) Click
        //************************************************************
        //** 저장 버튼 Click (여러 건의 DATA 추가입력/수정 후 저장)
        //************************************************************
        public void BtnSave_Click()
        {
            return;
        }
        #endregion
        #region 기능버튼(취소) Click
        //************************************************************
        //** 취소 버튼 Click
        //************************************************************
        public void BtnCancel_Click()
        {
            DialogResult result = MessageBox.Show(" 입력 및 수정중인 자료를 취소합니다.", "취소메세지", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            BtnSearch_Click();
        }
        #endregion
        #region 기능버튼(인쇄) Click
        //************************************************************
        //**  인쇄 버튼 Click
        //************************************************************
        public void BtnPrint_Click()
        {
            MessageBox.Show(this.Name + " 인쇄버튼 클릭");
        }
        #endregion
        #region 기능버튼(종료) Click
        //************************************************************
        //** 종료 버튼 Click
        //************************************************************
        public void BtnClose_Click()
        {
            if (con != null) con.Close();
        }
        #endregion
        #region Conrtrol Value Changed 공통 Event Handler
        //************************************************************
        //** Conrtrol Value Changed 공통 Event Handler
        //************************************************************
        private void InputData_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        #region DataGridView의 선택이 변경되었을 때 각 콘트롤에 Data Setting
        //************************************************************
        //** DataGridView의 선택이 변경되었을 때 각 콘트롤에 Data Setting
        //************************************************************
        private void DataList_SelectionChanged(object sender, EventArgs e)
        {

        }


        #endregion
        #region Dictionary 값추가
        private Dictionary<string, double> AddDictionary(string sql1, string sql2, OracleConnection con)
        {
            int lastday = DateTime.DaysInMonth(qt_cal_date2.Value.Year, qt_cal_date2.Value.Month);
            Dictionary<string, double> valuePairs = new Dictionary<string, double>();
            OracleCommand cmd;
            using (cmd = con.CreateCommand())
            {
                if (radiMonth.Checked)
                {
                    cmd.CommandText = sql1;
                    cmd.BindByName = true;
                    cmd.Parameters.Add("cal_date1", OracleDbType.Varchar2).Value = qt_cal_date1.Text + "-01";
                    cmd.Parameters.Add("cal_date2", OracleDbType.Varchar2).Value = qt_cal_date2.Text + "-" + lastday.ToString();
                }
                else if (radiYear.Checked)
                {
                    cmd.CommandText = sql2;
                    cmd.BindByName = true;
                    cmd.Parameters.Add("cal_date1", OracleDbType.Varchar2).Value = qt_cal_date1.Text + "-01-01";
                    cmd.Parameters.Add("cal_date2", OracleDbType.Varchar2).Value = qt_cal_date2.Text + "-12-31";
                }

                OracleDataReader reader = cmd.ExecuteReader();
                valuePairs.Clear();
                while (reader.Read())
                {
                    valuePairs.Add(reader["CAL_DATE"].ToString(), double.Parse(reader["BAS_EMPNO"].ToString()));
                }
            }

            return valuePairs;
        }
        #endregion
    }
}
