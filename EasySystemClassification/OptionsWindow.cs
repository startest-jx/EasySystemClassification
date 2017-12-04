using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasySystemClassification
{
    public partial class OptionsWindow : Form
    {
        private OptionsHelper _optionHelper;
        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void SaveOption(object sender, EventArgs e)
        {
            _optionHelper.Option.ImportOption.StartRow = Convert.ToInt64(txtImportStartRow.Text);
            _optionHelper.Option.ImportOption.StartColumn = Convert.ToInt64(txtImportStartColumn.Text);
            _optionHelper.Option.ImportOption.NameRegex = txtImportNameRegex.Text; 
            _optionHelper.Option.ImportOption.CodeRegex = txtImportCodeRegex.Text;
            _optionHelper.Option.ExportOption.StartRow = Convert.ToInt64(txtExportStartRow.Text);
            _optionHelper.Option.ExportOption.StartColumn = Convert.ToInt64(txtExportStartColumn.Text);
            _optionHelper.Option.ExportOption.ExportFormat = txtExportFormat.Text;
            if (_optionHelper.Save())
            {
                Close();
            }
            else
            {
                MessageBox.Show(@"配置信息写入失败", @"错误");
            }
        }

        private void CloseOption(object sender, EventArgs e)
        {
            Close();
        }

        private void OptionsWindow_Load(object sender, EventArgs e)
        {
            try
            {
                _optionHelper = new OptionsHelper("Config.json");
            }
            catch (Exception)
            {
                MessageBox.Show(@"程序没有足够的权限访问或生成配置文件", @"错误");
            }
            txtImportStartRow.Text = _optionHelper.Option.ImportOption.StartRow.ToString();
            txtImportStartColumn.Text = _optionHelper.Option.ImportOption.StartColumn.ToString();
            txtImportNameRegex.Text = _optionHelper.Option.ImportOption.NameRegex;
            txtImportCodeRegex.Text = _optionHelper.Option.ImportOption.CodeRegex;
            txtExportStartRow.Text = _optionHelper.Option.ExportOption.StartRow.ToString();
            txtExportStartColumn.Text = _optionHelper.Option.ExportOption.StartColumn.ToString();
            txtExportFormat.Text = _optionHelper.Option.ExportOption.ExportFormat;
        }
    }
}
