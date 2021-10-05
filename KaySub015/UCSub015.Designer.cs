namespace KaySub015
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateSearch2 = new System.Windows.Forms.DateTimePicker();
            this.dateSearch1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.papp_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_appno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_pap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_auth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_basis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_rmk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_pos_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_dut_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_dept_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_pos_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_dut_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_dept_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papp_sts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.papr_appno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papr_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papr_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papr_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datasys4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1073, 637);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateSearch2);
            this.panel1.Controls.Add(this.dateSearch1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nameSearch);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 34);
            this.panel1.TabIndex = 1;
            // 
            // dateSearch2
            // 
            this.dateSearch2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSearch2.Location = new System.Drawing.Point(362, 3);
            this.dateSearch2.Name = "dateSearch2";
            this.dateSearch2.Size = new System.Drawing.Size(88, 21);
            this.dateSearch2.TabIndex = 52;
            // 
            // dateSearch1
            // 
            this.dateSearch1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSearch1.Location = new System.Drawing.Point(251, 3);
            this.dateSearch1.Name = "dateSearch1";
            this.dateSearch1.Size = new System.Drawing.Size(88, 21);
            this.dateSearch1.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 50;
            this.label7.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "시행일자";
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(86, 3);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(100, 21);
            this.nameSearch.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "인사발령번호";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1067, 591);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.papp_empno,
            this.papp_appno,
            this.papp_date,
            this.papp_pap,
            this.papp_content,
            this.papp_auth,
            this.papp_basis,
            this.papp_rmk,
            this.papp_cont,
            this.papp_pos_cd,
            this.papp_dut_cd,
            this.papp_dept_cd,
            this.papp_pos_nm,
            this.papp_dut_nm,
            this.papp_dept_nm,
            this.papp_sts,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(429, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(635, 585);
            this.dataGridView2.TabIndex = 4;
            // 
            // papp_empno
            // 
            this.papp_empno.DataPropertyName = "papp_empno";
            this.papp_empno.HeaderText = "사원번호";
            this.papp_empno.Name = "papp_empno";
            this.papp_empno.Width = 78;
            // 
            // papp_appno
            // 
            this.papp_appno.DataPropertyName = "papp_appno";
            this.papp_appno.HeaderText = "인사발령번호";
            this.papp_appno.Name = "papp_appno";
            this.papp_appno.Width = 102;
            // 
            // papp_date
            // 
            this.papp_date.DataPropertyName = "papp_date";
            this.papp_date.HeaderText = "시행일자";
            this.papp_date.Name = "papp_date";
            this.papp_date.Width = 78;
            // 
            // papp_pap
            // 
            this.papp_pap.DataPropertyName = "papp_pap";
            this.papp_pap.HeaderText = "발령종류";
            this.papp_pap.Name = "papp_pap";
            this.papp_pap.Width = 78;
            // 
            // papp_content
            // 
            this.papp_content.DataPropertyName = "papp_content";
            this.papp_content.HeaderText = "발령내용";
            this.papp_content.Name = "papp_content";
            this.papp_content.Width = 78;
            // 
            // papp_auth
            // 
            this.papp_auth.DataPropertyName = "papp_auth";
            this.papp_auth.HeaderText = "발령권자";
            this.papp_auth.Name = "papp_auth";
            this.papp_auth.Width = 78;
            // 
            // papp_basis
            // 
            this.papp_basis.DataPropertyName = "papp_basis";
            this.papp_basis.HeaderText = "발령근거";
            this.papp_basis.Name = "papp_basis";
            this.papp_basis.Width = 78;
            // 
            // papp_rmk
            // 
            this.papp_rmk.DataPropertyName = "papp_rmk";
            this.papp_rmk.HeaderText = "비고";
            this.papp_rmk.Name = "papp_rmk";
            this.papp_rmk.Width = 54;
            // 
            // papp_cont
            // 
            this.papp_cont.DataPropertyName = "papp_cont";
            this.papp_cont.HeaderText = "계약구분";
            this.papp_cont.Name = "papp_cont";
            this.papp_cont.ReadOnly = true;
            this.papp_cont.Visible = false;
            this.papp_cont.Width = 78;
            // 
            // papp_pos_cd
            // 
            this.papp_pos_cd.DataPropertyName = "papp_pos_cd";
            this.papp_pos_cd.HeaderText = "당시직급코드";
            this.papp_pos_cd.Name = "papp_pos_cd";
            this.papp_pos_cd.Visible = false;
            this.papp_pos_cd.Width = 102;
            // 
            // papp_dut_cd
            // 
            this.papp_dut_cd.DataPropertyName = "papp_dut_cd";
            this.papp_dut_cd.HeaderText = "당시직책코드";
            this.papp_dut_cd.Name = "papp_dut_cd";
            this.papp_dut_cd.Visible = false;
            this.papp_dut_cd.Width = 102;
            // 
            // papp_dept_cd
            // 
            this.papp_dept_cd.DataPropertyName = "papp_dept_cd";
            this.papp_dept_cd.HeaderText = "당시부서코드";
            this.papp_dept_cd.Name = "papp_dept_cd";
            this.papp_dept_cd.Visible = false;
            this.papp_dept_cd.Width = 102;
            // 
            // papp_pos_nm
            // 
            this.papp_pos_nm.DataPropertyName = "papp_pos_nm";
            this.papp_pos_nm.HeaderText = "당시직급명";
            this.papp_pos_nm.Name = "papp_pos_nm";
            this.papp_pos_nm.Width = 90;
            // 
            // papp_dut_nm
            // 
            this.papp_dut_nm.DataPropertyName = "papp_dut_nm";
            this.papp_dut_nm.HeaderText = "당시직책명";
            this.papp_dut_nm.Name = "papp_dut_nm";
            this.papp_dut_nm.Width = 90;
            // 
            // papp_dept_nm
            // 
            this.papp_dept_nm.DataPropertyName = "papp_dept_nm";
            this.papp_dept_nm.HeaderText = "당시부서명";
            this.papp_dept_nm.Name = "papp_dept_nm";
            this.papp_dept_nm.Width = 90;
            // 
            // papp_sts
            // 
            this.papp_sts.DataPropertyName = "papp_sts";
            this.papp_sts.HeaderText = "신분구분";
            this.papp_sts.Name = "papp_sts";
            this.papp_sts.Width = 78;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "datasys1";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "datasys2";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "datasys3";
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "datasys4";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            this.Column7.Width = 80;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.papr_appno,
            this.papr_date,
            this.papr_content,
            this.papr_num,
            this.Column1,
            this.Column2,
            this.Column3,
            this.datasys4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(420, 585);
            this.dataGridView1.TabIndex = 0;
            // 
            // papr_appno
            // 
            this.papr_appno.DataPropertyName = "papr_appno";
            this.papr_appno.HeaderText = "인사발령번호";
            this.papr_appno.Name = "papr_appno";
            // 
            // papr_date
            // 
            this.papr_date.DataPropertyName = "papr_date";
            this.papr_date.HeaderText = "시행일자";
            this.papr_date.Name = "papr_date";
            // 
            // papr_content
            // 
            this.papr_content.DataPropertyName = "papr_content";
            this.papr_content.HeaderText = "발령내용";
            this.papr_content.Name = "papr_content";
            // 
            // papr_num
            // 
            this.papr_num.DataPropertyName = "papr_num";
            this.papr_num.HeaderText = "발령인원수";
            this.papr_num.Name = "papr_num";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "datasys1";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "datasys2";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "datasys3";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // datasys4
            // 
            this.datasys4.DataPropertyName = "datasys4";
            this.datasys4.HeaderText = "Column7";
            this.datasys4.Name = "datasys4";
            this.datasys4.Visible = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1073, 637);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateSearch2;
        private System.Windows.Forms.DateTimePicker dateSearch1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_appno;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_pap;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_auth;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_basis;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_rmk;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_pos_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_dut_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_dept_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_pos_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_dut_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_dept_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn papp_sts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_appno;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn papr_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasys4;
    }
}
