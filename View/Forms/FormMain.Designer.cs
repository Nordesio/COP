﻿namespace View
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ControlsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChartDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ControlsStripMenuItem,
            this.ActionsToolStripMenuItem,
            this.DocsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(538, 30);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "Меню";
            // 
            // ControlsStripMenuItem
            // 
            this.ControlsStripMenuItem.Name = "ControlsStripMenuItem";
            this.ControlsStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.ControlsStripMenuItem.Text = "Справочники";
            // 
            // ActionsToolStripMenuItem
            // 
            this.ActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddElementToolStripMenuItem,
            this.UpdElementToolStripMenuItem,
            this.DelElementToolStripMenuItem});
            this.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem";
            this.ActionsToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.ActionsToolStripMenuItem.Text = "Действия";
            // 
            // AddElementToolStripMenuItem
            // 
            this.AddElementToolStripMenuItem.Name = "AddElementToolStripMenuItem";
            this.AddElementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AddElementToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.AddElementToolStripMenuItem.Text = "Добавить";
            this.AddElementToolStripMenuItem.Click += new System.EventHandler(this.AddElementToolStripMenuItem_Click);
            // 
            // UpdElementToolStripMenuItem
            // 
            this.UpdElementToolStripMenuItem.Name = "UpdElementToolStripMenuItem";
            this.UpdElementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.UpdElementToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.UpdElementToolStripMenuItem.Text = "Изменить";
            this.UpdElementToolStripMenuItem.Click += new System.EventHandler(this.UpdElementToolStripMenuItem_Click);
            // 
            // DelElementToolStripMenuItem
            // 
            this.DelElementToolStripMenuItem.Name = "DelElementToolStripMenuItem";
            this.DelElementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DelElementToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.DelElementToolStripMenuItem.Text = "Удалить";
            this.DelElementToolStripMenuItem.Click += new System.EventHandler(this.DelElementToolStripMenuItem_Click);
            // 
            // DocsToolStripMenuItem
            // 
            this.DocsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImageDocToolStripMenuItem,
            this.TableDocToolStripMenuItem,
            this.ChartDocToolStripMenuItem});
            this.DocsToolStripMenuItem.Name = "DocsToolStripMenuItem";
            this.DocsToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.DocsToolStripMenuItem.Text = "Документы";
            // 
            // ImageDocToolStripMenuItem
            // 
            this.ImageDocToolStripMenuItem.Name = "ImageDocToolStripMenuItem";
            this.ImageDocToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ImageDocToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.ImageDocToolStripMenuItem.Text = "Простой документ";
            this.ImageDocToolStripMenuItem.Click += new System.EventHandler(this.ImageDocToolStripMenuItem_Click);
            // 
            // TableDocToolStripMenuItem
            // 
            this.TableDocToolStripMenuItem.Name = "TableDocToolStripMenuItem";
            this.TableDocToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.TableDocToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.TableDocToolStripMenuItem.Text = "Документ с таблицей";
            this.TableDocToolStripMenuItem.Click += new System.EventHandler(this.TableDocToolStripMenuItem_Click);
            // 
            // ChartDocToolStripMenuItem
            // 
            this.ChartDocToolStripMenuItem.Name = "ChartDocToolStripMenuItem";
            this.ChartDocToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ChartDocToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.ChartDocToolStripMenuItem.Text = "Диаграмма";
            this.ChartDocToolStripMenuItem.Click += new System.EventHandler(this.ChartDocToolStripMenuItem_Click);
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 30);
            this.panelControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(538, 463);
            this.panelControl.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 493);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Сотрудники";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem ControlsStripMenuItem;
        private ToolStripMenuItem ActionsToolStripMenuItem;
        private ToolStripMenuItem DocsToolStripMenuItem;
        private ToolStripMenuItem AddElementToolStripMenuItem;
        private ToolStripMenuItem UpdElementToolStripMenuItem;
        private ToolStripMenuItem DelElementToolStripMenuItem;
        private ToolStripMenuItem ImageDocToolStripMenuItem;
        private ToolStripMenuItem TableDocToolStripMenuItem;
        private ToolStripMenuItem ChartDocToolStripMenuItem;
        private System.Windows.Forms.Panel panelControl;
    }
}