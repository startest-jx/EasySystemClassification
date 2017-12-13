namespace EasySystemClassification
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miImport = new System.Windows.Forms.ToolStripMenuItem();
            this.miExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewChildCatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewBrotherCatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.miUpdateCatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteCatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.miOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCatalog = new System.Windows.Forms.GroupBox();
            this.trCatalog = new System.Windows.Forms.TreeView();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteCatalog = new System.Windows.Forms.Button();
            this.btnNewBrotherCatalog = new System.Windows.Forms.Button();
            this.btnNewChildCatalog = new System.Windows.Forms.Button();
            this.btnUpdateCatalog = new System.Windows.Forms.Button();
            this.txtCatalogLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParentCatalog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCatalogName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSheets = new System.Windows.Forms.ComboBox();
            this.btnPrevious = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.txtWholeCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbOperator = new System.Windows.Forms.GroupBox();
            this.picBarCode = new System.Windows.Forms.PictureBox();
            this.bgwLoad = new System.ComponentModel.BackgroundWorker();
            this.bgwSave = new System.ComponentModel.BackgroundWorker();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.gbCatalog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.btnPrevious.SuspendLayout();
            this.gbDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbOperator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miImport,
            this.miExport,
            this.toolStripMenuItem1,
            this.miClose,
            this.toolStripMenuItem2,
            this.miExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(58, 21);
            this.mnuFile.Text = "文件(&F)";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(152, 22);
            this.miNew.Text = "新建(&N)";
            this.miNew.Click += new System.EventHandler(this.NewFile);
            // 
            // miImport
            // 
            this.miImport.Name = "miImport";
            this.miImport.Size = new System.Drawing.Size(152, 22);
            this.miImport.Text = "导入(&I)";
            this.miImport.Click += new System.EventHandler(this.ImportFile);
            // 
            // miExport
            // 
            this.miExport.Name = "miExport";
            this.miExport.Size = new System.Drawing.Size(152, 22);
            this.miExport.Text = "导出(&O)";
            this.miExport.Click += new System.EventHandler(this.ExportFile);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // miClose
            // 
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(152, 22);
            this.miClose.Text = "关闭(&C)";
            this.miClose.Click += new System.EventHandler(this.CloseFile);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(152, 22);
            this.miExit.Text = "退出(&X)";
            this.miExit.Click += new System.EventHandler(this.Exit);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewChildCatalog,
            this.miNewBrotherCatalog,
            this.miUpdateCatalog,
            this.miDeleteCatalog});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(59, 21);
            this.mnuEdit.Text = "编辑(&E)";
            // 
            // miNewChildCatalog
            // 
            this.miNewChildCatalog.Name = "miNewChildCatalog";
            this.miNewChildCatalog.Size = new System.Drawing.Size(164, 22);
            this.miNewChildCatalog.Text = "新增子目录(&C)";
            this.miNewChildCatalog.Click += new System.EventHandler(this.NewChildCatalog);
            // 
            // miNewBrotherCatalog
            // 
            this.miNewBrotherCatalog.Name = "miNewBrotherCatalog";
            this.miNewBrotherCatalog.Size = new System.Drawing.Size(164, 22);
            this.miNewBrotherCatalog.Text = "新增同级目录(&B)";
            this.miNewBrotherCatalog.Click += new System.EventHandler(this.NewBrotherCatalog);
            // 
            // miUpdateCatalog
            // 
            this.miUpdateCatalog.Name = "miUpdateCatalog";
            this.miUpdateCatalog.Size = new System.Drawing.Size(164, 22);
            this.miUpdateCatalog.Text = "更新目录(&U)";
            this.miUpdateCatalog.Click += new System.EventHandler(this.UpdateCatalog);
            // 
            // miDeleteCatalog
            // 
            this.miDeleteCatalog.Name = "miDeleteCatalog";
            this.miDeleteCatalog.Size = new System.Drawing.Size(164, 22);
            this.miDeleteCatalog.Text = "删除目录(&D)";
            this.miDeleteCatalog.Click += new System.EventHandler(this.DeleteCatalog);
            // 
            // mnuTool
            // 
            this.mnuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOptions});
            this.mnuTool.Name = "mnuTool";
            this.mnuTool.Size = new System.Drawing.Size(59, 21);
            this.mnuTool.Text = "工具(&T)";
            // 
            // miOptions
            // 
            this.miOptions.Name = "miOptions";
            this.miOptions.Size = new System.Drawing.Size(118, 22);
            this.miOptions.Text = "选项(&O)";
            this.miOptions.Click += new System.EventHandler(this.OpenOptions);
            // 
            // gbCatalog
            // 
            this.gbCatalog.Controls.Add(this.trCatalog);
            this.gbCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCatalog.Location = new System.Drawing.Point(0, 0);
            this.gbCatalog.Name = "gbCatalog";
            this.gbCatalog.Size = new System.Drawing.Size(712, 496);
            this.gbCatalog.TabIndex = 1;
            this.gbCatalog.TabStop = false;
            this.gbCatalog.Text = "分类目录";
            // 
            // trCatalog
            // 
            this.trCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trCatalog.Location = new System.Drawing.Point(3, 17);
            this.trCatalog.Name = "trCatalog";
            this.trCatalog.Size = new System.Drawing.Size(706, 476);
            this.trCatalog.TabIndex = 0;
            this.trCatalog.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CheckCatalog);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(83, 53);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(173, 21);
            this.txtCode.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "物料编码:";
            // 
            // btnDeleteCatalog
            // 
            this.btnDeleteCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteCatalog.Location = new System.Drawing.Point(143, 326);
            this.btnDeleteCatalog.Name = "btnDeleteCatalog";
            this.btnDeleteCatalog.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteCatalog.TabIndex = 10;
            this.btnDeleteCatalog.Text = "删除目录(&D)";
            this.btnDeleteCatalog.UseVisualStyleBackColor = true;
            this.btnDeleteCatalog.Click += new System.EventHandler(this.DeleteCatalog);
            // 
            // btnNewBrotherCatalog
            // 
            this.btnNewBrotherCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewBrotherCatalog.Location = new System.Drawing.Point(143, 297);
            this.btnNewBrotherCatalog.Name = "btnNewBrotherCatalog";
            this.btnNewBrotherCatalog.Size = new System.Drawing.Size(113, 23);
            this.btnNewBrotherCatalog.TabIndex = 9;
            this.btnNewBrotherCatalog.Text = "新增同级目录(&B)";
            this.btnNewBrotherCatalog.UseVisualStyleBackColor = true;
            this.btnNewBrotherCatalog.Click += new System.EventHandler(this.NewBrotherCatalog);
            // 
            // btnNewChildCatalog
            // 
            this.btnNewChildCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewChildCatalog.Location = new System.Drawing.Point(20, 297);
            this.btnNewChildCatalog.Name = "btnNewChildCatalog";
            this.btnNewChildCatalog.Size = new System.Drawing.Size(113, 23);
            this.btnNewChildCatalog.TabIndex = 8;
            this.btnNewChildCatalog.Text = "新增子目录(&C)";
            this.btnNewChildCatalog.UseVisualStyleBackColor = true;
            this.btnNewChildCatalog.ClientSizeChanged += new System.EventHandler(this.NewChildCatalog);
            this.btnNewChildCatalog.Click += new System.EventHandler(this.NewChildCatalog);
            // 
            // btnUpdateCatalog
            // 
            this.btnUpdateCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateCatalog.Location = new System.Drawing.Point(20, 326);
            this.btnUpdateCatalog.Name = "btnUpdateCatalog";
            this.btnUpdateCatalog.Size = new System.Drawing.Size(113, 23);
            this.btnUpdateCatalog.TabIndex = 6;
            this.btnUpdateCatalog.Text = "更新目录(&U)";
            this.btnUpdateCatalog.UseVisualStyleBackColor = true;
            this.btnUpdateCatalog.Click += new System.EventHandler(this.UpdateCatalog);
            // 
            // txtCatalogLevel
            // 
            this.txtCatalogLevel.Location = new System.Drawing.Point(83, 113);
            this.txtCatalogLevel.Name = "txtCatalogLevel";
            this.txtCatalogLevel.ReadOnly = true;
            this.txtCatalogLevel.Size = new System.Drawing.Size(173, 21);
            this.txtCatalogLevel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "目录等级:";
            // 
            // txtParentCatalog
            // 
            this.txtParentCatalog.Location = new System.Drawing.Point(83, 143);
            this.txtParentCatalog.Name = "txtParentCatalog";
            this.txtParentCatalog.ReadOnly = true;
            this.txtParentCatalog.Size = new System.Drawing.Size(173, 21);
            this.txtParentCatalog.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "父级目录:";
            // 
            // txtCatalogName
            // 
            this.txtCatalogName.Location = new System.Drawing.Point(83, 23);
            this.txtCatalogName.Name = "txtCatalogName";
            this.txtCatalogName.Size = new System.Drawing.Size(173, 21);
            this.txtCatalogName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "目录名称:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSheets);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工作表";
            // 
            // cbSheets
            // 
            this.cbSheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSheets.FormattingEnabled = true;
            this.cbSheets.Location = new System.Drawing.Point(6, 19);
            this.cbSheets.Name = "cbSheets";
            this.cbSheets.Size = new System.Drawing.Size(267, 20);
            this.cbSheets.TabIndex = 1;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Controls.Add(this.button2);
            this.btnPrevious.Controls.Add(this.btnNext);
            this.btnPrevious.Controls.Add(this.txtSearch);
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrevious.Location = new System.Drawing.Point(3, 17);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(280, 57);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "查找目录";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "上一个";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SearchPrevious);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(149, 17);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(59, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一个";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.SearchNext);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(137, 21);
            this.txtSearch.TabIndex = 0;
            // 
            // gbDetail
            // 
            this.gbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbDetail.Controls.Add(this.picBarCode);
            this.gbDetail.Controls.Add(this.txtWholeCode);
            this.gbDetail.Controls.Add(this.txtCode);
            this.gbDetail.Controls.Add(this.btnNewChildCatalog);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.label3);
            this.gbDetail.Controls.Add(this.label1);
            this.gbDetail.Controls.Add(this.btnDeleteCatalog);
            this.gbDetail.Controls.Add(this.txtCatalogName);
            this.gbDetail.Controls.Add(this.btnNewBrotherCatalog);
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Controls.Add(this.txtParentCatalog);
            this.gbDetail.Controls.Add(this.btnUpdateCatalog);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Controls.Add(this.txtCatalogLevel);
            this.gbDetail.Location = new System.Drawing.Point(3, 134);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(283, 359);
            this.gbDetail.TabIndex = 13;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "目录详情";
            // 
            // txtWholeCode
            // 
            this.txtWholeCode.Location = new System.Drawing.Point(83, 83);
            this.txtWholeCode.Name = "txtWholeCode";
            this.txtWholeCode.ReadOnly = true;
            this.txtWholeCode.Size = new System.Drawing.Size(173, 21);
            this.txtWholeCode.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "总编码:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gbCatalog);
            this.panel1.Location = new System.Drawing.Point(287, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 496);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.gbOperator);
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 496);
            this.panel2.TabIndex = 4;
            // 
            // gbOperator
            // 
            this.gbOperator.Controls.Add(this.gbDetail);
            this.gbOperator.Controls.Add(this.groupBox1);
            this.gbOperator.Controls.Add(this.btnPrevious);
            this.gbOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOperator.Location = new System.Drawing.Point(0, 0);
            this.gbOperator.Name = "gbOperator";
            this.gbOperator.Size = new System.Drawing.Size(286, 496);
            this.gbOperator.TabIndex = 1;
            this.gbOperator.TabStop = false;
            this.gbOperator.Text = "操作";
            // 
            // picBarCode
            // 
            this.picBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBarCode.Location = new System.Drawing.Point(20, 184);
            this.picBarCode.Name = "picBarCode";
            this.picBarCode.Size = new System.Drawing.Size(236, 98);
            this.picBarCode.TabIndex = 13;
            this.picBarCode.TabStop = false;
            // 
            // ssStatus
            // 
            this.ssStatus.Location = new System.Drawing.Point(0, 524);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(999, 22);
            this.ssStatus.TabIndex = 5;
            this.ssStatus.Text = "statusStrip1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 546);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "MainWindow";
            this.Text = "体系分类快速工具";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbCatalog.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.btnPrevious.ResumeLayout(false);
            this.btnPrevious.PerformLayout();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbOperator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBarCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripMenuItem miImport;
        private System.Windows.Forms.ToolStripMenuItem miExport;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miClose;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem miNewChildCatalog;
        private System.Windows.Forms.ToolStripMenuItem miUpdateCatalog;
        private System.Windows.Forms.ToolStripMenuItem miDeleteCatalog;
        private System.Windows.Forms.ToolStripMenuItem mnuTool;
        private System.Windows.Forms.ToolStripMenuItem miOptions;
        private System.Windows.Forms.GroupBox gbCatalog;
        private System.Windows.Forms.TreeView trCatalog;
        private System.Windows.Forms.TextBox txtParentCatalog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCatalogName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCatalogLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSheets;
        private System.Windows.Forms.ToolStripMenuItem miNewBrotherCatalog;
        private System.Windows.Forms.Button btnUpdateCatalog;
        private System.Windows.Forms.Button btnDeleteCatalog;
        private System.Windows.Forms.Button btnNewBrotherCatalog;
        private System.Windows.Forms.Button btnNewChildCatalog;
        private System.Windows.Forms.GroupBox btnPrevious;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbOperator;
        private System.Windows.Forms.TextBox txtWholeCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBarCode;
        private System.ComponentModel.BackgroundWorker bgwLoad;
        private System.ComponentModel.BackgroundWorker bgwSave;
        private System.Windows.Forms.StatusStrip ssStatus;
    }
}

