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
        
        public Popup018_1()
        {
            InitializeComponent();

            qt_bas_dept.TextChanged += depttxt_TextChanged;
            qt_bas_dept_tor.TextChanged += depttxt_TextChanged;
            qt_bas_dut.TextChanged += depttxt_TextChanged;
        }

        private void Popup018_1_Load(object sender, EventArgs e)
        {
            Filter_DataView();
        }
        #endregion
        #region 참조 그리드 조회 + 필터링
        //*********************************************************
        //---그리드 필터링 추가하여 데이터 출력----------------------
        //*********************************************************
        DataTable tordt = new DataTable();
        DataTable teedt = new DataTable();
       

        private void Filter_DataView()
        {
            Utility.BusyIndicator(true);

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
                }
                Utility.BusyIndicator(false);
            }
            dataGridView2.DataSource = tordt;
            dataGridView1.DataSource = teedt;
        }

        private void depttxt_TextChanged(object sender, EventArgs e)
        {
            if((sender as TextBox).Name == "qt_bas_dut")
            {
                tordt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "dut_name", (sender as TextBox).Text);
            }

            else if ((sender as TextBox).Name == "qt_bas_dept_tor")
            {
                tordt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "dept_name", (sender as TextBox).Text);
            }

            else if((sender as TextBox).Name == "qt_bas_dept")
            {
                teedt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "dept_name", (sender as TextBox).Text);
            }
        }

        #endregion

        #region Submit Button 이벤트_데이터 메인으로 옮김
        //*********************************************************
        //*--확인 버튼 event
        //*********************************************************
        private void Submit_btn_Click(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();
            dataGridView1.EndEdit();

            for(int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                bool isChecked = Convert.ToBoolean(dataGridView2.Rows[i].Cells[0].Value);
                if (isChecked)
                {
                    
                }
            }

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

    }
}
