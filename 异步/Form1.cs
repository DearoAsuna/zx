namespace 异步
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient ht=new HttpClient())
            {
                var s1 = await ht.GetStringAsync("http://www.youzack.com");
                //Thread.Sleep(1000);
                await Task.Delay(1000); 
                textBox1.Text = s1.Substring(0,20);

               
            }
        }
    }
}