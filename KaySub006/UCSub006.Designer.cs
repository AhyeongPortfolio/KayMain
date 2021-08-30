namespace KaySub006
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bas_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fam_bthText = new System.Windows.Forms.MaskedTextBox();
            this.fam_ltgText = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.fam_relText = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fam_nameText = new System.Windows.Forms.TextBox();
            this.fam_empnoText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.incheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fam_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fam_rel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fam_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fam_bth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fam_ltg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.empnoSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nameSearch = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1113, 709);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 550F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1107, 663);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bas_empno,
            this.bas_name,
            this.bas_dept,
            this.bas_pos});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(551, 657);
            this.dataGridView1.TabIndex = 2;
            // 
            // bas_empno
            // 
            this.bas_empno.DataPropertyName = "bas_empno";
            this.bas_empno.HeaderText = "사원번호";
            this.bas_empno.Name = "bas_empno";
            this.bas_empno.ReadOnly = true;
            this.bas_empno.Width = 78;
            // 
            // bas_name
            // 
            this.bas_name.DataPropertyName = "bas_name";
            this.bas_name.HeaderText = "성명";
            this.bas_name.Name = "bas_name";
            this.bas_name.ReadOnly = true;
            this.bas_name.Width = 54;
            // 
            // bas_dept
            // 
            this.bas_dept.DataPropertyName = "bas_dept";
            this.bas_dept.HeaderText = "부서";
            this.bas_dept.Name = "bas_dept";
            this.bas_dept.ReadOnly = true;
            this.bas_dept.Width = 54;
            // 
            // bas_pos
            // 
            this.bas_pos.DataPropertyName = "bas_pos";
            this.bas_pos.HeaderText = "직급";
            this.bas_pos.Name = "bas_pos";
            this.bas_pos.ReadOnly = true;
            this.bas_pos.Width = 54;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(560, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(544, 657);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.fam_bthText);
            this.panel4.Controls.Add(this.fam_ltgText);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.fam_relText);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.fam_nameText);
            this.panel4.Controls.Add(this.fam_empnoText);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 360);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(538, 294);
            this.panel4.TabIndex = 3;
            // 
            // fam_bthText
            // 
            this.fam_bthText.Location = new System.Drawing.Point(63, 50);
            this.fam_bthText.Mask = "0000-00-00";
            this.fam_bthText.Name = "fam_bthText";
            this.fam_bthText.Size = new System.Drawing.Size(100, 21);
            this.fam_bthText.TabIndex = 4;
            this.fam_bthText.ValidatingType = typeof(System.DateTime);
            // 
            // fam_ltgText
            // 
            this.fam_ltgText.FormattingEnabled = true;
            this.fam_ltgText.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.fam_ltgText.Location = new System.Drawing.Point(228, 50);
            this.fam_ltgText.Name = "fam_ltgText";
            this.fam_ltgText.Size = new System.Drawing.Size(100, 20);
            this.fam_ltgText.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "동거여부";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 1);
            this.panel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "생년월일";
            // 
            // fam_relText
            // 
            this.fam_relText.FormattingEnabled = true;
            this.fam_relText.Location = new System.Drawing.Point(228, 27);
            this.fam_relText.Name = "fam_relText";
            this.fam_relText.Size = new System.Drawing.Size(100, 20);
            this.fam_relText.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "가족관계";
            // 
            // fam_nameText
            // 
            this.fam_nameText.Location = new System.Drawing.Point(63, 27);
            this.fam_nameText.MaxLength = 20;
            this.fam_nameText.Name = "fam_nameText";
            this.fam_nameText.Size = new System.Drawing.Size(100, 21);
            this.fam_nameText.TabIndex = 2;
            // 
            // fam_empnoText
            // 
            this.fam_empnoText.Location = new System.Drawing.Point(63, 3);
            this.fam_empnoText.MaxLength = 5;
            this.fam_empnoText.Name = "fam_empnoText";
            this.fam_empnoText.Size = new System.Drawing.Size(100, 21);
            this.fam_empnoText.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "가족성명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "사원번호";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incheck,
            this.fam_empno,
            this.fam_rel,
            this.fam_name,
            this.fam_bth,
            this.fam_ltg});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(538, 351);
            this.dataGridView2.TabIndex = 0;
            // 
            // incheck
            // 
            this.incheck.HeaderText = "상태";
            this.incheck.Name = "incheck";
            this.incheck.Width = 54;
            // 
            // fam_empno
            // 
            this.fam_empno.DataPropertyName = "fam_empno";
            this.fam_empno.HeaderText = "사원번호";
            this.fam_empno.Name = "fam_empno";
            this.fam_empno.ReadOnly = true;
            this.fam_empno.Width = 78;
            // 
            // fam_rel
            // 
            this.fam_rel.DataPropertyName = "fam_rel";
            this.fam_rel.HeaderText = "관계";
            this.fam_rel.Name = "fam_rel";
            this.fam_rel.ReadOnly = true;
            this.fam_rel.Width = 54;
            // 
            // fam_name
            // 
            this.fam_name.DataPropertyName = "fam_name";
            this.fam_name.HeaderText = "성명";
            this.fam_name.Name = "fam_name";
            this.fam_name.ReadOnly = true;
            this.fam_name.Width = 54;
            // 
            // fam_bth
            // 
            this.fam_bth.DataPropertyName = "fam_bth";
            this.fam_bth.HeaderText = "생년월일";
            this.fam_bth.Name = "fam_bth";
            this.fam_bth.ReadOnly = true;
            this.fam_bth.Width = 78;
            // 
            // fam_ltg
            // 
            this.fam_ltg.DataPropertyName = "fam_ltg";
            this.fam_ltg.HeaderText = "동거여부";
            this.fam_ltg.Name = "fam_ltg";
            this.fam_ltg.ReadOnly = true;
            this.fam_ltg.Width = 78;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.empnoSearch);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.nameSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1107, 34);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1107, 1);
            this.panel5.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 51;
            this.label1.Text = "사원번호";
            // 
            // empnoSearch
            // 
            this.empnoSearch.Location = new System.Drawing.Point(62, 2);
            this.empnoSearch.Name = "empnoSearch";
            this.empnoSearch.Size = new System.Drawing.Size(100, 21);
            this.empnoSearch.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 45;
            this.label2.Text = "부서";
            this.label2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(344, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 48;
            this.comboBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 46;
            this.label3.Text = "직급";
            this.label3.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(485, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 20);
            this.comboBox2.TabIndex = 49;
            this.comboBox2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 47;
            this.label9.Text = "성명";
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(203, 2);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(100, 21);
            this.nameSearch.TabIndex = 50;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1113, 709);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_pos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox fam_bthText;
        private System.Windows.Forms.ComboBox fam_ltgText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox fam_relText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fam_nameText;
        private System.Windows.Forms.TextBox fam_empnoText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn incheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn fam_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn fam_rel;
        private System.Windows.Forms.DataGridViewTextBoxColumn fam_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn fam_bth;
        private System.Windows.Forms.DataGridViewTextBoxColumn fam_ltg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empnoSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nameSearch;
    }
}
