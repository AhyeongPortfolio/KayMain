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

namespace KaySub021
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
                using(con = Utility.SetOracleConnection())
                {
                    using(OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = SQLStatement.SelectSQL;
                        cmd.Parameters.Add("evalm_year", OracleDbType.Varchar2).Value = "%" + qt_evalm_year.Text + "%";
                        cmd.Parameters.Add("evalm_no", OracleDbType.Varchar2).Value = "%" + qt_evalm_no.Text + "%";
                        cmd.Parameters.Add("evalm_tor", OracleDbType.Varchar2).Value = "%" + qt_evalm_tor.Text + "%";
                        cmd.Parameters.Add("evalm_type", OracleDbType.Varchar2).Value = "%" + qt_evalm_type.Text + "%";
                        cmd.BindByName = true;
                        
                        OracleDataAdapter ad = new OracleDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        ad.Fill(dt);

                        dataGridView1.DataSource = dt;
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
                last_button_status = Utility.SetFuncBtn(MainBtn, "0");
            }
            else
            {
                Utility.SetFocusingDataGridView(dataGridView1, 0); //Focus를 맨 첫줄로 보내기
              // this.DataList_SelectionChanged(null, null);   //선택된 첫줄을 Control에 표시하기

                last_button_status = Utility.SetFuncBtn(MainBtn, "0");
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
        #region 기능버튼(수정) Click
        //************************************************************
        //** 수정 버튼 Click 
        //************************************************************
        public void BtnUpdate_Click()
        {
            MessageBox.Show(this.Name + " 수정버튼 사용하지 않음");
            return;
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
        #region 이름 입력받아 사원번호 찾아오기
        private void CT_Name_to_Empno(object sender, EventArgs e)
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
                    cmd.CommandText = SQLStatement.SelectSQL2;
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
                    cmd.CommandText = SQLStatement.SelectSQL2;
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
        #region CellDoubleClick 이벤트

        private void List_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            if (string.IsNullOrEmpty(row.Cells["evalm_type"].Value.ToString()))
            {
                MessageBox.Show("해당되는 평가표 유형이 없습니다.");
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
                        if (int.Parse(cnt.ToString()) == 0)
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
            evals.status = row.Cells["evalm_findate"].Value.ToString() == "N" ? "A" : "U";

            evals.ShowDialog();

            BtnSearch_Click();

        }
        #endregion
    }
}
