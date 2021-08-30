
namespace KayMain
{
    partial class ButtonFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_insert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 39);
            this.panel1.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Image = global::KayMain.Properties.Resources.search;
            this.btn_search.Location = new System.Drawing.Point(3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(32, 32);
            this.btn_search.TabIndex = 8;
            this.btn_search.Tag = "BtnSearch_Click";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.Image = global::KayMain.Properties.Resources.print;
            this.btn_print.Location = new System.Drawing.Point(225, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(32, 32);
            this.btn_print.TabIndex = 14;
            this.btn_print.Tag = "BtnPrint_Click";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = global::KayMain.Properties.Resources.exit;
            this.btn_close.Location = new System.Drawing.Point(261, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 32);
            this.btn_close.TabIndex = 15;
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Image = global::KayMain.Properties.Resources.cancel;
            this.btn_cancel.Location = new System.Drawing.Point(188, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(32, 32);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Tag = "BtnCancel_Click";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Image = global::KayMain.Properties.Resources.save;
            this.btn_save.Location = new System.Drawing.Point(151, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(32, 32);
            this.btn_save.TabIndex = 12;
            this.btn_save.Tag = "BtnSave_Click";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Image = global::KayMain.Properties.Resources.delete;
            this.btn_delete.Location = new System.Drawing.Point(114, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(32, 32);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Tag = "BtnDelete_Click";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Image = global::KayMain.Properties.Resources.update;
            this.btn_update.Location = new System.Drawing.Point(77, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(32, 32);
            this.btn_update.TabIndex = 10;
            this.btn_update.Tag = "BtnUpdate_Click";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insert.Image = global::KayMain.Properties.Resources.add;
            this.btn_insert.Location = new System.Drawing.Point(40, 4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(32, 32);
            this.btn_insert.TabIndex = 9;
            this.btn_insert.Tag = "BtnInsert_Click";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // ButtonFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 39);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ButtonFrm";
            this.Text = "ButtonFrm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
    }
}