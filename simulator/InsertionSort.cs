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
    public partial class InsertionSort : Form
    {
        public InsertionSort()
        {
            InitializeComponent();

            arrow1.Visible = false;
            arrow2.Visible = false;
            arrow3.Visible = false;
            arrow4.Visible = false;
            arrow6.Visible = false;
            arrow7.Visible = false;
            arrow8.Visible = false;
            arrow9.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1.Text = txtbox1.Text;
            lbl2.Text = txtbox2.Text;
            lbl3.Text = txtbox3.Text;
            lbl4.Text = txtbox4.Text;
            lbl5.Text = txtbox5.Text;

            Label[] myLabels = new Label[] { lbl1, lbl2, lbl3, lbl4, lbl5 };
            //int[] arr = new int[5];

            //for (int x = 0; x < myLabels.Length; x++)
            //{

            //    myLabels[x].Text = Convert.ToString(arr[x]);

            //}
            int i = 0;
            try
            {
                while (i < 4)
                {
                    if (i == 0 && Convert.ToInt32(lbl1.Text) > Convert.ToInt32(lbl2.Text))
                    {
                        arrow1.Visible = true;
                        lbl2.BackColor = Color.Yellow;
                        this.Refresh();
                        System.Threading.Thread.Sleep(2000);

                        string temp = lbl1.Text;
                        lbl1.Text = lbl2.Text;
                        arrow6.Visible = true;
                        lbl1.BackColor = Color.Yellow;
                        this.Refresh();
                        System.Threading.Thread.Sleep(2000);

                        lbl2.Text = temp;
                        i = i + 1;
                        this.Refresh();
                        System.Threading.Thread.Sleep(2000);
                        arrow1.Visible = false;
                        arrow6.Visible = false;
                        lbl1.BackColor = Color.OrangeRed;
                        lbl2.BackColor = Color.OrangeRed;


                    }



                    else if (i == 1 && Convert.ToInt32(lbl2.Text) > Convert.ToInt32(lbl3.Text))
                    {
                        arrow2.Visible = true;
                        lbl3.BackColor = Color.Yellow;
                        this.Refresh();
                        System.Threading.Thread.Sleep(2000);

                        string temp = lbl2.Text;
                        lbl2.Text = lbl3.Text;
                        arrow7.Visible = true;
                        lbl2.BackColor = Color.Yellow;
                        this.Refresh();
                        System.Threading.Thread.Sleep(2000);


                        lbl3.Text = temp;
                        this.Refresh();
                        System.Threading.Thread.Sleep(2000);
                        arrow2.Visible = false;
                        arrow7.Visible = false;

                        lbl3.BackColor = Color.OrangeRed;
                        lbl2.BackColor = Color.OrangeRed;

                        if (Convert.ToInt32(lbl1.Text) > Convert.ToInt32(lbl2.Text))
                        {
                            arrow1.Visible = true;
                            lbl2.BackColor = Color.Yellow;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);

                            string temp1 = lbl1.Text;
                            lbl1.Text = lbl2.Text;
                            arrow6.Visible = true;
                            lbl1.BackColor = Color.Yellow;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);


                            lbl2.Text = temp1;
                            //    i = i + 1;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);

                            arrow1.Visible = false;
                            arrow6.Visible = false;
                            lbl1.BackColor = Color.OrangeRed;
                            lbl2.BackColor = Color.OrangeRed;
                        }
                        //System.Threading.Thread.Sleep(50);
                        i = i + 1;

                    }

                    else if (i == 2 && Convert.ToInt32(lbl3.Text) > Convert.ToInt32(lbl4.Text))
                    {
                        arrow3.Visible = true;
                        lbl4.BackColor = Color.Yellow;
                        this.Refresh();
                        System.Threading.Thread.Sleep(2000);


                        string temp = lbl3.Text;
                        lbl3.Text = lbl4.Text;
                        arrow8.Visible = true;
                        lbl3.BackColor = Color.Yellow;
                        this.Refresh();
                        System.Threading.Thread.Sleep(2000);


                        lbl4.Text = temp;

                        this.Refresh();
                        System.Threading.Thread.Sleep(2000);
                        arrow3.Visible = false;
                        arrow8.Visible = false;
                        lbl3.BackColor = Color.OrangeRed;
                        lbl4.BackColor = Color.OrangeRed;
                        if (Convert.ToInt32(lbl2.Text) > Convert.ToInt32(lbl3.Text))
                        {
                            arrow2.Visible = true;
                            lbl3.BackColor = Color.Yellow;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);


                            string temp1 = lbl2.Text;
                            lbl2.Text = lbl3.Text;
                            arrow7.Visible = true;
                            lbl2.BackColor = Color.Yellow;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);


                            lbl3.Text = temp1;
                            //    i = i + 1;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);
                            arrow2.Visible = false;
                            arrow7.Visible = false;
                            lbl3.BackColor = Color.OrangeRed;
                            lbl2.BackColor = Color.OrangeRed;

                        }

                        if (Convert.ToInt32(lbl1.Text) > Convert.ToInt32(lbl2.Text))
                        {
                            arrow1.Visible = true;
                            lbl2.BackColor = Color.Yellow;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);


                            string temp2 = lbl1.Text;
                            lbl1.Text = lbl2.Text;
                            arrow6.Visible = true;
                            lbl1.BackColor = Color.Yellow;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);

                            lbl2.Text = temp2;
                            //    i = i + 1;

                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);
                            arrow1.Visible = false;
                            arrow6.Visible = false;
                            lbl1.BackColor = Color.OrangeRed;
                            lbl2.BackColor = Color.OrangeRed;
                        }
                        //System.Threading.Thread.Sleep(50);
                        i = i + 1;

                    }
                    else if (i == 3 && Convert.ToInt32(lbl4.Text) > Convert.ToInt32(lbl5.Text))
                    {
                        arrow4.Visible = true;
                        lbl5.BackColor = Color.Yellow;
                        this.Refresh();
                        System.Threading.Thread.Sleep(2000);


                        string temp = lbl4.Text;
                        lbl4.Text = lbl5.Text;
                        arrow9.Visible = true;
                        lbl4.BackColor = Color.Yellow;
                        this.Refresh();
                        System.Threading.Thread.Sleep(2000);

                        lbl5.Text = temp;

                        this.Refresh();
                        System.Threading.Thread.Sleep(2000);

                        arrow4.Visible = false;
                        arrow9.Visible = false;

                        lbl4.BackColor = Color.OrangeRed;
                        lbl5.BackColor = Color.OrangeRed;

                        if (Convert.ToInt32(lbl3.Text) > Convert.ToInt32(lbl4.Text))
                        {
                            arrow3.Visible = true;
                            lbl4.BackColor = Color.Yellow;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);


                            string temp3 = lbl3.Text;
                            lbl3.Text = lbl4.Text;
                            arrow8.Visible = true;
                            lbl3.BackColor = Color.Yellow;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);


                            lbl4.Text = temp3;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);

                            arrow3.Visible = false;
                            arrow8.Visible = false;
                            lbl3.BackColor = Color.OrangeRed;
                            lbl4.BackColor = Color.OrangeRed;
                        }

                        if (Convert.ToInt32(lbl2.Text) > Convert.ToInt32(lbl3.Text))
                        {
                            arrow2.Visible = true;
                            lbl3.BackColor = Color.Yellow;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);


                            string temp1 = lbl2.Text;
                            lbl2.Text = lbl3.Text;
                            arrow7.Visible = true;
                            lbl2.BackColor = Color.Yellow;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);


                            lbl3.Text = temp1;
                            //    i = i + 1;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);
                            arrow2.Visible = false;
                            arrow7.Visible = false;
                            lbl3.BackColor = Color.OrangeRed;
                            lbl2.BackColor = Color.OrangeRed;
                        }

                        if (Convert.ToInt32(lbl1.Text) > Convert.ToInt32(lbl2.Text))
                        {
                            arrow1.Visible = true;
                            lbl2.BackColor = Color.Yellow;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);


                            string temp2 = lbl1.Text;
                            lbl1.Text = lbl2.Text;
                            arrow6.Visible = true;
                            lbl1.BackColor = Color.Yellow;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);


                            lbl2.Text = temp2;
                            //    i = i + 1;
                            this.Refresh();
                            System.Threading.Thread.Sleep(2000);

                            arrow1.Visible = false;
                            arrow6.Visible = false;

                            lbl1.BackColor = Color.OrangeRed;
                            lbl2.BackColor = Color.OrangeRed;
                        }


                        //  System.Threading.Thread.Sleep(50);



                        i = i + 1;

                    }
                    else
                    {
                        i = i + 1;
                    }




                }

                lblMsg.Text = "Succesfully Sorted";
            }
            catch (Exception ex)            {
                MessageBox.Show("Invalid input");
            }
        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void arrow3_Click(object sender, EventArgs e)
        {

        }


    }
}
