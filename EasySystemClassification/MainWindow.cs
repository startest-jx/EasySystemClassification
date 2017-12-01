using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EasySystemClassification
{
    public partial class MainWindow : Form
    {
        private OptionsHelper _optionsHelper;
        private ExcelOperator _excel;
        private List<string> _sheets;
        private string _curSheet;
        private string _curFileName;
        private string _curKeyWord;
        private List<TreeNode> _searchResult;
        private TreeNode _curSearchNode;
        private long _importStartRow, _importStartColumn;
        private long _exportStartRow, _exportStartColumn;
        private string _nameRegex = @".+(?=\$)";
        private string _codeRegex = @"(?<=\$)(\w+)";
        private string _cellFormat = @"%NAME%$%CODE%";

        public MainWindow()
        {
            InitializeComponent();
            _optionsHelper = new OptionsHelper("Config.json");
            DetailDisable();
        }

        private void ImportData(TreeNodeCollection curTree, long curColumn, long startRow, long endRow)
        {
            bool newNode = false;
            string curNodeName = "";
            string curNodeCode = "";
            var childStartLine = startRow;
            TreeNode tempNode;
            TreeNodeCollection tempTree;
            for (var row = startRow; row <= endRow; row++)
            {
                var cellString = _excel.GetCellValue(_curSheet, row, curColumn);
                if (cellString.Length == 0) continue;
                if (newNode)
                {
                    var childEndLine = --row;
                    tempNode = curTree.Add(curNodeName);
                    tempNode.Tag = curNodeCode;
                    tempTree= tempNode.Nodes;
                    Console.WriteLine($@"{curColumn} {curNodeName}");
                    if (curColumn < _excel.MaxUsedColumnCount(_curSheet))
                        ImportData(tempTree, curColumn + 1, childStartLine, childEndLine);
                    newNode = false;
                }
                else
                {
                    newNode = true;
                    childStartLine = row;
                    try
                    {
                        curNodeName = Regex.Match(cellString, _nameRegex).Value;
                        curNodeCode = Regex.Match(cellString, _codeRegex).Value;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            if (curNodeName.Length == 0) return;
            tempNode = curTree.Add(curNodeName);
            tempNode.Tag = curNodeCode;
            tempTree= tempNode.Nodes;
            Console.WriteLine($@"{curColumn} {curNodeName}");
            if (curColumn < _excel.MaxUsedColumnCount(_curSheet))
                ImportData(tempTree, curColumn + 1, childStartLine, endRow);
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
                string exportString = _cellFormat.Replace(@"%NAME%", curNode.Text).Replace(@"%CODE%", curNode.Tag.ToString());
                _excel.UniteCells(_curSheet, startRow, curColumn, startRow + nodeRowCount - 1, curColumn);
                _excel.SetCellValue(_curSheet, startRow, curColumn, exportString);
                startRow += nodeRowCount;
            }
            return totalRowCount;
        }

        private void SearchData(TreeNodeCollection curTree)
        {
            foreach (TreeNode node in curTree)
            {
                if (node.Text.IndexOf(_curKeyWord, StringComparison.Ordinal) != -1)
                {
                    _searchResult.Add(node);
                }
                SearchData(node.Nodes);
            }
        }

        private string GetNodeWholeCode(TreeNode node)
        {
            var pNode = node.Parent;
            if (pNode == null)
            {
                return node.Tag.ToString();
            }
            return GetNodeWholeCode(pNode) + node.Tag.ToString();
        }

        private void DetailEnable()
        {
            txtCatalogName.Enabled = true;
            txtCode.Enabled = true;
            txtWholeCode.Enabled = true;
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
            txtCode.Clear();
            txtWholeCode.Clear();
            txtCatalogLevel.Clear();
            txtParentCatalog.Clear();

            txtCatalogName.Enabled = false;
            txtCode.Enabled = false;
            txtWholeCode.Enabled = false;
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
            cbSheets.DataSource = null;
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
                string nodeCode = checkNode.Tag.ToString();
                int nodeLevel = checkNode.Level;
                string nodeParent = checkNode.Parent?.Text;

                txtCatalogName.Text = nodeName;
                txtCode.Text = nodeCode;
                txtWholeCode.Text = GetNodeWholeCode(checkNode);
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
                Text = txtCatalogName.Text,
                Tag = txtCode.Text
            };
            pNode.Nodes.Add(node);
        }

        private void NewBrotherCatalog(object sender, EventArgs e)
        {
            var pNode = trCatalog.SelectedNode;
            if (pNode == null) return;
            var node = new TreeNode
            {
                Text = txtCatalogName.Text,
                Tag = txtCode.Text
            };
            pNode.Parent.Nodes.Add(node);
        }

        private void UpdateCatalog(object sender, EventArgs e)
        {
            var pNode = trCatalog.SelectedNode;
            if (pNode == null) return;
            pNode.Text = txtCatalogName.Text;
            pNode.Tag = txtCode.Text;
        }

        private void DeleteCatalog(object sender, EventArgs e)
        {
            var pNode = trCatalog.SelectedNode;
            pNode?.Remove();
        }

        private void SearchNext(object sender, EventArgs e)
        {
            string keyWord = txtSearch.Text;
            if (keyWord.Length == 0) return;
            if (keyWord != _curKeyWord || _searchResult == null)
            {
                _curKeyWord = keyWord;
                _searchResult = new List<TreeNode>();
                SearchData(trCatalog.Nodes);
                _curSearchNode = _searchResult.First();
            }
            else
            {
                int curIndex = _searchResult.IndexOf(_curSearchNode);
                if (curIndex >= _searchResult.Count - 1)
                {
                    curIndex = -1;
                }
                _curSearchNode = _searchResult[curIndex + 1];
            }
            trCatalog.SelectedNode = _searchResult == null ? null : _curSearchNode;
            trCatalog.Focus();
        }

        private void SearchPrevious(object sender, EventArgs e)
        {
            string keyWord = txtSearch.Text;
            if (keyWord.Length == 0) return;
            if (keyWord != _curKeyWord || _searchResult == null)
            {
                _curKeyWord = keyWord;
                _searchResult = new List<TreeNode>();
                SearchData(trCatalog.Nodes);
                _curSearchNode = _searchResult.First();
            }
            else
            {
                int curIndex = _searchResult.IndexOf(_curSearchNode);
                if (curIndex <= 0)
                {
                    curIndex = _searchResult.Count;
                }
                _curSearchNode = _searchResult[curIndex - 1];
            }
            trCatalog.SelectedNode = _searchResult == null ? null : _curSearchNode;
            trCatalog.Focus();
        }

        private void OpenOptions(object sender, EventArgs e)
        {
            OptionsWindow optionsWindow = new OptionsWindow();
            optionsWindow.ShowDialog();
        }
    }
}
