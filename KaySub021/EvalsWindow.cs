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
    public partial class EvalsWindow : Form
    {
        #region 초기설정
        OracleConnection con = null; // default 기본값 private
        //************************************************************
        // 원하는 대로 데이터를 주고 받을 수 있음. property
        public string UserId { get; set; }               // 사용자 ID
        public string UserNm { get; set; }               // 사용자 이름
        public string Master { get; set; }               // 사용자 권한

        public string Type { get; set; }                 //평가표 유형
        public string Year { get; set; }                 //평가년도
        public string No { get; set; }                   //평가차수
        public string Stage { get; set; }                //평가단계
        public string Tee { get; set; }                  //피평가자
        public string status { get; set; }               //상태
        public EvalsWindow()
        {
            InitializeComponent();

            Utility.SetReadOnly(tableLayoutPanel1, true);
            Utility.SetReadOnly(tableLayoutPanel2, true);
            SubmitBtn.Enabled = true;
        }

        private void EvalsWindow_Load(object sender, EventArgs e)
        {
            Utility.BusyIndicator(true);
            //--DB Handling(Start)-----------------------------------
            try
            {
                using (con = Utility.SetOracleConnection())
                {
                    using(OracleCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = SQLStatement.SelectSQL_type;
                        cmd.BindByName = true;
                        cmd.Parameters.Add("evals_year", OracleDbType.Varchar2).Value = Year;
                        cmd.Parameters.Add("evals_no", OracleDbType.Varchar2).Value = No;
                        cmd.Parameters.Add("evals_tee", OracleDbType.Varchar2).Value = Tee;
                        cmd.Parameters.Add("evals_stage", OracleDbType.Varchar2).Value = Stage;
                        cmd.Parameters.Add("evali_type", OracleDbType.Varchar2).Value = Type;
                        OracleDataReader dr = cmd.ExecuteReader();
                        if (!dr.Read()) return;

                        //*--변수 선언-----------------------------------------
                        Label item_l = null, item_s = null;
                        string item_lStr = "";
                        int total = 0, result = 0, rowcnt = 0, rowidx = 0, i;

                        //*--평가표 만들기--------------------------------------
                        do
                        {
                            if(item_lStr != dr["evali_item_l"].ToString())
                            {
                                rowcnt = 1;
                                item_lStr = dr["evali_item_l"].ToString();
                                item_l = new Label() //대항목
                                {
                                    Text = dr["evali_item_l"].ToString(),
                                    Dock = DockStyle.Fill,
                                    TextAlign = ContentAlignment.MiddleCenter
                                };
                                tableLayoutPanel2.Controls.Add(item_l, 0, rowidx);
                            }
                            tableLayoutPanel2.SetRowSpan(item_l, rowcnt++); //대항목끼리 묶음
                            item_s = new Label //소항목
                            {
                                Text = dr["evali_item_s"].ToString(),
                                Dock = DockStyle.Fill,
                                TextAlign = ContentAlignment.MiddleLeft
                            };
                            tableLayoutPanel2.Controls.Add(item_s, 1, rowidx);

                            if(rowidx == 0)
                            {
                                item_s = new Label()
                                {
                                    Text = "대상 기간",
                                    Dock = DockStyle.Fill,
                                    TextAlign = ContentAlignment.MiddleCenter
                                };
                                tableLayoutPanel2.Controls.Add(item_s, 2, rowidx);
                            }
                            else
                            {
                                item_s = new Label()
                                {
                                    Text = "“",
                                    Dock = DockStyle.Fill,
                                    TextAlign = ContentAlignment.MiddleCenter
                                };
                                tableLayoutPanel2.Controls.Add(item_s, 2, rowidx);
                            }
                            item_s = new Label()
                            {
                                Text = dr["evali_points"].ToString(),
                                Dock = DockStyle.Fill,
                                TextAlign = ContentAlignment.MiddleCenter
                            };
                            tableLayoutPanel2.Controls.Add(item_s, 3, rowidx);

                            //--배점 계산하여 출력-------------------------------
                            int points = Convert.ToInt32(dr["evali_points"].ToString());
                            int gap = Convert.ToInt32(dr["evali_gap"].ToString());
                            char ch = 'A';
                            total += points;

                            for (i = 0; i < 5; i++)
                            {
                                item_s = new Label()
                                {
                                    Text = (points - gap * i).ToString(),
                                    Dock = DockStyle.Fill,
                                    Name = dr["evali_itemno"].ToString() + "_" + Convert.ToChar(ch + i),
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Cursor = Cursors.Hand
                                };
                               // item_s.Click += Score_Click;
                                tableLayoutPanel2.Controls.Add(item_s, 4 + i, rowidx);
                            }

                            TextBox tb = new TextBox()
                            {
                                Text = dr["evals_score"].ToString(),
                                Tag = dr["evals_grade"].ToString(),
                                Name = dr["evali_itemno"].ToString(),
                                Dock = DockStyle.Fill,
                                Anchor = AnchorStyles.None,
                                MaxLength = 2,
                                ReadOnly = true,
                                BackColor = Color.White,
                                BorderStyle = BorderStyle.None,
                                TextAlign = HorizontalAlignment.Center
                            };
                            tableLayoutPanel2.Controls.Add(tb, 4 + i, rowidx);

                            tableLayoutPanel2.RowCount++;
                            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
                            tableLayoutPanel1.Height += 61;
                            rowidx++;
                        }
                        while (dr.Read());
                        tableLayoutPanel2.RowCount--;
                        tableLayoutPanel2.RowStyles.RemoveAt(rowidx);
                        tableLayoutPanel1.Height -= 50;
                        evalm_total.Text = total.ToString();
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
        #region 기능버튼(점수) Click
        private void Score_Click(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            string[] lb_name = lb.Name.Split('_');
            Control[] ctl = tableLayoutPanel2.Controls.Find(lb_name[0], true);
            if (ctl.Length == 0) return;

            TextBox txt = ctl[0] as TextBox;
            txt.Tag = lb_name[1];
            txt.Text = lb.Text;
            sum_total();
        }

        #endregion
        #region 점수 총점 계산
        public void sum_total()
        {
            int result = 0;

            foreach (Control ctl in tableLayoutPanel2.Controls)
            {
                if (!(ctl is TextBox)) continue;
                if ((ctl as TextBox).Text == "") continue;
                result += Convert.ToInt32((ctl as TextBox).Text);
            }
            evalm_sum.Text = result.ToString();
        }
        #endregion

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
