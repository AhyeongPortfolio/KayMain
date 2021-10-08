using KayLibrary;
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

namespace KaySub020
{
    public partial class UserControl1 : UserControl
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

            qt_tor_name.Leave += QT_Name_to_Empno;
           // dataGridView1.CellDoubleClick += List_CellDoubleClick;
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {
            last_button_status = Utility.SetFuncBtn(MainBtn, "0");
            Utility.DataGridView_Scrolling_SpeedUp(dataGridView1);
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }
        #endregion
        #region 기능버튼(조회) Click
        //************************************************************
        //** 조회 버튼 Click
        //************************************************************
        public void BtnSearch_Click()
        {
            Utility.BusyIndicator(true);

            dataGridView1.Rows.Clear();
            int rowIdx = 0;
            DataGridViewRow row;
            //--DB Handling(Start)-------------------------------------
            try
            {
                using (con = Utility.SetOracleConnection())
                {
                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = SQLStatement.SelectSQL;
                        cmd.Parameters.Add("evalm_year", OracleDbType.Varchar2).Value = "%" + qt_evalm_year.Text + "%";
                        cmd.Parameters.Add("evalm_no", OracleDbType.Varchar2).Value = "%" + qt_evalm_no.Text + "%";
                        cmd.Parameters.Add("evalm_tor", OracleDbType.Varchar2).Value = "%" + qt_evalm_tor.Text + "%";
                        cmd.Parameters.Add("evalm_type", OracleDbType.Varchar2).Value = "%" + qt_evalm_type.Text + "%";
                        cmd.BindByName = true;

                        OracleDataReader dr = cmd.ExecuteReader();
                        query_sw = true; //*---SelectionChanged Event 발생을 회피하기 위해 (On)
                        while (dr.Read())
                        {
                            rowIdx = dataGridView1.Rows.Add();
                            row = dataGridView1.Rows[rowIdx];
                            row.Cells["EVALM_YEAR"].Value = dr["EVALM_YEAR"].ToString();
                            row.Cells["EVALM_NO"].Value = dr["EVALM_NO"].ToString();
                            row.Cells["EVALM_TYPE"].Value = dr["EVALM_TYPE"].ToString();
                            row.Cells["EVALM_PERIOD"].Value = dr["EVALM_PERIOD"].ToString();

                            row.Cells["evalm_tor"].Value = dr["evalm_tor"].ToString();
                            row.Cells["tor_name"].Value = dr["TOR_NAME"].ToString();
                            row.Cells["evalm_dept_tor"].Value = dr["evalm_dept_tor"].ToString();
                            row.Cells["evalm_pos_tor"].Value = dr["evalm_pos_tor"].ToString();
                            row.Cells["evalm_dut_tor"].Value = dr["evalm_dut_tor"].ToString();
                            
                            row.Cells["tee_count"].Value = dr["tee_count"].ToString();
                            row.Cells["tee_fincount"].Value = dr["tee_fincount"].ToString();
                            row.Cells["evalm_findate"].Value = Utility.FormatDate(dr["evalm_findate"].ToString());
                            row.Cells["eval_edate"].Value = Utility.FormatDate(dr["eval_edate"].ToString());
                            row.Cells["tee_yecount"].Value = int.Parse(dr["tee_count"].ToString()) - int.Parse(dr["tee_fincount"].ToString());
                        }
                        dr.Close();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                query_sw = false; //*---SelectionChanged Event 발생을 회피하기 위해 (Off)
                Utility.BusyIndicator(false);
                if (con != null) con.Close();
            }
            //--DB Handling(End)-------------------------------------
            var recCnt = dataGridView1.RowCount;
            Info_Count.Text = recCnt.ToString();
            if (recCnt == 0)
            {
                Info_Message.Text = "조건을 만족하는 자료가 없습니다.";
               // last_button_status = Utility.SetFuncBtn(MainBtn, "0");
            }
            else
            {
                Utility.SetFocusingDataGridView(dataGridView1, 0); //Focus를 맨 첫줄로 보내기
                // this.DataList_SelectionChanged(null, null);   //선택된 첫줄을 Control에 표시하기
               // last_button_status = Utility.SetFuncBtn(MainBtn, "0");
                Info_Message.Text = "자료가 정상적으로 조회 되었습니다.";
            }
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
        #region 이름 입력받아 사원번호 찾아오기
        
        private void QT_Name_to_Empno(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                return;
            }

            Control ctl = SetControlByName(panData, (sender as TextBox));

            //*--DB Handling(Start)------------------------------------
            try
            {
                using (con = Utility.SetOracleConnection())
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = SQLStatement.SelectSQL3;
                    cmd.BindByName = true;
                    cmd.Parameters.Add("bas_name", OracleDbType.Varchar2).Value = (sender as TextBox).Text;

                    string name = (string)cmd?.ExecuteScalar() ?? string.Empty;
                    ctl.Text = name;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private Control SetControlByName(Control control, TextBox text)
        {
            string[] ctl_name = text.Name.Split('_');
            string name = ctl_name[0] + "_evalm_" + ctl_name[1];

            Control[] ctl = control.Controls.Find(name, true);
            return ctl.Length == 0 ? null : ctl[0];
        }

        #endregion
    }
}
