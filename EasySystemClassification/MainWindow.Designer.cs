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
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.miMoveCatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.查询SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.miOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.gbCatalog = new System.Windows.Forms.GroupBox();
            this.trCatalog = new System.Windows.Forms.TreeView();
            this.gbDetail = new System.Windows.Forms.GroupBox();
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
            this.btnSheetRename = new System.Windows.Forms.Button();
            this.cbSheets = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.gbCatalog.SuspendLayout();
            this.gbDetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(763, 25);
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
            this.miNew.Size = new System.Drawing.Size(118, 22);
            this.miNew.Text = "新建(&N)";
            this.miNew.Click += new System.EventHandler(this.NewFile);
            // 
            // miImport
            // 
            this.miImport.Name = "miImport";
            this.miImport.Size = new System.Drawing.Size(118, 22);
            this.miImport.Text = "导入(&I)";
            this.miImport.Click += new System.EventHandler(this.ImportFile);
            // 
            // miExport
            // 
            this.miExport.Name = "miExport";
            this.miExport.Size = new System.Drawing.Size(118, 22);
            this.miExport.Text = "导出(&O)";
            this.miExport.Click += new System.EventHandler(this.ExportFile);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 6);
            // 
            // miClose
            // 
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(118, 22);
            this.miClose.Text = "关闭(&C)";
            this.miClose.Click += new System.EventHandler(this.CloseFile);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(115, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(118, 22);
            this.miExit.Text = "退出(&X)";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewChildCatalog,
            this.miNewBrotherCatalog,
            this.miUpdateCatalog,
            this.miDeleteCatalog,
            this.toolStripMenuItem3,
            this.miMoveCatalog,
            this.toolStripMenuItem4,
            this.查询SToolStripMenuItem});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(59, 21);
            this.mnuEdit.Text = "编辑(&E)";
            // 
            // miNewChildCatalog
            // 
            this.miNewChildCatalog.Name = "miNewChildCatalog";
            this.miNewChildCatalog.Size = new System.Drawing.Size(164, 22);
            this.miNewChildCatalog.Text = "新增子目录(&C)";
            // 
            // miNewBrotherCatalog
            // 
            this.miNewBrotherCatalog.Name = "miNewBrotherCatalog";
            this.miNewBrotherCatalog.Size = new System.Drawing.Size(164, 22);
            this.miNewBrotherCatalog.Text = "新增同级目录(&B)";
            // 
            // miUpdateCatalog
            // 
            this.miUpdateCatalog.Name = "miUpdateCatalog";
            this.miUpdateCatalog.Size = new System.Drawing.Size(164, 22);
            this.miUpdateCatalog.Text = "更新目录(&U)";
            // 
            // miDeleteCatalog
            // 
            this.miDeleteCatalog.Name = "miDeleteCatalog";
            this.miDeleteCatalog.Size = new System.Drawing.Size(164, 22);
            this.miDeleteCatalog.Text = "删除目录(&D)";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(161, 6);
            // 
            // miMoveCatalog
            // 
            this.miMoveCatalog.Name = "miMoveCatalog";
            this.miMoveCatalog.Size = new System.Drawing.Size(164, 22);
            this.miMoveCatalog.Text = "移动目录...(&M)";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(161, 6);
            // 
            // 查询SToolStripMenuItem
            // 
            this.查询SToolStripMenuItem.Name = "查询SToolStripMenuItem";
            this.查询SToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.查询SToolStripMenuItem.Text = "搜索(&S)";
            // 
            // mnuTool
            // 
            this.mnuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOptions});
            this.mnuTool.Name = "mnuTool";
            this.mnuTool.Size = new System.Drawing.Size(62, 21);
            this.mnuTool.Text = "工具(&O)";
            // 
            // miOptions
            // 
            this.miOptions.Name = "miOptions";
            this.miOptions.Size = new System.Drawing.Size(118, 22);
            this.miOptions.Text = "选项(&O)";
            // 
            // gbCatalog
            // 
            this.gbCatalog.Controls.Add(this.trCatalog);
            this.gbCatalog.Location = new System.Drawing.Point(12, 28);
            this.gbCatalog.Name = "gbCatalog";
            this.gbCatalog.Size = new System.Drawing.Size(463, 338);
            this.gbCatalog.TabIndex = 1;
            this.gbCatalog.TabStop = false;
            this.gbCatalog.Text = "分类目录";
            // 
            // trCatalog
            // 
            this.trCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trCatalog.Location = new System.Drawing.Point(3, 17);
            this.trCatalog.Name = "trCatalog";
            this.trCatalog.Size = new System.Drawing.Size(457, 318);
            this.trCatalog.TabIndex = 0;
            this.trCatalog.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CheckCatalog);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.btnDeleteCatalog);
            this.gbDetail.Controls.Add(this.btnNewBrotherCatalog);
            this.gbDetail.Controls.Add(this.btnNewChildCatalog);
            this.gbDetail.Controls.Add(this.btnUpdateCatalog);
            this.gbDetail.Controls.Add(this.txtCatalogLevel);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Controls.Add(this.txtParentCatalog);
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Controls.Add(this.txtCatalogName);
            this.gbDetail.Controls.Add(this.label1);
            this.gbDetail.Location = new System.Drawing.Point(481, 86);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(273, 280);
            this.gbDetail.TabIndex = 2;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "目录详情";
            // 
            // btnDeleteCatalog
            // 
            this.btnDeleteCatalog.Location = new System.Drawing.Point(142, 239);
            this.btnDeleteCatalog.Name = "btnDeleteCatalog";
            this.btnDeleteCatalog.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteCatalog.TabIndex = 10;
            this.btnDeleteCatalog.Text = "删除目录(&D)";
            this.btnDeleteCatalog.UseVisualStyleBackColor = true;
            this.btnDeleteCatalog.Click += new System.EventHandler(this.DeleteCatalog);
            // 
            // btnNewBrotherCatalog
            // 
            this.btnNewBrotherCatalog.Location = new System.Drawing.Point(142, 207);
            this.btnNewBrotherCatalog.Name = "btnNewBrotherCatalog";
            this.btnNewBrotherCatalog.Size = new System.Drawing.Size(113, 23);
            this.btnNewBrotherCatalog.TabIndex = 9;
            this.btnNewBrotherCatalog.Text = "新增同级目录(&B)";
            this.btnNewBrotherCatalog.UseVisualStyleBackColor = true;
            this.btnNewBrotherCatalog.Click += new System.EventHandler(this.NewBrotherCatalog);
            // 
            // btnNewChildCatalog
            // 
            this.btnNewChildCatalog.Location = new System.Drawing.Point(19, 207);
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
            this.btnUpdateCatalog.Location = new System.Drawing.Point(19, 239);
            this.btnUpdateCatalog.Name = "btnUpdateCatalog";
            this.btnUpdateCatalog.Size = new System.Drawing.Size(113, 23);
            this.btnUpdateCatalog.TabIndex = 6;
            this.btnUpdateCatalog.Text = "更新目录(&U)";
            this.btnUpdateCatalog.UseVisualStyleBackColor = true;
            this.btnUpdateCatalog.Click += new System.EventHandler(this.UpdateCatalog);
            // 
            // txtCatalogLevel
            // 
            this.txtCatalogLevel.Location = new System.Drawing.Point(82, 71);
            this.txtCatalogLevel.Name = "txtCatalogLevel";
            this.txtCatalogLevel.ReadOnly = true;
            this.txtCatalogLevel.Size = new System.Drawing.Size(173, 21);
            this.txtCatalogLevel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "目录等级:";
            // 
            // txtParentCatalog
            // 
            this.txtParentCatalog.Location = new System.Drawing.Point(82, 122);
            this.txtParentCatalog.Name = "txtParentCatalog";
            this.txtParentCatalog.ReadOnly = true;
            this.txtParentCatalog.Size = new System.Drawing.Size(173, 21);
            this.txtParentCatalog.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "父级目录:";
            // 
            // txtCatalogName
            // 
            this.txtCatalogName.Location = new System.Drawing.Point(82, 23);
            this.txtCatalogName.Name = "txtCatalogName";
            this.txtCatalogName.Size = new System.Drawing.Size(173, 21);
            this.txtCatalogName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "目录名称:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSheetRename);
            this.groupBox1.Controls.Add(this.cbSheets);
            this.groupBox1.Location = new System.Drawing.Point(481, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工作表";
            // 
            // btnSheetRename
            // 
            this.btnSheetRename.Location = new System.Drawing.Point(209, 17);
            this.btnSheetRename.Name = "btnSheetRename";
            this.btnSheetRename.Size = new System.Drawing.Size(58, 23);
            this.btnSheetRename.TabIndex = 2;
            this.btnSheetRename.Text = "更名";
            this.btnSheetRename.UseVisualStyleBackColor = true;
            // 
            // cbSheets
            // 
            this.cbSheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSheets.FormattingEnabled = true;
            this.cbSheets.Location = new System.Drawing.Point(6, 19);
            this.cbSheets.Name = "cbSheets";
            this.cbSheets.Size = new System.Drawing.Size(197, 20);
            this.cbSheets.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.gbCatalog);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "体系分类快速工具";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbCatalog.ResumeLayout(false);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem miMoveCatalog;
        private System.Windows.Forms.ToolStripMenuItem mnuTool;
        private System.Windows.Forms.ToolStripMenuItem miOptions;
        private System.Windows.Forms.GroupBox gbCatalog;
        private System.Windows.Forms.TreeView trCatalog;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.TextBox txtParentCatalog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCatalogName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 查询SToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCatalogLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSheets;
        private System.Windows.Forms.Button btnSheetRename;
        private System.Windows.Forms.ToolStripMenuItem miNewBrotherCatalog;
        private System.Windows.Forms.Button btnUpdateCatalog;
        private System.Windows.Forms.Button btnDeleteCatalog;
        private System.Windows.Forms.Button btnNewBrotherCatalog;
        private System.Windows.Forms.Button btnNewChildCatalog;
    }
}

