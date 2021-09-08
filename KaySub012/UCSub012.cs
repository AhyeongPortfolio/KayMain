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

namespace KaySub012
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --Form Name           : 통합조회
    /// --최근작성 정보
    /// 1. 2021-08-31              권아영             신규생성
    /// 2. 2021-09-07              권아영             코드수정
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
            ct_bas_empno.TextChanged += InputData_TextChanged;
            ct_bas_name.TextChanged += InputData_TextChanged;
            ct_bas_cname.TextChanged += InputData_TextChanged;
            ct_bas_ename.TextChanged += InputData_TextChanged;
            ct_bas_resno.TextChanged += InputData_TextChanged;
            ct_bas_fix.TextChanged += InputData_TextChanged;
            ct_bas_zip.TextChanged += InputData_TextChanged;
            ct_bas_mar.TextChanged += InputData_TextChanged;

            ct_bas_addr.TextChanged += InputData_TextChanged;
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
            ct_bas_wsta.TextChanged += InputData_TextChanged;
            ct_bas_sts.TextChanged += InputData_TextChanged;
            ct_bas_pos.TextChanged += InputData_TextChanged;
            ct_bas_dut.TextChanged += InputData_TextChanged;
            ct_bas_dept.TextChanged += InputData_TextChanged;
            ct_bas_rmk.TextChanged += InputData_TextChanged;
            //*----Value Changed Event Handler(END)-----------------------------       
            dataGridView1.CellMouseDoubleClick += DataGridView1_CellMouseDoubleClick;
            dataGridView1.SelectionChanged += DataList_SelectionChanged;
            //dataGridView2.SelectionChanged += DataList_SelectionChanged;
            dataGridView1.ReadOnly = true;
            grd_kay_insa_award.ReadOnly = true;
            grd_kay_insa_car.ReadOnly = true;
            grd_kay_insa_edu.ReadOnly = true;
            grd_kay_insa_fam.ReadOnly = true;
            grd_kay_insa_forl.ReadOnly = true;
            grd_kay_insa_lic.ReadOnly = true;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            last_button_status = Utility.SetFuncBtn(MainBtn, "0");
            Utility.DataGridView_Scrolling_SpeedUp(dataGridView1);

            Utility.DataGridView_Scrolling_SpeedUp(grd_kay_insa_fam);
            Utility.DataGridView_Scrolling_SpeedUp(grd_kay_insa_award);
            Utility.DataGridView_Scrolling_SpeedUp(grd_kay_insa_car);
            Utility.DataGridView_Scrolling_SpeedUp(grd_kay_insa_edu);
            Utility.DataGridView_Scrolling_SpeedUp(grd_kay_insa_forl);
            Utility.DataGridView_Scrolling_SpeedUp(grd_kay_insa_lic);

        }
        #endregion
        #region 기능버튼(조회) Click
        //************************************************************
        //** 조회 버튼 Click
        //************************************************************
        public void BtnSearch_Click()
        {
            Utility.BusyIndicator(true);

            DataTable dt = new DataTable();
            //dataGridView1.Rows.Clear();
            
            //--DB Handling(Start)-------------------------------------
            try
            {
                DataSet ds = new DataSet();
                using (con = Utility.SetOracleConnection())
                {
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandText = SQLStatement.SelectSQL;
                    cmd.BindByName = true;
                    cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = "%" + empnoSearch.Text + "%";
                    cmd.Parameters.Add("bas_name", OracleDbType.Varchar2).Value = "%" + nameSearch.Text + "%";
                    cmd.Parameters.Add("bas_wsta", OracleDbType.Varchar2).Value = "%" + wstaSearch.Text + "%";
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(ds);
                }
                dt = ds.Tables[0];
                
                
                dataGridView1.DataSource = dt;

                var byteArray = Encoding.UTF8.GetBytes(ct_bas_resno.Text); // 복호화 키
                
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["bas_resno"] = Utility.AESDecrypt128(dt.Rows[i]["bas_resno"].ToString(), byteArray.ToString());
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
            if (select_sw) return; //GridView 선택 시 최초값 설정에 따른 이벤트는 무시

            if (dataGridView1.SelectedRows.Count <= 0) return;

            Utility.SetValueToGridView(dataGridView1, sender as Control);
                        
            last_button_status = Utility.SetFuncBtn(MainBtn, "0");
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

           // Input_Validation_Check(sender, e); //*--Control 에 오류메세지 표시

            select_sw = false; //*--Control의 TextChanged 이벤트와의 충돌을 피하기 위해 (Off)
        }

        //************************************************************
        //** DataGridView를 더블클릭 했을 때 각 콘트롤에 Data Setting
        //************************************************************   
        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Utility.BusyIndicator(true);
              grd_kay_insa_fam.Rows?.Clear();
              grd_kay_insa_edu.Rows?.Clear();
              grd_kay_insa_award.Rows?.Clear();
              grd_kay_insa_car.Rows?.Clear();
              grd_kay_insa_lic.Rows?.Clear();
              grd_kay_insa_forl.Rows?.Clear();

            int rowIdx = 0;
            DataGridViewRow row;
            //db--------start
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = SQLStatement.SelectSQL1;
                cmd.BindByName = true;
                cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = ct_bas_empno.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                //query_sw = true; //*---SelectionChanged Event 발생을 회피하기 위해 (On)
                while (dr.Read())
                {
                    if (dr["type"].ToString() == "FAM")
                    {
                        rowIdx = grd_kay_insa_fam.Rows.Add();
                        row = grd_kay_insa_fam.Rows[rowIdx];
                        row.Cells["fam_empno"].Value = dr["col1"].ToString();
                        row.Cells["fam_name"].Value = dr["col2"].ToString();
                        row.Cells["fam_rel"].Value = dr["col3"].ToString();
                        row.Cells["fam_bth"].Value = Utility.FormatDate(dr["col4"].ToString());
                        row.Cells["fam_ltg"].Value = dr["col5"].ToString();
                    }
                    else
                    {
                        if (dr["type"].ToString() == "EDU")
                        {
                            rowIdx = grd_kay_insa_edu.Rows.Add();
                            row = grd_kay_insa_edu.Rows[rowIdx];
                            row.Cells["edu_empno"].Value = dr["col1"].ToString();
                            row.Cells["edu_loe"].Value = dr["col2"].ToString();
                            row.Cells["edu_entdate"].Value = Utility.FormatDate(dr["col3"].ToString());
                            row.Cells["edu_gradate"].Value = Utility.FormatDate(dr["col4"].ToString());
                            row.Cells["edu_schnm"].Value = dr["col5"].ToString();
                            row.Cells["edu_dept"].Value = dr["col6"].ToString();
                            row.Cells["edu_degree"].Value = dr["col7"].ToString();
                            row.Cells["edu_grade"].Value = dr["col8"].ToString();
                            row.Cells["edu_gra"].Value = dr["col9"].ToString();
                            row.Cells["edu_last"].Value = dr["col10"].ToString();
                        }
                        else
                        {
                            if (dr["type"].ToString() == "AWARD")
                            {
                                rowIdx = grd_kay_insa_award.Rows.Add();
                                row = grd_kay_insa_award.Rows[rowIdx];
                                row.Cells["award_empno"].Value = dr["col1"].ToString();
                                row.Cells["award_date"].Value = Utility.FormatDate(dr["col2"].ToString());
                                row.Cells["award_no"].Value = dr["col3"].ToString();
                                row.Cells["award_kind"].Value = dr["col4"].ToString();
                                row.Cells["award_organ"].Value = dr["col5"].ToString();
                                row.Cells["award_content"].Value = dr["col6"].ToString();
                                row.Cells["award_inout"].Value = dr["col7"].ToString();
                                row.Cells["award_pos"].Value = dr["col8"].ToString();
                                row.Cells["award_dept"].Value = dr["col9"].ToString();
                            }
                            else
                            {
                                if (dr["type"].ToString() == "CAR")
                                {
                                    rowIdx = grd_kay_insa_car.Rows.Add();
                                    row = grd_kay_insa_car.Rows[rowIdx];
                                    row.Cells["car_empno"].Value = dr["col1"].ToString();
                                    row.Cells["car_com"].Value = dr["col2"].ToString();
                                    row.Cells["car_region"].Value = dr["col3"].ToString();
                                    row.Cells["car_yyyymm_f"].Value = Utility.FormatDate(dr["col4"].ToString());
                                    row.Cells["car_yyyymm_t"].Value = Utility.FormatDate(dr["col5"].ToString());
                                    row.Cells["car_pos"].Value = dr["col6"].ToString();
                                    row.Cells["car_dept"].Value = dr["col7"].ToString();
                                    row.Cells["car_reason"].Value = dr["col8"].ToString();
                                }
                                else
                                {
                                    if (dr["type"].ToString() == "LIC")
                                    {
                                        rowIdx = grd_kay_insa_lic.Rows.Add();
                                        row = grd_kay_insa_lic.Rows[rowIdx];
                                        row.Cells["lic_empno"].Value = dr["col1"].ToString();
                                        row.Cells["lic_name"].Value = dr["col2"].ToString();
                                        row.Cells["lic_grade"].Value = dr["col3"].ToString();
                                        row.Cells["lic_acqdate"].Value = Utility.FormatDate(dr["col4"].ToString());
                                        row.Cells["lic_organ"].Value = dr["col5"].ToString();
                                    }
                                    else
                                    {
                                        if (dr["type"].ToString() == "FORL")
                                        {
                                            rowIdx = grd_kay_insa_forl.Rows.Add();
                                            row = grd_kay_insa_forl.Rows[rowIdx];
                                            row.Cells["forl_empno"].Value = dr["col1"].ToString();
                                            row.Cells["forl_name"].Value = dr["col2"].ToString();
                                            row.Cells["forl_score"].Value = dr["col3"].ToString();
                                            row.Cells["forl_acqdate"].Value = Utility.FormatDate(dr["col4"].ToString());
                                            row.Cells["forl_organ"].Value = dr["col5"].ToString();
                                        }
                                    }
                                }
                            }
                        }
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
                if (con != null) con.Close();
                Utility.BusyIndicator(false);
            }
                        
            //if (dataGridView1.Rows.Count == 0) return;

            //Utility.BusyIndicator(true);

            //DataGridViewRow selectRow = dataGridView1.CurrentRow;
            //string empno = selectRow.Cells["bas_empno"].Value.ToString();

            //try
            //{
            //    DataSet ds = new DataSet();

            //    using (con = Utility.SetOracleConnection())
            //    {
            //        OracleCommand cmd = con.CreateCommand();
            //        cmd.CommandText = SQLStatement.SelectSQL1;
            //        cmd.Parameters.Add("bas_empno", OracleDbType.Varchar2).Value = empno;
            //        cmd.BindByName = true;

            //        OracleDataAdapter da = new OracleDataAdapter(cmd);
            //        da.ReturnProviderSpecificTypes = true;
            //        da.Fill(ds);
            //    }
            //    //0~5 테이블
            //    DataTable dt = new DataTable();
            //    dt = ds.Tables[0];
            //    if (dt.Rows.Count == 0) return;
            //    int count = dt.Rows.Count;

            //    for(int i = 0; i <= count; i++)
            //    {
            //        if (dt.Rows[i]["type"].ToString().Equals("FAM"))
            //        {
            //            grd_kay_insa_fam.DataSource = dt;
            //        }
            //        if (dt.Rows[i]["type"].ToString().Equals("EDU"))
            //        {
            //            grd_kay_insa_edu.DataSource = dt;
            //        }
            //        if (dt.Rows[i]["type"].ToString().Equals("AWARD"))
            //        {
            //            grd_kay_insa_award.DataSource = dt;
            //        }
            //        if (dt.Rows[i]["type"].ToString().Equals("CAR"))
            //        {
            //            grd_kay_insa_car.DataSource = dt;
            //        }
            //        if (dt.Rows[i]["type"].ToString().Equals("LIC"))
            //        {
            //            grd_kay_insa_lic.DataSource = dt;
            //        }
            //        if (dt.Rows[i]["type"].ToString().Equals("FORL"))
            //        {                      
            //            grd_kay_insa_forl.DataSource = dt;
            //        }
            //    }

            //*---각 SELECT 문 당 하나의 DataTable 생성
            //  grd_kay_insa_fam.DataSource = ds.Tables[0];
            //  grd_kay_insa_edu.DataSource = ds.Tables[1];
          //  grd_kay_insa_award.DataSource = ds.Tables[2];
            //  grd_kay_insa_car.DataSource = ds.Tables[3];
            //  grd_kay_insa_lic.DataSource = ds.Tables[4];
            // grd_kay_insa_forl.DataSource = ds.Tables[5];
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return;
            //}
            //finally
            //{
            //    query_sw = false; //*---SelectionChanged Event 발생을 회피하기 위해 (Off)
            //    Utility.BusyIndicator(false);
            //}
        }
        


        #endregion

    }
}
