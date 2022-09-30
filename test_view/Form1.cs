using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace test_view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void selectedListBox1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string str = "";
            for (int i =0; i < 10; i++)
            {
                //string str = "";
                selectedListBox1.FillList = str + rnd.Next(90);
            }
            selectedListBox1.FillList = str + 1;
            selectedListBox1.SelectedElement = str + 1;
        }

        private void numericPicker1_Load(object sender, EventArgs e)
        {
            int NumFrom = 10;
            int NumTo = 100;
            numericPicker1.NumFrom = NumFrom;
            numericPicker1.NumTo = NumTo;
        }

        private void treeCreater1_Load(object sender, EventArgs e)
        {
            Worker worker1 = new Worker();
            worker1.Place = "Development";
            worker1.Job = "Programmer";
            worker1.Name = "Ivanov Ivan";
            Worker worker2 = new Worker();
            worker2.Place = "Development";
            worker2.Job = "Programmer";
            worker2.Name = "Petrov Petr";
            Worker worker3 = new Worker();
            worker3.Place = "Management";
            worker3.Job = "Logistician";
            worker3.Name = "Alexandrov Alex";
            Worker worker4 = new Worker();
            worker4.Place = "Development";
            worker4.Job = "Frontend";
            worker4.Name = "Semenov Semen";
            Worker worker5 = new Worker();
            worker5.Place = "Management";
            worker5.Job = "Head of Department";
            worker5.Name = "Dmitriev Dmirtry";
            Worker worker6 = new Worker();
            worker6.Place = "Top";
            worker6.Job = "Gen director";
            worker6.Name = "Olegov Oleg";

            List<string> list = new List<string>();
            list.Add("Place");
            list.Add("Job");
            list.Add("Name");
            
            treeCreater1.setHierarchy(list);
            
            treeCreater1.CreateTree(worker1, "Name");
            treeCreater1.CreateTree(worker2, "Name");
            treeCreater1.CreateTree(worker3, "Name");
            treeCreater1.CreateTree(worker4, "Name");
            treeCreater1.CreateTree(worker5, "Name");
            treeCreater1.CreateTree(worker6, "Name");
        }
    }
}
