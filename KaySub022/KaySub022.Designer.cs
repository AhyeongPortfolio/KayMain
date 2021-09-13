
namespace KaySub022
{
    partial class KaySub022
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KaySub022));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_print = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.resnoBox = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ct_date = new System.Windows.Forms.MaskedTextBox();
            this.ct_date2 = new System.Windows.Forms.MaskedTextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 638);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_print
            // 
            this.btn_print.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_print.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.Image")));
            this.btn_print.Location = new System.Drawing.Point(666, 0);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(44, 36);
            this.btn_print.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_print, "인쇄");
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // resnoBox
            // 
            this.resnoBox.Location = new System.Drawing.Point(3, 3);
            this.resnoBox.Mask = "000000-0000000";
            this.resnoBox.Name = "resnoBox";
            this.resnoBox.Size = new System.Drawing.Size(100, 21);
            this.resnoBox.TabIndex = 3;
            this.resnoBox.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ct_date2);
            this.panel1.Controls.Add(this.ct_date);
            this.panel1.Controls.Add(this.resnoBox);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 36);
            this.panel1.TabIndex = 1;
            // 
            // ct_date
            // 
            this.ct_date.Location = new System.Drawing.Point(109, 3);
            this.ct_date.Mask = "0000-00-00";
            this.ct_date.Name = "ct_date";
            this.ct_date.Size = new System.Drawing.Size(100, 21);
            this.ct_date.TabIndex = 4;
            this.ct_date.ValidatingType = typeof(System.DateTime);
            this.ct_date.Visible = false;
            // 
            // ct_date2
            // 
            this.ct_date2.Location = new System.Drawing.Point(215, 3);
            this.ct_date2.Mask = "0000-00-00";
            this.ct_date2.Name = "ct_date2";
            this.ct_date2.Size = new System.Drawing.Size(100, 21);
            this.ct_date2.TabIndex = 4;
            this.ct_date2.ValidatingType = typeof(System.DateTime);
            this.ct_date2.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KaySub022.Reissue.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 45);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowPrintButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(710, 570);
            this.reportViewer1.TabIndex = 2;
            // 
            // KaySub022_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 638);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KaySub022_popup";
            this.Text = "증명서발급";
            this.Load += new System.EventHandler(this.KaySub022_popup_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox resnoBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox ct_date;
        private System.Windows.Forms.MaskedTextBox ct_date2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}