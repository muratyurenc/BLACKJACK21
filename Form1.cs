using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();// rastgele sayılar uretecek
        int sayac = 0; //kağıt çekme sayısı
        int oycpuan = 0;// oyuncunun puan toplamı
        int pcpuan = 0; // bilgisayarın toplam puanı
        // oyuncunun kagıt çekme alanı
        private void Button1_Click(object sender, EventArgs e)
        {
            sayac++;
            // kullanıcı bir defa kağit çekerse.
            if (sayac == 1)
            {
                int lab1, lab2, top = 0;
                lab1 = rnd.Next(1, 11);
                lab2 = rnd.Next(1, 11);
                top = lab1 + lab2;
                label10.Text = top.ToString();
                label1.Text = lab1.ToString();
                label2.Text = lab2.ToString();
            }
            //kullanıcı iki kağıt çekerse.
            if (sayac == 2)
            {
                int lab3 = rnd.Next(1, 11);
                label3.Text = lab3.ToString();
                int top = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + lab3;
                label10.Text = top.ToString();
            }
            //kullanıcı üç kağıt çekerse.
            if (sayac == 3)
            {
                int lab4 = rnd.Next(1, 11);
                label4.Text = lab4.ToString();
                int top = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + lab4;
                label10.Text = top.ToString();
            }

            //rastgele gelen sayıların 1.konumdaki img resimleri
            if (label1.Text == "1")
            {
                pictureBox1.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinekA.png";
            }
            if (label1.Text == "2")
            {
                pictureBox1.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek2.png";

            }
            if (label1.Text == "3")
            {
                pictureBox1.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek3.png";
            }
            if (label1.Text == "4")
            {
                pictureBox1.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek4.png";
            }
            if (label1.Text == "5")
            {
                pictureBox1.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek5.png";
            }
            if (label1.Text == "6")
            {
                pictureBox1.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek6.png";
            }
            if (label1.Text == "7")
            {
                pictureBox1.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek7.png";
            }
            if (label1.Text == "8")
            {
                pictureBox1.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek8.png"; ;
            }
            if (label1.Text == "9")
            {
                pictureBox1.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek9.png";
            }
            if (label1.Text == "10")
            {
                pictureBox1.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek10.png";
            } //birinci konumun sonu

            // ikinci konumdakı img karşılığı !!!!!
            if (label2.Text == "1")
            {
                pictureBox2.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinekA.png";
            }
            if (label2.Text == "2")
            {
                pictureBox2.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek2.png";
            }
            if (label2.Text == "3")
            {
                pictureBox2.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek3.png";

            }
            if (label2.Text == "4")
            {
                pictureBox2.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek4.png";
            }
            if (label2.Text == "5")
            {
                pictureBox2.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek5.png";

            }
            if (label2.Text == "6")
            {
                pictureBox2.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek6.png";
            }
            if (label2.Text == "7")
            {
                pictureBox2.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek7.png";
            }
            if (label2.Text == "8")
            {
                pictureBox2.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek8.png";
            }
            if (label2.Text == "9")
            {
                pictureBox2.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek9.png";
            }
            if (label2.Text == "10")
            {
                pictureBox2.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek10.png";
            }
            //ikinci konum sonu !!!!!!!!!!!!!!!!!!
            // üçüncü konum img karşılığı
            if (label3.Text == "1")
            {
                pictureBox3.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinekA.png";
            }
            if (label3.Text == "2")
            {
                pictureBox3.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek2.png";
            }
            if (label3.Text == "3")
            {
                pictureBox3.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek3.png";

            }
            if (label3.Text == "4")
            {
                pictureBox3.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek4.png";
            }
            if (label3.Text == "5")
            {
                pictureBox3.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek5.png";

            }
            if (label3.Text == "6")
            {
                pictureBox3.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek6.png";
            }
            if (label3.Text == "7")
            {
                pictureBox3.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek7.png";
            }
            if (label3.Text == "8")
            {
                pictureBox3.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek8.png";
            }
            if (label3.Text == "9")
            {
                pictureBox3.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek9.png";
            }
            if (label3.Text == "10")
            {
                pictureBox3.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek10.png";
            }
            //üçüncü konumun sonu !!!
            // 4 konum img karşılığı!!!!
            if (label4.Text == "1")
            {
                pictureBox4.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinekA.png";
            }
            if (label4.Text == "2")
            {
                pictureBox4.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek2.png";
            }
            if (label4.Text == "3")
            {
                pictureBox4.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek3.png";

            }
            if (label4.Text == "4")
            {
                pictureBox4.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek4.png";
            }
            if (label4.Text == "5")
            {
                pictureBox4.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek5.png";

            }
            if (label4.Text == "6")
            {
                pictureBox4.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek6.png";
            }
            if (label4.Text == "7")
            {
                pictureBox4.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek7.png";
            }
            if (label4.Text == "8")
            {
                pictureBox4.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek8.png";
            }
            if (label4.Text == "9")
            {
                pictureBox4.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek9.png";
            }
            if (label4.Text == "10")
            {
                pictureBox4.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek10.png";
            }
            // 4 konumun sonu
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        //bilgisayar oyuncusunun alanı !!!
        private void Button2_Click(object sender, EventArgs e)
        {
            // rastgele ilk iki kağıdın toplamı
            int lab5, lab6, top = 0;
            lab5 = rnd.Next(1, 11);
            lab6 = rnd.Next(1, 11);
            top = lab5 + lab6;
            label13.Text = top.ToString();
            label5.Text = lab5.ToString();
            label6.Text = lab6.ToString();
            //toplamı 16 küçückse bir kağıt daha çeksin.
            if (top < 16)
            {
                int lab7 = rnd.Next(1, 11);
                label7.Text = lab7.ToString();
                top = top + lab7;
                label13.Text = top.ToString();
            }
            // 3 kağıttan sonra toplamı 16 kucukse bir tane daha çeksin.
            if (top < 16)
            {
                int lab8 = rnd.Next(1, 11);
                label8.Text = lab8.ToString();
                top = top + lab8;
                label13.Text = top.ToString();


            }
            // pc den gelen  rastgele gelen sayıların 1.konumdaki img resimleri
            if (label5.Text == "1")
            {
                pictureBox5.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinekA.png";
            }
            if (label5.Text == "2")
            {
                pictureBox5.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek2.png";

            }
            if (label5.Text == "3")
            {
                pictureBox5.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek3.png";
            }
            if (label5.Text == "4")
            {
                pictureBox5.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek4.png";
            }
            if (label5.Text == "5")
            {
                pictureBox5.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek5.png";
            }
            if (label5.Text == "6")
            {
                pictureBox5.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek6.png";
            }
            if (label5.Text == "7")
            {
                pictureBox5.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek7.png";
            }
            if (label5.Text == "8")
            {
                pictureBox5.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek8.png"; ;
            }
            if (label5.Text == "9")
            {
                pictureBox5.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek9.png";
            }
            if (label5.Text == "10")
            {
                pictureBox5.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek10.png";
            } //birinci konumun sonu

            // ikinci konumdakı img karşılığı !!!!!
            if (label6.Text == "1")
            {
                pictureBox6.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinekA.png";
            }
            if (label6.Text == "2")
            {
                pictureBox6.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek2.png";
            }
            if (label6.Text == "3")
            {
                pictureBox6.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek3.png";

            }
            if (label6.Text == "4")
            {
                pictureBox6.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek4.png";
            }
            if (label6.Text == "5")
            {
                pictureBox6.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek5.png";

            }
            if (label6.Text == "6")
            {
                pictureBox6.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek6.png";
            }
            if (label6.Text == "7")
            {
                pictureBox6.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek7.png";
            }
            if (label6.Text == "8")
            {
                pictureBox6.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek8.png";
            }
            if (label6.Text == "9")
            {
                pictureBox6.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek9.png";
            }
            if (label6.Text == "10")
            {
                pictureBox6.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek10.png";
            }
            //ikinci konum sonu !!!!!!!!!!!!!!!!!!
            // üçüncü konum img karşılığı
            if (label7.Text == "1")
            {
                pictureBox7.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinekA.png";
            }
            if (label7.Text == "2")
            {
                pictureBox7.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek2.png";
            }
            if (label7.Text == "3")
            {
                pictureBox7.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek3.png";

            }
            if (label7.Text == "4")
            {
                pictureBox7.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek4.png";
            }
            if (label7.Text == "5")
            {
                pictureBox7.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek5.png";

            }
            if (label7.Text == "6")
            {
                pictureBox7.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek6.png";
            }
            if (label7.Text == "7")
            {
                pictureBox7.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek7.png";
            }
            if (label7.Text == "8")
            {
                pictureBox7.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek8.png";
            }
            if (label7.Text == "9")
            {
                pictureBox7.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek9.png";
            }
            if (label7.Text == "10")
            {
                pictureBox7.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek10.png";
            }
            //üçüncü konumun sonu !!!
            // 4 konum img karşılığı!!!!
            if (label4.Text == "1")
            {
                pictureBox8.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinekA.png";
            }
            if (label8.Text == "2")
            {
                pictureBox8.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek2.png";
            }
            if (label8.Text == "3")
            {
                pictureBox8.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek3.png";

            }
            if (label8.Text == "4")
            {
                pictureBox8.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek4.png";
            }
            if (label8.Text == "5")
            {
                pictureBox8.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek5.png";

            }
            if (label8.Text == "6")
            {
                pictureBox8.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek6.png";
            }
            if (label8.Text == "7")
            {
                pictureBox8.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek7.png";
            }
            if (label8.Text == "8")
            {
                pictureBox8.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek8.png";
            }
            if (label8.Text == "9")
            {
                pictureBox8.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek9.png";
            }
            if (label8.Text == "10")
            {
                pictureBox8.ImageLocation = " ‪C: \\Users\\Lenovo\\Desktop\\img\\sinek10.png";
            }
            // 4 konumun sonu
        }

    

    // oyun sonu olasılıkları !!!
    private void Button3_Click(object sender, EventArgs e)
    { // button 4 aktifse button3 pasif olur!!
        button4.Enabled = true;
        button3.Enabled = false;
        //oyuncu ve pc karşılaştırması
        int oyuncu, pc;
        oyuncu = Convert.ToInt32(label10.Text);
        pc = Convert.ToInt32(label13.Text);
        //oyuncu pc den buyuk ve 21'e eşit ve küçükse oyuncuskoruna +10 ekle
        if (oyuncu > pc && oyuncu <= 21)
        {
            oycpuan = oycpuan + 10;
            label17.Text = oycpuan.ToString();

        }
        //pc oyuncudan buyuk ve 21'e  eşit ve kücükse pcskoruna +10 ekle
        if (pc > oyuncu && pc <= 21)
        {
            pcpuan = pcpuan + 10;
            label18.Text = pcpuan.ToString();

        }
        // pc ve oyuncu eşitse kasa kazanır!!!
        if (pc >= 22 && oyuncu >= 22)
        {
            MessageBox.Show("KASA KAZANDI");
        }
        //pc ve oyuncu eşit 21 küçükse ikiside kazanır.
        if (pc == oyuncu && pc <= 21 && oyuncu <= 21)
        {
            oycpuan = oycpuan + 10;
            pcpuan = pcpuan + 10;
            label17.Text = oycpuan.ToString();
            label18.Text = pcpuan.ToString();
        }
        // pc 21 den kucuk oyuncu 21 den buyuk ise pc kazanır.
        if (pc <= 21 && oyuncu >= 22)
        {
            pcpuan = pcpuan + 10;
            label18.Text = pcpuan.ToString();
        }
        // oyuncu 21 den kucuk pc 21 den buyuk ise oyuncu kazanır.
        if (oyuncu <= 21 && pc >= 22)
        {
            oycpuan = oycpuan + 10;
            label17.Text = oycpuan.ToString();
        }
        // oyuncu 50 puana eşitlerse kazanır
        if (oycpuan == 50)
        {
            MessageBox.Show("tebrikler kazandınız !!!");
        }
        //pc 50 puan yaparsa oyuncu kaybeder
        if (pcpuan == 50)
        {
            MessageBox.Show("maalesef kaybettiniz");
        }
    }

    private void Button4_Click(object sender, EventArgs e)
    {
        // restart
        label1.Text = "0";
        label2.Text = "0";
        label3.Text = "0";
        label4.Text = "0";
        label5.Text = "0";
        label6.Text = "0";
        label7.Text = "0";
        label8.Text = "0";
        label10.Text = "0";
        label13.Text = "0";
        //button4 pasif button3 aktif durumdadır.
        button4.Enabled = false;
        button3.Enabled = true;

    }
        


    }


    }
