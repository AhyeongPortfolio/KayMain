
namespace KaySub017
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panData = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.evali_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evali_itemno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evali_item_l = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evali_item_s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evali_points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evali_gap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.qt_evali_item_l = new System.Windows.Forms.TextBox();
            this.qt_evali_item_s = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ct_evali_itemno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ct_evali_item_l = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ct_evali_item_s = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ct_evali_points = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ct_evali_gap = new System.Windows.Forms.TextBox();
            this.ct_evali_type = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panData.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1073, 637);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.panData, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1067, 591);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panData
            // 
            this.panData.Controls.Add(this.ct_evali_type);
            this.panData.Controls.Add(this.label8);
            this.panData.Controls.Add(this.ct_evali_gap);
            this.panData.Controls.Add(this.label7);
            this.panData.Controls.Add(this.ct_evali_points);
            this.panData.Controls.Add(this.label6);
            this.panData.Controls.Add(this.ct_evali_item_s);
            this.panData.Controls.Add(this.label5);
            this.panData.Controls.Add(this.ct_evali_item_l);
            this.panData.Controls.Add(this.label4);
            this.panData.Controls.Add(this.ct_evali_itemno);
            this.panData.Controls.Add(this.label3);
            this.panData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panData.Location = new System.Drawing.Point(749, 3);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(315, 585);
            this.panData.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.qt_evali_item_s);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.qt_evali_item_l);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 34);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 1);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evali_type,
            this.evali_itemno,
            this.evali_item_l,
            this.evali_item_s,
            this.evali_points,
            this.evali_gap});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(740, 585);
            this.dataGridView1.TabIndex = 1;
            // 
            // evali_type
            // 
            this.evali_type.DataPropertyName = "evali_type";
            this.evali_type.HeaderText = "평가표 유형";
            this.evali_type.Name = "evali_type";
            this.evali_type.Width = 96;
            // 
            // evali_itemno
            // 
            this.evali_itemno.DataPropertyName = "evali_itemno";
            this.evali_itemno.HeaderText = "항목번호";
            this.evali_itemno.Name = "evali_itemno";
            this.evali_itemno.Width = 80;
            // 
            // evali_item_l
            // 
            this.evali_item_l.DataPropertyName = "evali_item_l";
            this.evali_item_l.HeaderText = "대항목";
            this.evali_item_l.Name = "evali_item_l";
            this.evali_item_l.Width = 68;
            // 
            // evali_item_s
            // 
            this.evali_item_s.DataPropertyName = "evali_item_s";
            this.evali_item_s.HeaderText = "소항목";
            this.evali_item_s.Name = "evali_item_s";
            this.evali_item_s.Width = 68;
            // 
            // evali_points
            // 
            this.evali_points.DataPropertyName = "evali_points";
            this.evali_points.HeaderText = "배점";
            this.evali_points.Name = "evali_points";
            this.evali_points.Width = 56;
            // 
            // evali_gap
            // 
            this.evali_gap.DataPropertyName = "evali_gap";
            this.evali_gap.HeaderText = "평점간격";
            this.evali_gap.Name = "evali_gap";
            this.evali_gap.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "대항목";
            // 
            // qt_evali_item_l
            // 
            this.qt_evali_item_l.Location = new System.Drawing.Point(52, 5);
            this.qt_evali_item_l.Name = "qt_evali_item_l";
            this.qt_evali_item_l.Size = new System.Drawing.Size(100, 23);
            this.qt_evali_item_l.TabIndex = 2;
            // 
            // qt_evali_item_s
            // 
            this.qt_evali_item_s.Location = new System.Drawing.Point(207, 5);
            this.qt_evali_item_s.Name = "qt_evali_item_s";
            this.qt_evali_item_s.Size = new System.Drawing.Size(100, 23);
            this.qt_evali_item_s.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "소항목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "평가표 유형";
            // 
            // ct_evali_itemno
            // 
            this.ct_evali_itemno.Location = new System.Drawing.Point(87, 33);
            this.ct_evali_itemno.Name = "ct_evali_itemno";
            this.ct_evali_itemno.Size = new System.Drawing.Size(196, 23);
            this.ct_evali_itemno.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "항목번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "대항목";
            // 
            // ct_evali_item_l
            // 
            this.ct_evali_item_l.Location = new System.Drawing.Point(87, 59);
            this.ct_evali_item_l.Name = "ct_evali_item_l";
            this.ct_evali_item_l.Size = new System.Drawing.Size(196, 23);
            this.ct_evali_item_l.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "소항목";
            // 
            // ct_evali_item_s
            // 
            this.ct_evali_item_s.Location = new System.Drawing.Point(87, 85);
            this.ct_evali_item_s.Multiline = true;
            this.ct_evali_item_s.Name = "ct_evali_item_s";
            this.ct_evali_item_s.Size = new System.Drawing.Size(196, 35);
            this.ct_evali_item_s.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "배점";
            // 
            // ct_evali_points
            // 
            this.ct_evali_points.Location = new System.Drawing.Point(87, 123);
            this.ct_evali_points.Name = "ct_evali_points";
            this.ct_evali_points.Size = new System.Drawing.Size(196, 23);
            this.ct_evali_points.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "평점간격";
            // 
            // ct_evali_gap
            // 
            this.ct_evali_gap.Location = new System.Drawing.Point(87, 149);
            this.ct_evali_gap.Name = "ct_evali_gap";
            this.ct_evali_gap.Size = new System.Drawing.Size(196, 23);
            this.ct_evali_gap.TabIndex = 10;
            // 
            // ct_evali_type
            // 
            this.ct_evali_type.FormattingEnabled = true;
            this.ct_evali_type.Location = new System.Drawing.Point(87, 7);
            this.ct_evali_type.Name = "ct_evali_type";
            this.ct_evali_type.Size = new System.Drawing.Size(196, 23);
            this.ct_evali_type.TabIndex = 12;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1073, 637);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panData.ResumeLayout(false);
            this.panData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_itemno;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_item_l;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_item_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_points;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_gap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ct_evali_itemno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qt_evali_item_s;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox qt_evali_item_l;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ct_evali_gap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ct_evali_points;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ct_evali_item_s;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ct_evali_item_l;
        private System.Windows.Forms.ComboBox ct_evali_type;
    }
}
