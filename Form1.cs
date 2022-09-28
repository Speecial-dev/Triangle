using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

/*
 * abstract class kullanmayı unutma
 * static ile küpü yaptırıcaksın ama tekrar bak
 * interface ile X,Y,Z değerleri alınabilir
 * miras zaten var allahın emri
 * Polymorphism anlaşılmadı tekrar bakılcak
 * Kodlar berbat halde daha iyi yazmalısın
 * Küpü yazdırırken bir method kullanacaksın methodu abstract olarak tanımlayabilirim
 * daha fazla şekil düşünmem lazım
 17/12/2020
 her classdan başvuru alırken değiştirme yapıcam 
 2-boyutluluk ---- Abstract
 Daire ----------- İnterface
 küp ------------- static 
 gibi gibi 
 * */
namespace Triangel
{
  
    public partial class Form1 : Form
    {
        private bool button1WasClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        Thread th;
        Thread th1;
        Thread th2;
        Random rdm;


        public void thread()
        {
            Daire dair = new Daire("kare");
            for (int i = 0; i < 15; i++)
            {

                dair.X = 100;
                dair.Y = 100;
                Sekiller(dair.X, dair.Y,Color.Red);
                Thread.Sleep(100);
                

            }
          
      
        }
        public void threadblue() // kare
        {
            Kalıtım kare = new Kalıtım();
            for (int i = 0; i < 10; i++)
            {

                kare.x1 = 100;
                kare.y1 = 100;

                Sekiller(kare.x1, kare.y1,Color.DarkBlue);
                Thread.Sleep(100);
            }
            kare.Nedir = "Kare";
            kare.Bilgi();
        }
        public void Kare2()
        {
            
            Kare2 kare2 = new Kare2();
            if (chechBox1.Checked == true)
            {
                kare2.Renk = Color.DarkRed;
            }
            else
                kare2.Renk = Color.DarkBlue;
            for (int i = 0; i < 10; i++)
            {
                kare2.x1 = 100;
                kare2.y1 = 100;
                kare2.Nedir = "Kare";
                Sekiller(kare2.x1, kare2.y1, kare2.Renk);
            }
            kare2.Bilgi();
        }
        public void Dikdörtgen()
        {
            int kısakenar;
            int uzunkenar;
            kısakenar = rdm.Next(50, 150);
            uzunkenar = rdm.Next(150, 200);

            Kalıtım dikdörtgen = new Kalıtım()
            {
                x1 = kısakenar,
                y1 = uzunkenar,
            };
           
     
        }
        public void Sekiller(int x, int y,Color Renk) // kare 

        {

            this.CreateGraphics().DrawRectangle(new Pen(Renk, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), x, y));
        }

        public void Sekiller1(int x, int y) //daire
        {
            this.CreateGraphics().DrawEllipse(new Pen(Brushes.Blue, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), x, y));
            //this.CreateGraphics().DrawRectangle(new Pen(Brushes.SkyBlue, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), x, y));
        }
        public void KüpYapımı(int x1, int y1, int x2, int y2, int a1, int a2, int b1, int b2, Color Renk)
        {

            for (int i = 0; i < 10; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Renk, 2), new Rectangle(a1, b1, a2, b2));//kare oluşturmak için
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Black, 2), new Rectangle(x1, y1, x2, y2));//kare oluşturmak için 
                this.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2), x1 + x2, y1, a1 + a2, b1); // okeydir. sağ üst çizgi
                this.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2), x1, y1, a1, b1); // okeydir. sol üst 
                this.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2), x1, y1 + x2, a1, b1 + b2); //sol alt çizgi 
                this.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2), x1 + x2, y1 + y2, a1 + a2, b1 + b2); //sağ alt çizgi için 
               
            }
 

        }

        public void threadblack() // kare spamlamak için method
        {
            Küp küpküp = new Küp();
            for (int i = 0; i < 1; i++)
            {
            
                küpküp.CurrentColor = Color.SkyBlue;
                küpküp.x1 = rdm.Next(100, 200);
                küpküp.y1 = rdm.Next(100, 200);
                küpküp.x2 = 100;
                küpküp.y2 = 100;
                küpküp.a1 = rdm.Next(150, 200);
                küpküp.a2 = 100;
                küpküp.b1 = rdm.Next(150, 200);
                küpküp.b2 = 100;
                KüpYapımı(küpküp.x1, küpküp.y1, küpküp.x2, küpküp.y2, küpküp.a1, küpküp.a2, küpküp.b1, küpküp.b2, küpküp.CurrentColor);
               
                Thread.Sleep(100);
                küpküp.ozellikyaz();
               


                // Sekiller2(kare.x1, kare.y1, kare.x2, kare.y2, kare.a1, kare.a2, kare.b1, kare.b2);
            }
          


        }

        private void button1_Click(object sender, EventArgs e)
        {
            th = new Thread(thread);
            th.Start();
            

        }
        private void button2_Click(object sender, EventArgs e)
        {
            th1 = new Thread(threadblue);
            
            th1.Start();
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            rdm = new Random();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Küp küpküp = new Küp();
            th2 = new Thread(threadblack);
            th2.Start();
            label1.Text = küpküp.NEY;
            label2.Text = küpküp.Hesaplama();
           
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;
            Ücgen();
           
            label1.Text = "ücgenin kenarlarının uzunlukları:"+ Convert.ToString(toplamoruq());
           
            
        }
        public static int toplamoruq()
        {
            int Length;
            Length = Triangle.p1.X * Triangle.p1.X + Triangle.p2.Y * Triangle.p2.Y;
         
                
            return Convert.ToInt16(Math.Sqrt(Length));
        }

        public  void Ücgen()
        {
            Random rdm = new Random();
               Triangle.p1 = new Point(rdm.Next(0,1000),rdm.Next(200,300));
            Triangle.p2 = new Point(rdm.Next(0,1000), rdm.Next(300,600));
            Triangle.p3 = new Point(rdm.Next(0,1000), rdm.Next(200,600));

            this.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2), Triangle.p1, Triangle.p2); // okeydir. sağ üst çizgi
            this.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2), Triangle.p1, Triangle.p3); // okeydir. sağ üst çizgi
            this.CreateGraphics().DrawLine(new Pen(Brushes.Black, 2), Triangle.p3, Triangle.p2); // okeydir. sağ üst çizgi
            Triangle.Hoppala(Triangle.p1.X, Triangle.p1.Y);
            label2.Text = Convert.ToString(Triangle.Hoppala(Triangle.p1.X, Triangle.p1.Y));
          
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            label1.Text = "x- coordinate" + e.X + "y-coordinate" + e.Y;
        }

        private void ClearColor(PaintEventArgs e)
        {
            // Clear screen with teal background.
            e.Graphics.Clear(Color.Teal);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Triangle.Yazma(label1.Text, label2.Text);
            
            this.Invalidate();
            if (button1WasClicked == true)
            {
               
               
                button1WasClicked = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            th1 = new Thread(Kare2);
            th1.Start();
            
        }
    }
}

