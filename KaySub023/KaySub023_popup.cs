using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KaySub023
{
    public partial class KaySub023_popup : Form
    {
        public KaySub023_popup()
        {
            InitializeComponent();
        }

        private void KaySub023_popup_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
