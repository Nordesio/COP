namespace Plugins.Forms
{
    partial class FormWorker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlSelectedComboBoxList = new ControlsLibraryNet60.Selected.ControlSelectedComboBoxList();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.inputBox = new VisualComponentLibrary.InputUserControl();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // controlSelectedComboBoxList
            // 
            this.controlSelectedComboBoxList.Location = new System.Drawing.Point(185, 99);
            this.controlSelectedComboBoxList.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.controlSelectedComboBoxList.Name = "controlSelectedComboBoxList";
            this.controlSelectedComboBoxList.SelectedElement = "";
            this.controlSelectedComboBoxList.Size = new System.Drawing.Size(183, 32);
            this.controlSelectedComboBoxList.TabIndex = 0;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(14, 29);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(125, 20);
            this.labelFIO.TabIndex = 2;
            this.labelFIO.Text = "ФИО сотрудника";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(14, 111);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(54, 20);
            this.labelProduct.TabIndex = 3;
            this.labelProduct.Text = "Навык";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(14, 387);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(69, 20);
            this.labelMail.TabIndex = 4;
            this.labelMail.Text = "Телефон";
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(14, 204);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(44, 20);
            this.labelImage.TabIndex = 5;
            this.labelImage.Text = "Фото";
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(14, 296);
            this.buttonAddImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(86, 31);
            this.buttonAddImage.TabIndex = 6;
            this.buttonAddImage.Text = "Добавить";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(14, 465);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 31);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(185, 25);
            this.textBoxFIO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(276, 27);
            this.textBoxFIO.TabIndex = 8;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(174, 380);
            this.inputBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.inputBox.Name = "inputBox";
            this.inputBox.Pattern = "^(?(\")(\"[^\"]+?\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&\'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9" +
    "a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9]{" +
    "2,17}))$";
            this.inputBox.Size = new System.Drawing.Size(217, 27);
            this.inputBox.TabIndex = 18;
            this.inputBox.Value = "";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(185, 188);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(224, 139);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // FormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 509);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.controlSelectedComboBoxList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormWorker";
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlsLibraryNet60.Selected.ControlSelectedComboBoxList controlSelectedComboBoxList;
        private Label labelFIO;
        private Label labelProduct;
        private Label labelMail;
        private Label labelImage;
        private Button buttonAddImage;
        private Button buttonSave;
        private TextBox textBoxFIO;
        private PictureBox pictureBox;
        /*private WinFormsControlLibrarySergeev.VisualControls.EmailInputBox inputBox;*/
        private VisualComponentLibrary.InputUserControl inputBox;
    }
}