using Library2_COP.Classes_for_word;
using System;
using System.Collections.Generic;
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
            for (int i = 0; i < 10; i++)
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
            
            treeCreater.setHierarchy(list);
            
            treeCreater.CreateTree(worker1, "Name");
            treeCreater.CreateTree(worker2, "Name");
            treeCreater.CreateTree(worker3, "Name");
            treeCreater.CreateTree(worker4, "Name");
            treeCreater.CreateTree(worker5, "Name");
            treeCreater.CreateTree(worker6, "Name");
        }
       
        private void buttonPicture_Click(object sender, EventArgs e)
        {
            string fileName = "";
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = dialog.FileName.ToString();
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }
            }
            List<String> str = new List<String>();
            str.Add("C:/Users/vladg/Desktop/1.jpg");
            str.Add("C:/Users/vladg/Desktop/2.jpg");
            wordPicture.InsertAPicture(fileName, "123", str);
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
           
            List<Test> test = new List<Test>();
            List<string> colTitles = new List<string>();
            List<string> colFields = new List<string>();
            List<Tuple<int, int>> mergeCells = new List<Tuple<int, int>>();
            List<string> mergeTitles = new List<string>();
            colTitles.Add("Статус");
            colTitles.Add("Имя");
            colTitles.Add("Фамилия");
            colTitles.Add("Возраст");
            colTitles.Add("шк1");
            colTitles.Add("шк2");
            colTitles.Add("шк3");
            colTitles.Add("шк4");
            mergeTitles.Add("Личные данные");

            mergeTitles.Add("рнд");
            mergeCells.Add(new Tuple<int, int>(2, 4));
            mergeCells.Add(new Tuple<int, int>(6, 8));
            colFields.Add("status");
            colFields.Add("name");
            colFields.Add("family");
            colFields.Add("year");
            colFields.Add("ir1");
            colFields.Add("ir2");
            colFields.Add("ir3");
            colFields.Add("ir4");
            test.Add(new Test { status = "no", name = "vlad", family = "gusev", year = 20, ir1 = "no", ir2 = "vlad", ir3 = "gusev", ir4 = 20 });
            test.Add(new Test { status = "yes", name = "kirill", family = "dolgov", year = 20, ir1 = "no", ir2 = "vlad", ir3 = "gusev", ir4 = 20 });
            test.Add(new Test { status = "no", name = "alex", family = "senkin", year = 20, ir1 = "no", ir2 = "vlad", ir3 = "gusev", ir4 = 20 });
            test.Add(new Test { status = "yes", name = "123", family = "321", year = 1000, ir1 = "no", ir2 = "vlad", ir3 = "gusev", ir4 = 20 });
            test.Add(new Test { status = "no", name = "321", family = "123", year = 201, ir1 = "no", ir2 = "vlad", ir3 = "gusev", ir4 = 20 });


            string fileName = "";
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = dialog.FileName.ToString();
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }
            }
            word_Table.CreateTable(fileName, "123321",  2, test, colTitles, colFields, mergeCells, mergeTitles);

        }

        private void buttonDiagramm_Click(object sender, EventArgs e)
        {
            string fileName = "";
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = dialog.FileName.ToString();
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                }
            }
            List<Test> data = new List<Test>();
            data.Add(new Test { name = "123", year = 312 });
            data.Add(new Test { name = "456", year = 654 });
            data.Add(new Test { name = "789", year = 987 });
            data.Add(new Test { name = "101112", year = 121 });
            data.Add(new Test { name = "aaaaa", year = 999 });
            Legend legend = new Legend();
            wordDiagramm.ReportSaveDiagramm(fileName, "PieDiagramm", "PieDiagramm", legend, data, "name", "year");
        }
    }
}
