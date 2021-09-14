﻿using KayLibrary;
using LiveCharts;
using LiveCharts.Wpf;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace KaySub027
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
            dataGridView1.ReadOnly = true;

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //*---부서 검색 콤보박스 채우기----------------------------------------
            Utility.SetComboWithCdnm(searchDept, SQLStatement.SelectSQL1);
            //*---날짜 초기화----------------------------------------------------
            DateTime today = DateTime.Now.Date;
            dateSearch1.Value = System.DateTime.Now;

            last_button_status = Utility.SetFuncBtn(MainBtn, "0");
            Utility.DataGridView_Scrolling_SpeedUp(dataGridView1);
        }
        #endregion
        #region 기능버튼(조회) Click
        //************************************************************
        //** 조회 버튼 Click
        //************************************************************
        public void BtnSearch_Click()
        {
            Utility.BusyIndicator(true);

            Dictionary<string, double> slice = new Dictionary<string, double>();

            //--DB Handling(Start)-------------------------------------
            try
            {
                DataSet ds = new DataSet();
                using (con = Utility.SetOracleConnection())
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = SQLStatement.SelectSQL;
                    cmd.BindByName = true;
                    cmd.Parameters.Add("dept_nm", OracleDbType.Varchar2).Value = "%" + searchDept.Text + "%";
                    cmd.Parameters.Add("papp_date", OracleDbType.Varchar2).Value = Utility.FormatDateR(dateSearch1.Text);
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(ds);
                }
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        slice.Add(row.Cells["papp_dept_nm"].Value.ToString(), double.Parse(row.Cells["papp_empno"].Value.ToString()));
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
                this.DataList_SelectionChanged(null, null);   //선택된 첫줄을 Control에 표시하기

                // Chart
                pieChart1.Series.Clear();
                PieSeries series = new PieSeries();

                foreach (var n in slice)
                {
                    pieChart1.Series.Add(new PieSeries
                    {
                        Title = n.Key,
                        Values = new ChartValues<double> { n.Value }
                    });
                }


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
       
    }
}
