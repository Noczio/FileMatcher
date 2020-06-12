using AppGetSameFiles.resources.abstract_class;
using AppGetSameFiles.resources.interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AppGetSameFiles.resources.implementation
{
    public class FormListBox : AbstracBox<ListBox>
    {
        public FormListBox(ListBox _lbox) : base(_lbox)
        {
        }

        public override bool BoxIsNotEmpty()
        {
            return this.box.Items.Count > 0;
        }

        public override void BoxIsEnable(bool _bln)
        {
            this.box.Enabled = _bln;
        }

        public override void Fill()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.ShowNewFolderButton = false;
                DialogResult result = fbd.ShowDialog();
                string path = fbd.SelectedPath;

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(path))
                {                  
                    List<string> filesList = new List<string>();
                    foreach (string fileName in Directory.GetFiles(path).Select(Path.GetFileName)) filesList.Add(fileName);
                    this.box.DataSource = filesList;
                    this.box.SelectedIndex = -1;
                    SetSource(path);
                }
            }
        }
    }

    public class BBEnabler : IEnabler
    {
        protected Node node;
        public AbstracBox<ListBox> box;

        public class Node
        {
            protected GroupBox self;
            protected GroupBox next;

            public Node(GroupBox _self, GroupBox _next) => (self, next) = (_self, _next);

            public bool SelfState()
            {
                return self.Enabled;
            }

            public bool NextState()
            {
                return next.Enabled;
            }

            public void EnableNext() => next.Enabled = true;

            public void DisableNext() => next.Enabled = false;

            public void EnableSelf() => self.Enabled = true;

            public void DisableSelf()
            {
                self.Enabled = false;
                DisableNext();
            }
        }

        public BBEnabler(GroupBox _self, GroupBox _next, AbstracBox<ListBox> _box) => (node, box) = (new Node(_self, _next), _box);

        public bool ValidateCondition()
        {
            if (box.BoxIsNotEmpty()) return true;
            return false;
        }

        public void ValidateNode()
        {
            if (!node.SelfState())
            {
                node.DisableNext();
            }
            else
            {
                if (ValidateCondition()) node.EnableNext();
                else
                {
                    node.EnableSelf();
                    node.DisableNext();
                }
            }
        }
    }

    public class BBEnablerPool : IEPool
    {
        private List<IEnabler> pool = new List<IEnabler>(2);
        protected static BBEnablerPool instance = null;

        public static BBEnablerPool GetInstance()
        {
            if (instance == null)
            {
                instance = new BBEnablerPool();
            }
            return instance;
        }

        protected BBEnablerPool()
        {
        }

        public void Add(IEnabler _data)
        {
            pool.Add(_data);
        }

        public void ValidateNodes()
        {
            foreach (var elm in pool)
            {
                elm.ValidateNode();
            }
        }

        public List<IEnabler> Return()
        {
            return pool;
        }
    }
}