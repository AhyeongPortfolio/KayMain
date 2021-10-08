namespace KaySub009
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panData = new System.Windows.Forms.Panel();
            this.ct_car_yyyymm_t = new System.Windows.Forms.MaskedTextBox();
            this.ct_car_yyyymm_f = new System.Windows.Forms.MaskedTextBox();
            this.ct_car_reason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ct_car_dept = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ct_car_pos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ct_car_region = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ct_car_com = new System.Windows.Forms.TextBox();
            this.ct_car_empno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.car_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_com = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_yyyymm_f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_yyyymm_t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bas_empno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bas_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.empnoSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nameSearch = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1098, 637);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1092, 591);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panData, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(549, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(540, 585);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panData
            // 
            this.panData.Controls.Add(this.ct_car_yyyymm_t);
            this.panData.Controls.Add(this.ct_car_yyyymm_f);
            this.panData.Controls.Add(this.ct_car_reason);
            this.panData.Controls.Add(this.label8);
            this.panData.Controls.Add(this.panel2);
            this.panData.Controls.Add(this.ct_car_dept);
            this.panData.Controls.Add(this.label6);
            this.panData.Controls.Add(this.ct_car_pos);
            this.panData.Controls.Add(this.label11);
            this.panData.Controls.Add(this.ct_car_region);
            this.panData.Controls.Add(this.label10);
            this.panData.Controls.Add(this.label9);
            this.panData.Controls.Add(this.label7);
            this.panData.Controls.Add(this.ct_car_com);
            this.panData.Controls.Add(this.ct_car_empno);
            this.panData.Controls.Add(this.label5);
            this.panData.Controls.Add(this.label4);
            this.panData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panData.Location = new System.Drawing.Point(3, 268);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(534, 314);
            this.panData.TabIndex = 3;
            // 
            // ct_car_yyyymm_t
            // 
            this.ct_car_yyyymm_t.Location = new System.Drawing.Point(269, 54);
            this.ct_car_yyyymm_t.Mask = "0000-00";
            this.ct_car_yyyymm_t.Name = "ct_car_yyyymm_t";
            this.ct_car_yyyymm_t.Size = new System.Drawing.Size(100, 21);
            this.ct_car_yyyymm_t.TabIndex = 5;
            this.ct_car_yyyymm_t.ValidatingType = typeof(System.DateTime);
            // 
            // ct_car_yyyymm_f
            // 
            this.ct_car_yyyymm_f.Location = new System.Drawing.Point(92, 54);
            this.ct_car_yyyymm_f.Mask = "0000-00";
            this.ct_car_yyyymm_f.Name = "ct_car_yyyymm_f";
            this.ct_car_yyyymm_f.Size = new System.Drawing.Size(100, 21);
            this.ct_car_yyyymm_f.TabIndex = 4;
            this.ct_car_yyyymm_f.ValidatingType = typeof(System.DateTime);
            // 
            // ct_car_reason
            // 
            this.ct_car_reason.Location = new System.Drawing.Point(92, 126);
            this.ct_car_reason.MaxLength = 30;
            this.ct_car_reason.Name = "ct_car_reason";
            this.ct_car_reason.Size = new System.Drawing.Size(277, 21);
            this.ct_car_reason.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 38;
            this.label8.Text = "퇴직/이직사유";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 1);
            this.panel2.TabIndex = 0;
            // 
            // ct_car_dept
            // 
            this.ct_car_dept.Location = new System.Drawing.Point(92, 102);
            this.ct_car_dept.MaxLength = 30;
            this.ct_car_dept.Name = "ct_car_dept";
            this.ct_car_dept.Size = new System.Drawing.Size(277, 21);
            this.ct_car_dept.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "담당부서";
            // 
            // ct_car_pos
            // 
            this.ct_car_pos.Location = new System.Drawing.Point(92, 78);
            this.ct_car_pos.MaxLength = 20;
            this.ct_car_pos.Name = "ct_car_pos";
            this.ct_car_pos.Size = new System.Drawing.Size(277, 21);
            this.ct_car_pos.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 38;
            this.label11.Text = "최종직급";
            // 
            // ct_car_region
            // 
            this.ct_car_region.Location = new System.Drawing.Point(269, 30);
            this.ct_car_region.MaxLength = 10;
            this.ct_car_region.Name = "ct_car_region";
            this.ct_car_region.Size = new System.Drawing.Size(100, 21);
            this.ct_car_region.TabIndex = 3;
            this.ct_car_region.Tag = "car_region";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(222, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 36;
            this.label10.Text = "소재지";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "근무종료월";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "근무시작월";
            // 
            // ct_car_com
            // 
            this.ct_car_com.Location = new System.Drawing.Point(92, 30);
            this.ct_car_com.MaxLength = 30;
            this.ct_car_com.Name = "ct_car_com";
            this.ct_car_com.Size = new System.Drawing.Size(100, 21);
            this.ct_car_com.TabIndex = 2;
            this.ct_car_com.Tag = "car_com";
            // 
            // ct_car_empno
            // 
            this.ct_car_empno.Location = new System.Drawing.Point(92, 6);
            this.ct_car_empno.MaxLength = 9;
            this.ct_car_empno.Name = "ct_car_empno";
            this.ct_car_empno.ReadOnly = true;
            this.ct_car_empno.Size = new System.Drawing.Size(100, 21);
            this.ct_car_empno.TabIndex = 1;
            this.ct_car_empno.Tag = "car_empno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "근무처명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "사원번호";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.car_empno,
            this.car_com,
            this.car_region,
            this.car_yyyymm_f,
            this.car_yyyymm_t,
            this.car_pos,
            this.car_dept,
            this.car_reason,
            this.status,
            this.Key1,
            this.Key2});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(534, 259);
            this.dataGridView2.TabIndex = 0;
            // 
            // car_empno
            // 
            this.car_empno.DataPropertyName = "car_empno";
            this.car_empno.HeaderText = "사원번호";
            this.car_empno.Name = "car_empno";
            this.car_empno.ReadOnly = true;
            this.car_empno.Width = 78;
            // 
            // car_com
            // 
            this.car_com.DataPropertyName = "car_com";
            this.car_com.HeaderText = "근무처명";
            this.car_com.Name = "car_com";
            this.car_com.ReadOnly = true;
            this.car_com.Width = 78;
            // 
            // car_region
            // 
            this.car_region.DataPropertyName = "car_region";
            this.car_region.HeaderText = "소재지";
            this.car_region.Name = "car_region";
            this.car_region.ReadOnly = true;
            this.car_region.Width = 66;
            // 
            // car_yyyymm_f
            // 
            this.car_yyyymm_f.DataPropertyName = "car_yyyymm_f";
            this.car_yyyymm_f.HeaderText = "근무시작일";
            this.car_yyyymm_f.Name = "car_yyyymm_f";
            this.car_yyyymm_f.ReadOnly = true;
            this.car_yyyymm_f.Width = 90;
            // 
            // car_yyyymm_t
            // 
            this.car_yyyymm_t.DataPropertyName = "car_yyyymm_t";
            this.car_yyyymm_t.HeaderText = "근무종료일";
            this.car_yyyymm_t.Name = "car_yyyymm_t";
            this.car_yyyymm_t.ReadOnly = true;
            this.car_yyyymm_t.Width = 90;
            // 
            // car_pos
            // 
            this.car_pos.DataPropertyName = "car_pos";
            this.car_pos.HeaderText = "최종직급";
            this.car_pos.Name = "car_pos";
            this.car_pos.ReadOnly = true;
            this.car_pos.Width = 78;
            // 
            // car_dept
            // 
            this.car_dept.DataPropertyName = "car_dept";
            this.car_dept.HeaderText = "담당부서";
            this.car_dept.Name = "car_dept";
            this.car_dept.ReadOnly = true;
            this.car_dept.Width = 78;
            // 
            // car_reason
            // 
            this.car_reason.DataPropertyName = "car_reason";
            this.car_reason.HeaderText = "퇴직/이직사유";
            this.car_reason.Name = "car_reason";
            this.car_reason.ReadOnly = true;
            this.car_reason.Width = 108;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "상태";
            this.status.Name = "status";
            this.status.Visible = false;
            this.status.Width = 54;
            // 
            // Key1
            // 
            this.Key1.HeaderText = "Key1";
            this.Key1.Name = "Key1";
            this.Key1.Visible = false;
            this.Key1.Width = 58;
            // 
            // Key2
            // 
            this.Key2.HeaderText = "Key2";
            this.Key2.Name = "Key2";
            this.Key2.Visible = false;
            this.Key2.Width = 58;
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
            this.dept,
            this.pos});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(540, 585);
            this.dataGridView1.TabIndex = 1;
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
            // dept
            // 
            this.dept.DataPropertyName = "dept";
            this.dept.HeaderText = "부서";
            this.dept.Name = "dept";
            this.dept.ReadOnly = true;
            this.dept.Width = 54;
            // 
            // pos
            // 
            this.pos.DataPropertyName = "pos";
            this.pos.HeaderText = "직급";
            this.pos.Name = "pos";
            this.pos.ReadOnly = true;
            this.pos.Width = 54;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.empnoSearch);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.nameSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1092, 34);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1092, 1);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(168, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 47;
            this.label12.Text = "성명";
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(203, 2);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(100, 21);
            this.nameSearch.TabIndex = 50;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1098, 637);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panData.ResumeLayout(false);
            this.panData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panData;
        private System.Windows.Forms.MaskedTextBox ct_car_yyyymm_t;
        private System.Windows.Forms.MaskedTextBox ct_car_yyyymm_f;
        private System.Windows.Forms.TextBox ct_car_reason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ct_car_dept;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ct_car_pos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ct_car_region;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ct_car_com;
        private System.Windows.Forms.TextBox ct_car_empno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empnoSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox nameSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn bas_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_empno;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_com;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_region;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_yyyymm_f;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_yyyymm_t;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key2;
    }
}
