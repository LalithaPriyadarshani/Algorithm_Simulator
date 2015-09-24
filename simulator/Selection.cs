using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace simulator
{
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1_f.Text = textBox1.Text;
            lbl2_f.Text = textBox2.Text;
            lbl3_f.Text = textBox3.Text;
            lbl4_f.Text = textBox4.Text;
            lbl5_f.Text = textBox5.Text;

            int j = 0;
            int i=0;
            int smallest;
            Label[] myLabels = { lbl1_f, lbl2_f, lbl3_f, lbl4_f, lbl5_f };

            try
            {
                while (i < 3)
                {
                    if (i == 0)
                    {
                        smallest = 0;

                        for (int x = j + 1; x < 5; x++)
                        {
                            if (Convert.ToInt32(myLabels[smallest].Text) > Convert.ToInt32(myLabels[x].Text))
                            {
                                smallest = x;
                            }
                        }

                        string temp;
                        myLabels[0].BackColor = Color.Yellow;
                        myLabels[smallest].BackColor = Color.Yellow;
                        temp = myLabels[0].Text;
                        myLabels[0].Text = myLabels[smallest].Text;
                        myLabels[smallest].Text = temp;

                        i = i + 1;
                        j = j + 1;

                        this.Refresh();
                        System.Threading.Thread.Sleep(3000);
                        myLabels[0].BackColor = Color.Violet;
                        myLabels[smallest].BackColor = Color.Violet;

                        lbl1.Text = lbl1_f.Text;
                        lbl2.Text = lbl2_f.Text;
                        lbl3.Text = lbl3_f.Text;
                        lbl4.Text = lbl4_f.Text;
                        lbl5.Text = lbl5_f.Text;
                        this.Refresh();
                        System.Threading.Thread.Sleep(3000);
                    }

                    if (i == 1)
                    {
                        smallest = 1;

                        for (int x = j + 1; x < 5; x++)
                        {
                            if (Convert.ToInt32(myLabels[smallest].Text) > Convert.ToInt32(myLabels[x].Text))
                            {
                                smallest = x;
                            }
                        }

                        string temp;
                        myLabels[1].BackColor = Color.Yellow;
                        myLabels[smallest].BackColor = Color.Yellow;
                        temp = myLabels[1].Text;
                        myLabels[1].Text = myLabels[smallest].Text;
                        myLabels[smallest].Text = temp;

                        i = i + 1;
                        j = j + 1;

                        this.Refresh();
                        System.Threading.Thread.Sleep(3000);
                        myLabels[1].BackColor = Color.Violet;
                        myLabels[smallest].BackColor = Color.Violet;

                        lbl6.Text = lbl1_f.Text;
                        lbl7.Text = lbl2_f.Text;
                        lbl8.Text = lbl3_f.Text;
                        lbl9.Text = lbl4_f.Text;
                        lbl10.Text = lbl5_f.Text;

                        this.Refresh();
                        System.Threading.Thread.Sleep(3000);
                    }

                    if (i == 2)
                    {
                        smallest = 2;

                        for (int x = j + 1; x < 5; x++)
                        {
                            if (Convert.ToInt32(myLabels[smallest].Text) > Convert.ToInt32(myLabels[x].Text))
                            {
                                smallest = x;
                            }
                        }

                        string temp;
                        myLabels[2].BackColor = Color.Yellow;
                        myLabels[smallest].BackColor = Color.Yellow;
                        temp = myLabels[2].Text;
                        myLabels[2].Text = myLabels[smallest].Text;
                        myLabels[smallest].Text = temp;

                        i = i + 1;
                        j = j + 1;

                        this.Refresh();
                        System.Threading.Thread.Sleep(3000);
                        myLabels[2].BackColor = Color.Violet;
                        myLabels[smallest].BackColor = Color.Violet;

                        lbl11.Text = lbl1_f.Text;
                        lbl12.Text = lbl2_f.Text;
                        lbl13.Text = lbl3_f.Text;
                        lbl14.Text = lbl4_f.Text;
                        lbl15.Text = lbl5_f.Text;

                        this.Refresh();
                        System.Threading.Thread.Sleep(3000);
                    }


                    if (i == 3)
                    {
                        smallest = 3;

                        for (int x = j + 1; x < 5; x++)
                        {
                            if (Convert.ToInt32(myLabels[smallest].Text) > Convert.ToInt32(myLabels[x].Text))
                            {
                                smallest = x;
                            }
                        }

                        string temp;
                        myLabels[3].BackColor = Color.Yellow;
                        myLabels[smallest].BackColor = Color.Yellow;
                        temp = myLabels[3].Text;
                        myLabels[3].Text = myLabels[smallest].Text;
                        myLabels[smallest].Text = temp;

                        i = i + 1;
                        j = j + 1;

                        this.Refresh();
                        System.Threading.Thread.Sleep(3000);
                        myLabels[3].BackColor = Color.Violet;
                        myLabels[smallest].BackColor = Color.Violet;

                        lbl16.Text = lbl1_f.Text;
                        lbl17.Text = lbl2_f.Text;
                        lbl18.Text = lbl3_f.Text;
                        lbl19.Text = lbl4_f.Text;
                        lbl20.Text = lbl5_f.Text;
                        this.Refresh();
                        System.Threading.Thread.Sleep(3000);
                    }

                    myLabels[4].BackColor = Color.Violet;



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Outputs");
            }
           

         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
