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

namespace KaySub018
{
    public partial class Popup018_1 : Form
    {
        #region 초기정보
        OracleConnection con = null;
        private List<Evals> evalsList;

        public List<Evals> GetResult
        {
            get { return evalsList; }
        }
        
        public Popup018_1()
        {
            InitializeComponent();

            //*----Validated Event Handler(Start)-------------------------------
            ct_evalm_type.Validated += Input_Validation_Check;
            //*----Validated Event Handler(END)---------------------------------
            //*----TextChanged Event Handler(Start)-----------------------------
            qt_bas_dept.TextChanged += depttxt_TextChanged;
            qt_bas_dept_tor.TextChanged += depttxt_TextChanged;
            qt_bas_dut.TextChanged += depttxt_TextChanged;
            qt_eval_no.TextChanged += depttxt_TextChanged;
            qt_eval_year.TextChanged += depttxt_TextChanged; 
            //*----TextChanged Event Handler(END)-------------------------------

        }
        private void Popup018_1_Load(object sender, EventArgs e)
        {
            Filter_DataView();
            //*--콤보박스 채우기-------------------------------------------------
            Utility.SetComboWithCdnm(ct_evalm_type, SQLStatement.SelectSQL3);
            //*--콤보박스 미리 선택----------------------------------------------
            ct_evalm_type.SelectedIndex = 1;
        }
        #endregion
        #region 참조 그리드 조회 + 필터링
        //*********************************************************
        //---그리드 필터링 추가하여 데이터 출력----------------------
        //*********************************************************
        DataTable tordt = new DataTable();
        DataTable teedt = new DataTable();
        DataTable evaldt = new DataTable();

        private void Filter_DataView()
        {
            Utility.BusyIndicator(true);
            tordt.Rows.Clear();
            teedt.Rows.Clear();
            evaldt.Rows.Clear();

            using (con = Utility.SetOracleConnection())
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = SQLStatement.SelectSQL_tor;
                    cmd.BindByName = true;
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(tordt);

                    cmd.Parameters.Clear();

                    cmd.CommandText = SQLStatement.SelectSQL_tee;
                    cmd.BindByName = true;
                    da = new OracleDataAdapter(cmd);
                    da.Fill(teedt);

                    cmd.Parameters.Clear();

                    cmd.CommandText = SQLStatement.SelectSQL_evalp;
                    cmd.BindByName = true;
                    da = new OracleDataAdapter(cmd);
                    da.Fill(evaldt);
                }
                Utility.BusyIndicator(false);
            }
            dataGridView2.DataSource = tordt;
            dataGridView1.DataSource = teedt;
            dataGridView3.DataSource = evaldt;
        }

        private void depttxt_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Name == "qt_bas_dut")
            {
                tordt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "dut_name", (sender as TextBox).Text);
            }

            else if ((sender as TextBox).Name == "qt_bas_dept_tor")
            {
                tordt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "dept_name", (sender as TextBox).Text);
            }

            else if ((sender as TextBox).Name == "qt_bas_dept")
            {
                teedt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "dept_name", (sender as TextBox).Text);
            }

            else if ((sender as TextBox).Name == "qt_eval_year")
            {
                evaldt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "eval_year", (sender as TextBox).Text);
            }

            else if ((sender as TextBox).Name == "qt_eval_no")
            {
                evaldt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "eval_no", (sender as TextBox).Text);
            }
        }

        #endregion
        #region Submit Button 이벤트_데이터 메인으로 옮김
        //*********************************************************
        //*--확인 버튼 event
        //*********************************************************
        private void Submit_btn_Click(object sender, EventArgs e)
        {
            //*--입력값에 오류가 있는지 여부 확인
            if (!Utility.InputErrorCheck(dataGridView1)) return;

            dataGridView2.EndEdit();
            dataGridView1.EndEdit();

            evalsList = new List<Evals>();
            for (int k = 0; k < dataGridView3.Rows.Count; k++)
            {
                bool isChecked_eval = Convert.ToBoolean(dataGridView3.Rows[k].Cells[0].FormattedValue);
                if (isChecked_eval)
                {
                    DataGridViewRow rowEval = dataGridView3.Rows[k];
                    for(int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        bool isChecked = Convert.ToBoolean(dataGridView2.Rows[i].Cells[0].FormattedValue);
                        if (isChecked)
                        {
                            DataGridViewRow row = dataGridView2.Rows[i];
                            for (int j = 0; j < dataGridView1.Rows.Count; j++)
                            {
                                bool isChecked_tee = Convert.ToBoolean(dataGridView1.Rows[j].Cells[0].FormattedValue);
                                if (isChecked_tee)
                                {
                                    DataGridViewRow row_tee = dataGridView1.Rows[j];
                                    Evals evals = new Evals();
                                    evals.evalm_year = rowEval.Cells["eval_year"].Value.ToString();
                                    evals.evalm_type = ct_evalm_type.Text;
                                    evals.evalm_stage = ct_evalm_stage.Text;
                                    evals.evalm_period = rowEval.Cells["eval_period"].Value.ToString();
                                    evals.evalm_no = rowEval.Cells["eval_no"].Value.ToString();

                                    evals.evalm_tor = row.Cells["bas_empno_tor"].Value.ToString();
                                    evals.evalm_tor_name = row.Cells["bas_name_tor"].Value.ToString();
                                    evals.evalm_dept_tor = row.Cells["dept_name_tor"].Value.ToString();
                                    evals.evalm_dut_tor = row.Cells["dut_name_tor"].Value.ToString();
                                    evals.evalm_pos_tor = row.Cells["pos_name_tor"].Value.ToString();

                                    evals.evalm_tee = row_tee.Cells["bas_empno_tee"].Value.ToString();
                                    evals.evalm_tee_name = row_tee.Cells["bas_name_tee"].Value.ToString();
                                    evals.evalm_pos_tee = row_tee.Cells["pos_name_tee"].Value.ToString();
                                    evals.evalm_dept_tee = row_tee.Cells["dept_name_tee"].Value.ToString();

                                    evalsList.Add(evals);
                                }
                            }
                        }                
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        //*********************************************************
        //*--취소 버튼 event
        //*********************************************************
        private void Cancle_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
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
            if (string.IsNullOrEmpty(ct_evalm_stage.Text))
            {
                SetError(ct_evalm_stage, "평가단계를 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_evalm_stage, errorProvider1);
            }

            //*---------------------------------------------------------------------------------------------------------
            if (string.IsNullOrEmpty(ct_evalm_type.Text))
            {
                SetError(ct_evalm_type, "평가표 유형을 반드시 입력하세요", dataGridView1.SelectedRows[0], errorProvider1);
            }
            else
            {
                ResetError(ct_evalm_type, errorProvider1);
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


    }

    public class Evals
    {
        public string evalm_year { get; set; }
        public string evalm_no { get; set; }
        public string evalm_tee { get; set; }
        public string evalm_tee_name { get; set; }
        public string evalm_stage { get; set; }
        public string evalm_tor { get; set; }
        public string evalm_tor_name { get; set; }
        public string evalm_type { get; set; }
        public string evalm_period { get; set; }
        public string evalm_dept_tee { get; set; }
        public string evalm_pos_tee { get; set; }
        public string evalm_dept_tor { get; set; }
        public string evalm_pos_tor { get; set; }
        public string evalm_dut_tor { get; set; }
    }
}
