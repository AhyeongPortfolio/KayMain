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


namespace KaySub005
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 인사정보관리
    /// --최근작성 정보
    /// 1. 2021-08-31          권아영                  신규생성
    /// 2. 2021-09-06          권아영                  코드작성
    /// 3. 2021-10-13          권아영                  버튼 변경
    /// **********************************************************************
    /// </summary>
    public partial class UserControl1: UserControl
    {
        #region 초기설정

        OracleConnection con = null;
        private bool select_sw = false;
        private bool query_sw = false;
        private string Today = System.DateTime.Now.ToString("yyyyMMdd");
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
            ct_bas_empno.TextChanged += InputData_TextChanged;
            ct_bas_name.TextChanged += InputData_TextChanged;
            ct_bas_emp_sdate.TextChanged += InputData_TextChanged;
            ct_bas_emp_edate.TextChanged += InputData_TextChanged;
            ct_bas_entdate.TextChanged += InputData_TextChanged;
            ct_bas_resdate.TextChanged += InputData_TextChanged;
            ct_bas_levdate.TextChanged += InputData_TextChanged;
            ct_bas_reidate.TextChanged += InputData_TextChanged;
            ct_bas_dptdate.TextChanged += InputData_TextChanged;
            ct_bas_jkdate.TextChanged += InputData_TextChanged;
            ct_bas_posdate.TextChanged += InputData_TextChanged;
            ct_bas_wsta.TextChanged += InputData_TextChanged;
            ct_bas_sts.TextChanged += InputData_TextChanged;
            ct_bas_pos.TextChanged += InputData_TextChanged;
            ct_bas_dut.TextChanged += InputData_TextChanged;
            ct_bas_dept.TextChanged += InputData_TextChanged;
            //*----Value Changed Event Handler(END)-----------------------------
            //*----Enter Number Only(Start)-------------------------------------
            ct_bas_emp_sdate.KeyPress += Number_Only_Protect;
            ct_bas_emp_edate.KeyPress += Number_Only_Protect;
            ct_bas_entdate.KeyPress += Number_Only_Protect;
            ct_bas_resdate.KeyPress += Number_Only_Protect;
            ct_bas_levdate.KeyPress += Number_Only_Protect;
            ct_bas_reidate.KeyPress += Number_Only_Protect;
            ct_bas_dptdate.KeyPress += Number_Only_Protect;
            ct_bas_jkdate.KeyPress += Number_Only_Protect;
            ct_bas_posdate.KeyPress += Number_Only_Protect;
            //*----Enter Number Only(END)---------------------------------------

            dataGridView1.SelectionChanged += DataList_SelectionChanged;

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
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = "%" + search_empno.Text + "%";
                cmd.Parameters.Add("bas_name", OracleDbType.Varchar2).Value = "%" + search_name.Text + "%";
                OracleDataReader dr = cmd.ExecuteReader();


                query_sw = true; //*---SelectionChanged Event 발생을 회피하기 위해 (On)
                while (dr.Read())
                {
                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    row.Cells["BAS_EMPNO"].Value = dr["bas_empno"].ToString();
                    row.Cells["BAS_NAME"].Value = dr["bas_name"].ToString();
                    //*-----인사변동사항에서 입력 및 수정 할 데이터-----------------------------------------------
                    row.Cells["BAS_CONT"].Value = dr["bas_cont"].ToString();
                    row.Cells["BAS_EMP_SDATE"].Value = Utility.FormatDate(dr["bas_emp_sdate"].ToString());
                    row.Cells["BAS_EMP_EDATE"].Value = Utility.FormatDate(dr["bas_emp_edate"].ToString());
                    row.Cells["BAS_ENTDATE"].Value = Utility.FormatDate(dr["bas_entdate"].ToString());
                    row.Cells["BAS_RESDATE"].Value = Utility.FormatDate(dr["bas_resdate"].ToString());
                    row.Cells["BAS_LEVDATE"].Value = Utility.FormatDate(dr["bas_levdate"].ToString());
                    row.Cells["BAS_REIDATE"].Value = Utility.FormatDate(dr["bas_reidate"].ToString());
                    row.Cells["BAS_DPTDATE"].Value = Utility.FormatDate(dr["bas_dptdate"].ToString());
                    row.Cells["BAS_JKDATE"].Value = Utility.FormatDate(dr["bas_jkdate"].ToString());
                    row.Cells["BAS_POSDATE"].Value = Utility.FormatDate(dr["bas_posdate"].ToString());
                    row.Cells["BAS_WSTA"].Value = dr["bas_wsta"].ToString();
                    row.Cells["BAS_STS"].Value = dr["bas_sts"].ToString();
                    row.Cells["BAS_POS"].Value = dr["bas_pos"].ToString();
                    row.Cells["BAS_DUT"].Value = dr["bas_dut"].ToString();
                    row.Cells["BAS_DEPT"].Value = dr["bas_dept"].ToString();
                    //*----------------------------------------------------------------------------------------
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
                last_button_status = Utility.SetFuncBtn(MainBtn, "0");
            }
            else
            {
                Utility.SetFocusingDataGridView(dataGridView1, 0); //Focus를 맨 첫줄로 보내기
                this.DataList_SelectionChanged(null, null);   //선택된 첫줄을 Control에 표시하기

                last_button_status = Utility.SetFuncBtn(MainBtn, "4");
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
                    
                    cmd.CommandText = SQLStatement.UpdateSQL;                    
                    cmd.Parameters.Add("BAS_EMPNO", OracleDbType.Varchar2).Value = row.Cells["bas_empno"].Value;
                    cmd.Parameters.Add("BAS_CONT", OracleDbType.Varchar2).Value = row.Cells["bas_cont"].Value;
                    cmd.Parameters.Add("BAS_EMP_SDATE", OracleDbType.Varchar2).Value = row.Cells["bas_emp_sdate"].Value;
                    cmd.Parameters.Add("BAS_EMP_EDATE", OracleDbType.Varchar2).Value = row.Cells["bas_emp_edate"].Value;
                    cmd.Parameters.Add("BAS_ENTDATE", OracleDbType.Varchar2).Value = row.Cells["bas_entdate"].Value;
                    cmd.Parameters.Add("BAS_RESDATE", OracleDbType.Varchar2).Value = row.Cells["bas_resdate"].Value;
                    cmd.Parameters.Add("BAS_LEVDATE", OracleDbType.Varchar2).Value = row.Cells["bas_levdate"].Value;
                    cmd.Parameters.Add("BAS_REIDATE", OracleDbType.Varchar2).Value = row.Cells["bas_reidate"].Value;
                    cmd.Parameters.Add("BAS_DPTDATE", OracleDbType.Varchar2).Value = row.Cells["bas_dptdate"].Value;
                    cmd.Parameters.Add("BAS_JKDATE", OracleDbType.Varchar2).Value = row.Cells["bas_jkdate"].Value;
                    cmd.Parameters.Add("BAS_POSDATE", OracleDbType.Varchar2).Value = row.Cells["bas_posdate"].Value;
                    cmd.Parameters.Add("BAS_WSTA", OracleDbType.Varchar2).Value = row.Cells["bas_wsta"].Value;
                    cmd.Parameters.Add("BAS_STS", OracleDbType.Varchar2).Value = Utility.GetCode((String)row.Cells["sts"].Value);
                    cmd.Parameters.Add("BAS_POS", OracleDbType.Varchar2).Value = Utility.GetCode((String)row.Cells["pos"].Value);
                    cmd.Parameters.Add("BAS_DUT", OracleDbType.Varchar2).Value = Utility.GetCode((String)row.Cells["dut"].Value);
                    cmd.Parameters.Add("BAS_DEPT", OracleDbType.Varchar2).Value = Utility.GetCode((String)row.Cells["dept"].Value);
                    cmd.Parameters.Add("DATASYS2", OracleDbType.Varchar2).Value = "U";
                    cmd.Parameters.Add("DATASYS3", OracleDbType.Varchar2).Value = UserId + ":" + UserNm;
                    cmd.Parameters.Add("DATASYS4", OracleDbType.Varchar2).Value = Utility.MyIpAddress;

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

            //*--Data Status = "수정"  설정-------------------
            DataGridViewRow row = dataGridView1.CurrentRow;
            if ((String)row.Cells["status"].Value == "")
            {
                row.Cells["status"].Value = "U";
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

    }
}
