using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;



namespace KayLibrary
{
    /// <summary>
    /// **********************************************************************
    /// --Project             : 인사관리시스템(ver2)
    /// --최근작성 정보
    /// 1. 2021-09-09              권아영             코드검색(배열로 받아가는거)생성
    /// **********************************************************************
    /// </summary>
    public partial class SearchArrWindow : Form
    {
        private ArrayList result;
        private string sql;
        public string Aa;

        public ArrayList GetResult
        {
            get { return result; }
        }

        public SearchArrWindow()
        {
            InitializeComponent();
        }

        public SearchArrWindow(string sql)
        {
            this.sql = sql;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void SearchCDWindow_Load(object sender, EventArgs e)
        {
            this.ActiveControl = searchText;
            searchText.Focus();

        }

        private void searchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                Query_Code();
            }
        }
        private void Query_Code()
        {
            OracleConnection con = null;
            try
            {
                con = Utility.SetOracleConnection();
                OracleCommand cmd = con.CreateCommand();

                cmd.CommandText = sql;
                cmd.Parameters.Add("condition", OracleDbType.Varchar2).Value = "%" + searchText.Text + "%";

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "TAB");
                dataGridView1.DataSource = ds.Tables["TAB"].DefaultView;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            result = new ArrayList();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                result.Add(dataGridView1.Rows[e.RowIndex].Cells[i]?.Value ?? string.Empty);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
