using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaySub022
{
    public partial class KaySub022_popup : Form
    {
        public KaySub022_popup()
        {
            InitializeComponent();
        }

        private void KaySub022_popup_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
