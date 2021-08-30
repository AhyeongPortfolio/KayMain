namespace KaySub001
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
            this.Rwud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_grpcd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_grpnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_digit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_use = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdg_kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.grpYN = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kindBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.digitBox = new System.Windows.Forms.TextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.grpnmBox = new System.Windows.Forms.TextBox();
            this.grpcdBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cdgGrpcd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cdgUse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cdgKind = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.cdgName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(931, 634);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(925, 588);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rwud,
            this.cdg_grpcd,
            this.cdg_grpnm,
            this.cdg_digit,
            this.cdg_length,
            this.cdg_use,
            this.cdg_kind});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(619, 582);
            this.dataGridView1.TabIndex = 0;
            // 
            // Rwud
            // 
            this.Rwud.DataPropertyName = "Rwud";
            this.Rwud.HeaderText = "상태";
            this.Rwud.Name = "Rwud";
            this.Rwud.Width = 54;
            // 
            // cdg_grpcd
            // 
            this.cdg_grpcd.DataPropertyName = "cdg_grpcd";
            this.cdg_grpcd.HeaderText = "그룹코드";
            this.cdg_grpcd.Name = "cdg_grpcd";
            this.cdg_grpcd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cdg_grpcd.Width = 78;
            // 
            // cdg_grpnm
            // 
            this.cdg_grpnm.DataPropertyName = "cdg_grpnm";
            this.cdg_grpnm.HeaderText = "그룹코드명";
            this.cdg_grpnm.Name = "cdg_grpnm";
            this.cdg_grpnm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cdg_grpnm.Width = 90;
            // 
            // cdg_digit
            // 
            this.cdg_digit.DataPropertyName = "cdg_digit";
            this.cdg_digit.HeaderText = "단위코드 자리수";
            this.cdg_digit.Name = "cdg_digit";
            this.cdg_digit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cdg_digit.Width = 118;
            // 
            // cdg_length
            // 
            this.cdg_length.DataPropertyName = "cdg_length";
            this.cdg_length.HeaderText = "단위코드명 길이";
            this.cdg_length.Name = "cdg_length";
            this.cdg_length.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cdg_length.Width = 118;
            // 
            // cdg_use
            // 
            this.cdg_use.DataPropertyName = "cdg_use";
            this.cdg_use.HeaderText = "사용여부";
            this.cdg_use.Name = "cdg_use";
            this.cdg_use.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cdg_use.Width = 78;
            // 
            // cdg_kind
            // 
            this.cdg_kind.DataPropertyName = "cdg_kind";
            this.cdg_kind.HeaderText = "분류";
            this.cdg_kind.Name = "cdg_kind";
            this.cdg_kind.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cdg_kind.Width = 54;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.grpYN);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.kindBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.digitBox);
            this.panel1.Controls.Add(this.lengthBox);
            this.panel1.Controls.Add(this.grpnmBox);
            this.panel1.Controls.Add(this.grpcdBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(628, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 582);
            this.panel1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 43;
            this.label8.Text = "사용여부";
            // 
            // grpYN
            // 
            this.grpYN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grpYN.FormattingEnabled = true;
            this.grpYN.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.grpYN.Location = new System.Drawing.Point(136, 122);
            this.grpYN.Name = "grpYN";
            this.grpYN.Size = new System.Drawing.Size(139, 20);
            this.grpYN.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 581);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 1);
            this.panel3.TabIndex = 41;
            // 
            // kindBox
            // 
            this.kindBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kindBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kindBox.FormattingEnabled = true;
            this.kindBox.Items.AddRange(new object[] {
            "학사행정",
            "일반행정"});
            this.kindBox.Location = new System.Drawing.Point(136, 51);
            this.kindBox.Name = "kindBox";
            this.kindBox.Size = new System.Drawing.Size(139, 20);
            this.kindBox.TabIndex = 13;
            this.kindBox.Tag = "cdg_kind";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(101, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 40;
            this.label11.Text = "분류";
            // 
            // digitBox
            // 
            this.digitBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.digitBox.Location = new System.Drawing.Point(136, 74);
            this.digitBox.MaxLength = 2;
            this.digitBox.Name = "digitBox";
            this.digitBox.Size = new System.Drawing.Size(139, 21);
            this.digitBox.TabIndex = 14;
            this.digitBox.Tag = "cdg_length";
            // 
            // lengthBox
            // 
            this.lengthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lengthBox.Location = new System.Drawing.Point(136, 98);
            this.lengthBox.MaxLength = 2;
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(139, 21);
            this.lengthBox.TabIndex = 15;
            this.lengthBox.Tag = "cdg_digit";
            // 
            // grpnmBox
            // 
            this.grpnmBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpnmBox.Location = new System.Drawing.Point(136, 27);
            this.grpnmBox.MaxLength = 30;
            this.grpnmBox.Name = "grpnmBox";
            this.grpnmBox.Size = new System.Drawing.Size(139, 21);
            this.grpnmBox.TabIndex = 11;
            this.grpnmBox.Tag = "cdg_grpnm";
            // 
            // grpcdBox
            // 
            this.grpcdBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpcdBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.grpcdBox.Location = new System.Drawing.Point(136, 3);
            this.grpcdBox.MaxLength = 3;
            this.grpcdBox.Name = "grpcdBox";
            this.grpcdBox.Size = new System.Drawing.Size(139, 21);
            this.grpcdBox.TabIndex = 1;
            this.grpcdBox.Tag = "cdg_grpcd";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "단위코드 자리수";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "단위코드명(원형) 길이";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "그룹코드명";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "그룹코드";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cdgGrpcd);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cdgUse);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cdgKind);
            this.panel4.Controls.Add(this.label34);
            this.panel4.Controls.Add(this.cdgName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(925, 34);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(925, 1);
            this.panel5.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 50;
            this.label1.Text = "그룹코드";
            // 
            // cdgGrpcd
            // 
            this.cdgGrpcd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cdgGrpcd.Location = new System.Drawing.Point(62, 3);
            this.cdgGrpcd.Name = "cdgGrpcd";
            this.cdgGrpcd.Size = new System.Drawing.Size(100, 21);
            this.cdgGrpcd.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 44;
            this.label2.Text = "사용여부";
            // 
            // cdgUse
            // 
            this.cdgUse.FormattingEnabled = true;
            this.cdgUse.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cdgUse.Location = new System.Drawing.Point(227, 3);
            this.cdgUse.Name = "cdgUse";
            this.cdgUse.Size = new System.Drawing.Size(100, 20);
            this.cdgUse.TabIndex = 47;
            this.cdgUse.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 45;
            this.label3.Text = "분류";
            // 
            // cdgKind
            // 
            this.cdgKind.FormattingEnabled = true;
            this.cdgKind.Items.AddRange(new object[] {
            "학사행정",
            "일반행정"});
            this.cdgKind.Location = new System.Drawing.Point(368, 3);
            this.cdgKind.Name = "cdgKind";
            this.cdgKind.Size = new System.Drawing.Size(100, 20);
            this.cdgKind.TabIndex = 48;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(474, 7);
            this.label34.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(65, 12);
            this.label34.TabIndex = 46;
            this.label34.Text = "그룹코드명";
            // 
            // cdgName
            // 
            this.cdgName.Location = new System.Drawing.Point(545, 3);
            this.cdgName.Name = "cdgName";
            this.cdgName.Size = new System.Drawing.Size(100, 21);
            this.cdgName.TabIndex = 49;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(931, 634);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rwud;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_grpcd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_grpnm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_digit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_use;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdg_kind;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox grpYN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox kindBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox digitBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox grpnmBox;
        private System.Windows.Forms.TextBox grpcdBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cdgGrpcd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cdgUse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cdgKind;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox cdgName;
    }
}
