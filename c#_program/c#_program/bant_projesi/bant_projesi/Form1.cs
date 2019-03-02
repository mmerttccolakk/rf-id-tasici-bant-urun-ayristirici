using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bant_projesi
{
    public partial class Form1 : Form
    {
        string sonuc;//gelen data
        int log_say=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void baglan_b_Click(object sender, EventArgs e)
        {
            baglan();
        }

        private void portlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti_ac();
            
        }

        private void portlar_Click(object sender, EventArgs e)
        {
            if (portlar.Text == "Bağlantı Seçin")
            {
                portlar.Items.Clear();
                for (int i = 0; i < System.IO.Ports.SerialPort.GetPortNames().Length; i++)
                {
                    portlar.Items.Add(System.IO.Ports.SerialPort.GetPortNames()[i]);
                }
            }
        }

        public void baglan()
        {//port açılıp bağlanılıyor
            if (serialPort1.IsOpen == false)
            {
                serialPort1.PortName = portlar.Text;
                serialPort1.BaudRate = Convert.ToInt32(haberlesme_hiz.Text);
                baglanti_bildirim.Text = "Bağlanılıyor...";
                try
                {
                    serialPort1.Open();
                    baglan_b.Text = "Bağlantıyı Kes";
                    periyodik_kontrol.Enabled = true;
                    baglanti_bildirim.Text = "Bağlanıldı.";

                }
                catch (Exception hata)
                {
                    periyodik_kontrol.Enabled = false;
                    baglanti_bildirim.Text = "Hata:" + hata.Message;
                    serialPort1.Close();
                    baglan_b.Text = "Bağlan";
                    baglanti_bildirim.Text = "Bağlantı Yok";
                    baglan_b.Enabled = false;
                    portlar.Enabled = true;
                    haberlesme_hiz.Enabled = true;
                    portlar.Text = "Bağlantı Seçin";
                    portlar.Items.Clear();
                }
            }
            else
            {
                serialPort1.Close();
                baglan_b.Text = "Bağlan";
                baglanti_bildirim.Text = "Bağlantı Yok";
                periyodik_kontrol.Enabled = false;
                baglan_b.Enabled = false;
                portlar.Enabled = true;
                haberlesme_hiz.Enabled = true;
                portlar.Text = "Bağlantı Seçin";
                portlar.Items.Clear();
            }
        }
        public void baglanti_ac()
        {
            //comboBox üzerinden port seçildi butonlar açılıp timer ve comboboxlar kapatılacak
            baglan_b.Enabled = true;
            portlar.Enabled = false;
        }
        private void periyodik_kontrol_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false) { baglan(); }
        }
        public void verigonder(String deger)
        {
            if (serialPort1.IsOpen == true)
            {
                deger = deger + "\n";
                serialPort1.Write(deger);
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                sonuc = serialPort1.ReadLine();
                isle(sonuc);
            }
        }
        private void isle(string sonuc)
        {
            BeginInvoke(new EventHandler(delegate
            {
                anlik_veri.Text = sonuc;

            }));
        }

        private void anlik_veri_TextChanged(object sender, EventArgs e)
        {
            log_say++;
            log_kayit.Items.Add(log_say + ":" + sonuc);
            log_kayit.SelectedIndex = log_kayit.Items.Count - 1;
            log_kayit.SetSelected(log_kayit.Items.Count - 1, false);
        }

        private void veri_temizle_Click(object sender, EventArgs e)
        {
            log_kayit.Items.Clear();
            log_say = 0;
        }

        private void veri_gonder_Click(object sender, EventArgs e)
        {
            verigonder(veri_giris.Text);
            log_say++;
            log_kayit.Items.Add(log_say + ":" + veri_giris.Text);
            veri_giris.Text = "";
        }
    }
}
