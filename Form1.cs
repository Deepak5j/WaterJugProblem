using System;
using System.Drawing;
using System.Windows.Forms;

namespace WaterJugProblem
{
    public partial class Form1 : Form
    {
        int steps = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Resource1._5jar5);
            steps++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = new Bitmap(Resource1._3jar3);
            steps++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Resource1._5jar0);
            steps++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = new Bitmap(Resource1._3jar0);
            steps++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string curImgPar = "";
            if(pictureBox1.Image.Width == 200)
            {
                curImgPar = "Height" + pictureBox1.Image.Height.ToString();
            }
            else
            {
                curImgPar = "Width" + pictureBox1.Image.Width.ToString();
            }
            
            switch(curImgPar)
            {
                case "Width201":
                    //MessageBox.Show("5 j 1"); 
                    if(pictureBox2.Image.Width == 201)
                    {
                        //1
                        pictureBox2.Image = new Bitmap(Resource1._3jar2);
                        pictureBox1.Image = new Bitmap(Resource1._5jar0);
                        steps++;
                    }
                    else
                    {
                        //2
                        if (pictureBox2.Image.Width == 199)
                        {
                            pictureBox2.Image = new Bitmap(Resource1._3jar3);
                            pictureBox1.Image = new Bitmap(Resource1._5jar0);
                            steps++;
                        }
                        else
                        {
                            //3
                            if (pictureBox2.Image.Height == 201)
                            {
                                pictureBox2.Image = new Bitmap(Resource1._3jar3);
                                pictureBox1.Image = new Bitmap(Resource1._5jar1);
                                steps++;
                            }
                            else
                            {
                                //0
                                pictureBox2.Image = new Bitmap(Resource1._3jar1);
                                pictureBox1.Image = new Bitmap(Resource1._5jar0);
                                steps++;
                            }
                        }
                    }
                    break;
                case "Height201":
                    //MessageBox.Show("5 j 2");
                    if (pictureBox2.Image.Width == 201)
                    {
                        //1
                        pictureBox2.Image = new Bitmap(Resource1._3jar3);
                        pictureBox1.Image = new Bitmap(Resource1._5jar0);
                        steps++;
                    }
                    else
                    {
                        //2
                        if (pictureBox2.Image.Width == 199)
                        {
                            pictureBox2.Image = new Bitmap(Resource1._3jar3);
                            pictureBox1.Image = new Bitmap(Resource1._5jar1);
                            steps++;
                        }
                        else
                        {
                            //3
                            if (pictureBox2.Image.Height == 201)
                            {
                                pictureBox2.Image = new Bitmap(Resource1._3jar3);
                                pictureBox1.Image = new Bitmap(Resource1._5jar2);
                                steps++;
                            }
                            else
                            {
                                //0
                                pictureBox2.Image = new Bitmap(Resource1._3jar2);
                                pictureBox1.Image = new Bitmap(Resource1._5jar0);
                                steps++;
                            }
                        }
                    }
                    break;
                case "Width199":
                    //MessageBox.Show("5 j 3");
                    if (pictureBox2.Image.Width == 201)
                    {
                        //1
                        pictureBox2.Image = new Bitmap(Resource1._3jar3);
                        pictureBox1.Image = new Bitmap(Resource1._5jar1);
                        steps++;
                    }
                    else
                    {
                        //2
                        if (pictureBox2.Image.Width == 199)
                        {
                            pictureBox2.Image = new Bitmap(Resource1._3jar3);
                            pictureBox1.Image = new Bitmap(Resource1._5jar2);
                            steps++;
                        }
                        else
                        {
                            //3
                            if (pictureBox2.Image.Height == 201)
                            {
                                pictureBox2.Image = new Bitmap(Resource1._3jar3);
                                pictureBox1.Image = new Bitmap(Resource1._5jar3);
                                steps++;
                            }
                            else
                            {
                                //0
                                pictureBox2.Image = new Bitmap(Resource1._3jar3);
                                pictureBox1.Image = new Bitmap(Resource1._5jar0);
                                steps++;
                            }
                        }
                    }
                    break;
                case "Height199":
                    //MessageBox.Show("5 j 4");
                    if (pictureBox2.Image.Width == 201)
                    {
                        //1
                        pictureBox2.Image = new Bitmap(Resource1._3jar3);
                        pictureBox1.Image = new Bitmap(Resource1._5jar2);
                        steps++;
                    }
                    else
                    {
                        //2
                        if (pictureBox2.Image.Width == 199)
                        {
                            pictureBox2.Image = new Bitmap(Resource1._3jar3);
                            pictureBox1.Image = new Bitmap(Resource1._5jar3);
                            steps++;
                        }
                        else
                        {
                            //3
                            if (pictureBox2.Image.Height == 201)
                            {
                                pictureBox2.Image = new Bitmap(Resource1._3jar3);
                                pictureBox1.Image = new Bitmap(Resource1._5jar4);
                                steps++;
                            }
                            else
                            {
                                //0
                                pictureBox2.Image = new Bitmap(Resource1._3jar3);
                                pictureBox1.Image = new Bitmap(Resource1._5jar1);
                                steps++;
                            }
                        }
                    }
                    break;
                case "Width202":
                    //MessageBox.Show("5 j 5"); 
                    //1
                    if (pictureBox2.Image.Width == 201)
                    {
                        pictureBox2.Image = new Bitmap(Resource1._3jar3);
                        pictureBox1.Image = new Bitmap(Resource1._5jar3);
                        steps++;
                    }
                    else
                    {
                        //2
                        if (pictureBox2.Image.Width == 199)
                        {
                            pictureBox2.Image = new Bitmap(Resource1._3jar3);
                            pictureBox1.Image = new Bitmap(Resource1._5jar4);
                            steps++;
                        }
                        else
                        {
                            //3
                            if (pictureBox2.Image.Height == 201)
                            {
                                pictureBox2.Image = new Bitmap(Resource1._3jar3);
                                pictureBox1.Image = new Bitmap(Resource1._5jar5);
                                steps++;
                            }
                            else
                            {
                                //0
                                pictureBox2.Image = new Bitmap(Resource1._3jar3);
                                pictureBox1.Image = new Bitmap(Resource1._5jar2);
                                steps++;
                            }
                        }
                    }
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string curImgPar = "";
            if (pictureBox2.Image.Width == 200)
            {
                curImgPar = "Height" + pictureBox2.Image.Height.ToString();
            }
            else
            {
                curImgPar = "Width" + pictureBox2.Image.Width.ToString();
            }

            switch (curImgPar)
            {
                case "Width201":
                    //MessageBox.Show("3 j 1"); 
                    //1
                    if (pictureBox1.Image.Width == 201)
                    {
                        pictureBox1.Image = new Bitmap(Resource1._5jar2);
                        pictureBox2.Image = new Bitmap(Resource1._3jar0);
                        steps++;
                    }
                    else
                    {
                        //2
                        if (pictureBox1.Image.Height == 201)
                        {
                            pictureBox1.Image = new Bitmap(Resource1._5jar3);
                            pictureBox2.Image = new Bitmap(Resource1._3jar0);
                            steps++;
                        }
                        else
                        {
                            //3
                            if (pictureBox1.Image.Width == 199)
                            {
                                pictureBox1.Image = new Bitmap(Resource1._5jar4);
                                pictureBox2.Image = new Bitmap(Resource1._3jar0);
                                steps++;
                            }
                            else
                            {
                                //4
                                if (pictureBox1.Image.Height == 199)
                                {
                                    pictureBox1.Image = new Bitmap(Resource1._5jar5);
                                    pictureBox2.Image = new Bitmap(Resource1._3jar0);
                                    steps++;
                                }
                                else
                                {
                                    //5
                                    if (pictureBox1.Image.Width == 202)
                                    {
                                        pictureBox1.Image = new Bitmap(Resource1._5jar5);
                                        pictureBox2.Image = new Bitmap(Resource1._3jar1);
                                        steps++;
                                    }
                                    else
                                    {
                                        //0
                                        pictureBox1.Image = new Bitmap(Resource1._5jar1);
                                        pictureBox2.Image = new Bitmap(Resource1._3jar0);
                                        steps++;
                                    }
                                }
                            }

                        }
                    }
                    break;
                case "Width199":
                    //MessageBox.Show("3 j 2"); 
                    //1
                    if (pictureBox1.Image.Width == 201)
                    {
                        pictureBox1.Image = new Bitmap(Resource1._5jar3);
                        pictureBox2.Image = new Bitmap(Resource1._3jar0);
                        steps++;
                    }
                    else
                    {
                        //2
                        if (pictureBox1.Image.Height == 201)
                        {
                            pictureBox1.Image = new Bitmap(Resource1._5jar4);
                            pictureBox2.Image = new Bitmap(Resource1._3jar0);
                            steps++;
                        }
                        else
                        {
                            //3
                            if (pictureBox1.Image.Width == 199)
                            {
                                pictureBox1.Image = new Bitmap(Resource1._5jar5);
                                pictureBox2.Image = new Bitmap(Resource1._3jar0);
                                steps++;
                            }
                            else
                            {
                                //4
                                if (pictureBox1.Image.Height == 199)
                                {
                                    pictureBox1.Image = new Bitmap(Resource1._5jar5);
                                    pictureBox2.Image = new Bitmap(Resource1._3jar1);
                                    steps++;
                                }
                                else
                                {
                                    //5
                                    if (pictureBox1.Image.Width == 202)
                                    {
                                        pictureBox1.Image = new Bitmap(Resource1._5jar5);
                                        pictureBox2.Image = new Bitmap(Resource1._3jar2);
                                        steps++;
                                    }
                                    else
                                    {
                                        //0
                                        pictureBox1.Image = new Bitmap(Resource1._5jar2);
                                        pictureBox2.Image = new Bitmap(Resource1._3jar0);
                                        steps++;
                                    }
                                }
                            }

                        }
                    }
                    break;
                case "Height201":
                    //MessageBox.Show("3 j 3"); 
                    //1
                    if (pictureBox1.Image.Width == 201)
                    {
                        pictureBox1.Image = new Bitmap(Resource1._5jar4);
                        pictureBox2.Image = new Bitmap(Resource1._3jar0);
                        steps++;
                    }
                    else
                    {
                        //2
                        if (pictureBox1.Image.Height == 201)
                        {
                            pictureBox1.Image = new Bitmap(Resource1._5jar5);
                            pictureBox2.Image = new Bitmap(Resource1._3jar0);
                            steps++;
                        }
                        else
                        {
                            //3
                            if (pictureBox1.Image.Width == 199)
                            {
                                pictureBox1.Image = new Bitmap(Resource1._5jar5);
                                pictureBox2.Image = new Bitmap(Resource1._3jar1);
                                steps++;
                            }
                            else
                            {
                                //4
                                if (pictureBox1.Image.Height == 199)
                                {
                                    pictureBox1.Image = new Bitmap(Resource1._5jar5);
                                    pictureBox2.Image = new Bitmap(Resource1._3jar2);
                                    steps++;
                                }
                                else
                                {
                                    //5
                                    if (pictureBox1.Image.Width == 202)
                                    {
                                        pictureBox1.Image = new Bitmap(Resource1._5jar5);
                                        pictureBox2.Image = new Bitmap(Resource1._3jar3);
                                        steps++;
                                    }
                                    else
                                    {
                                        //0
                                        pictureBox1.Image = new Bitmap(Resource1._5jar3);
                                        pictureBox2.Image = new Bitmap(Resource1._3jar0);
                                        steps++;
                                    }
                                }
                            }

                        }
                    }
                    break;
            
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Resource1._5jar1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Resource1._5jar2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Resource1._5jar3);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Resource1._5jar4);
            steps++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Resource1._5jar5);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = new Bitmap(Resource1._3jar1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = new Bitmap(Resource1._3jar2);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = new Bitmap(Resource1._3jar3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image.Height == 199)
            {
                MessageBox.Show("CONGRATULATION! YOU WON" + "\nDone in " + steps + " Steps");
                pictureBox1.Image = new Bitmap(Resource1._5jar0);
                pictureBox2.Image = new Bitmap(Resource1._3jar0);
                steps = 0;
            }
            else
            {
                MessageBox.Show("FAILED! TRY AGAIN");
                pictureBox1.Image = new Bitmap(Resource1._5jar0);
                pictureBox2.Image = new Bitmap(Resource1._3jar0);
                steps = 0;
            }
        }
    }
}
