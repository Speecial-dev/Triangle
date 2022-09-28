using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Triangel
{
    interface İnterfaceFor2D
    {
       
        int x1 { get; set; }
        int y1 { get; set; }
        string Nedir { get; set; }
        Color Renk { get; set; }
        void Bilgi(); // Console.WriteLine{"bu bir {0}",ne ise artık}

    }
    abstract class Deneme
    {
        abstract public void ozellikyaz();
    }
    class KurucuMetod
    {

        public KurucuMetod()
        {

        }
    }
    class Küp:Deneme
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }

        public int a1 { get; set; }
        public int a2 { get; set; }
        public int b1 { get; set; }
        public int b2 { get; set; }
        internal Color CurrentColor { get; set; }
        private string Nedir = "küp basılıyor";
        public string NEY = "Küp";
        public override void ozellikyaz()
        {
            MessageBox.Show("Ekrana şimdi" + Nedir);
            MessageBox.Show(CurrentColor + "Renkte Bir Küptür ve sol üst noktasının koordinatları"+Environment.NewLine+"x="+Convert.ToString(x1)+Environment.NewLine+"y="+Convert.ToString(y1));
            
            
        }
        public string Hesaplama()
        {
           
           
            return Convert.ToString(Math.Pow(x2 - x1, y2 - y1));
        }


    }
    public class Kalıtım : İnterfaceFor2D               //interface örneği
    {


        public int x1 { get; set; }
        public int y1 { get; set; }
        public string Nedir { get; set; }
        public Color Renk { get; set; }
        public void Bilgi()
        {
            MessageBox.Show(Nedir + " Ekrana Basılmıştır. ");
        }


    }
    public class Kare2: İnterfaceFor2D                     //interface örneği
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public string Nedir { get; set; }
        public Color Renk { get; set; }
        public void Bilgi()
        {
            MessageBox.Show(Nedir + "Ekrana basılmıştır. Rengi ise"+Renk);
        }

    }
      class Daire                     //kurucu metod      
    {
       

        public int X { get; set; }
        public int Y { get; set; }
        public string ad1 { get; set; }
        public string asd { get; set; }
        public Daire(string ad)
        {
          
            MessageBox.Show("Çizilen şey bir"+ ad);

        }
    }
    class Sekil                                         
    {
        public int ad;
        public Sekil(string ad)
        {
            MessageBox.Show(this.ad+"Çizilen şey bir");
        }
    }
    public static class Triangle                        //static örneği
    {
        public static Point p1;
        public static Point p2;
        public static Point p3;
        public static int aqwe;
        public static int bqwr;
        public static int Hoppala(int X_koordinatı, int Y_koordinatı)
        {
            p1.X = X_koordinatı;
            p1.Y = Y_koordinatı;
            return X_koordinatı+Y_koordinatı;
        }
        public static void Yazma(string satır, string text)
        {
            string dosya_yolu = @"C:\Users\CoolerMaster\Desktop\deneme.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Write);
             StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(satır.ToString());
            sw.WriteLine(text);
            sw.Close();
            fs.Close();
        }

    }
    class Uye           //form 2 polymorphsim
    {
        public string Ad { get; set; }

        public int Sifre = 12345;
        public virtual void GirisYap()
        {
           MessageBox.Show(this.Ad + "Hoşgeldin Ve Güle güle");
        }
    }

    class Admin : Uye            //form 2 polymorphsim
    {
        
        public new int Sifre = 11223344;
        public override void GirisYap()
        {
            base.GirisYap();

           MessageBox.Show(this.Ad + "Proje Açılıyor");
        }
    }


}
