using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using KayLibrary;

namespace KaySub002
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 세부코드 관리
    /// --최근작성 정보
    /// 1. 2021-09-01             권아영             신규생성
    /// 2. 2021-09-02             권아영             쿼리 수정
    /// **********************************************************************
    /// </summary>
    /// 
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

            //*----Value Changed Event Handler(Start)---------------------------
            ct_cd_code.TextChanged += InputData_TextChanged;
            ct_cd_codnm.TextChanged += InputData_TextChanged;
            ct_cd_addinfo.TextChanged += InputData_TextChanged;
            ct_cd_codnms.TextChanged += InputData_TextChanged;
            ct_cd_edate.TextChanged += InputData_TextChanged;
            ct_cd_grpcd.TextChanged += InputData_TextChanged;
            ct_cd_sdate.TextChanged += InputData_TextChanged;
            ct_cd_seq.TextChanged += InputData_TextChanged;
            ct_cd_upper.TextChanged += InputData_TextChanged;
            ct_cd_use.SelectedValueChanged += InputData_TextChanged;
            //*----Value Changed Event Handler(END)-----------------------------
            //*----Validated Event Handler(Start)-------------------------------
            ct_cd_grpcd.Validated += Input_Validation_Check;
            ct_cd_code.Validated += Input_Validation_Check;
            ct_cd_codnm.Validated += Input_Validation_Check;
            //*----Validated Event Handler(END)---------------------------------
            //*----Enter Number Only(Start)-------------------------------------
            ct_cd_sdate.KeyPress += Number_Only_Protect;
            //*----Enter Number Only(END)---------------------------------------
            btn_bas_univ.Click += btn_bas_univ_Click;
            dataGridView1.SelectionChanged += DataList_SelectionChanged;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //*--콤보박스 채우기-----------------------------------------
            Utility.SetComboWithCdnm(qt_cd_grpcd, SQLStatement.SelectSQL2);
            
            //*--콤보박스 미리 선택--------------------------------------
            qt_cd_grpcd.SelectedIndex = 1;
            
            last_button_status = Utility.SetFuncBtn(MainBtn, "1");
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
                cmd.BindByName = true;
                cmd.Parameters.Add("cd_grpcd", OracleDbType.Varchar2).Value = "%" + Utility.GetCode(qt_cd_grpcd.Text) + "%";
                cmd.Parameters.Add("cd_use", OracleDbType.Varchar2).Value = "%" + qt_cd_use.Text + "%";
                OracleDataReader dr = cmd.ExecuteReader();
                query_sw = true; //*---SelectionChanged Event 발생을 회피하기 위해 (On)
                while (dr.Read())
                {
                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    row.Cells["cd_grpcd"].Value = dr["cd_grpcd"].ToString();
                    row.Cells["cd_code"].Value = dr["cd_code"].ToString();
                    row.Cells["cd_seq"].Value = dr["cd_seq"].ToString();
                    row.Cells["cd_codnms"].Value = dr["cd_codnms"].ToString();
                    row.Cells["cd_codnm"].Value = dr["cd_codnm"].ToString();
                    row.Cells["cd_addinfo"].Value = dr["cd_addinfo"].ToString();
                    row.Cells["cd_upper"].Value = dr["cd_upper"].ToString();
                    row.Cells["cd_use"].Value = dr["cd_use"].ToString();
                    row.Cells["cd_sdate"].Value = Utility.FormatDate(dr["cd_sdate"].ToString());
                    row.Cells["cd_edate"].Value = Utility.FormatDate(dr["cd_edate"].ToString());
                    row.Cells["key1"].Value = dr["cd_code"].ToString();
                    row.Cells["status"].Value = "";
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
                last_button_status = Utility.SetFuncBtn(MainBtn, "1");
            }
            else
            {
                Utility.SetFocusingDataGridView(dataGridView1, 0); //Focus를 맨 첫줄로 보내기
                this.DataList_SelectionChanged(null, null);   //선택된 첫줄을 Control에 표시하기

                last_button_status = Utility.SetFuncBtn(MainBtn, "2");
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
            var rowIdx = dataGridView1.CurrentRow == null ? 0 : dataGridView1.CurrentRow.Index;

            if (dataGridView1.Rows.Count == 0)
            {
                rowIdx = dataGridView1.Rows.Add();
            }
            else
            {
                rowIdx++;
                dataGridView1.Rows.Insert(rowIdx);
            }
            dataGridView1.Rows[rowIdx].Cells["status"].Value = "A";
            //---추가된 Row로 Focus 이동-------------------------------- 
            Utility.SetFocusingDataGridView(dataGridView1, rowIdx);
            ct_cd_grpcd.Focus();

            last_button_status = Utility.SetFuncBtn(MainBtn, "3");

            //*--날짜 리셋----------------------------------------------
            ct_cd_sdate.Text = System.DateTime.Now.ToString("yyyyMMdd");
            //*--사용여부 초기값-----------------------------------------
            ct_cd_use.Text = "Y";
            //*--그룹코드 초기값-----------------------------------------
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
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 자료를 먼저 선택하세요.", "삭제확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataGridViewRow row = dataGridView1.CurrentRow;
            //신규 입력중인 자료는 단순하게 Grid에서 제거만 한다.
            if ((String)row.Cells["status"].Value == "A")
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                return;
            }
            DialogResult result = MessageBox.Show(row.Cells["cd_codnm"].Value +
                                                  " 자료를 삭제하시겠습니까.", "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.BindByName = true;
                cmd.CommandText = SQLStatement.DeleteSQL;
                cmd.Parameters.Add("cd_grpcd", OracleDbType.Varchar2).Value = Utility.GetCode((String)row.Cells["cd_grpcd"].Value);
                cmd.Parameters.Add("key1", OracleDbType.Varchar2).Value = row.Cells["key1"].Value;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                    Info_Count.Text = dataGridView1.RowCount.ToString();
                    Info_Message.Text = "자료가 정상적으로 삭제 되었습니다.";
                }
                else
                {
                    Info_Message.Text = "자료삭제에 문제가 있습니다. 시스템 담당자에게 문의하세요.";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (con != null) con.Close();
            }
            //--DB Handling(End)-------------------------------------
            if (dataGridView1.RowCount == 0)
            {
                select_sw = true;
                Utility.SetTextNull(panData);
                select_sw = false;
            }
        }
        #endregion
        #region 기능버튼(저장) Click
        //************************************************************
        //** 저장 버튼 Click (여러 건의 DATA 추가입력/수정 후 저장)
        //************************************************************
        public void BtnSave_Click()
        {
            DialogResult result = MessageBox.Show("입력 및 수정중인 자료를 저장합니다.", "저장확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            //*--입력값에 오류가 있는지 여부 확인
            if (!Utility.InputErrorCheck(dataGridView1)) return;

            OracleTransaction tran = null;
            try
            {
                con = Utility.SetOracleConnection();
                tran = con.BeginTransaction(IsolationLevel.ReadCommitted);
                OracleCommand cmd = con.CreateCommand();
                cmd.BindByName = true;
                cmd.Transaction = tran;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["status"].Value.Equals("")) continue;
                    if (row.Cells["status"].Value.Equals("A"))
                    {
                        cmd.CommandText = SQLStatement.InsertSQL;
                    }
                    if (row.Cells["status"].Value.Equals("U"))
                    {
                        cmd.CommandText = SQLStatement.UpdateSQL;
                        cmd.Parameters.Add("key1", OracleDbType.Varchar2).Value = row.Cells["key1"].Value;                                              
                    }
                    cmd.Parameters.Add("cd_grpcd", OracleDbType.Varchar2).Value =   Utility.GetCode((String)row.Cells["cd_grpcd"].Value);
                    cmd.Parameters.Add("cd_code", OracleDbType.Varchar2).Value =   row.Cells["cd_code"].Value;
                    cmd.Parameters.Add("cd_seq", OracleDbType.Varchar2).Value =   row.Cells["cd_seq"].Value;
                    cmd.Parameters.Add("cd_codnms", OracleDbType.Varchar2).Value =  row.Cells["cd_codnms"].Value;
                    cmd.Parameters.Add("cd_codnm", OracleDbType.Varchar2).Value =     row.Cells["cd_codnm"].Value;
                    cmd.Parameters.Add("cd_addinfo", OracleDbType.Varchar2).Value =    row.Cells["cd_addinfo"].Value;
                    cmd.Parameters.Add("cd_upper", OracleDbType.Varchar2).Value =   row.Cells["cd_upper"].Value;
                    cmd.Parameters.Add("cd_use", OracleDbType.Varchar2).Value =   row.Cells["cd_use"].Value;
                    cmd.Parameters.Add("cd_sdate", OracleDbType.Varchar2).Value =   Utility.FormatDateR((String)row.Cells["cd_sdate"].Value);                    
                    cmd.Parameters.Add("cd_edate", OracleDbType.Varchar2).Value = Utility.FormatDateR((String)row.Cells["cd_edate"].Value);
                    cmd.Parameters.Add("DATASYS3", OracleDbType.Varchar2).Value = UserId + ":" + UserNm;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();  //*----반드시 포함
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (con != null) con.Close();
            }
            //**정상 저장 후 초기화*******************************************************
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["status"].Value.Equals("")) continue;
                row.Cells["key1"].Value = row.Cells["cd_code"].Value;
                row.Cells["status"].Value = "";
            }
            Info_Message.Text = "자료가 정상적으로 저장 되었습니다.";
            last_button_status = Utility.SetFuncBtn(MainBtn, "2");
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
            if (select_sw) return; //GridView 선택 시 최초값 설정에 따른 이벤트는 무시

            if (dataGridView1.SelectedRows.Count <= 0) return;

            Utility.SetValueToGridView(dataGridView1, sender as Control);
            ct_cd_edate.ReadOnly = true;

            //*--Data Status = "수정"  설정-------------------
            DataGridViewRow row = dataGridView1.CurrentRow;
            if ((String)row.Cells["status"].Value == "")
            {
                row.Cells["status"].Value = "U";
                if (row.Cells["cd_use"].Value.ToString().Equals("N")) //만약 폐기를 하게 될 시
                {
                    ct_cd_edate.ReadOnly = false;
                    ct_cd_edate.Text = System.DateTime.Now.ToString("yyyyMMdd");
                }
            }
            //*--Data Status = "수정"  설정-------------------

            last_button_status = Utility.SetFuncBtn(MainBtn, "3");
        }
        #endregion
        #region DataGridView의 선택이 변경되었을 때 각 콘트롤에 Data Setting
        //************************************************************
        //** DataGridView의 선택이 변경되었을 때 각 콘트롤에 Data Setting
        //************************************************************
        private void DataList_SelectionChanged(object sender, EventArgs e)
        {
            if (query_sw) return;  //조회 버튼을 누를때, 수행하지 않기 위해
            if (dataGridView1.Rows.Count == 0) return;

            select_sw = true; //*--Control의 TextChanged 이벤트와의 충돌을 피하기 위해 (On)

            Utility.SetValueToControlFromGridView(dataGridView1, panData);

            Input_Validation_Check(sender, e); //*--Control 에 오류메세지 표시

            select_sw = false; //*--Control의 TextChanged 이벤트와의 충돌을 피하기 위해 (Off)
        }
        #endregion
        #region Input Data Validation Check (Validated Event)
        //************************************************************
        //** Input Data Validation Check (Validated Event)
        //************************************************************
        private void Input_Validation_Check(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;

            dataGridView1.SelectedRows[0].ErrorText = "";
            //*---------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(ct_cd_grpcd.Text))
            {
                SetError(ct_cd_grpcd, "그룹코드를 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_cd_grpcd, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(ct_cd_code.Text))
            {
                SetError(ct_cd_code, "코드를 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_cd_code, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(ct_cd_codnm.Text))
            {
                SetError(ct_cd_codnm, "코드명을 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_cd_codnm, errorProvider1);
            }

           
        }
        private void SetError(Control ctl, String errMsg, DataGridViewRow row, ErrorProvider errProvider)
        {
            errProvider.SetError(ctl, errMsg);
            row.ErrorText = errMsg;
        }
        private void ResetError(Control ctl, ErrorProvider errProvider)
        {
            errProvider.SetError(ctl, "");
        }
        #endregion
        #region TextBox에서 숫자만 입력받도록 (KeyPress Event)
        //************************************************************
        //** TextBox에서 숫자만 입력받도록 (KeyPress Event)
        //************************************************************
        private void Number_Only_Protect(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            //*--8 : BackSpace , 46 : dot  ----------------*/
            if (!Char.IsDigit(chr) && chr != 8 && chr != 46)
            {
                e.Handled = true;
            }
        }
        #endregion
        #region 코드 검색 윈도우 실행
        //************************************************************
        //** 코드 검색 윈도우 실행
        //************************************************************
        private void btn_bas_univ_Click(object sender, EventArgs e)
        {
            if (Utility.ShowSearchCDWindow(SQLStatement.SelectSQL1, "프로그램코드", out string result) == true)
            {
                if (dataGridView1.SelectedRows.Count < 1) return;
                ct_cd_grpcd.Text = result;
            }
        }
        #endregion
    }
}
