
namespace KaySub023
{
    partial class KaySub023_popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KaySub023_popup));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resnoBox = new System.Windows.Forms.MaskedTextBox();
            this.btn_print = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(728, 581);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resnoBox);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 36);
            this.panel1.TabIndex = 2;
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
            // btn_print
            // 
            this.btn_print.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_print.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.Image")));
            this.btn_print.Location = new System.Drawing.Point(678, 0);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(44, 36);
            this.btn_print.TabIndex = 1;
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 45);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(722, 533);
            this.reportViewer1.TabIndex = 3;
            // 
            // KaySub023_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 581);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KaySub023_popup";
            this.Text = "경력증명서";
            this.Load += new System.EventHandler(this.KaySub023_popup_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox resnoBox;
        private System.Windows.Forms.Button btn_print;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}