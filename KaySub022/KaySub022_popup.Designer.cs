
namespace KaySub022
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qt_resno = new System.Windows.Forms.MaskedTextBox();
            this.qt_date = new System.Windows.Forms.MaskedTextBox();
            this.qt_date1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KaySub022.MainPrint.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(731, 529);
            this.reportViewer1.TabIndex = 0;
            // 
            // qt_resno
            // 
            this.qt_resno.Location = new System.Drawing.Point(396, 127);
            this.qt_resno.Mask = "000000-0000000";
            this.qt_resno.Name = "qt_resno";
            this.qt_resno.Size = new System.Drawing.Size(98, 21);
            this.qt_resno.TabIndex = 1;
            this.qt_resno.Visible = false;
            // 
            // qt_date
            // 
            this.qt_date.Location = new System.Drawing.Point(396, 154);
            this.qt_date.Mask = "0000-00-00";
            this.qt_date.Name = "qt_date";
            this.qt_date.Size = new System.Drawing.Size(98, 21);
            this.qt_date.TabIndex = 1;
            this.qt_date.ValidatingType = typeof(System.DateTime);
            this.qt_date.Visible = false;
            // 
            // qt_date1
            // 
            this.qt_date1.Location = new System.Drawing.Point(396, 181);
            this.qt_date1.Mask = "0000-00-00";
            this.qt_date1.Name = "qt_date1";
            this.qt_date1.Size = new System.Drawing.Size(98, 21);
            this.qt_date1.TabIndex = 1;
            this.qt_date1.ValidatingType = typeof(System.DateTime);
            this.qt_date1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 529);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.qt_date1);
            this.Controls.Add(this.qt_date);
            this.Controls.Add(this.qt_resno);
            this.Name = "Form1";
            this.Text = "증명서발급";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.MaskedTextBox qt_resno;
        private System.Windows.Forms.MaskedTextBox qt_date;
        private System.Windows.Forms.MaskedTextBox qt_date1;
    }
}

