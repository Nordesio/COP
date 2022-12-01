using ComponentsLibraryNet60.DocumentWithChart;
using ComponentsLibraryNet60.DocumentWithTable;
using ControlsLibraryNet60.Data;
using ControlsLibraryNet60.Models;
using LogicDB.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugins.Forms;
using Library2_COP;
using Plugins.Plugins;
using ComponentsLibraryNet60.DocumentWithContext;
using VisualComponentLibrary.Nonvisual;
using LogicDB.ViewModels;
namespace Plugin.Plugin
{
    [Export(typeof(IPluginsConvention))]
    public class MainPluginConvention : IPluginsConvention
    {
        private List<CellPdfTable> rowTablePdfOne;
        private List<CellPdfTable> rowTablePdfTwo;
        private ControlDataTableTable dataTableView;
        private OrderLogic orderLogic;
        private List<DataTableColumnConfig> config;

        public MainPluginConvention()
        {
            dataTableView = new ControlDataTableTable();

            var menu = new ContextMenuStrip();
            var productMenuItem = new ToolStripMenuItem("Навыки");
            menu.Items.Add(productMenuItem);
            productMenuItem.Click += (sender, e) =>
            {
                var formSkill = new FormSkill();
                formSkill.ShowDialog();
            };
            dataTableView.ContextMenuStrip = menu;

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
            dataTableView.LoadColumns(config);
            orderLogic = new OrderLogic();
            ReloadData();
        }

        public string PluginName => "Сотрудники";

        public UserControl GetControl => dataTableView;

        public PluginsConventionElement GetElement => dataTableView.GetSelectedObject<PluginsConventionElement>();


        public  bool CreateImageDoc(PluginsConventionSaveDocument saveDocument)
        {
           try
            {
                ComponentDocumentWithContextImageWord component = new ComponentDocumentWithContextImageWord();
                
                component.CreateDoc(
                    new ComponentsLibraryNet60.Models.ComponentDocumentWithContextImageConfig
                    {
                        FilePath = saveDocument.FileName,
                        Header = "Личные фото",
                        Images = WordImages()
                    });
                MessageBox.Show("Документ сохранен", "Создание документа",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool CreateTableDoc(PluginsConventionSaveDocument saveDocument)
        {
            try
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


                    component.CreateDocument(saveDocument.FileName, "Информация о сотрудниках", hi, rowTablePdfOne, rowTablePdfTwo, 10, 8);

                    MessageBox.Show("Документ сохранен", "Создание документа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                return false;
            }
            return true;
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
 
        public bool CreateChartDoc(PluginsConventionSaveDocument saveDocument)
        {
            try
            {

            
                ComponentDocumentWithChartBarExcel component = new ComponentDocumentWithChartBarExcel();
                component.CreateDoc(new ComponentsLibraryNet60.Models.ComponentDocumentWithChartConfig
                {
                    FilePath = saveDocument.FileName,
                    Header = "Сотрудники",
                    ChartTitle = "Навыки",
                    LegendLocation = ComponentsLibraryNet60.Models.Location.Bottom,
                    Data = ExcelData()
                });
                MessageBox.Show("Документ сохранен", "Создание документа",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
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



      
        public bool DeleteElement(PluginsConventionElement element)
        {
            try
            {
                orderLogic.Delete(new LogicDB.BindingModels.WorkerBindingModel { Id = element.Id });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public Form GetForm(PluginsConventionElement element)
        {
            var formWorker = new FormWorker();
            if (element != null)
            {
                formWorker.Id = element.Id;
            }
            return formWorker;
        }

        public void ReloadData()
        {
            dataTableView.Clear();
            var data = orderLogic.Read(null);
            if (data.Count > 0)
            {
                dataTableView.AddTable(data);
            }
        }
    }
}
