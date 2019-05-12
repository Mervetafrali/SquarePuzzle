using System;
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
            button1.Click += new System.EventHandler(buttonc);
            button2.Click += new System.EventHandler(buttonc);
            button3.Click += new System.EventHandler(buttonc);
            button4.Click += new System.EventHandler(buttonc);
            button5.Click += new System.EventHandler(buttonc);
            button6.Click += new System.EventHandler(buttonc);
            button7.Click += new System.EventHandler(buttonc);
            button8.Click += new System.EventHandler(buttonc);
            button9.Click += new System.EventHandler(buttonc);
            button10.Click += new System.EventHandler(buttonc);
            button11.Click += new System.EventHandler(buttonc);
            button12.Click += new System.EventHandler(buttonc);
            button13.Click += new System.EventHandler(buttonc);
            button14.Click += new System.EventHandler(buttonc);
            button15.Click += new System.EventHandler(buttonc);
            button16.Click += new System.EventHandler(buttonc);
            string path = @"D:\enyüksekskor.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }



        }
        String name;
        Image[] imgarray = new Image[16];
        Button[] array;
        int count = 0;
        String name2;
        String name3;

        private void Game_Load(object sender, EventArgs e)
        {
        }
        public void fix(Image[] item, String name)
        {

            var img = Image.FromFile(name);
            int a = img.Height;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var index = i * 4 + j;
                    imgarray[index] = new Bitmap(104, 104);
                    var graphics = Graphics.FromImage(imgarray[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, 104, 104), new Rectangle(i * a / 4, j * a / 4, a / 4, a / 4), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }

            button1.Image = imgarray[0];
            button2.Image = imgarray[4];
            button3.Image = imgarray[8];
            button4.Image = imgarray[12];
            button5.Image = imgarray[1];
            button6.Image = imgarray[5];
            button7.Image = imgarray[9];
            button8.Image = imgarray[13];
            button9.Image = imgarray[2];
            button10.Image = imgarray[6];
            button11.Image = imgarray[10];
            button12.Image = imgarray[14];
            button13.Image = imgarray[3];
            button14.Image = imgarray[7];
            button15.Image = imgarray[11];
            button16.Image = imgarray[15];
        }
        public void delete()
        {
            System.IO.DirectoryInfo di = new DirectoryInfo("D:\\test\\");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
        public void save(Image[] item, String name)
        {

            //delete();
            var img = Image.FromFile(name);
            int a = img.Height;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var index = i * 4 + j;
                    imgarray[index] = new Bitmap(104, 104);
                    var graphics = Graphics.FromImage(imgarray[index]);
                    graphics.DrawImage(img, new Rectangle(0, 0, 104, 104), new Rectangle(i * a / 4, j * a / 4, a / 4, a / 4), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }

            imgarray[0].Save("D:\\test\\" + 0 + ".jpg");
            imgarray[4].Save("D:\\test\\" + 1 + ".jpg");
            imgarray[8].Save("D:\\test\\" + 2 + ".jpg");
            imgarray[12].Save("D:\\test\\" + 3 + ".jpg");
            imgarray[1].Save("D:\\test\\" + 4 + ".jpg");
            imgarray[5].Save("D:\\test\\" + 5 + ".jpg");
            imgarray[9].Save("D:\\test\\" + 6 + ".jpg");
            imgarray[13].Save("D:\\test\\" + 7 + ".jpg");
            imgarray[2].Save("D:\\test\\" + 8 + ".jpg");
            imgarray[6].Save("D:\\test\\" + 9 + ".jpg");
            imgarray[10].Save("D:\\test\\" + 10 + ".jpg");
            imgarray[14].Save("D:\\test\\" + 11 + ".jpg");
            imgarray[3].Save("D:\\test\\" + 12 + ".jpg");
            imgarray[7].Save("D:\\test\\" + 13 + ".jpg");
            imgarray[11].Save("D:\\test\\" + 14 + ".jpg");
            imgarray[15].Save("D:\\test\\" + 15 + ".jpg");





        }
        public void deneme()
        {
            int co = 0;
            Image image1 = Image.FromFile("D:\\test\\0.jpg");
            Image image2 = Image.FromFile("D:\\test\\15.jpg");
            Bitmap bmp1 = new Bitmap(image1);

            int bt = 0;
            int bt2 = 0;
            Bitmap bmp2 = new Bitmap(image2);

            //get image dimension
            int width = bmp1.Width;
            int height = bmp1.Height;

            //color of pixel
            Color p;

            //grayscale
            int[,] list1 = new int[width, height];
            int[,] list2 = new int[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color originalColor = bmp1.GetPixel(i, j);
                    int grayScale = (int)((originalColor.R * .3) + (originalColor.G *
                    .59) + (originalColor.B * .11));
                    list1[i, j] = grayScale;

                    //Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    //bmp1.SetPixel(i, j, newColor);
                }
            }
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color originalColor = bmp2.GetPixel(i, j);
                    int grayScale = (int)((originalColor.R * .3) + (originalColor.G *
                    .59) + (originalColor.B * .11));
                    list2[i, j] = grayScale;
                    // Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    // bmp2.SetPixel(i, j, newColor);
                }
            }


            //list1[i, width - 1] == list2[i, 0]
            int fark = 0;
            for (int i = 0; i < width; i++)
            {
                fark = Math.Abs(list1[i, width - 1] - list2[i, 0]);
                //MessageBox.Show(fark.ToString());
                if (fark >= 0 && fark <= 130)
                {
                    co++;
                }

            }
            /*for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(string.Format("{0} ", list1[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }*/
            MessageBox.Show(co.ToString());





        }


        private void button17_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;*.png)|*.jpg; *.jpeg; *.gif; *.bmp;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {

                var imgarray = new Image[16];
                var img = Image.FromFile(open.FileName);
                name = open.FileName;
                int a = img.Height;



                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        var index = i * 4 + j;
                        imgarray[index] = new Bitmap(104, 104);
                        var graphics = Graphics.FromImage(imgarray[index]);
                        graphics.DrawImage(img, new Rectangle(0, 0, 104, 104), new Rectangle(i * a / 4, j * a / 4, a / 4, a / 4), GraphicsUnit.Pixel);

                        graphics.Dispose();
                    }
                }
                save(imgarray, name);
                var imgarrayshuffle = new Image[16];
                int rndNo;

                Random rnd = new Random();
                for (int i = imgarrayshuffle.Length; i >= 1; i--)
                {
                    rndNo = rnd.Next(1, i + 1) - 1;
                    imgarrayshuffle[i - 1] = imgarray[rndNo];
                    imgarray[rndNo] = imgarray[i - 1];
                }

                array = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16 };
                for (int i = 0; i < 16; i++)
                {
                    array[i].Image = imgarrayshuffle[i];
                }



            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            fix(imgarray, name);
            deneme();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void buttonc(object sender, EventArgs e)
        {
            count++;
            Button btn1 = new Button();
            Button btn2 = new Button();


            if (count == 1)
            {
                name2 = (sender as Button).Name;
            }
            else if (count == 2)
            {
                name3 = (sender as Button).Name;
                array = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16 };
                for (int i = 0; i < 16; i++)
                {
                    if (array[i].Name.Equals(name2))
                    {
                        for (int j = 0; j < 16; j++)
                        {
                            if (array[j].Name.Equals(name3))
                            {
                                btn1.Image = array[j].Image;
                                array[j].Image = array[i].Image;
                                array[i].Image = btn1.Image;
                                count = 0;
                                break;

                            }
                        }
                    }
                }

            }



        }
    }
}