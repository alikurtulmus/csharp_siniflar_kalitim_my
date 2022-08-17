using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_sınıflar_kalitim_my
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //nesne türetmek için; "sınıf adı" + "nesne adı" = "new" + "sınıf adı"
            araba car = new araba(); //car isimli bir nesne türettik
            //nesneler aracılığıyla sınıfların özelliklerine ulaşabiliriz. araba sınıfında 5 tane özellik belirlemiştik. renk, hiz, motor, durum, fiyat

            car.renk = "Mavi";
            car.hiz = 160;
            car.motor = 1245.56;
            car.fiyat = 50000;
            car.durum = 's'; //durum değişkeninin türü char olduğu için tek tırnakta yazdık

            //aşağıdaki özellikleri ayrı bir nesne türetmeden kalıtım özelliği ile araba sınıfına getirdik
            car.muayene = 2017;
            car.plaka= "07 ESN 1996";
            car.sahibi = "Mehmet";

            label1.Text = car.renk;
            label2.Text = car.hiz.ToString();
            label3.Text = car.motor.ToString();
            label4.Text = car.fiyat.ToString();
            label5.Text = car.durum.ToString();
            label6.Text = car.muayene.ToString();
            label7.Text = car.plaka;
            label8.Text = car.sahibi;

            pictureBox1.BackColor = Color.CadetBlue;
        }
    }
}
