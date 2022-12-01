using ComponentsLibraryNet60.DocumentWithChart;
using ComponentsLibraryNet60.DocumentWithTable;
using ComponentsLibraryNet60.DocumentWithContext;
using VisualComponentLibrary.Nonvisual;
using ControlsLibraryNet60.Models;
using LogicDB.BindingModels;
using LogicDB.Logics;
using LogicDB.ViewModels;
using View.Forms;
using Library2_COP;
using System.Linq;

namespace View
{
    public partial class FormMain : Form
    {
        private OrderLogic orderLogic;
        private List<DataTableColumnConfig> config;
        private List<CellPdfTable> rowTablePdfOne;
        private List<CellPdfTable> rowTablePdfTwo;
        public FormMain()
        {
            InitializeComponent();
            config = new List<DataTableColumnConfig>
            {
                new DataTableColumnConfig
                {
                    ColumnHeader = "Id",
                    PropertyName = "Id",
                    Visible = false,
                },
                new DataTableColumnConfig
                {
                    ColumnHeader = "ФИО сотрудника",
                    PropertyName = "WorkerName",
                    Visible = true,
                    Width = 120
                },
                new DataTableColumnConfig
                {
                    ColumnHeader = "Навык",
                    PropertyName = "SkillType",
                    Visible = true,
                    Width = 140
                },
                new DataTableColumnConfig
                {
                    ColumnHeader = "Номер телефона",
                    PropertyName = "PhoneNumber",
                    Visible = true,
                    Width = 200
                }
            };
            controlDataTableTable.LoadColumns(config);
            orderLogic = new OrderLogic();
            ReloadData();
        }

        private void ReloadData()
        {
            controlDataTableTable.Clear();
            var data = orderLogic.Read(null);
            if (data.Count > 0)
            {
                controlDataTableTable.AddTable(data);
            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control)
            {
                return;
            }
            switch (e.KeyCode)
            {
                case Keys.A:
                    AddNewElement();
                    break;
                case Keys.U:
                    UpdateElement();
                    break;
                case Keys.D:
                    DeleteElement();
                    break;
                case Keys.S:
                    CreateImageDoc();
                    break;
                case Keys.T:
                    CreateTableDoc();
                    break;
                case Keys.C:
                    CreateChartDoc();
                    break;
            }
        }

        private void AddNewElement()
        {
            var form = new FormWorker();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReloadData();
            }
        }

