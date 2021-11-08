using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Nasledovanie
{ 
    public partial class Form1 : Form
    {
        List<Pets> petslist = new List<Pets>();

        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.petslist.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) 
                {
                    case 0: 
                        this.petslist.Add(new Cow
                        {
                            horn = 20 - rnd.Next() % 6,
                            milk = rnd.Next() % 16
                        });
                        break;
                    case 1: 
                        this.petslist.Add(new Dog
                        {
                            lengthtail = 15 - rnd.Next() % 10,
                            lengthcommands = 300 - rnd.Next() % 201,
                            type = (DogType)rnd.Next(6)
                        });
                        break;
                    case 2: 
                        this.petslist.Add(new Cat
                        {
                            fur = rnd.Next() % 2 == 0,
                            killsmouse = rnd.Next() % 11

                        });
                        break; 
                }
            }
            
            rtbqueue.Text = "След.\n";
            for(int i = 0; i < petslist.Count; i++)
            {
                if (Convert.ToString(petslist.ElementAt(i)) == "Lab4_Nasledovanie.Dog")
                {
                    rtbqueue.Text += "Собака\n";
                }
                else if (Convert.ToString(petslist.ElementAt(i)) == "Lab4_Nasledovanie.Cow")
                {
                    rtbqueue.Text += "Корова\n";
                }
                else if (Convert.ToString(petslist.ElementAt(i)) == "Lab4_Nasledovanie.Cat")
                {
                    rtbqueue.Text += "Кошка\n";
                }
            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            int cowCount = 0;
            int dogCount = 0;
            int catCount = 0;

            foreach (var pet in this.petslist)
            {
                
                if (pet is Cow) 
                {
                    cowCount += 1;
                }
                else if (pet is Dog)
                {
                    dogCount += 1;
                }
                else if (pet is Cat)
                {
                    catCount += 1;
                }
            }
            
            txtInfo.Text = "Коровы\tСобаки\tКошки"; 
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", cowCount, dogCount, catCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.petslist.Count == 0)
            {
                txtOut.Text = "Пусто ^_^";
                return;
            }
        
            var pet = this.petslist[0];

            rtbqueue.Text = "След.\n";
            for (int i = 1; i < petslist.Count; i++)
            {
                if (Convert.ToString(petslist.ElementAt(i)) == "Lab4_Nasledovanie.Dog")
                {
                    rtbqueue.Text += "Собака\n";
                }
                else if (Convert.ToString(petslist.ElementAt(i)) == "Lab4_Nasledovanie.Cow")
                {
                    rtbqueue.Text += "Корова\n";
                }
                else if (Convert.ToString(petslist.ElementAt(i)) == "Lab4_Nasledovanie.Cat")
                {
                    rtbqueue.Text += "Кошка\n";
                }
            }
            this.petslist.RemoveAt(0);
            txtOut.Text = pet.GetInfo();
            ShowInfo();
        }
    }
}

