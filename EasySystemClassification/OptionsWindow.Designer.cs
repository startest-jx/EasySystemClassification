namespace EasySystemClassification
{
    partial class OptionsWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtImportCodeRegex = new System.Windows.Forms.TextBox();
            this.txtImportNameRegex = new System.Windows.Forms.TextBox();
            this.txtImportStartColumn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImportStartRow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtExportFormat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExportStartColumn = new System.Windows.Forms.TextBox();
            this.txtExportStartRow = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始行数:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "名称正则:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtImportCodeRegex);
            this.groupBox1.Controls.Add(this.txtImportNameRegex);
            this.groupBox1.Controls.Add(this.txtImportStartColumn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtImportStartRow);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导入配置";
            // 
            // txtImportCodeRegex
            // 
            this.txtImportCodeRegex.Location = new System.Drawing.Point(87, 113);
            this.txtImportCodeRegex.Name = "txtImportCodeRegex";
            this.txtImportCodeRegex.Size = new System.Drawing.Size(107, 21);
            this.txtImportCodeRegex.TabIndex = 1;
            // 
            // txtImportNameRegex
            // 
            this.txtImportNameRegex.Location = new System.Drawing.Point(87, 83);
            this.txtImportNameRegex.Name = "txtImportNameRegex";
            this.txtImportNameRegex.Size = new System.Drawing.Size(107, 21);
            this.txtImportNameRegex.TabIndex = 1;
            // 
            // txtImportStartColumn
            // 
            this.txtImportStartColumn.Location = new System.Drawing.Point(87, 53);
            this.txtImportStartColumn.Name = "txtImportStartColumn";
            this.txtImportStartColumn.Size = new System.Drawing.Size(107, 21);
            this.txtImportStartColumn.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "开始列数:";
            // 
            // txtImportStartRow
            // 
            this.txtImportStartRow.Location = new System.Drawing.Point(87, 23);
            this.txtImportStartRow.Name = "txtImportStartRow";
            this.txtImportStartRow.Size = new System.Drawing.Size(107, 21);
            this.txtImportStartRow.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "编码正则:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtExportFormat);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtExportStartColumn);
            this.groupBox2.Controls.Add(this.txtExportStartRow);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(0, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 122);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "导出配置";
            // 
            // txtExportFormat
            // 
            this.txtExportFormat.Location = new System.Drawing.Point(87, 83);
            this.txtExportFormat.Name = "txtExportFormat";
            this.txtExportFormat.Size = new System.Drawing.Size(107, 21);
            this.txtExportFormat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "导出格式化:";
            // 
            // txtExportStartColumn
            // 
            this.txtExportStartColumn.Location = new System.Drawing.Point(87, 53);
            this.txtExportStartColumn.Name = "txtExportStartColumn";
            this.txtExportStartColumn.Size = new System.Drawing.Size(107, 21);
            this.txtExportStartColumn.TabIndex = 1;
            // 
            // txtExportStartRow
            // 
            this.txtExportStartRow.Location = new System.Drawing.Point(87, 23);
            this.txtExportStartRow.Name = "txtExportStartRow";
            this.txtExportStartRow.Size = new System.Drawing.Size(107, 21);
            this.txtExportStartRow.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "开始行数:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "开始行数:";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(11, 320);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "确定";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.SaveOption);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(119, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.CloseOption);
            // 
            // OptionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 355);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsWindow";
            this.Text = "选项";
            this.Load += new System.EventHandler(this.OptionsWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtImportCodeRegex;
        private System.Windows.Forms.TextBox txtImportNameRegex;
        private System.Windows.Forms.TextBox txtImportStartRow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtExportFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExportStartRow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtImportStartColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExportStartColumn;
        private System.Windows.Forms.Label label7;
    }
}