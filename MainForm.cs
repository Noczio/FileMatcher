using AppGetSameFiles.resources.abstract_class;
using AppGetSameFiles.resources.implementation;
using AppGetSameFiles.resources.interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace AppGetSameFiles
{
    public partial class MainForm : Form
    {
        private AbstracBox<ListBox> leftBox;
        private AbstracBox<ListBox> rightBox;
        private IEPool enablerPool;

        public MainForm()
        {
            InitializeComponent();          
        }

        private void bntLeft_Click(object sender, EventArgs e)
        {
            leftBox = new FormListBox(lbLeft);
            enablerPool.Add(new BBEnabler(gpLeft,gpRight,leftBox));
            enablerPool.ValidateNodes();
        }


        private void btnRight_Click(object sender, EventArgs e)
        {
            rightBox = new FormListBox(lbRight);
            enablerPool.Add(new BBEnabler(gpRight, gpMatch, rightBox));
            enablerPool.ValidateNodes();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            enablerPool = BBEnablerPool.GetInstance();
        }

        private HashSet<string> TransformToHash(ListBox _lbox)
        {
            HashSet<string> set = new HashSet<string>();
            foreach (var elm in _lbox.Items)
            {
                set.Add(elm.ToString());
            }
            return set;
        }

        private decimal GetMatchCount(int expected, int actual)
        {
            return (decimal)actual / expected;
        }

        private void CopyToClipBoard(string _source, HashSet<string> _files)
        {
            StringCollection paths = new StringCollection();
            
            foreach (var f in _files)
            {
                paths.Add($"{_source}\\{f}");
            }
            Clipboard.SetFileDropList(paths);
        }
        private void btnMatch_Click(object sender, EventArgs e)
        {

            HashSet<string> leftSet = TransformToHash(leftBox.GetBox());
            HashSet<string> rightSet = TransformToHash(rightBox.GetBox());

            leftSet.IntersectWith(rightSet);
            decimal matchCount = GetMatchCount(leftBox.GetBox().Items.Count, leftSet.Count);
            lblMatch.Text = $"{String.Format("{0:0.0}", matchCount * 100)}  %";
            if (matchCount > 0) {
                CopyToClipBoard(rightBox.GetSource(), leftSet);
                MessageBox.Show("Copy completed, now you can crlt+v your files wherever you want","Succes");
            }
            else
            {
                MessageBox.Show("0 % file match","Criteria not found");
            }
            
        }
    }
}