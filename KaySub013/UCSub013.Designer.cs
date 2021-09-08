namespace KaySub013
{
    partial class UserControl1
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.papr_appnoSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panData = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ct_papr_date = new System.Windows.Forms.MaskedTextBox();
            this.ct_papr_content = new System.Windows.Forms.TextBox();
            this.ct_papr_num = new System.Windows.Forms.TextBox();
            this.ct_papr_appno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateSearch1 = new System.Windows.Forms.DateTimePicker();
            this.dateSearch2 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.papr_appno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papr_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papr_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papr_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(992, 604);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateSearch2);
            this.panel1.Controls.Add(this.dateSearch1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.papr_appnoSearch);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 34);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(986, 1);
            this.panel5.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "시행일자";
            // 
            // papr_appnoSearch
            // 
            this.papr_appnoSearch.Location = new System.Drawing.Point(86, 0);
            this.papr_appnoSearch.Name = "papr_appnoSearch";
            this.papr_appnoSearch.Size = new System.Drawing.Size(100, 21);
            this.papr_appnoSearch.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "인사발령번호";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panData, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(986, 558);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.papr_appno,
            this.papr_date,
            this.papr_content,
            this.papr_num,
            this.status});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(680, 552);
            this.dataGridView1.TabIndex = 3;
            // 
            // panData
            // 
            this.panData.Controls.Add(this.panel4);
            this.panData.Controls.Add(this.ct_papr_date);
            this.panData.Controls.Add(this.ct_papr_content);
            this.panData.Controls.Add(this.ct_papr_num);
            this.panData.Controls.Add(this.ct_papr_appno);
            this.panData.Controls.Add(this.label4);
            this.panData.Controls.Add(this.label3);
            this.panData.Controls.Add(this.label2);
            this.panData.Controls.Add(this.label1);
            this.panData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panData.Location = new System.Drawing.Point(689, 3);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(294, 552);
            this.panData.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 551);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 1);
            this.panel4.TabIndex = 42;
            // 
            // ct_papr_date
            // 
            this.ct_papr_date.Location = new System.Drawing.Point(126, 27);
            this.ct_papr_date.Mask = "0000-90-90";
            this.ct_papr_date.Name = "ct_papr_date";
            this.ct_papr_date.Size = new System.Drawing.Size(152, 21);
            this.ct_papr_date.TabIndex = 2;
            // 
            // ct_papr_content
            // 
            this.ct_papr_content.Location = new System.Drawing.Point(126, 75);
            this.ct_papr_content.MaxLength = 50;
            this.ct_papr_content.Multiline = true;
            this.ct_papr_content.Name = "ct_papr_content";
            this.ct_papr_content.Size = new System.Drawing.Size(152, 63);
            this.ct_papr_content.TabIndex = 4;
            // 
            // ct_papr_num
            // 
            this.ct_papr_num.Location = new System.Drawing.Point(126, 51);
            this.ct_papr_num.MaxLength = 3;
            this.ct_papr_num.Name = "ct_papr_num";
            this.ct_papr_num.Size = new System.Drawing.Size(152, 21);
            this.ct_papr_num.TabIndex = 3;
            // 
            // ct_papr_appno
            // 
            this.ct_papr_appno.Location = new System.Drawing.Point(126, 3);
            this.ct_papr_appno.MaxLength = 20;
            this.ct_papr_appno.Name = "ct_papr_appno";
            this.ct_papr_appno.ReadOnly = true;
            this.ct_papr_appno.Size = new System.Drawing.Size(152, 21);
            this.ct_papr_appno.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "발령내용";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "발령인원수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "시행일자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "인사발령번호";
            // 
            // dateSearch1
            // 
            this.dateSearch1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSearch1.Location = new System.Drawing.Point(251, 0);
            this.dateSearch1.Name = "dateSearch1";
            this.dateSearch1.Size = new System.Drawing.Size(88, 21);
            this.dateSearch1.TabIndex = 46;
            // 
            // dateSearch2
            // 
            this.dateSearch2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSearch2.Location = new System.Drawing.Point(362, 0);
            this.dateSearch2.Name = "dateSearch2";
            this.dateSearch2.Size = new System.Drawing.Size(88, 21);
            this.dateSearch2.TabIndex = 46;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // papr_appno
            // 
            this.papr_appno.DataPropertyName = "papr_appno";
            this.papr_appno.FillWeight = 120F;
            this.papr_appno.HeaderText = "인사발령번호";
            this.papr_appno.MinimumWidth = 111;
            this.papr_appno.Name = "papr_appno";
            this.papr_appno.ReadOnly = true;
            this.papr_appno.Width = 111;
            // 
            // papr_date
            // 
            this.papr_date.DataPropertyName = "papr_date";
            this.papr_date.FillWeight = 106.2606F;
            this.papr_date.HeaderText = "시행일자";
            this.papr_date.MinimumWidth = 125;
            this.papr_date.Name = "papr_date";
            this.papr_date.Width = 125;
            // 
            // papr_content
            // 
            this.papr_content.DataPropertyName = "papr_content";
            this.papr_content.FillWeight = 106.2606F;
            this.papr_content.HeaderText = "발령내용";
            this.papr_content.MinimumWidth = 145;
            this.papr_content.Name = "papr_content";
            this.papr_content.Width = 145;
            // 
            // papr_num
            // 
            this.papr_num.DataPropertyName = "papr_num";
            this.papr_num.FillWeight = 106.2606F;
            this.papr_num.HeaderText = "발령인원수";
            this.papr_num.MinimumWidth = 75;
            this.papr_num.Name = "papr_num";
            this.papr_num.Width = 90;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.FillWeight = 60F;
            this.status.HeaderText = "상태";
            this.status.MinimumWidth = 56;
            this.status.Name = "status";
            this.status.Visible = false;
            this.status.Width = 56;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(992, 604);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panData.ResumeLayout(false);
            this.panData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox papr_appnoSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox ct_papr_date;
        private System.Windows.Forms.TextBox ct_papr_content;
        private System.Windows.Forms.TextBox ct_papr_num;
        private System.Windows.Forms.TextBox ct_papr_appno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateSearch2;
        private System.Windows.Forms.DateTimePicker dateSearch1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_appno;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
