using System;
using System.Windows.Forms;
namespace sj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            Controller c1 = new Controller(form);
            form.ShowDialog();
            Console.ReadKey();
        }
    }
    class Controller
    {
        private Form form;

        public Controller(Form form)
        {
            if(form!=null)
            {
                this.form = form;
                this.form.Click += this.FormClick;
            }
        }

        private void FormClick(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
