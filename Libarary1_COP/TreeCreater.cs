using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libarary1_COP
{
    public partial class TreeCreater : UserControl
    {
        public TreeCreater()
        {
            InitializeComponent();
            treeView.AfterSelect += (sender, e) => _event?.Invoke(sender, e);
        }
        private event EventHandler _event;
        private List<string> Hierarhy;
        public event EventHandler SelectedNodeChanged
        {
            add
            {
                _event += value;
            }
            remove
            {
                _event -= value;
            }
        }

        private List<string> config;
        
        public int SelectedIndex
        {
            get
            {
                return treeView.SelectedNode != null ? treeView.SelectedNode.Index : -1;
            }
            set
            {
                if (value > -1 && value < treeView.Nodes.Count)
                {
                    treeView.SelectedNode = treeView.Nodes[value];
                    treeView.Focus();
                    return;
                }
                throw new IndexOutOfRangeException();
            }
        }
        public void setHierarchy(List<string> str)
        {
            Hierarhy = str;         
        }
        public void CreateTree<T>(T obj, String pole) where T : class, new()
        {
            if (pole == null)
                throw new NullReferenceException("Add not null pole");
            if (obj == null)
                throw new NullReferenceException("Add not null object");
            Type type = obj.GetType();
            //List<String> poles= new List<String>();
            /*foreach (var f in type.GetFields().Where(f => f.IsPublic))
            {
                poles.Add(f.Name);
            }*/

            var elementType = obj.GetType();
                var currentLevelNodes = treeView.Nodes;
                int curlvl = 1;
                foreach (var nodeName in Hierarhy)
                {
               
                    var propertyInfo = elementType.GetProperty(nodeName);
                    if (propertyInfo != null)
                    {
                        var propertyValue = propertyInfo.GetValue(obj).ToString();
                        if (!currentLevelNodes.ContainsKey(propertyValue))
                        {
                            if (curlvl == Hierarhy.Count)
                            {
                                currentLevelNodes.Add(propertyValue);
                            }
                            else
                                currentLevelNodes.Add(propertyValue, propertyValue);
                        }
                        if (curlvl != Hierarhy.Count)
                            currentLevelNodes = currentLevelNodes.Find(propertyValue, false)[0].Nodes;
                    }
                    else
                    {
                        var fieldInfo = elementType.GetField(nodeName);
                        if (fieldInfo != null)
                        {
                            var fieldValue = fieldInfo.GetValue(obj).ToString();
                            if (!currentLevelNodes.ContainsKey(fieldValue))
                            {
                                if (curlvl == Hierarhy.Count)
                                {
                                    currentLevelNodes.Add(fieldValue);
                                }
                                else
                                    currentLevelNodes.Add(fieldValue, fieldValue);
                            }
                            if (curlvl != Hierarhy.Count)
                                currentLevelNodes = currentLevelNodes.Find(fieldValue, false)[0].Nodes;
                        }
                    if (pole == nodeName)
                    {
                        return;
                    }
                }
                    curlvl++;
                }

        }

        public T GetSelectedNode<T>() where T : class, new()
        {
            if (treeView.SelectedNode == null)
                return null;

            var curNode = treeView.SelectedNode;
            if (curNode.Nodes.Count > 0)
                throw new Exception("Choose last node of tree (leaf)");

            var Vals = new List<string>();
            while (curNode != null)
            {
                Vals.Add(curNode.Text);
                curNode = curNode.Parent;
            }

            Vals.Reverse();
            var item = new T();
            var count = item.GetType().GetProperties().Length;
            for (int i = 0; i < config.Count; ++i)
            {
                if (i < count)
                {
                    var pinfo = item.GetType().GetProperty(config[i]);
                    if (pinfo != null)
                        pinfo.SetValue(item, Convert.ChangeType(Vals[i], pinfo.PropertyType));
                }
                else
                {
                    var finfo = item.GetType().GetField(config[i]);
                    if (finfo != null)
                    {
                        finfo.SetValue(item, Convert.ChangeType(Vals[i], finfo.FieldType));
                    }
                }
            }
            return item;
        }

        public void Clear()
        {
            treeView.Nodes.Clear();
        }
    }
}
