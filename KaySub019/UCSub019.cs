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

namespace KaySub019
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

            dataGridView1.CellDoubleClick += List_CellDoubleClick;
            //*--콤보박스 채우기-------------------------------------------------
            Utility.SetComboWithCdnm(qt_evalm_type, SQLStatement.SelectSQL5);
            //*--콤보박스 미리 선택----------------------------------------------
            qt_evalm_type.SelectedIndex = 1;
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
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();

                cmd.CommandText = SQLStatement.SelectSQL;
                cmd.Parameters.Add("evalm_tor", OracleDbType.Varchar2).Value = UserId;
                cmd.BindByName = true;
                
                OracleDataReader dr = cmd.ExecuteReader();
                query_sw = true; //*---SelectionChanged Event 발생을 회피하기 위해 (On)
                while (dr.Read())
                {
                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    row.Cells["EVALM_YEAR"].Value = dr["EVALM_YEAR"].ToString();
                    row.Cells["EVALM_NO"].Value = dr["EVALM_NO"].ToString();
                    row.Cells["EVALM_TEE"].Value = dr["EVALM_TEE"].ToString();
                    row.Cells["EVALM_STAGE"].Value = dr["EVALM_STAGE"].ToString();
                    row.Cells["EVALM_TOR"].Value = dr["EVALM_TOR"].ToString();
                    row.Cells["EVALM_TYPE"].Value = dr["EVALM_TYPE"].ToString();
                    row.Cells["EVALM_PERIOD"].Value = dr["EVALM_PERIOD"].ToString();
                    row.Cells["tee_name"].Value = dr["TEE_NAME"].ToString();
                    row.Cells["tor_name"].Value = dr["TOR_NAME"].ToString();
                    row.Cells["EVALM_FINDATE"].Value = Utility.FormatDate(dr["EVALM_FINDATE"].ToString());
                    row.Cells["EVALM_DEPT_TEE"].Value = dr["EVALM_DEPT_TEE"].ToString();
                    row.Cells["EVALM_POS_TEE"].Value = dr["EVALM_POS_TEE"].ToString();
                    row.Cells["EVALM_DEPT_TOR"].Value = dr["EVALM_DEPT_TOR"].ToString();
                    row.Cells["EVALM_POS_TOR"].Value = dr["EVALM_POS_TOR"].ToString();
                    row.Cells["EVALM_DUT_TOR"].Value = dr["EVALM_DUT_TOR"].ToString();
                    row.Cells["EVALM_TOTAL"].Value = dr["EVALM_TOTAL"].ToString();
                    row.Cells["EVALM_MERIT"].Value = dr["EVALM_MERIT"].ToString();
                    row.Cells["EVALM_WEAK"].Value = dr["EVALM_WEAK"].ToString();
                    row.Cells["eval_edate"].Value = Utility.FormatDate(dr["eval_edate"].ToString());

                    string Edate = string.Empty;
                    if (string.IsNullOrEmpty(dr["EVALM_FINDATE"].ToString()))
                    {
                        Edate = DateTime.Now.ToString("yyyyMMdd");
                    }
                    else Edate = dr["EVALM_FINDATE"].ToString();

                    if (int.Parse(dr["eval_edate"].ToString()) <= int.Parse(Edate))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;                        
                    }
                    
                }
                dr.Close();
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
            }
            else
            {
                //Utility.SetFocusingDataGridView(dataGridView1, 0); //Focus를 맨 첫줄로 보내기
                //this.DataList_SelectionChanged(null, null);   //선택된 첫줄을 Control에 표시하기

                Info_Message.Text = "자료가 정상적으로 조회 되었습니다.";
            }
        }
        #endregion

        #region CellDoubleClick 이벤트

        private void List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            if (string.IsNullOrEmpty(row.Cells["evalm_type"].Value.ToString()))
            {
                MessageBox.Show("해당되는 평가표 유형이 없습니다.");
                return;
            }
            //*---날짜 지난거 체크---------------------------------------------------
            if (int.Parse(DateTime.Now.ToString("yyyyMMdd")) > int.Parse(Utility.FormatDateR(row.Cells["eval_edate"].Value.ToString())))
            {
                MessageBox.Show("평가 기간이 지났습니다.");
                return;
            }

            //*---DB Handling(Start)------------------------------------------------
            try
            {
                using (con = Utility.SetOracleConnection())
                {
                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = SQLStatement.SelectSQL6;
                        cmd.BindByName = true;
                        cmd.Parameters.Add("evali_type", OracleDbType.Varchar2).Value = row.Cells["evalm_type"].Value.ToString();
                        var cnt = cmd.ExecuteScalar();
                        if(int.Parse(cnt.ToString()) == 0)
                        {
                            MessageBox.Show("평가표 유형이 유효하지 않습니다.");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            //*--DB Handling(End)-------------------------------------------------

            //*--평가 창 Open------------------------------------------------------
            EvalsWindow evals = new EvalsWindow();

            evals.evalm_dept_tee.Text = row.Cells["evalm_dept_tee"].Value.ToString();
            evals.evalm_pos_tee.Text = row.Cells["evalm_pos_tee"].Value.ToString();
            evals.name_tee.Text = row.Cells["tee_name"]?.Value.ToString() ?? "";
            evals.evalm_period.Text = row.Cells["evalm_period"]?.Value.ToString() ?? "";
            evals.evalm_dut_tor.Text = row.Cells["evalm_dut_tor"]?.Value.ToString() ?? "";
            evals.name_tor.Text = row.Cells["tor_name"].Value.ToString();
            evals.Type = row.Cells["evalm_type"].Value.ToString();
            evals.Year = row.Cells["evalm_year"].Value.ToString();
            evals.No = row.Cells["evalm_no"]?.Value.ToString() ?? "";
            evals.Stage = row.Cells["evalm_stage"]?.Value.ToString() ?? "";
            evals.Tee = row.Cells["evalm_tee"]?.Value.ToString() ?? "";
            evals.evalm_sum.Text = row.Cells["evalm_total"].Value?.ToString() ?? "";
            evals.evalm_merit.Text = row.Cells["evalm_merit"].Value?.ToString() ?? "";
            evals.evalm_weak.Text = row.Cells["evalm_weak"]?.Value.ToString() ?? "";
            evals.UserId = UserId;
            evals.UserNm = UserNm;
            evals.status = row.Cells["evalm_findate"].Value.ToString() == "" ? "A" : "U";

            evals.ShowDialog();

            BtnSearch_Click();

        }
        #endregion

    }
}
