using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquarePuzzle
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            //buton click almak için
            #region           
            button1.Click += new System.EventHandler(buttonc);
            button2.Click += new System.EventHandler(buttonc);
            button3.Click += new System.EventHandler(buttonc);
           // button4.Click += new System.EventHandler(buttonc);
            button5.Click += new System.EventHandler(buttonc);
            button6.Click += new System.EventHandler(buttonc);
            button7.Click += new System.EventHandler(buttonc);
           // button8.Click += new System.EventHandler(buttonc);
            button9.Click += new System.EventHandler(buttonc);
            button10.Click += new System.EventHandler(buttonc);
            button11.Click += new System.EventHandler(buttonc);
           // button12.Click += new System.EventHandler(buttonc);
           // button13.Click += new System.EventHandler(buttonc);
           // button14.Click += new System.EventHandler(buttonc);
           // button15.Click += new System.EventHandler(buttonc);
           // button16.Click += new System.EventHandler(buttonc);
            #endregion

        }
        String name;
        Image[] imgarray = new Image[9];
        Image[] imgarrayshuffle = new Image[9];
        Button[] array;
        int count = 0;
        String name2;
        String name3;
        String filename;
        int movecount = 0;
        int yourscore = 100;
        Point temp = new Point(0, 0);
        int checkCount = 0;
        Bitmap bmp11, bmp22;
        ArrayList arl = new ArrayList();
        ArrayList arl2 = new ArrayList();
        private void Game_Load(object sender, EventArgs e)
        {
            var max = File.ReadAllLines(@"D:\enyüksekskor.txt").Max(m => m);
            label5.Text = max;
            label7.Text = yourscore.ToString();
            label8.Text = checkCount.ToString();
            label9.Text += "\n";
            button20.Enabled = false;
        }
        public Boolean cc(Bitmap bmp11, Bitmap bmp22)
        {
            arl.Clear();

            for (int a = 0; a < bmp11.Width; a++)
            {
                for (int b = 0; b < bmp11.Height; b++)
                {
                    arl.Add(bmp11.GetPixel(a, b).Name);
                }
            }
            arl2.Clear();
            for (int a = 0; a < bmp22.Width; a++)
            {
                for (int b = 0; b < bmp22.Height; b++)
                {
                    arl2.Add(bmp22.GetPixel(a, b).Name);
                }
            }
            double equal = 0;
            double notequal = 0;
            for (int a = 0; a < arl.Count; a++)
            {
                if (arl[a].ToString() == arl2[a].ToString())
                {
                    equal++;
                }
                else
                {
                    notequal++;
                }
            }

            if (notequal == 0)
            {
                return true;
            }
            return false;

        }
        //solve puzzle function
        public void fix(Image[] item, String name)
        {

            Bitmap bmp = new Bitmap("D:\\test\\0.jpg");
            Bitmap bmp2 = new Bitmap("D:\\test\\1.jpg");
            Bitmap bmp3 = new Bitmap("D:\\test\\2.jpg");
           // Bitmap bmp4 = new Bitmap("D:\\test\\3.jpg");
            Bitmap bmp4 = new Bitmap("D:\\test\\3.jpg");
            Bitmap bmp5 = new Bitmap("D:\\test\\4.jpg");
            Bitmap bmp6 = new Bitmap("D:\\test\\5.jpg");
          //  Bitmap bmp8 = new Bitmap("D:\\test\\7.jpg");
            Bitmap bmp7 = new Bitmap("D:\\test\\6.jpg");
            Bitmap bmp8 = new Bitmap("D:\\test\\7.jpg");
            Bitmap bmp9 = new Bitmap("D:\\test\\8.jpg");
           // Bitmap bmp12 = new Bitmap("D:\\test\\11.jpg");
          //  Bitmap bmp13 = new Bitmap("D:\\test\\12.jpg");
           // Bitmap bmp14 = new Bitmap("D:\\test\\13.jpg");
           // Bitmap bmp15 = new Bitmap("D:\\test\\14.jpg");
            //Bitmap bmp16 = new Bitmap("D:\\test\\15.jpg");
            Bitmap[] bm = new Bitmap[9];
            bm = new Bitmap[] { bmp, bmp2, bmp3, bmp4, bmp5, bmp6, bmp7, bmp8, bmp9 };

            //buton atanması
            #region
            button1.Image = bm[0];
            button2.Image = bm[1];
            button3.Image = bm[2];
          //  button4.Image = bm[3];
            button5.Image = bm[3];
            button6.Image = bm[4];
            button7.Image = bm[5];
          //  button8.Image = bm[7];
            button9.Image = bm[6];
            button10.Image = bm[7];
            button11.Image = bm[8];
          //  button12.Image = bm[11];
           // button13.Image = bm[12];
          //  button14.Image = bm[13];
           // button15.Image = bm[14];
           // button16.Image = bm[15];
            #endregion

        }


        //save image to test file
        public void save(Image[] item, String name)
        {

            //delete();
           // var img = Image.FromFile(filename);
            
            var imgarray = new Image[9];
          
            var img = Image.FromFile(filename);
            int a = img.Width;
            int b = img.Height;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var index = i * 3 + j;
                    imgarray[index] = new Bitmap(104, 104);
                    var graphics = Graphics.FromImage(imgarray[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, 104, 104), new Rectangle(j * a/3, i * b/3, a/3, b/3), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }

            //test dosyasına resimleri kaydetme
            #region
            imgarray[0].Save("D:\\test\\" + 0 + ".jpg");
            imgarray[1].Save("D:\\test\\" + 1 + ".jpg");
            imgarray[2].Save("D:\\test\\" + 2 + ".jpg");
          //  imgarray[3].Save("D:\\test\\" + 3 + ".jpg");
            imgarray[3].Save("D:\\test\\" + 3 + ".jpg");
            imgarray[4].Save("D:\\test\\" + 4 + ".jpg");
            imgarray[5].Save("D:\\test\\" + 5 + ".jpg");
          //  imgarray[7].Save("D:\\test\\" + 7 + ".jpg");
            imgarray[6].Save("D:\\test\\" + 6 + ".jpg");
            imgarray[7].Save("D:\\test\\" + 7 + ".jpg");
            imgarray[8].Save("D:\\test\\" + 8 + ".jpg");
           // imgarray[11].Save("D:\\test\\" + 11 + ".jpg");
            //imgarray[12].Save("D:\\test\\" + 12 + ".jpg");
           // imgarray[13].Save("D:\\test\\" + 13 + ".jpg");
           // imgarray[14].Save("D:\\test\\" + 14 + ".jpg");
           // imgarray[15].Save("D:\\test\\" + 15 + ".jpg");
            #endregion
        }


        //Select picture from file
        private void button17_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();

            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;*.png)|*.jpg; *.jpeg; *.gif; *.bmp;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                var image = Image.FromFile(open.FileName);
                filename = open.FileName;
            }
        }

        //fix
        private void button18_Click(object sender, EventArgs e)
        {
          
            button19.Enabled = false;
 
          
            var imgarray = new Image[9];
            var img = Image.FromFile(filename);
            int a = img.Width;
            int b = img.Height;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var index = i * 3 + j;
                    imgarray[index] = new Bitmap(104, 104);
                    var graphics = Graphics.FromImage(imgarray[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, 104, 104), new Rectangle(j * a / 3, i * b / 3, a / 3, b / 3), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }

            save(imgarray, filename);
            fix(imgarray, name);

        }



        //change selected buttons location function 
        private void buttonc(object sender, EventArgs e)
        {
            count++;
            Image gg;
            if (count == 1)
            {
                name2 = (sender as Button).Name;
            }
            else if (count == 2)
            {
                name3 = (sender as Button).Name;
                array = new Button[] { button1, button2, button3, button5, button6, button7, button9, button10, button11 };
                for (int i = 0; i < 9; i++)
                {
                    if (array[i].Name.Equals(name2))
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (array[j].Name.Equals(name3))
                            {
                                gg = array[j].Image;
                                array[j].Image = array[i].Image;
                                array[i].Image = gg;
                                count = 0;
                                movecount++;
                                label6.Text = movecount.ToString();
                                yourscore = yourscore - 4;
                                label7.Text = yourscore.ToString();
                                check(array[i], i);
                                check(array[j], j);

                                break;
                            }

                        }
                    }
                }
            }
        }

        //control of button location function
        public void check(Button arr2, int s)
        {



            Bitmap bmp = new Bitmap("D:\\test\\0.jpg");
            Bitmap bmp2 = new Bitmap("D:\\test\\1.jpg");
            Bitmap bmp3 = new Bitmap("D:\\test\\2.jpg");
          //  Bitmap bmp4 = new Bitmap("D:\\test\\3.jpg");
            Bitmap bmp4 = new Bitmap("D:\\test\\3.jpg");
            Bitmap bmp5 = new Bitmap("D:\\test\\4.jpg");
            Bitmap bmp6 = new Bitmap("D:\\test\\5.jpg");
         //   Bitmap bmp8 = new Bitmap("D:\\test\\7.jpg");
            Bitmap bmp7 = new Bitmap("D:\\test\\6.jpg");
            Bitmap bmp8 = new Bitmap("D:\\test\\7.jpg");
            Bitmap bmp9 = new Bitmap("D:\\test\\8.jpg");
          //  Bitmap bmp12 = new Bitmap("D:\\test\\11.jpg");
          //  Bitmap bmp13 = new Bitmap("D:\\test\\12.jpg");
           // Bitmap bmp14 = new Bitmap("D:\\test\\13.jpg");
          //  Bitmap bmp15 = new Bitmap("D:\\test\\14.jpg");
            //Bitmap bmp16 = new Bitmap("D:\\test\\15.jpg");
            Bitmap[] bm = new Bitmap[9];
            bm = new Bitmap[] { bmp, bmp2, bmp3, bmp4,bmp5, bmp6, bmp7, bmp8, bmp9 };

            if (cc(bm[s], (Bitmap)arr2.Image))
            {

                checkCount++;
                label8.Text = checkCount.ToString();
                label9.Text += "\n" + arr2.Name;
                arr2.Enabled = false;
                yourscore = yourscore + 1;
                label7.Text = yourscore.ToString();
                if (checkCount == 9)
                {
                    writeFile(yourscore);
                    MessageBox.Show("Mission Completed! :D " + "\n\n" + "Your Score: " + yourscore);
                }
            }






        }
        public bool mcheck(Button arr3, int s)
        {
            Bitmap bmp = new Bitmap("D:\\test\\0.jpg");
            Bitmap bmp2 = new Bitmap("D:\\test\\1.jpg");
            Bitmap bmp3 = new Bitmap("D:\\test\\2.jpg");
           // Bitmap bmp4 = new Bitmap("D:\\test\\3.jpg");
            Bitmap bmp4 = new Bitmap("D:\\test\\3.jpg");
            Bitmap bmp5 = new Bitmap("D:\\test\\4.jpg");
            Bitmap bmp6 = new Bitmap("D:\\test\\5.jpg");
          //  Bitmap bmp8 = new Bitmap("D:\\test\\7.jpg");
            Bitmap bmp7 = new Bitmap("D:\\test\\6.jpg");
            Bitmap bmp8 = new Bitmap("D:\\test\\7.jpg");
            Bitmap bmp9 = new Bitmap("D:\\test\\8.jpg");
          //  Bitmap bmp12 = new Bitmap("D:\\test\\11.jpg");
           // Bitmap bmp13 = new Bitmap("D:\\test\\12.jpg");
           // Bitmap bmp14 = new Bitmap("D:\\test\\13.jpg");
            //Bitmap bmp15 = new Bitmap("D:\\test\\14.jpg");
           // Bitmap bmp16 = new Bitmap("D:\\test\\15.jpg");
            Bitmap[] bm = new Bitmap[9];
            bm = new Bitmap[] { bmp, bmp2, bmp3, bmp4, bmp5, bmp6, bmp7, bmp8,  bmp9 };

            if (cc(bm[s], (Bitmap)arr3.Image))
            {

                checkCount++;
                label8.Text = checkCount.ToString();
                label9.Text += "\n" + arr3.Name;
                arr3.Enabled = false;

                if (checkCount == 9)
                {
                    writeFile(yourscore);
                    MessageBox.Show("Mission Completed! :D " + "\n\n" + "Your Score: " + yourscore);
                }
                return true;
            }

            return false;

        }
        //write file
        public void writeFile(int score)
        {
            string dosya_yolu = @"D:\enyüksekskor.txt";
            using (var writer = new StreamWriter(dosya_yolu, true))
            {
                writer.WriteLine(score + Environment.NewLine);
                writer.Close();
            }

        }


        //mix again
        private void button20_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
           // button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
           // button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
          //  button12.Enabled = true;
          //  button13.Enabled = true;
           // button14.Enabled = true;
           // button15.Enabled = true;
            //button16.Enabled = true;
            Bitmap bmp = new Bitmap("D:\\test\\0.jpg");
            Bitmap bmp2 = new Bitmap("D:\\test\\1.jpg");
            Bitmap bmp3 = new Bitmap("D:\\test\\2.jpg");
           // Bitmap bmp4 = new Bitmap("D:\\test\\3.jpg");
            Bitmap bmp4 = new Bitmap("D:\\test\\3.jpg");
            Bitmap bmp5 = new Bitmap("D:\\test\\4.jpg");
            Bitmap bmp6 = new Bitmap("D:\\test\\5.jpg");
         //   Bitmap bmp8 = new Bitmap("D:\\test\\7.jpg");
            Bitmap bmp7 = new Bitmap("D:\\test\\6.jpg");
            Bitmap bmp8 = new Bitmap("D:\\test\\7.jpg");
            Bitmap bmp9 = new Bitmap("D:\\test\\8.jpg");
         //   Bitmap bmp12 = new Bitmap("D:\\test\\11.jpg");
           // Bitmap bmp13 = new Bitmap("D:\\test\\12.jpg");
          //  Bitmap bmp14 = new Bitmap("D:\\test\\13.jpg");
          //  Bitmap bmp15 = new Bitmap("D:\\test\\14.jpg");
          //  Bitmap bmp16 = new Bitmap("D:\\test\\15.jpg");
            Bitmap[] bm = new Bitmap[9];
            bm = new Bitmap[] { bmp, bmp2, bmp3, bmp4,bmp5, bmp6, bmp7, bmp8, bmp9};


            int rndNo;

            Random rnd = new Random();
            int k = 0;
            for (int i = imgarrayshuffle.Length; i >= 1; i--)
            {
                rndNo = rnd.Next(1, i + 1) - 1;
                imgarrayshuffle[i - 1] = bm[rndNo];
                bm[rndNo] = bm[i - 1];
            }

            array = new Button[] { button1, button2, button3, button5, button6, button7,  button9, button10, button11};

            for (int i = 0; i < 9; i++)
            {
                array[i].Image = imgarrayshuffle[i];

            }

            for (int i = 0; i < 9; i++)
            {
                if (mcheck(array[i], i))
                {

                    k++;
                }
            }



            checkCount = k;

            label8.Text = checkCount.ToString();
        }

        //first mix
        private void button19_Click(object sender, EventArgs e)
        {
          //  button18.Enabled = false;
            var imgarray = new Image[9];
            try
            {
             
    


               
                var img = Image.FromFile(filename);
                int a = img.Width;
                int b = img.Height;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        var index = i * 3 + j;
                        imgarray[index] = new Bitmap(104, 104);
                        var graphics = Graphics.FromImage(imgarray[index]);
                        graphics.DrawImage(img, new Rectangle(0, 0, 104, 104), new Rectangle(j * a / 3, i * b / 3, a / 3, b / 3), GraphicsUnit.Pixel);
                        graphics.Dispose();
                    }
                }
                save(imgarray, filename);

                int rndNo;

                Random rnd = new Random();
                int k = 0;

                for (int i = imgarrayshuffle.Length; i >= 1; i--)
                {
                    rndNo = rnd.Next(1, i + 1) - 1;
                    imgarrayshuffle[i - 1] = imgarray[rndNo];
                    imgarray[rndNo] = imgarray[i - 1];
                }

                array = new Button[] { button1, button2, button3, button5, button6, button7,  button9, button10, button11 };

                for (int i = 0; i < 9; i++)
                {
                    array[i].Image = imgarrayshuffle[i];

                }

                for (int i = 0; i <9; i++)
                {
                    if (mcheck(array[i], i))
                    {

                        k++;
                    }
                }

                if (k < 1)
                {

                    button19.Enabled = false;
                    button20.Enabled = true;
                    MessageBox.Show("if you want a correct picture, press the 'mix again' button");
                }

                button19.Enabled = false;
                checkCount = k;

                label8.Text = checkCount.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Select IMAGE!");
                this.Close();
            }


        }


    }
}