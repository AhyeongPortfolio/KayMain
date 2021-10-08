using KayLibrary;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KaySub004
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 인사정보관리
    /// --최근작성 정보
    /// 1. 2021-09-02              권아영             신규생성
    /// 2. 2021-09-03                                 CRUD 생성
    /// 3. 2021-09-03                                 이미지 저장, 로그인정보
    /// **********************************************************************
    /// </summary>
    public partial class UserControl1 : UserControl
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
            ct_bas_cname.TextChanged += InputData_TextChanged;
            ct_bas_ename.TextChanged += InputData_TextChanged;
            ct_bas_resno.TextChanged += InputData_TextChanged;
            ct_bas_fix.SelectedValueChanged += InputData_TextChanged;
            ct_bas_zip.TextChanged += InputData_TextChanged;
            ct_bas_mar.SelectedValueChanged += InputData_TextChanged;

            ct_bas_addr.TextChanged += InputData_TextChanged;
            ct_bas_anaddr.TextChanged += InputData_TextChanged;
            ct_bas_hdpno.TextChanged += InputData_TextChanged;
            ct_bas_telno.TextChanged += InputData_TextChanged;
            ct_bas_email.TextChanged += InputData_TextChanged;

            ct_bas_mil_sta.TextChanged += InputData_TextChanged;
            ct_bas_mil_mil.TextChanged += InputData_TextChanged;
            ct_bas_mil_rnk.TextChanged += InputData_TextChanged;
            ct_bas_mar.TextChanged += InputData_TextChanged;
            ct_bas_acc_bank.TextChanged += InputData_TextChanged;
            ct_bas_acc_name.TextChanged += InputData_TextChanged;
            ct_bas_acc_no.TextChanged += InputData_TextChanged;
            ct_bas_cont.TextChanged += InputData_TextChanged;
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
            ct_pos.TextChanged += InputData_TextChanged;
            ct_dut.TextChanged += InputData_TextChanged;
            ct_dept.TextChanged += InputData_TextChanged;
            ct_bas_rmk.TextChanged += InputData_TextChanged;

            ct_bas_eaddr.TextChanged += InputData_TextChanged;
            //*----Value Changed Event Handler(END)-----------------------------
            //*----Validated Event Handler(Start)-------------------------------
            ct_bas_name.Validated += Input_Validation_Check;
            ct_bas_resno.Validated += Input_Validation_Check;
            //*----Validated Event Handler(END)---------------------------------
            //*----Enter Number Only(Start)-------------------------------------
            ct_bas_resno.KeyPress += Number_Only_Protect;
            ct_bas_hdpno.KeyPress += Number_Only_Protect;
            ct_bas_telno.KeyPress += Number_Only_Protect;
            ct_bas_acc_no.KeyPress += Number_Only_Protect;
            //*----Enter Number Only(END)---------------------------------------

            dataGridView1.SelectionChanged += DataList_SelectionChanged;
            dataGridView1.CellMouseDoubleClick += DataList_CellMouseDoubleClick;
        }  
        private void UserControl1_Load(object sender, EventArgs e)
        {
            //*--콤보박스 채우기-----------------------------------------
            Utility.SetComboWithCdnm(ct_bas_mil_mil, SQLStatement.SelectSQL3);
            Utility.SetComboWithCdnm(ct_bas_mil_rnk, SQLStatement.SelectSQL4);
            Utility.SetComboWithCdnm(ct_bas_acc_bank, SQLStatement.SelectSQL5);

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
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = "%" + search_empno.Text + "%";
                cmd.Parameters.Add("bas_name", OracleDbType.Varchar2).Value = "%" + search_name.Text + "%";
                OracleDataReader dr = cmd.ExecuteReader();

                var byteArray = Encoding.UTF8.GetBytes(ct_bas_resno.Text); // 복호화 키

                query_sw = true; //*---SelectionChanged Event 발생을 회피하기 위해 (On)
                while (dr.Read())
                {
                    rowIdx = dataGridView1.Rows.Add();
                    row = dataGridView1.Rows[rowIdx];
                    row.Cells["BAS_EMPNO"].Value = dr["bas_empno"].ToString();
                    row.Cells["BAS_RESNO"].Value = Utility.AESDecrypt128(dr["bas_resno"].ToString(), byteArray.ToString());
                    row.Cells["BAS_NAME"].Value = dr["bas_name"].ToString();
                    row.Cells["BAS_CNAME"].Value = dr["bas_cname"].ToString();
                    row.Cells["BAS_ENAME"].Value = dr["bas_ename"].ToString();
                    row.Cells["BAS_FIX"].Value = dr["bas_fix"].ToString();
                    row.Cells["BAS_ZIP"].Value = dr["bas_zip"].ToString();
                    row.Cells["BAS_ADDR"].Value = dr["bas_addr"].ToString();
                    row.Cells["BAS_HDPNO"].Value = dr["bas_hdpno"].ToString();
                    row.Cells["BAS_TELNO"].Value = dr["bas_telno"].ToString();
                    row.Cells["BAS_EMAIL"].Value = dr["bas_email"].ToString();
                    row.Cells["BAS_MIL_STA"].Value = dr["bas_mil_sta"].ToString();
                    row.Cells["BAS_MIL_MIL"].Value = dr["bas_mil_mil"].ToString();
                    row.Cells["BAS_MIL_RNK"].Value = dr["bas_mil_rnk"].ToString();
                    row.Cells["BAS_MAR"].Value = dr["bas_mar"].ToString();
                    row.Cells["BAS_ACC_BANK"].Value = dr["bas_acc_bank"].ToString();
                    row.Cells["BAS_ACC_NAME"].Value = dr["bas_acc_name"].ToString();
                    row.Cells["BAS_ACC_NO"].Value = dr["bas_acc_no"].ToString();
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
                    row.Cells["STS"].Value = dr["sts"].ToString();
                    row.Cells["POS"].Value = dr["pos"].ToString();
                    row.Cells["DUT"].Value = dr["dut"].ToString();
                    row.Cells["DEPT"].Value = dr["dept"].ToString();
                    //*----------------------------------------------------------------------------------------
                    row.Cells["BAS_RMK"].Value = dr["bas_rmk"].ToString();
                    row.Cells["BAS_ANADDR"].Value = dr["bas_anaddr"].ToString();
                    row.Cells["Key1"].Value = dr["bas_empno"].ToString();
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

                last_button_status = Utility.SetFuncBtn(MainBtn, "1");
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
            ct_bas_name.Focus();

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
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.BindByName = true;
                cmd.CommandText = "SP_KAY_UCSUB004_S";
                var byteArray = Encoding.UTF8.GetBytes(ct_bas_resno.Text); // 복호화 키
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["status"].Value.Equals("")) continue;

                    if (row.Cells["status"].Value.Equals("A"))
                    {
                        cmd.Parameters.Add("p_work_type", OracleDbType.Varchar2).Value = "A";
                        cmd.Parameters.Add("P_BAS_EMPNO", OracleDbType.Varchar2).Value = "";
                    }
                    if (row.Cells["status"].Value.Equals("U"))
                    {
                        cmd.Parameters.Add("p_work_type", OracleDbType.Varchar2).Value = "B";
                        cmd.Parameters.Add("p_key1", OracleDbType.Varchar2).Value = row.Cells["key1"].Value;
                        cmd.Parameters.Add("P_BAS_EMPNO", OracleDbType.Varchar2).Value = row.Cells["bas_empno"].Value;
                    }
                    cmd.Parameters.Add("P_BAS_RESNO", OracleDbType.Varchar2).Value = Utility.AESEncrypt128(row.Cells["bas_resno"].Value.ToString(), byteArray.ToString());
                    cmd.Parameters.Add("P_BAS_NAME", OracleDbType.Varchar2).Value = row.Cells["bas_name"].Value;
                    cmd.Parameters.Add("P_BAS_CNAME", OracleDbType.Varchar2).Value = row.Cells["bas_cname"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_ENAME", OracleDbType.Varchar2).Value = row.Cells["bas_ename"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_FIX", OracleDbType.Varchar2).Value = row.Cells["bas_fix"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_ZIP", OracleDbType.Varchar2).Value = row.Cells["bas_zip"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_ADDR", OracleDbType.Varchar2).Value = row.Cells["bas_addr"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_ANADDR", OracleDbType.Varchar2).Value = row.Cells["bas_anaddr"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_HDPNO", OracleDbType.Varchar2).Value = row.Cells["bas_hdpno"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_TELNO", OracleDbType.Varchar2).Value = row.Cells["bas_telno"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_EMAIL", OracleDbType.Varchar2).Value = row.Cells["bas_email"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_MIL_STA", OracleDbType.Varchar2).Value = row.Cells["bas_mil_sta"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_MIL_MIL", OracleDbType.Varchar2).Value = row.Cells["bas_mil_mil"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_MIL_RNK", OracleDbType.Varchar2).Value = row.Cells["bas_mil_rnk"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_MAR", OracleDbType.Varchar2).Value = row.Cells["bas_mar"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_ACC_BANK", OracleDbType.Varchar2).Value = row.Cells["bas_acc_bank"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_ACC_NAME", OracleDbType.Varchar2).Value = row.Cells["bas_acc_name"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_ACC_NO", OracleDbType.Varchar2).Value = row.Cells["bas_acc_no"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_CONT", OracleDbType.Varchar2).Value = row.Cells["bas_cont"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_BAS_RMK", OracleDbType.Varchar2).Value = row.Cells["bas_rmk"]?.Value ?? string.Empty;
                    cmd.Parameters.Add("P_DATASYS3", OracleDbType.Varchar2).Value = UserId + ":" + UserNm;
                    cmd.Parameters.Add("P_DATASYS4", OracleDbType.Varchar2).Value = Utility.MyIpAddress;
                    cmd.Parameters.Add("P_BAS_EADDR", OracleDbType.Varchar2).Value = row.Cells["bas_eaddr"]?.Value ?? string.Empty;

                    cmd.Parameters.Add("O_BAS_NO", OracleDbType.Varchar2, 9).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    if(row.Cells["status"].Value.ToString() == "A") 
                        row.Cells["bas_empno"].Value = cmd.Parameters["O_BAS_NO"].Value.ToString();
                }
                    cmd.Parameters.Clear();  //*----반드시 포함
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
            //**정상 저장 후 초기화*******************************************************
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["status"].Value.Equals("")) continue;
                row.Cells["key1"].Value = row.Cells["bas_empno"].Value;
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
        private void DataList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row;
            row = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            string empno = row.Cells["BAS_EMPNO"].Value.ToString();
            Image_Find(empno);
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
            if (!Utility.IsValid_ResNo(ct_bas_resno.Text))
            {
                SetError(ct_bas_resno, "주민번호를 잘 못 입력하셨습니다", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_resno, errorProvider1);
            }
            //*---------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(ct_bas_name.Text))
            {
                SetError(ct_bas_name, "이름을 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_bas_name, errorProvider1);
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

        #region 우편번호 검색
        //***********************************************************
        //*-----우편번호 검색
        //***********************************************************
        private void button1_Click(object sender, EventArgs e)
        {
            UCSub004_addr_popup addr_Popup = new UCSub004_addr_popup(this);
            addr_Popup.Show(this);
        }

        #endregion

        #region 이미지 Event Handler
        //*********************************************************
        //*--이미지 파일 선택 Directory Open
        //*********************************************************
        Image img2;
        byte[] b1;
        int image_check = 0;
        private void loadPic_Click(object sender, EventArgs e)
        {
            String image_file2 = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"c:\";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!Regex.IsMatch(dialog.FileName, @".jpg|.png|.bmp|.JPG|.PNG|.BMP|.JPEG|.jpeg$"))
                {
                    MessageBox.Show("이미지 파일로 선택 해 주세요");
                    return;
                }

                image_file2 = dialog.FileName;
                img2 = Bitmap.FromFile(image_file2);

                ImageConverter converter = new ImageConverter();

                b1 = (byte[])converter.ConvertTo(img2, typeof(byte[])); //실제 사용 할 이미지
                if (b1.Length >= Math.Pow(2, 11) * 20)
                {
                    MessageBox.Show("사진크기가 큽니다. 50kb이하의 이미지로 선택해주세요.");
                    return;
                }
                pictureBox1.Image = Bitmap.FromFile(image_file2);
            }
        }
        //***************************************************************
        //*---이미지 저장
        //***************************************************************
        private void savePic_Click(object sender, EventArgs e)
        {
            //uimg_empno : 사원번호
            //uimg_img : 이미지 blob

            // 만약 사진이 없는 경우
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("이미지가 없습니다");
                return;
            }

            // 원래 이미지가 있었을 때 = Update
            // 원래 이미지가 없었을 때 = Insert
            OracleTransaction tran = null;
            try
            {
                con = Utility.SetOracleConnection();
                tran = con.BeginTransaction(IsolationLevel.ReadCommitted);
                OracleCommand cmd = con.CreateCommand();
                cmd.BindByName = true;
                cmd.Transaction = tran;
                if (image_check == 0)
                {
                    if (!string.IsNullOrEmpty(ct_bas_empno.Text))
                    {
                        cmd.CommandText = SQLStatement.ImageSQL;
                        cmd.Parameters.Add("empno", OracleDbType.Varchar2).Value = ct_bas_empno.Text;
                    }                   
                }
                else if (image_check == 1)
                {
                    cmd.CommandText = SQLStatement.ImageSQL2;
                    cmd.Parameters.Add("empno", OracleDbType.Varchar2).Value = ct_bas_empno.Text;
                }
                cmd.Parameters.Add("img", OracleDbType.Blob, b1.Length, b1, ParameterDirection.Input);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();  //*----반드시 포함

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
        }

        private void Image_Find(string empno)
        {
            pictureBox1.Image = null;
            image_check = 0;
            try
            {
                using(con = Utility.SetOracleConnection())
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.BindByName = true;
                    cmd.CommandText = SQLStatement.SelectSQLImg;
                    cmd.Parameters.Add("empno", OracleDbType.Varchar2).Value = empno;
                    OracleDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        byte[] byteBLOBData = new byte[0];
                        byteBLOBData = (byte[])dr["uimg_img"];
                        MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                        pictureBox1.Image = Image.FromStream(stmBLOBData);
                        image_check = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        #endregion

    }
}
