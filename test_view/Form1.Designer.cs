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
            this.selectedListBox1 = new Libarary1_COP.SelectedListBox();
            this.numericPicker1 = new Libarary1_COP.NumericPicker();
            this.treeCreater1 = new Libarary1_COP.TreeCreater();
            this.label1 = new System.Windows.Forms.Label();
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
            // treeCreater1
            // 
            this.treeCreater1.Location = new System.Drawing.Point(757, 61);
            this.treeCreater1.Name = "treeCreater1";
            this.treeCreater1.Size = new System.Drawing.Size(359, 291);
            this.treeCreater1.TabIndex = 2;
            this.treeCreater1.Load += new System.EventHandler(this.treeCreater1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeCreater1);
            this.Controls.Add(this.numericPicker1);
            this.Controls.Add(this.selectedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Libarary1_COP.SelectedListBox selectedListBox1;
        private Libarary1_COP.NumericPicker numericPicker1;
        private Libarary1_COP.TreeCreater treeCreater1;
        private System.Windows.Forms.Label label1;
    }
}
