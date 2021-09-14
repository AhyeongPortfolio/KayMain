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

namespace KaySub025
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 증명서발급대장 
    /// --최근작성 정보
    /// 1. 2021-08-31              권아영             신규생성
    /// 2. 2021-09-09              권아영             코드수정
    /// **********************************************************************
    /// </summary>
    /// 
    public delegate void DataPushEventHandler(string _value, string _kind, string _date, string _dname, string _rkind);
    public partial class UserControl1: UserControl
    {
        #region 초기설정

        OracleConnection con = null;
        private bool select_sw = false;
        private bool query_sw = false;
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

        public DataPushEventHandler DataSendEvent;

        public UserControl1()
        {
            InitializeComponent();
            //*----Validated Event Handler(Start)-------------------------------
            ct_ceri_empno.Validated += Input_Validation_Check;
            ct_ceri_kind.Validated += Input_Validation_Check;
            ct_ceri_date.Validated += Input_Validation_Check;
            ct_ceri_lang.Validated += Input_Validation_Check;
            //*----Validated Event Handler(END)---------------------------------
            ct_ceri_date.KeyPress += Number_Only_Protect;
            ct_ceri_cnt.KeyPress += Number_Only_Protect;

            dataGridView1.ReadOnly = true;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            last_button_status = Utility.SetFuncBtn(MainBtn, "P");
            Utility.DataGridView_Scrolling_SpeedUp(dataGridView1);
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            //*------날짜 기본 셋팅------------------------------
            ct_ceri_date.Text = DateTime.Now.ToString();
        }
        #endregion
        #region 기능버튼(조회) Click
        //************************************************************
        //** 조회 버튼 Click
        //************************************************************
        public void BtnSearch_Click()
        {
            Utility.BusyIndicator(true);

            //--DB Handling(Start)-------------------------------------
            try
            {
                dataGridView1.Rows.Clear();
                DataGridViewRow row;
                int rowIdx = 0;
                using (con = Utility.SetOracleConnection())
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = SQLStatement.SelectSQL;
                    cmd.BindByName = true;
                    cmd.Parameters.Add("bas_name", OracleDbType.Varchar2).Value = "%" + nameSearch.Text + "%";
                    cmd.Parameters.Add("CERI_EMPNO", OracleDbType.Varchar2).Value = "%" + empnoSearch.Text + "%";
                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        rowIdx = dataGridView1.Rows.Add();
                        row = dataGridView1.Rows[rowIdx];
                        row.Cells["ceri_empno"].Value = dr["ceri_empno"].ToString();
                        row.Cells["ceri_kind"].Value = dr["ceri_kind"].ToString();
                        row.Cells["ceri_date"].Value = dr["ceri_date"].ToString();
                        row.Cells["ceri_lang"].Value = dr["ceri_lang"].ToString();
                        row.Cells["ceri_num"].Value = dr["ceri_num"].ToString();
                        row.Cells["ceri_cnt"].Value = dr["ceri_cnt"].ToString();
                        row.Cells["ceri_sau"].Value = dr["ceri_sau"].ToString();
                        row.Cells["bas_name"].Value = dr["bas_name"].ToString();
                    }
                }               
                query_sw = true; //*---SelectionChanged Event 발생을 회피하기 위해 (On)

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
                this.DataList_SelectionChanged(null, null);   //선택된 첫줄을 Control에 표시하기

                Info_Message.Text = "자료가 정상적으로 조회 되었습니다.";
            }
        }
        #endregion       
        #region 기능버튼(인쇄) Click
        //************************************************************
        //**  인쇄 버튼 Click
        //************************************************************
        public void BtnPrint_Click()
        {
            if (!this.ValidateChildren()) return;

            empno = ct_ceri_empno.Text;
            kind = ct_ceri_kind.Text;
            date = ct_ceri_date.Text;
            lang = ct_ceri_lang.Text;
            cnt = ct_ceri_cnt.Text;    // 발급부수        
            rkind = ct_ceri_sau.Text;
            dname = "011"; // 발급번호

            if (lang.Equals("국문"))
            {
                //--DB에 기록
                if(MessageBox.Show("증명서 발급을 하시겠습니까? 입력하신 정보는 저장됩니다.", "증명서 발급 여부확인", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)== DialogResult.No)
                {
                    return;
                }

                CeriSave();

                var employee = new KaySub022_popup();
                this.DataSendEvent += new DataPushEventHandler(employee.SetActiveValue);
                DataSendEvent(empno, kind, date, dname, rkind);
                employee.ShowDialog();
            }
            if (lang.Equals("영문"))
            {
                //var employee = new KaySub023.KaySub023_popup();

            }
           
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
        #region Input Data Validation Check (Validated Event)
        //************************************************************
        //** Input Data Validation Check (Validated Event)
        //************************************************************
        private void Input_Validation_Check(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;

            dataGridView1.SelectedRows[0].ErrorText = "";
            //*---------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(ct_ceri_empno.Text))
            {
                SetError(ct_ceri_empno, "사원번호를 반드시 입력하세요",  errorProvider1);
            }
            else
            {
                ResetError(ct_ceri_empno, errorProvider1);
            }
            //*---------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(ct_ceri_lang.Text))
            {
                SetError(ct_ceri_lang, "발급언어를 반드시 입력하세요",  errorProvider1);
            }
            else
            {
                ResetError(ct_ceri_lang, errorProvider1);
            }
            //*---------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(ct_ceri_date.Text))
            {
                SetError(ct_ceri_date, "발급날짜를 반드시 입력하세요", errorProvider1);
            }
            else
            {
                ResetError(ct_ceri_date, errorProvider1);
            }
            //*---------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(ct_ceri_kind.Text))
            {
                SetError(ct_ceri_kind, "증명서종류를 반드시 선택하세요", errorProvider1);
            }
            else
            {
                ResetError(ct_ceri_kind, errorProvider1);
            }
        }
        private void SetError(Control ctl, String errMsg, ErrorProvider errProvider)
        {
            errProvider.SetError(ctl, errMsg);
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
        #region 재발급 버튼 Click
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("재발급버튼 클릭");
        }

        #endregion
        #region 증명서 발급 내역 저장
        private void CeriSave()
        {
            //--저장프로시저 호출
            using (con = Utility.SetOracleConnection()) 
            {
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_KAY_UCSUB025_S";
                cmd.Parameters.Add("P_CERI_EMPNO", OracleDbType.Varchar2).Value = ct_ceri_empno.Text ;
                cmd.Parameters.Add("P_CERI_KIND", OracleDbType.Varchar2).Value = ct_ceri_kind.Text;
                cmd.Parameters.Add("P_CERI_DATE", OracleDbType.Varchar2).Value = Utility.FormatDateR(ct_ceri_date.Text);
                cmd.Parameters.Add("P_CERI_LANG", OracleDbType.Varchar2).Value = ct_ceri_lang.Text;
                cmd.Parameters.Add("P_CERI_CNT", OracleDbType.Varchar2).Value = ct_ceri_cnt.Text;
                cmd.Parameters.Add("P_CERI_SAU", OracleDbType.Varchar2).Value = ct_ceri_sau.Text;
                cmd.Parameters.Add("P_DATASYS3", OracleDbType.Varchar2).Value = UserId + ":" + UserNm;
                cmd.Parameters.Add("P_DATASYS4", OracleDbType.Varchar2).Value = Utility.MyIpAddress;

                OracleParameter parm = new OracleParameter("O_CERI_NUM", OracleDbType.Varchar2, 1);
                cmd.Parameters.Add(parm).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                dname = parm.Value.ToString();

                MessageBox.Show(dname);
            }
            
        }
        #endregion
    }
}
