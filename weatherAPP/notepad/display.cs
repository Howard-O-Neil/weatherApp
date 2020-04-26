using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weatherAPP.notepad
{
    public partial class display : Form
    {
        public string data = "";
        tabNote parentControl;

        public display()
        {
            InitializeComponent();
        }

        public display(string data, tabNote parentControl)
        {
            InitializeComponent();
            this.parentControl = parentControl;
            textBox.Text = data;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (parentControl != null)
            {
                parentControl.textChange = true;
            }
            data = textBox.Text;
        }
    }
}
