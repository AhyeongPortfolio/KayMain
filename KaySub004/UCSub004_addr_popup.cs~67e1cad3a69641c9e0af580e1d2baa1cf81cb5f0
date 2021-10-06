using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Windows.Input;
using System.Net;
using System.Xml;

namespace KaySub004
{
    public partial class UCSub004_addr_popup : Form
    {
        UserControl1 userControl1;

        private string confmKey = " "; //api key ( 사용기간 : 2021-09-03 ~ 2021-12-02 )
        private int currentPage = 1; //보여줄 페이지 번호
        private int countPerPage = 80; //보여줄 데이터 개수
        private string keyword = string.Empty; //확인용
        private string apiurl = string.Empty; //apiurl 입력 변수

        public UCSub004_addr_popup(UserControl1 _userControl1)
        {
            InitializeComponent();
            userControl1 = _userControl1;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
        }

        #region 우편번호 api 검색 후 데이터 그리드 띄우기
        /// <summary>
        ///  행정안전부 api 사용
        ///  https://www.juso.go.kr/addrlink/devAddrLinkRequestGuide.do?menu=roadApi
        ///  데이터 테이블 헤더 이름 변경 및 입력 내용 골라내기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void search_Addr()
        {
            try
            {
                keyword = textBox1.Text.Trim();
                apiurl = "https://www.juso.go.kr/addrlink/addrLinkApi.do?currentPage=" + currentPage
                                    + "&countPerPage=" + countPerPage + "&keyword=" + keyword
                                    + "&confmKey=" + confmKey;

                WebClient wc = new WebClient();

                XmlReader read = new XmlTextReader(wc.OpenRead(apiurl));

                DataSet ds = new DataSet();
                ds.ReadXml(read);

                DataRow[] rows = ds.Tables[0].Select();

                dataGridView1.Rows.Clear();

                if (rows[0]["totalCount"].ToString() != "0")
                {
                    foreach (DataRow rowss in ds.Tables[1].Rows)
                    {
                        int rowidx = dataGridView1.Rows.Add();
                        dataGridView1.Rows[rowidx].Cells["roadAddr"].Value = rowss["roadAddr"].ToString();
                        dataGridView1.Rows[rowidx].Cells["zipNo"].Value = rowss["zipNo"].ToString();
                        dataGridView1.Rows[rowidx].Cells["engAddr"].Value = rowss["engAddr"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search_Addr();
        }

        //***********************************************
        // Enter 키로 확인버튼 대체
        //***********************************************
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Keys key = keyData & ~(Keys.Shift | Keys.Control);

            switch (key)
            {
                case Keys.Enter:
                    search_Addr();
                    return true;
                default: return false;
            }
        }
        #endregion

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string zip = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            string addr = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            userControl1.ct_bas_zip.Text = zip;
            userControl1.ct_bas_addr.Text = addr;
            userControl1.ct_bas_eaddr.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            userControl1.ct_bas_anaddr.Focus();
            this.Close();
        }

    }
}