        private void UpdateElement()
        {
            var element = controlDataTableTable.GetSelectedObject<WorkerViewModel>();
            if (element == null)
            {
                MessageBox.Show("Нет выбранного элемента", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = new FormWorker { Id = element.Id };
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReloadData();
            }
        }

        private void DeleteElement()
        {
            if (MessageBox.Show("Удалить выбранный элемент", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            var element = controlDataTableTable.GetSelectedObject<WorkerViewModel>();
            if (element == null)
            {
                MessageBox.Show("Нет выбранного элемента", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            orderLogic.Delete(new WorkerBindingModel { Id = element.Id });
            ReloadData();
        }

        private void CreateImageDoc()
        {
            string fileName = "";
            using var dialog = new SaveFileDialog { Filter = "docx|*.docx" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ComponentDocumentWithContextImageWord component = new ComponentDocumentWithContextImageWord();
                fileName = dialog.FileName.ToString();
                component.CreateDoc(
                    new ComponentsLibraryNet60.Models.ComponentDocumentWithContextImageConfig
                    {
                        FilePath = fileName,
                        Header = "Личные фото",
                        Images = WordImages()
                    });
                MessageBox.Show("Документ сохранен", "Создание документа",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CreateTableDoc()
        {
            using (var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" })
            {
                if (dialog.ShowDialog() == DialogResult.OK) 
                {
                    
                    ComponentTablePdf component = new ComponentTablePdf();
                    rowTablePdfOne = new List<CellPdfTable>
                    {
                        new CellPdfTable()
                        {
                            Name = "Id",
                            ColumnWidth = "1cm",
                            PropertyName = "Id"
                        },
                        new CellPdfTable()
                        {
                            Name = "Название",
                            ColumnWidth = "2cm",
                            PropertyName = "WorkerName"
                        },
                        new CellPdfTable()
                        {
                            Name = "Информация",
                            ColumnWidth = "2cm",
                            CountCells = 2,
                        },
                    };
                    rowTablePdfTwo = new List<CellPdfTable>
                    {
                        new CellPdfTable()
                        {
                            Name = "Телефон",
                            PropertyName = "PhoneNumber"
                        },
                        new CellPdfTable()
                        {
                            Name = "Навыки",
                            PropertyName = "SkillType"
                        }
                    };

                    
                    List<WorkerViewModelWithoutImg> hi = new List<WorkerViewModelWithoutImg>();
                    Dictionary<string, List<WorkerViewModel>> dict = new Dictionary<string, List<WorkerViewModel>>();
                    var list = orderLogic.Read(null);

                    foreach (var item in list)
                    {
                        WorkerViewModelWithoutImg orderViewModelWithoutImg = new WorkerViewModelWithoutImg()
                        {
                            WorkerName = item.WorkerName,
                            SkillType = item.SkillType,
                            PhoneNumber = item.PhoneNumber,
                            Id = item.Id,
                        };
                        hi.Add(orderViewModelWithoutImg);

                    }
                  

                    component.CreateDocument(dialog.FileName, "Информация о поставщиках", hi, rowTablePdfOne, rowTablePdfTwo, 10, 8);

                    MessageBox.Show("Документ сохранен", "Создание документа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private List<byte[]> WordImages()
        {
            var list = orderLogic.Read(null);
            var list_bytes = new List<byte[]>();
            foreach (var item in list)
            {
                list_bytes.Add(item.Image);
            }
            return list_bytes;
        }

        private void CreateChartDoc()
        {
            using var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ComponentDocumentWithChartBarExcel component = new ComponentDocumentWithChartBarExcel();
                component.CreateDoc(new ComponentsLibraryNet60.Models.ComponentDocumentWithChartConfig
                {
                    FilePath = dialog.FileName,
                    Header = "Сотрудники",
                    ChartTitle = "Навыки",
                    LegendLocation = ComponentsLibraryNet60.Models.Location.Bottom,
                    Data = ExcelData()
                });
                MessageBox.Show("Документ сохранен", "Создание документа",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Dictionary<string, List<(int, double)>> ExcelData()
        {
            var list = orderLogic.Read(null);
            var list_product = new Dictionary<string, int>();
            foreach (var item in list)
            {
                if (list_product.ContainsKey(item.SkillType))
                    list_product[item.SkillType]++;
                else
                {
                    list_product.Add(item.SkillType, 1);
                }
            }
            var list_changed = new Dictionary<string, List<(int, double)>>();

            var new_list = new List<(int, double)>();
            var i = 0;
            foreach (var new_item in list_product)
            {
                i++;
                new_list.Add((i, new_item.Value));
            }

            list_changed.Add("Серия", new_list);

           
            return list_changed;
        }


        private void простойДокументCtrlSToolStripMenuItem_Click(object sender, EventArgs e) =>
        CreateImageDoc();

        private void документСТаблицейCtrlTToolStripMenuItem_Click(object sender, EventArgs e) =>
        CreateTableDoc();

        private void диаграммаCtrlCToolStripMenuItem_Click(object sender, EventArgs e) =>
        CreateChartDoc();

        private void добавитьCtrlAToolStripMenuItem_Click(object sender, EventArgs e) =>
        AddNewElement();

        private void изменитьCtrlUToolStripMenuItem_Click(object sender, EventArgs e) =>
        UpdateElement();

        private void удалитьCtrlDToolStripMenuItem_Click(object sender, EventArgs e) =>
        DeleteElement();

        private void продуктыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormSkill();
            form.ShowDialog();
        }
    }
}