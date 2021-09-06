﻿using System;
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

namespace KaySub007
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 학력사항 관리
    /// --최근작성 정보
    /// 1. 2021-08-31              권아영             신규생성
    /// 2. 2021-09-06              권아영             코드작성
    /// **********************************************************************
    /// </summary>
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
            ct_edu_empno.TextChanged += InputData_TextChanged;
            ct_edu_loe.TextChanged += InputData_TextChanged;
            ct_edu_entdate.TextChanged += InputData_TextChanged;
            ct_edu_gradate.TextChanged += InputData_TextChanged;
            ct_edu_schnm.TextChanged += InputData_TextChanged;
            ct_edu_dept.TextChanged += InputData_TextChanged;
            ct_edu_degree.TextChanged += InputData_TextChanged;
            ct_edu_grade.TextChanged += InputData_TextChanged;
            ct_edu_gra.TextChanged += InputData_TextChanged;
            //ct_edu_last.TextChanged += InputData_TextChanged; //최종여부 : 졸업:Y, 재학:N
            //*----Value Changed Event Handler(END)-----------------------------
            //*----Validated Event Handler(Start)-------------------------------
            ct_edu_loe.Validated += Input_Validation_Check;
            ct_edu_empno.Validated += Input_Validation_Check;
            ct_edu_entdate.Validated += Input_Validation_Check;
            //*----Validated Event Handler(END)---------------------------------
            //*----Enter Number Only(Start)-------------------------------------
            ct_edu_entdate.KeyPress += Number_Only_Protect;
            ct_edu_gradate.KeyPress += Number_Only_Protect;            
            //*----Enter Number Only(END)---------------------------------------           
            dataGridView1.CellMouseDoubleClick += DataGridView1_CellMouseDoubleClick;
            dataGridView2.SelectionChanged += DataList_SelectionChanged;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //*----ComboBox 채우기---------------------------------------------
            //*--콤보박스 채우기-----------------------------------------
            //Utility.SetComboWithCdnm(ct_edu_rel, SQLStatement.SelectSQL2);

            last_button_status = Utility.SetFuncBtn(MainBtn, "1");
            Utility.DataGridView_Scrolling_SpeedUp(dataGridView1);
            Utility.DataGridView_Scrolling_SpeedUp(dataGridView2);
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
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = "%" + empnoSearch.Text + "%";
                cmd.Parameters.Add("bas_name", OracleDbType.Varchar2).Value = "%" + nameSearch.Text + "%";
                OracleDataReader dr = cmd.ExecuteReader();
                query_sw = true; //*---SelectionChanged Event 발생을 회피하기 위해 (On)
                while (dr.Read())
                {
                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    row.Cells["bas_empno"].Value = dr["bas_empno"].ToString();
                    row.Cells["bas_name"].Value = dr["bas_name"].ToString();
                    row.Cells["pos"].Value = dr["pos"].ToString();
                    row.Cells["dept"].Value = dr["dept"].ToString();
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
            var rowIdx = dataGridView2.CurrentRow == null ? 0 : dataGridView2.CurrentRow.Index;

            if (dataGridView2.Rows.Count == 0)
            {
                rowIdx = dataGridView2.Rows.Add();
            }
            else
            {
                rowIdx++;
                dataGridView2.Rows.Insert(rowIdx);
            }
            dataGridView2.Rows[rowIdx].Cells["status"].Value = "A";
            DataGridViewRow selectRow = dataGridView1.CurrentRow;
            ct_edu_empno.Text = selectRow.Cells["bas_empno"].Value.ToString();                 

            //---추가된 Row로 Focus 이동-------------------------------- 
            Utility.SetFocusingDataGridView(dataGridView2, rowIdx);
            ct_edu_schnm.Focus();

            last_button_status = Utility.SetFuncBtn(MainBtn, "3");
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
            if (dataGridView2.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 자료를 먼저 선택하세요.", "삭제확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataGridViewRow row = dataGridView2.CurrentRow;
            //신규 입력중인 자료는 단순하게 Grid에서 제거만 한다.
            if ((String)row.Cells["status"].Value == "A")
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                return;
            }
            DialogResult result = MessageBox.Show(row.Cells["edu_name"].Value +
                                                  " 자료를 삭제하시겠습니까.", "삭제확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.BindByName = true;
                cmd.CommandText = SQLStatement.DeleteSQL;
                cmd.Parameters.Add("Key1", OracleDbType.Varchar2).Value = row.Cells["Key1"].Value;
                cmd.Parameters.Add("Key2", OracleDbType.Varchar2).Value = row.Cells["Key2"].Value;
                cmd.Parameters.Add("Key3", OracleDbType.Varchar2).Value = row.Cells["Key3"].Value;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    dataGridView2.Rows.RemoveAt(row.Index);
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
            if (!Utility.InputErrorCheck(dataGridView2)) return;

            OracleTransaction tran = null;
            try
            {
                con = Utility.SetOracleConnection();
                tran = con.BeginTransaction(IsolationLevel.ReadCommitted);
                OracleCommand cmd = con.CreateCommand();
                cmd.BindByName = true;
                cmd.Transaction = tran;
                foreach (DataGridViewRow row in dataGridView2.Rows)
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
                        cmd.Parameters.Add("key2", OracleDbType.Varchar2).Value = row.Cells["key2"].Value;
                        cmd.Parameters.Add("key3", OracleDbType.Varchar2).Value = row.Cells["key3"].Value;
                    }

                    cmd.Parameters.Add("EDU_EMPNO", OracleDbType.Varchar2).Value = row.Cells["edu_empno"].Value;
                    cmd.Parameters.Add("EDU_LOE", OracleDbType.Varchar2).Value = row.Cells["edu_loe"].Value;
                    cmd.Parameters.Add("EDU_ENTDATE", OracleDbType.Varchar2).Value = Utility.FormatDateR(row.Cells["edu_entdate"].Value.ToString());
                    cmd.Parameters.Add("EDU_GRADATE", OracleDbType.Varchar2).Value = Utility.FormatDateR(row.Cells["edu_gradate"].Value.ToString());
                    cmd.Parameters.Add("EDU_SCHNM", OracleDbType.Varchar2).Value = row.Cells["edu_schnm"].Value;
                    cmd.Parameters.Add("EDU_DEPT", OracleDbType.Varchar2).Value =  row.Cells["edu_dept"].Value;
                    cmd.Parameters.Add("EDU_DEGREE", OracleDbType.Varchar2).Value = row.Cells["edu_degree"].Value;
                    cmd.Parameters.Add("EDU_GRADE", OracleDbType.Varchar2).Value = row.Cells["edu_grade"].Value;
                    cmd.Parameters.Add("EDU_GRA", OracleDbType.Varchar2).Value = row.Cells["edu_gra"].Value;

                    if (row.Cells["edu_gra"].Value.Equals("졸업"))
                        cmd.Parameters.Add("EDU_LAST", OracleDbType.Varchar2).Value = "Y";
                    else
                        cmd.Parameters.Add("EDU_LAST", OracleDbType.Varchar2).Value = "N";

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
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["status"].Value.Equals("")) continue;
                row.Cells["key1"].Value = row.Cells["edu_empno"].Value;
                row.Cells["key2"].Value = row.Cells["edu_loe"].Value;
                row.Cells["key3"].Value = Utility.FormatDateR(row.Cells["edu_entdate"].Value.ToString());
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

            if (dataGridView2.SelectedRows.Count <= 0) return;

            Utility.SetValueToGridView(dataGridView2, sender as Control);

            //*--Data Status = "수정"  설정-------------------
            DataGridViewRow row = dataGridView2.CurrentRow;
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
            if (dataGridView2.Rows.Count == 0) return;

            select_sw = true; //*--Control의 TextChanged 이벤트와의 충돌을 피하기 위해 (On)

            Utility.SetValueToControlFromGridView(dataGridView2, panData);

            Input_Validation_Check(sender, e); //*--Control 에 오류메세지 표시

            select_sw = false; //*--Control의 TextChanged 이벤트와의 충돌을 피하기 위해 (Off)
        }

        //************************************************************
        //** DataGridView를 더블클릭 했을 때 각 콘트롤에 Data Setting
        //************************************************************   
        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;

            Utility.BusyIndicator(true);
            dataGridView2.Rows.Clear();
            int rowIdx = 0;
            DataGridViewRow row;
            DataGridViewRow selectRow = dataGridView1.CurrentRow;
            //--DB Handling(Start)-------------------------------------
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL1;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = selectRow.Cells["bas_empno"].Value; //수정                 
                OracleDataReader dr = cmd.ExecuteReader();
                query_sw = true; //*---SelectionChanged Event 발생을 회피하기 위해 (On)
                while (dr.Read())
                {
                    rowIdx = dataGridView2.Rows.Add();
                    row = dataGridView2.Rows[rowIdx];
                    row.Cells["edu_empno"].Value = dr["edu_empno"].ToString();
                    row.Cells["edu_loe"].Value = dr["EDU_LOE"].ToString();
                    row.Cells["edu_entdate"].Value = Utility.FormatDate(dr["edu_entdate"].ToString());
                    row.Cells["edu_gradate"].Value = Utility.FormatDate(dr["edu_gradate"].ToString());
                    row.Cells["edu_schnm"].Value = dr["edu_schnm"].ToString();
                    row.Cells["edu_dept"].Value = dr["edu_dept"].ToString();
                    row.Cells["edu_degree"].Value = dr["edu_degree"].ToString();
                    row.Cells["edu_grade"].Value = dr["edu_grade"].ToString();
                    row.Cells["edu_degree"].Value = dr["edu_degree"].ToString();
                    row.Cells["edu_gra"].Value = dr["edu_gra"].ToString();
                    row.Cells["edu_last"].Value = dr["edu_last"].ToString();

                    row.Cells["Key1"].Value = dr["edu_empno"].ToString();
                    row.Cells["Key2"].Value = dr["edu_loe"].ToString();
                    row.Cells["Key3"].Value = dr["edu_entdate"].ToString();
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
            var recCnt = dataGridView2.RowCount;
            Info_Count.Text = recCnt.ToString();
            if (recCnt == 0)
            {
                Info_Message.Text = "조건을 만족하는 자료가 없습니다.";
                last_button_status = Utility.SetFuncBtn(MainBtn, "1");
            }
            else
            {
                Utility.SetFocusingDataGridView(dataGridView2, 0); //Focus를 맨 첫줄로 보내기
                this.DataList_SelectionChanged(null, null);   //선택된 첫줄을 Control에 표시하기

                last_button_status = Utility.SetFuncBtn(MainBtn, "2");
                Info_Message.Text = "자료가 정상적으로 조회 되었습니다.";
            }
        }

        #endregion
        #region Input Data Validation Check (Validated Event)
        //************************************************************
        //** Input Data Validation Check (Validated Event)
        //************************************************************
        private void Input_Validation_Check(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count <= 0) return;

            dataGridView2.SelectedRows[0].ErrorText = "";
            //*---------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(ct_edu_empno.Text))
            {
                SetError(ct_edu_empno, "입력하실 사원을 선택해주세요", dataGridView2.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_edu_empno, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(ct_edu_loe.Text))
            {
                SetError(ct_edu_loe, "졸업구분을 반드시 입력하세요", dataGridView2.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_edu_loe, errorProvider1);
            }
            //*---------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(ct_edu_entdate.Text))
            {
                SetError(ct_edu_entdate, "입학일자를 반드시 입력하세요", dataGridView2.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_edu_entdate, errorProvider1);
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
    }
}
