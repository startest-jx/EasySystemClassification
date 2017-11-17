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
    public partial class MainWindow : Form
    {
        private ExcelOperator _excel;
        private List<string> _sheets;
        private string _curSheet;
        private string _curFileName;

        public MainWindow()
        {
            InitializeComponent();
            DetailDisable();
        }

        private void ImportData(TreeNodeCollection curTree, long curColumn, long startRow, long endRow)
        {
            bool newNode = false;
            string curNodeName = "";
            var childStartLine = startRow;
            TreeNodeCollection tempNode;
            for (var row = startRow; row <= endRow; row++)
            {
                var cellString = _excel.GetCellValue(_curSheet, row, curColumn);
                if (cellString.Length == 0) continue;
                if (newNode)
                {
                    var childEndLine = --row;
                    tempNode = curTree.Add(curNodeName).Nodes;
                    Console.WriteLine($@"{curColumn} {curNodeName}");
                    if (curColumn < _excel.MaxUsedColumnCount(_curSheet))
                        ImportData(tempNode, curColumn + 1, childStartLine, childEndLine);
                    newNode = false;
                }
                else
                {
                    newNode = true;
                    childStartLine = row;
                    curNodeName = cellString;
                }
            }
            if (curNodeName.Length == 0) return;
            tempNode = curTree.Add(curNodeName).Nodes;
            Console.WriteLine($@"{curColumn} {curNodeName}");
            if (curColumn < _excel.MaxUsedColumnCount(_curSheet))
                ImportData(tempNode, curColumn + 1, childStartLine, endRow);
        }

        private long ExportData(TreeNodeCollection curTree, long curColumn, long startRow)
        {
            long totalRowCount = 0;
            foreach (TreeNode curNode in curTree)
            {
                long nodeRowCount = 0;
                if (curNode.Nodes.Count == 0)
                {
                    nodeRowCount = 1;
                }
                else
                {
                    nodeRowCount += ExportData(curNode.Nodes, curColumn + 1, startRow);
                }
                totalRowCount += nodeRowCount;
                _excel.UniteCells(_curSheet, startRow, curColumn, startRow + nodeRowCount - 1, curColumn);
                _excel.SetCellValue(_curSheet, startRow, curColumn, curNode.Text);
                startRow += nodeRowCount;
            }
            return totalRowCount;
        }

        private void DetailEnable()
        {
            txtCatalogName.Enabled = true;
            txtCatalogLevel.Enabled = true;
            txtParentCatalog.Enabled = true;

            btnNewChildCatalog.Enabled = true;
            btnNewBrotherCatalog.Enabled = true;
            btnUpdateCatalog.Enabled = true;
            btnDeleteCatalog.Enabled = true;
        }

        private void DetailDisable()
        {
            txtCatalogName.Clear();
            txtCatalogLevel.Clear();
            txtParentCatalog.Clear();

            txtCatalogName.Enabled = false;
            txtCatalogLevel.Enabled = false;
            txtParentCatalog.Enabled = false;

            btnNewChildCatalog.Enabled = false;
            btnNewBrotherCatalog.Enabled = false;
            btnUpdateCatalog.Enabled = false;
            btnDeleteCatalog.Enabled = false;
        }

        private void NewFile(object sender, EventArgs e)
        {
            _excel = new ExcelOperator();
            _excel.CreateExcel();
            _sheets = _excel.GetSheetList();
//            _curSheet = _excel.AddSheet("默认工作表").Name;
            cbSheets.DataSource = _sheets;
            cbSheets.SelectedIndex = 0;
        }

        private void ImportFile(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = @"Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx|所有文件|*.*",
                ValidateNames = true,
                CheckPathExists = true,
                CheckFileExists = true
            };
            if (ofd.ShowDialog() != DialogResult.OK) return;
            _curFileName = ofd.FileName;
            _excel = new ExcelOperator();
            _excel.OpenExcel(_curFileName);
            _sheets = _excel.GetSheetList();
            _curSheet = _sheets[0];
            cbSheets.DataSource = _sheets;
            cbSheets.SelectedIndex = 0;
            ImportData(trCatalog.Nodes, 1, 2, _excel.MaxUsedRowCount(_curSheet));
            _excel.Close();
        }

        private void CloseFile(object sender, EventArgs e)
        {
            trCatalog.Nodes.Clear();
            _sheets.Clear();
            DetailDisable();
        }

        private void ExportFile(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Filter = @"Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx|所有文件|*.*",
                ValidateNames = true
            };
            if (sfd.ShowDialog() != DialogResult.OK) return;
            _curFileName = sfd.FileName;
            NewFile(null, null);
            ExportData(trCatalog.Nodes, 1, 2);
            _excel.SaveAs(_curFileName);
            _excel.Close();
        }

        private void CheckCatalog(object sender, TreeViewEventArgs e)
        {
            var checkNode = e.Node;
            if (checkNode.IsSelected)
            {
                DetailEnable();
                string nodeName = checkNode.Text;
                int nodeLevel = checkNode.Level;
                string nodeParent = checkNode.Parent?.Text;

                txtCatalogName.Text = nodeName;
                txtCatalogLevel.Text = nodeLevel.ToString();
                txtParentCatalog.Text = nodeParent;
            }
            else
            {
                DetailDisable();
            }
        }

        private void NewChildCatalog(object sender, EventArgs e)
        {
            var pNode = trCatalog.SelectedNode;
            if (pNode == null) return;
            var node = new TreeNode
            {
                Text = txtCatalogName.Text
            };
            pNode.Nodes.Add(node);
        }

        private void NewBrotherCatalog(object sender, EventArgs e)
        {
            var pNode = trCatalog.SelectedNode;
            if (pNode == null) return;
            var node = new TreeNode
            {
                Text = txtCatalogName.Text
            };
            pNode.Parent.Nodes.Add(node);
        }

        private void UpdateCatalog(object sender, EventArgs e)
        {
            var pNode = trCatalog.SelectedNode;
            if (pNode == null) return;
            pNode.Text = txtCatalogName.Text;
        }

        private void DeleteCatalog(object sender, EventArgs e)
        {
            var pNode = trCatalog.SelectedNode;
            pNode?.Remove();
        }
    }
}
