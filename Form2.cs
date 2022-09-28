using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            Uye uye = new Admin { Ad = "İnsan Evladı" };
            Admin admin = new Admin { Ad = "Alp" };
            int a = Convert.ToInt32(textBox2.Text);
          
            if (a == uye.Sifre)
            {
                uye.GirisYap(); //burada admin classından oluşturduğumuz için uyeden değil adminden çalıştırıyor bunu engellemek için uye uye = new uye yapmam lazım
                Application.Exit();
            }
            if (a == admin.Sifre)
            {
                admin.GirisYap();
               
                 this.Visible = false;
                ff.Show();
            }
        }
    }
}
