using System.Security.Cryptography.X509Certificates;

namespace guzikcwel
{
    public partial class Form1 : Form
    {
        Random chuj = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Point p = new Point(chuj.Next(0, Size.Width - button1.Size.Width), chuj.Next(0, Size.Height - button1.Size.Height));
            button1.Location = p;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
