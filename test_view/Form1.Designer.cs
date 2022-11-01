namespace test_view
{
    partial class Form1
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
            this.selectedListBox1 = new Libarary1_COP.SelectedListBox();
            this.numericPicker1 = new Libarary1_COP.NumericPicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPicture = new System.Windows.Forms.Button();
            this.buttonTable = new System.Windows.Forms.Button();
            this.buttonDiagramm = new System.Windows.Forms.Button();
            this.wordDiagramm = new Library2_COP.WordDiagramm();
            this.wordPicture = new Library2_COP.WordPicture(this.components);
            this.word_Table = new Library2_COP.Word_Table(this.components);
            this.treeCreater = new Libarary1_COP.TreeCreater();
            this.SuspendLayout();
            // 
            // selectedListBox1
            // 
            this.selectedListBox1.Location = new System.Drawing.Point(340, 61);
            this.selectedListBox1.Name = "selectedListBox1";
            this.selectedListBox1.SelectedElement = "";
            this.selectedListBox1.Size = new System.Drawing.Size(354, 291);
            this.selectedListBox1.TabIndex = 0;
            this.selectedListBox1.Load += new System.EventHandler(this.selectedListBox1_Load);
            // 
            // numericPicker1
            // 
            this.numericPicker1.Location = new System.Drawing.Point(22, 116);
            this.numericPicker1.Name = "numericPicker1";
            this.numericPicker1.NumPicked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericPicker1.Size = new System.Drawing.Size(280, 94);
            this.numericPicker1.TabIndex = 1;
            this.numericPicker1.Load += new System.EventHandler(this.numericPicker1_Load);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            // 
            // buttonPicture
            // 
            this.buttonPicture.Location = new System.Drawing.Point(1249, 84);
            this.buttonPicture.Name = "buttonPicture";
            this.buttonPicture.Size = new System.Drawing.Size(94, 29);
            this.buttonPicture.TabIndex = 4;
            this.buttonPicture.Text = "Picture";
            this.buttonPicture.UseVisualStyleBackColor = true;
            this.buttonPicture.Click += new System.EventHandler(this.buttonPicture_Click);
            // 
            // buttonTable
            // 
            this.buttonTable.Location = new System.Drawing.Point(1249, 181);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.Size = new System.Drawing.Size(94, 29);
            this.buttonTable.TabIndex = 5;
            this.buttonTable.Text = "Table";
            this.buttonTable.UseVisualStyleBackColor = true;
            this.buttonTable.Click += new System.EventHandler(this.buttonTable_Click);
            // 
            // buttonDiagramm
            // 
            this.buttonDiagramm.Location = new System.Drawing.Point(1249, 259);
            this.buttonDiagramm.Name = "buttonDiagramm";
            this.buttonDiagramm.Size = new System.Drawing.Size(94, 29);
            this.buttonDiagramm.TabIndex = 6;
            this.buttonDiagramm.Text = "Diagramm";
            this.buttonDiagramm.UseVisualStyleBackColor = true;
            this.buttonDiagramm.Click += new System.EventHandler(this.buttonDiagramm_Click);
            // 
            // treeCreater
            // 
            this.treeCreater.Location = new System.Drawing.Point(742, 61);
            this.treeCreater.Name = "treeCreater";
            this.treeCreater.Size = new System.Drawing.Size(340, 269);
            this.treeCreater.TabIndex = 8;
            this.treeCreater.Load += new System.EventHandler(this.treeCreater1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 501);
            this.Controls.Add(this.treeCreater);
            this.Controls.Add(this.buttonDiagramm);
            this.Controls.Add(this.buttonTable);
            this.Controls.Add(this.buttonPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericPicker1);
            this.Controls.Add(this.selectedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Libarary1_COP.SelectedListBox selectedListBox1;
        private Libarary1_COP.NumericPicker numericPicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPicture;
        private System.Windows.Forms.Button buttonTable;
        private System.Windows.Forms.Button buttonDiagramm;
        private Library2_COP.WordDiagramm wordDiagramm;
        private Library2_COP.WordPicture wordPicture;
        private Library2_COP.Word_Table word_Table;
        private Libarary1_COP.TreeCreater treeCreater;
    }
}
