namespace View
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продуктыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьCtrlUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьCtrlDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.простойДокументCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документСТаблицейCtrlTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диаграммаCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDataTableTable = new ControlsLibraryNet60.Data.ControlDataTableTable();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникToolStripMenuItem,
            this.действияToolStripMenuItem,
            this.документыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(538, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продуктыToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникToolStripMenuItem.Text = "Справочники";
            // 
            // продуктыToolStripMenuItem
            // 
            this.продуктыToolStripMenuItem.Name = "продуктыToolStripMenuItem";
            this.продуктыToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.продуктыToolStripMenuItem.Text = "Навыки";
            this.продуктыToolStripMenuItem.Click += new System.EventHandler(this.продуктыToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьCtrlAToolStripMenuItem,
            this.изменитьCtrlUToolStripMenuItem,
            this.удалитьCtrlDToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // добавитьCtrlAToolStripMenuItem
            // 
            this.добавитьCtrlAToolStripMenuItem.Name = "добавитьCtrlAToolStripMenuItem";
            this.добавитьCtrlAToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.добавитьCtrlAToolStripMenuItem.Text = "Добавить    Ctrl + A";
            this.добавитьCtrlAToolStripMenuItem.Click += new System.EventHandler(this.добавитьCtrlAToolStripMenuItem_Click);
            // 
            // изменитьCtrlUToolStripMenuItem
            // 
            this.изменитьCtrlUToolStripMenuItem.Name = "изменитьCtrlUToolStripMenuItem";
            this.изменитьCtrlUToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.изменитьCtrlUToolStripMenuItem.Text = "Изменить   Ctrl + U";
            this.изменитьCtrlUToolStripMenuItem.Click += new System.EventHandler(this.изменитьCtrlUToolStripMenuItem_Click);
            // 
            // удалитьCtrlDToolStripMenuItem
            // 
            this.удалитьCtrlDToolStripMenuItem.Name = "удалитьCtrlDToolStripMenuItem";
            this.удалитьCtrlDToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.удалитьCtrlDToolStripMenuItem.Text = "Удалить       Ctrl + D";
            this.удалитьCtrlDToolStripMenuItem.Click += new System.EventHandler(this.удалитьCtrlDToolStripMenuItem_Click);
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.простойДокументCtrlSToolStripMenuItem,
            this.документСТаблицейCtrlTToolStripMenuItem,
            this.диаграммаCtrlCToolStripMenuItem});
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.документыToolStripMenuItem.Text = "Документы";
            // 
            // простойДокументCtrlSToolStripMenuItem
            // 
            this.простойДокументCtrlSToolStripMenuItem.Name = "простойДокументCtrlSToolStripMenuItem";
            this.простойДокументCtrlSToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.простойДокументCtrlSToolStripMenuItem.Text = "Простой документ          Ctrl + S";
            this.простойДокументCtrlSToolStripMenuItem.Click += new System.EventHandler(this.простойДокументCtrlSToolStripMenuItem_Click);
            // 
            // документСТаблицейCtrlTToolStripMenuItem
            // 
            this.документСТаблицейCtrlTToolStripMenuItem.Name = "документСТаблицейCtrlTToolStripMenuItem";
            this.документСТаблицейCtrlTToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.документСТаблицейCtrlTToolStripMenuItem.Text = "Документ с таблицей     Ctrl + T";
            this.документСТаблицейCtrlTToolStripMenuItem.Click += new System.EventHandler(this.документСТаблицейCtrlTToolStripMenuItem_Click);
            // 
            // диаграммаCtrlCToolStripMenuItem
            // 
            this.диаграммаCtrlCToolStripMenuItem.Name = "диаграммаCtrlCToolStripMenuItem";
            this.диаграммаCtrlCToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.диаграммаCtrlCToolStripMenuItem.Text = "Диаграмма                       Ctrl + C";
            this.диаграммаCtrlCToolStripMenuItem.Click += new System.EventHandler(this.диаграммаCtrlCToolStripMenuItem_Click);
            // 
            // controlDataTableTable
            // 
            this.controlDataTableTable.Location = new System.Drawing.Point(15, 48);
            this.controlDataTableTable.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.controlDataTableTable.Name = "controlDataTableTable";
            this.controlDataTableTable.SelectedRowIndex = -1;
            this.controlDataTableTable.Size = new System.Drawing.Size(507, 427);
            this.controlDataTableTable.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 493);
            this.Controls.Add(this.controlDataTableTable);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Сотрудники";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникToolStripMenuItem;
        private ToolStripMenuItem действияToolStripMenuItem;
        private ToolStripMenuItem документыToolStripMenuItem;
        private ToolStripMenuItem добавитьCtrlAToolStripMenuItem;
        private ToolStripMenuItem изменитьCtrlUToolStripMenuItem;
        private ToolStripMenuItem удалитьCtrlDToolStripMenuItem;
        private ToolStripMenuItem простойДокументCtrlSToolStripMenuItem;
        private ToolStripMenuItem документСТаблицейCtrlTToolStripMenuItem;
        private ToolStripMenuItem диаграммаCtrlCToolStripMenuItem;
        private ToolStripMenuItem продуктыToolStripMenuItem;
        private ControlsLibraryNet60.Data.ControlDataTableTable controlDataTableTable;
        private ContextMenuStrip contextMenuStrip1;
    }
}