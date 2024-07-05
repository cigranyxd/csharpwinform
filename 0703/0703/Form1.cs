using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0703
{

    public partial class Form1 : Form
    {
        private bool lathato;

        private List <Pizza> pizzak = new List<Pizza>();
        private List<CheckBox> jeloloNegyzetek = new List<CheckBox>();
        private List<RadioButton> rdBtnKicsiArak = new List<RadioButton>();
        private List<RadioButton> rdBtnNagyArak = new List<RadioButton>();
        private List<TextBox> txtDarabok = new List<TextBox>();

        private int bal = 20, fent = 10;

        private int kozY = 40;
        private int meretY = 20;
        private int panelX = 200;
        private int meretChk = 120;
        private int meretAr = 50;
        private int meretFt = 40;
        private int meretDb = 50;
        private int koz = 3;
        class Pizza
        {
            public string Nev { get; private set; }
            public int ArKicsi { get; set; }
            public int ArNagy { get; set; }

            public Pizza(string nev, int arKicsi, int arNagy)
            {
                Nev = nev;
                ArKicsi = arKicsi;
                ArNagy = arNagy;
            }

            public override string ToString()
            {
                return this.Nev;
            }
        }
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            openFileDialog1.FileName = "";

            lathato = false;
            LathatosagBeallitas(lathato);
        }

        private void LathatosagBeallitas(bool lathatoE) 
        {
            foreach(Control item in this.Controls)
            {
                item.Visible = lathatoE;
            }
            btnAdatBe.Visible = !lathatoE;
        }

        private void btnAdatBe_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamReader sr = null;
                try
                {
                    string fajlNev = openFileDialog1.FileName;
                    sr = new StreamReader(fajlNev);

                    AdatBeolvasas(sr);

                    ValasztekFeltoltes();

                    lathato = true;
                    LathatosagBeallitas(lathato);
                    btnAdatBe.Visible = false;
                    this.BackgroundImage = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "hibaüzenet a fejlesztő számára");
                }
                finally
                {
                    if (sr != null) 
                    {
                        sr.Close();
                    }
                }
            }
        }
        private void ValasztekFeltoltes()
        {
            CheckBox checkBox;
            Label label;
            RadioButton radioButton;
            Panel panel;
            TextBox textBox;

            for (int i = 0; i < pizzak.Count; i++) 
            {
                checkBox = new CheckBox();
                checkBox.TextAlign = ContentAlignment.MiddleLeft; checkBox.Text = pizzak[i].Nev;
                checkBox.Location = new Point(bal, fent + i * kozY); checkBox.Size = new Size(meretChk, meretY);
                // a most beállított jelölőnégyzetet hozzáadjuk // a jelölőnégyzetek listájához jeloloNegyzetek.Add(checkBox);
                // a most beállított jelölőnégyzetet rárakjuk // a központi panelre pnlkozponti.Controls.Add(checkBox);
                // panel felrakása
                panel = new Panel();
                panel.Size = new Size(panelX, meretY);
                panel.Location = new Point(bal + meretChk, fent + i * kozY);
                // A panelt rárakjuk a központi panelre pnlkozponti.Controls.Add(panel);
                pnlKozponti.Controls.Add(panel);

                // radiobtn kicsi ár felrakása radioButton = new RadioButton();
                  radioButton = new RadioButton();
                  radioButton.Size = new Size(meretAr, meretY); radioButton.TextAlign = ContentAlignment.MiddleRight; radioButton.Text = pizzak[i].ArKicsi.ToString(); radioButton.Location = new Point(0, 0);
                rdBtnKicsiArak.Add(radioButton);
                // A rádiógombot rárakjuk az őket tartalmazó panelre panel.Controls.Add(radioButton);
                // Fix Ft felirat
                label = new Label();
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Text = " Ft";
                label.Location = new Point(meretAr + koz, 0); label.Size = new Size(meretFt, meretY);
                panel.Controls.Add(label);
            }
        }

    }
}


