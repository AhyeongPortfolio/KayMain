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

            // dataGridView1.CellDoubleClick += List_CellDoubleClick;
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {
            last_button_status = Utility.SetFuncBtn(MainBtn, "0");
            Utility.DataGridView_Scrolling_SpeedUp(dataGridView1);
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
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
    }
}
