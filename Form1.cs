using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikFormElemanları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblSkor.Text = "0";
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            int mayin1 = 0;
            int mayin2 = 0;
            int mayin3 = 0;

            Random rnd = new Random();
            mayin1= rnd.Next(0, 20);
            mayin2 = rnd.Next(21, 35);
            mayin3 = rnd.Next(36, 49);
            for (int i=0; i<50; i++)
            {
                Button btnTemp = new Button();
                btnTemp.Name = "btn" + i.ToString();
                btnTemp.Size = new System.Drawing.Size(35, 35);
                btnTemp.Text = i.ToString();
                btnTemp.UseVisualStyleBackColor = true;
                if(mayin1==i || mayin2==i || mayin3==i)
                {
                    btnTemp.Tag = true;

                }

                else
                {
                    btnTemp.Tag = false;
                }

                //btnTemp.Tag = null;
                btnTemp.Click += BtnTemp_Click;
                flowLayoutPanel1.Controls.Add(btnTemp);


            }
        }

        private void BtnTemp_Click(object sender, EventArgs e)
        {
            Button basilanButon = ((Button)sender);
            bool mayinbulundumu= (bool)basilanButon.Tag;
            if (mayinbulundumu)
            {
                MessageBox.Show("Mayına bastınız");
                basilanButon.BackColor = Color.Red;
                int mayinInt = int.Parse(lblmayin.Text);
                mayinInt++;
                lblmayin.Text = mayinInt.ToString();
                

                
            }

            else
            {
                basilanButon.BackColor = Color.Green;
                int skorInt = int.Parse(lblSkor.Text);
                skorInt++;
                lblSkor.Text = skorInt.ToString();
            }
            if (int.Parse(lblmayin.Text) == 3)

            {

                foreach (Button item in flowLayoutPanel1.Controls)

                {

                    item.Enabled = false;

                }

                MessageBox.Show("Oyun Bitti");

            }
        }


    }
}
