using LogicDB.BindingModels;
using LogicDB.Logics;
using LogicDB.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Forms
{
    public partial class FormWorker : Form
    {
        public int Id { set { id = value; } }
        private int? id;
        private ProductTypeLogic productLogic;
        private OrderLogic orderLogic;
        private byte[] image = null;
        private string pattern = @"^(\+7|8)+\d{7}$";
        private string toolTip = "+79999999";

        public FormWorker()
        {
            InitializeComponent();
            productLogic = new ProductTypeLogic();
            orderLogic = new OrderLogic();
            var productList = productLogic.Read(null);
            var list = new List<string>();
            inputBox.Pattern = pattern;
            inputBox.SetToolTip(toolTip);
            foreach (var product in productList)
            {
                list.Add(product.Name);
            }
            controlSelectedComboBoxList.AddList(list);
        }

        private void LoadData()
        {   
            if (id.HasValue)
            {
                try
                {
                    var view = orderLogic.Read(new WorkerBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxFIO.Text = view.WorkerName;
                        pictureBox.Image = byteArrayToImage(view.Image);
                        controlSelectedComboBoxList.SelectedElement = view.SkillType;
                        inputBox.Value = view.PhoneNumber;
                        image = view.Image;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            
            
        }

        private bool Save()
        {
            if (textBoxFIO.Text != string.Empty && controlSelectedComboBoxList.SelectedElement != string.Empty && image != null)
            {
                if (id != null)
                {
                    if (MessageBox.Show("Сохранить изменения в сотруднике?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            string value = inputBox.Value;
                            
                            orderLogic.CreateOrUpdate(new WorkerBindingModel()
                            {
                                Id = id,
                                WorkerName = textBoxFIO.Text,
                                Image = image,
                                SkillType = controlSelectedComboBoxList.SelectedElement,
                                PhoneNumber = inputBox.Value
                            });
                            return true;
                        }
                        catch (ArgumentException)
                        {
                            MessageBox.Show("Введеный номер некорректен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    return false;
                }
                else
                {
                    if (MessageBox.Show("Сохранить сотрудника?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            string value = inputBox.Value;

                            orderLogic.CreateOrUpdate(new WorkerBindingModel()
                            {
                                Id = id,
                                WorkerName = textBoxFIO.Text,
                                Image = image,
                                SkillType = controlSelectedComboBoxList.SelectedElement,
                                PhoneNumber = inputBox.Value
                            });
                            return true;
                        }
                        catch (ArgumentException)
                        {
                            MessageBox.Show("Введеный номер некорректен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Введите значения");
                return false;
            }
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Выберите изображение";
            dialog.Filter = "jpg files (*.jpg)|*.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var image_new = new Bitmap(dialog.FileName);
                pictureBox.Image = image_new;
                image = ImageToByteArray(image_new);
            }

            dialog.Dispose();
        }

        private Image byteArrayToImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        /*private void FormOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Save())
            {
                e.Cancel = true;
            }
            DialogResult = DialogResult.OK;
        }*/
    }
}
