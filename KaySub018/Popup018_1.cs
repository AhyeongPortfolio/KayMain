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
        private bool select_sw = false;
        private bool query_sw = false;

        
        
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
        string filterField = null;

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
            if((sender as TextBox).Name == "qt_bas_dut" || (sender as TextBox).Name == "qt_bas_dept_tor")
            {
                tordt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, (sender as TextBox).Text);
            }
            else if((sender as TextBox).Name == "qt_bas_dept_tee")
            {
                teedt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, (sender as TextBox).Text);
            }
        }

        #endregion
    }
}
