using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libarary1_COP
{
    public partial class NumericPicker : UserControl
    {
        public NumericPicker()
        {
            InitializeComponent();
            numericUpDown.ValueChanged += (sender, e) => _event?.Invoke(sender, e);
        }

        private event EventHandler _event;

        public event EventHandler SelectedTimeChanged
        {
            add
            {
                _event += value;
            }
            remove
            {
                _event -= value;
            }
        }
        public int? NumFrom;
        public int? NumTo;
        private int NumPrev { get; set; }

        public decimal NumPicked
        {
            get
            {
                if (NumFrom == null || NumTo == null)
                {
                    labelError.Text = $"Enter granici";
                    labelError.BackColor = Color.Red;
                    return 0;
                }
                if (numericUpDown.Value < NumFrom || numericUpDown.Value > NumTo)
                {
                    labelError.Text = $"Out of range";
                    labelError.BackColor = Color.Red;
                    return 0;
                }
                labelError.Text = string.Empty;
                labelError.BackColor = BackColor;
                return numericUpDown.Value;
            }
            set
            {
                if ((NumFrom == null || NumTo == null || value < NumFrom || value > NumTo))
                {
                    labelError.Text = $"Enter parameters";
                    labelError.BackColor = Color.Red;
                    return;
                }
                numericUpDown.Value = value;
                labelError.Text = string.Empty;
                labelError.BackColor = BackColor;
            }
        }

        private void numericPicker_ValueChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            NumPicked = numericUpDown.Value;
            if (NumPrev != NumPicked && NumPicked != 0)
            {
                BackColor = Color.FromArgb(random.Next(256),
                    random.Next(256),
                    random.Next(256));
                NumPrev = (int)NumPicked;
            }
        }
    }
}
