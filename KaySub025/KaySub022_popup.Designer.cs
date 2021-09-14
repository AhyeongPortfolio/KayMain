
namespace KaySub025
{
    partial class KaySub022_popup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qt_date1 = new System.Windows.Forms.MaskedTextBox();
            this.qt_date = new System.Windows.Forms.MaskedTextBox();
            this.qt_resno = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KaySub025.Report.MainPrint.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(638, 601);
            this.reportViewer1.TabIndex = 0;
            // 
            // qt_date1
            // 
            this.qt_date1.Location = new System.Drawing.Point(270, 317);
            this.qt_date1.Mask = "0000-00-00";
            this.qt_date1.Name = "qt_date1";
            this.qt_date1.Size = new System.Drawing.Size(98, 21);
            this.qt_date1.TabIndex = 2;
            this.qt_date1.ValidatingType = typeof(System.DateTime);
            this.qt_date1.Visible = false;
            // 
            // qt_date
            // 
            this.qt_date.Location = new System.Drawing.Point(270, 290);
            this.qt_date.Mask = "0000-00-00";
            this.qt_date.Name = "qt_date";
            this.qt_date.Size = new System.Drawing.Size(98, 21);
            this.qt_date.TabIndex = 3;
            this.qt_date.ValidatingType = typeof(System.DateTime);
            this.qt_date.Visible = false;
            // 
            // qt_resno
            // 
            this.qt_resno.Location = new System.Drawing.Point(270, 263);
            this.qt_resno.Mask = "000000-0000000";
            this.qt_resno.Name = "qt_resno";
            this.qt_resno.Size = new System.Drawing.Size(98, 21);
            this.qt_resno.TabIndex = 4;
            this.qt_resno.Visible = false;
            // 
            // KaySub022_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 601);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.qt_date1);
            this.Controls.Add(this.qt_date);
            this.Controls.Add(this.qt_resno);
            this.Name = "KaySub022_popup";
            this.Text = "증명서발급";
            this.Load += new System.EventHandler(this.KaySub022_popup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.MaskedTextBox qt_date1;
        private System.Windows.Forms.MaskedTextBox qt_date;
        private System.Windows.Forms.MaskedTextBox qt_resno;
    }
}