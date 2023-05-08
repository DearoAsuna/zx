using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp1
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
            this.MyButton.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "Hello World";
        }
    }
}
