using System;
using System.Windows.Forms;

namespace sj3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm f1 = new MyForm();
            f1.ShowDialog();


        }
    }
    class MyForm : Form
    {
        private TextBox textBox;
        private Button button;
        public MyForm()
        {
            this.textBox = new TextBox();
            this.button = new Button();
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.button.Click += this.buttonClick;
            this.button.Text = "Say hello";
            this.button.Top = 100;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            this.textBox.Text = "smd";
        }
    }
}
