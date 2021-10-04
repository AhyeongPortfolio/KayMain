
namespace KaySub016
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panData = new System.Windows.Forms.Panel();
            this.ct_evali_type = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ct_evali_gap = new System.Windows.Forms.TextBox();
            this.ct_evali_points = new System.Windows.Forms.TextBox();
            this.ct_evali_item_s = new System.Windows.Forms.TextBox();
            this.ct_evali_item_l = new System.Windows.Forms.TextBox();
            this.ct_evali_itemno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.evali_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evali_itemno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evali_item_l = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evali_item_s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evali_points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evali_gap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.qt_evali_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 637);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1044, 591);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panData
            // 
            this.panData.Controls.Add(this.ct_evali_type);
            this.panData.Controls.Add(this.label9);
            this.panData.Controls.Add(this.label8);
            this.panData.Controls.Add(this.ct_evali_gap);
            this.panData.Controls.Add(this.ct_evali_points);
            this.panData.Controls.Add(this.ct_evali_item_s);
            this.panData.Controls.Add(this.ct_evali_item_l);
            this.panData.Controls.Add(this.ct_evali_itemno);
            this.panData.Controls.Add(this.label5);
            this.panData.Controls.Add(this.label6);
            this.panData.Controls.Add(this.label4);
            this.panData.Controls.Add(this.label3);
            this.panData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panData.Location = new System.Drawing.Point(733, 3);
            this.panData.Name = "panData";
            this.panData.Size = new System.Drawing.Size(308, 585);
            this.panData.TabIndex = 0;
            // 
            // ct_evali_type
            // 
            this.ct_evali_type.Location = new System.Drawing.Point(87, 11);
            this.ct_evali_type.Name = "ct_evali_type";
            this.ct_evali_type.Size = new System.Drawing.Size(206, 21);
            this.ct_evali_type.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "평점간격";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "배점";
            // 
            // ct_evali_gap
            // 
            this.ct_evali_gap.Location = new System.Drawing.Point(87, 135);
            this.ct_evali_gap.Name = "ct_evali_gap";
            this.ct_evali_gap.Size = new System.Drawing.Size(206, 21);
            this.ct_evali_gap.TabIndex = 14;
            // 
            // ct_evali_points
            // 
            this.ct_evali_points.Location = new System.Drawing.Point(87, 110);
            this.ct_evali_points.Name = "ct_evali_points";
            this.ct_evali_points.Size = new System.Drawing.Size(206, 21);
            this.ct_evali_points.TabIndex = 13;
            // 
            // ct_evali_item_s
            // 
            this.ct_evali_item_s.Location = new System.Drawing.Point(87, 85);
            this.ct_evali_item_s.Name = "ct_evali_item_s";
            this.ct_evali_item_s.Size = new System.Drawing.Size(206, 21);
            this.ct_evali_item_s.TabIndex = 12;
            // 
            // ct_evali_item_l
            // 
            this.ct_evali_item_l.Location = new System.Drawing.Point(87, 60);
            this.ct_evali_item_l.Name = "ct_evali_item_l";
            this.ct_evali_item_l.Size = new System.Drawing.Size(206, 21);
            this.ct_evali_item_l.TabIndex = 11;
            // 
            // ct_evali_itemno
            // 
            this.ct_evali_itemno.Location = new System.Drawing.Point(87, 35);
            this.ct_evali_itemno.Name = "ct_evali_itemno";
            this.ct_evali_itemno.Size = new System.Drawing.Size(206, 21);
            this.ct_evali_itemno.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "소항목";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "대항목";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "항목번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "평가표 유형";
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evali_type,
            this.evali_itemno,
            this.evali_item_l,
            this.evali_item_s,
            this.evali_points,
            this.evali_gap,
            this.status,
            this.Key1,
            this.Key2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(724, 585);
            this.dataGridView1.TabIndex = 1;
            // 
            // evali_type
            // 
            this.evali_type.DataPropertyName = "evali_type";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.evali_type.DefaultCellStyle = dataGridViewCellStyle1;
            this.evali_type.HeaderText = "평가표 유형";
            this.evali_type.Name = "evali_type";
            this.evali_type.Width = 94;
            // 
            // evali_itemno
            // 
            this.evali_itemno.DataPropertyName = "evali_itemno";
            this.evali_itemno.HeaderText = "항목번호";
            this.evali_itemno.Name = "evali_itemno";
            this.evali_itemno.Width = 78;
            // 
            // evali_item_l
            // 
            this.evali_item_l.DataPropertyName = "evali_item_l";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.evali_item_l.DefaultCellStyle = dataGridViewCellStyle2;
            this.evali_item_l.HeaderText = "대항목";
            this.evali_item_l.Name = "evali_item_l";
            this.evali_item_l.Width = 66;
            // 
            // evali_item_s
            // 
            this.evali_item_s.DataPropertyName = "evali_item_s";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.evali_item_s.DefaultCellStyle = dataGridViewCellStyle3;
            this.evali_item_s.HeaderText = "소항목";
            this.evali_item_s.Name = "evali_item_s";
            this.evali_item_s.Width = 66;
            // 
            // evali_points
            // 
            this.evali_points.DataPropertyName = "evali_points";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.evali_points.DefaultCellStyle = dataGridViewCellStyle4;
            this.evali_points.HeaderText = "배점";
            this.evali_points.Name = "evali_points";
            this.evali_points.Width = 54;
            // 
            // evali_gap
            // 
            this.evali_gap.DataPropertyName = "evali_gap";
            this.evali_gap.HeaderText = "평점간격";
            this.evali_gap.Name = "evali_gap";
            this.evali_gap.Width = 78;
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
            this.Key1.DataPropertyName = "Key1";
            this.Key1.HeaderText = "Key1";
            this.Key1.Name = "Key1";
            this.Key1.Visible = false;
            this.Key1.Width = 58;
            // 
            // Key2
            // 
            this.Key2.DataPropertyName = "Key2";
            this.Key2.HeaderText = "Key2";
            this.Key2.Name = "Key2";
            this.Key2.Visible = false;
            this.Key2.Width = 58;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.qt_evali_type);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 34);
            this.panel2.TabIndex = 1;
            // 
            // qt_evali_type
            // 
            this.qt_evali_type.FormattingEnabled = true;
            this.qt_evali_type.Location = new System.Drawing.Point(78, 6);
            this.qt_evali_type.Name = "qt_evali_type";
            this.qt_evali_type.Size = new System.Drawing.Size(100, 20);
            this.qt_evali_type.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "평가표 유형";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1044, 1);
            this.panel3.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1050, 637);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panData.ResumeLayout(false);
            this.panData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panData;
        private System.Windows.Forms.TextBox ct_evali_type;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ct_evali_gap;
        private System.Windows.Forms.TextBox ct_evali_points;
        private System.Windows.Forms.TextBox ct_evali_item_s;
        private System.Windows.Forms.TextBox ct_evali_item_l;
        private System.Windows.Forms.TextBox ct_evali_itemno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_itemno;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_item_l;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_item_s;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_points;
        private System.Windows.Forms.DataGridViewTextBoxColumn evali_gap;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox qt_evali_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
