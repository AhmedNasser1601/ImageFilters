using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZGraphTools;

namespace ImageFilters
{
    public partial class Form1 : Form
    {
        int flag; 
        double[] tim1 = new double[40];
        double[] tim2 = new double[40];
        int AM;
      
        public Form1()
        {
            InitializeComponent();
        }

        byte[,] ImageMatrix;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the browsed image and display it
                string OpenedFilePath = openFileDialog1.FileName;
                ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);
                ImageOperations.DisplayImage(ImageMatrix, pictureBox1);

            }
        }

        private void btnZGraph_Click(object sender, EventArgs e)
        {
            // Make up some data points from the N, N log(N) functions
            int N = 40;
   
            double[] M = new double[N];        
            double[] y_values_NLogN = new double[N];

            Zg z = new Zg();
            M =z.xaxis(AM);
           
            //Create a graph and add two curves to it
            switch(flag)
            {
                case 1:
                    {
                        ZGraphForm ZGF = new ZGraphForm("Adaptive", "Window Size", "Time");
                        ZGF.add_curve("Count", M, tim1, Color.Red);
                        ZGF.add_curve("Quick", M, tim2, Color.Blue);
                        ZGF.Show();
                        break;
                    }
                case 2:
                    {
                        ZGraphForm ZGF = new ZGraphForm("Alpha Trim", "Window Size", "Time");
                        ZGF.add_curve("Count", M, tim1, Color.Red);
                        ZGF.add_curve("Rondomization", M, tim2, Color.Blue);
                        ZGF.Show();
                        break;
                    }

            }
            
            
        }

        public void Filter_btn_Click(object sender, EventArgs e)
        {
            byte[,] ImageMatrix2 = ImageMatrix;

            DateTime ti = DateTime.Now;
            byte[,] Image = new byte[ImageOperations.GetHeight(ImageMatrix), ImageOperations.GetWidth(ImageMatrix)];
            ADAPTIVE ad = new ADAPTIVE();

            //Max Window size
            String mw =MaxW_TB.Text;
            int MW=int.Parse(mw);

            //Window Size
            String ws  = textBox1.Text;
            int WS = int.Parse(ws);
            if (MW % 2 == 0)
            {
                MW++;
            }
            int Cho = 0;
            int q = 3;
            for (int i = 3; i <= MW; i+=2)
            {
                if (Adaptive_RB.Checked)
                {
                    flag = 1;
                    if (Count_RB.Checked)
                    {
                        for (int y = 0; y < ImageOperations.GetHeight(ImageMatrix); y++)
                        {
                            for (int x = 0; x < ImageOperations.GetWidth(ImageMatrix); x++)
                            {
                                ADAPTIVE n = new ADAPTIVE();
                                ImageMatrix2[y, x] = n.adap(ImageMatrix, x, y, WS, MW, 2);
                            }
                        }

                    }
                    else if (Quick_RB.Checked)
                    {
                        for (int y = 0; y < ImageOperations.GetHeight(ImageMatrix); y++)
                        {
                            for (int x = 0; x < ImageOperations.GetWidth(ImageMatrix); x++)
                            {
                                ADAPTIVE n = new ADAPTIVE();
                                ImageMatrix2[y, x] = n.adap(ImageMatrix, x, y, WS, MW, 1);
                            }
                        }
                    }
                }
                else if (Alpha_RB.Checked)
                {
                    flag = 2;
                    //T elements
                    String t = T_tb.Text;
                    int T = int.Parse(t);

                    if (Count_RB2.Checked)
                    {
                        Alpha a = new Alpha();
                       ImageMatrix2= a.Al(ImageMatrix, 1, T, WS, MW);
                    }
                    if (Rondom_RB2.Checked)
                    {
                        Alpha a = new Alpha();
                      ImageMatrix2=  a.Al(ImageMatrix, 2, T, WS, MW);
                    }
                }

                TimeSpan time = DateTime.Now - ti;
                Time_lbl.Text = (time.Seconds + " . " + time.Milliseconds + "   Seconds").ToString();
                ImageOperations.DisplayImage(ImageMatrix2, pictureBox2);
               if(Count_RB.Checked || Count_RB2.Checked)
                {
                    tim1[Cho] = time.TotalSeconds;
                }
               if(Quick_RB.Checked || Rondom_RB2.Checked)
                {
                    tim2[Cho] = time.TotalSeconds;
                }
                
                AM = MW;
                Cho++; 
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Count_RB2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Adaptive_RB_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            T_tb.Visible = false;
            T_lb.Visible = false;
        }

        private void Alpha_RB_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible= true;
            groupBox2.Visible = false;
            T_tb.Visible = true;
            T_lb.Visible = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void T_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void T_lb_Click(object sender, EventArgs e)
        {

        }
    }
}