namespace KaySub010
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
            this.lic_acqdateText = new System.Windows.Forms.MaskedTextBox();
            this.lic_organText = new System.Windows.Forms.TextBox();
            this.lic_gradeText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lic_nameText = new System.Windows.Forms.TextBox();
            this.lic_empnoText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.RWUD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lic_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lic_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lic_grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lic_acqdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lic_organ = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1060, 648);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1054, 602);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bas_empno,
            this.bas_name,
            this.bas_dept,
            this.bas_pos});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(498, 596);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(507, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(544, 596);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lic_acqdateText);
            this.panel4.Controls.Add(this.lic_organText);
            this.panel4.Controls.Add(this.lic_gradeText);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lic_nameText);
            this.panel4.Controls.Add(this.lic_empnoText);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 299);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(538, 294);
            this.panel4.TabIndex = 3;
            // 
            // lic_acqdateText
            // 
            this.lic_acqdateText.Location = new System.Drawing.Point(63, 28);
            this.lic_acqdateText.Mask = "0000-00-00";
            this.lic_acqdateText.Name = "lic_acqdateText";
            this.lic_acqdateText.Size = new System.Drawing.Size(100, 21);
            this.lic_acqdateText.TabIndex = 2;
            this.lic_acqdateText.ValidatingType = typeof(System.DateTime);
            // 
            // lic_organText
            // 
            this.lic_organText.Location = new System.Drawing.Point(63, 77);
            this.lic_organText.MaxLength = 30;
            this.lic_organText.Name = "lic_organText";
            this.lic_organText.Size = new System.Drawing.Size(120, 21);
            this.lic_organText.TabIndex = 4;
            // 
            // lic_gradeText
            // 
            this.lic_gradeText.Location = new System.Drawing.Point(254, 76);
            this.lic_gradeText.MaxLength = 10;
            this.lic_gradeText.Name = "lic_gradeText";
            this.lic_gradeText.Size = new System.Drawing.Size(120, 21);
            this.lic_gradeText.TabIndex = 5;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "발급기관";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "취득일자";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "급수";
            // 
            // lic_nameText
            // 
            this.lic_nameText.Location = new System.Drawing.Point(63, 52);
            this.lic_nameText.MaxLength = 30;
            this.lic_nameText.Name = "lic_nameText";
            this.lic_nameText.Size = new System.Drawing.Size(311, 21);
            this.lic_nameText.TabIndex = 3;
            // 
            // lic_empnoText
            // 
            this.lic_empnoText.Location = new System.Drawing.Point(63, 4);
            this.lic_empnoText.MaxLength = 9;
            this.lic_empnoText.Name = "lic_empnoText";
            this.lic_empnoText.Size = new System.Drawing.Size(100, 21);
            this.lic_empnoText.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "자격증명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 8);
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
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RWUD,
            this.lic_empno,
            this.lic_name,
            this.lic_grade,
            this.lic_acqdate,
            this.lic_organ});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(538, 290);
            this.dataGridView2.TabIndex = 0;
            // 
            // RWUD
            // 
            this.RWUD.HeaderText = "상태";
            this.RWUD.Name = "RWUD";
            this.RWUD.Width = 54;
            // 
            // lic_empno
            // 
            this.lic_empno.DataPropertyName = "lic_empno";
            this.lic_empno.HeaderText = "사원번호";
            this.lic_empno.Name = "lic_empno";
            this.lic_empno.ReadOnly = true;
            this.lic_empno.Visible = false;
            this.lic_empno.Width = 78;
            // 
            // lic_name
            // 
            this.lic_name.DataPropertyName = "lic_name";
            this.lic_name.HeaderText = "자격증명";
            this.lic_name.Name = "lic_name";
            this.lic_name.ReadOnly = true;
            this.lic_name.Width = 78;
            // 
            // lic_grade
            // 
            this.lic_grade.DataPropertyName = "lic_grade";
            this.lic_grade.HeaderText = "급수";
            this.lic_grade.Name = "lic_grade";
            this.lic_grade.ReadOnly = true;
            this.lic_grade.Width = 54;
            // 
            // lic_acqdate
            // 
            this.lic_acqdate.DataPropertyName = "lic_acqdate";
            this.lic_acqdate.HeaderText = "취득일자";
            this.lic_acqdate.Name = "lic_acqdate";
            this.lic_acqdate.ReadOnly = true;
            this.lic_acqdate.Width = 78;
            // 
            // lic_organ
            // 
            this.lic_organ.DataPropertyName = "lic_organ";
            this.lic_organ.HeaderText = "발급기관";
            this.lic_organ.Name = "lic_organ";
            this.lic_organ.ReadOnly = true;
            this.lic_organ.Width = 78;
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
            this.panel3.Size = new System.Drawing.Size(1054, 34);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1054, 1);
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
            this.Size = new System.Drawing.Size(1060, 648);
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
        private System.Windows.Forms.MaskedTextBox lic_acqdateText;
        private System.Windows.Forms.TextBox lic_organText;
        private System.Windows.Forms.TextBox lic_gradeText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lic_nameText;
        private System.Windows.Forms.TextBox lic_empnoText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RWUD;
        private System.Windows.Forms.DataGridViewTextBoxColumn lic_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn lic_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lic_grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn lic_acqdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lic_organ;
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
