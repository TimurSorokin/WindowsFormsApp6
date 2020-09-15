using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        imagedatabase imagedatabase = new imagedatabase();
        
        public Form1()
        {
           
            InitializeComponent();
            findTextBox.Visible = false;
            findOk.Visible = false;

        }

        private void add_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            AddFileOrFolder(path);
            console2.Text = imagedatabase.DataBaseStats();
        }

        private  void AddFileOrFolder(string path)
        {
            
            
            Console.WriteLine(Checker(path));

           
            string filename;
            int imgHeight;
            int imgWidth;
            long length;
            string output;
            image image;
            switch (Checker(path))
            {
                case ObjectType.file:

                    if(ImageChecker(path) != ImageType.undefined)
                    {

                    

                      var imgfromfile = Image.FromFile(path);
                           filename = Path.GetFileName(path);
                            imgHeight = imgfromfile.Height;
                            imgWidth = imgfromfile.Width;
                            length = new System.IO.FileInfo(path).Length;
                            output = String.Format("Name: {0} | Width: {1} | Heght: {2} | Size: {3} KB \n ", filename, imgHeight, imgWidth, length/1000);

                            console.Text += output;
                           // console.Text += (a + "||| TYPE|" + ImageChecker(a));
                                                
                            image =  new image(filename, imgWidth, imgHeight, length/1000);
                            imagedatabase.AddToDataBase(image);
                    }
                    else
                    {
                        MessageBox.Show("Path doesnt contain images");
                    }

                    break;


                case ObjectType.folder:
                    string[] test = Directory.GetFiles(path);
                    
                    foreach (string a in test)
                    {

                        if (ImageChecker(a) != ImageType.undefined)
                        {
                           

                            var img = Image.FromFile(a);
                            filename = Path.GetFileName(a);
                            imgHeight = img.Height;
                            imgWidth = img.Width;
                            length = new System.IO.FileInfo(a).Length;
                            output = String.Format("Name: {0} | Width{1} | Heght {2} | Size {3} KB \n \n \n", filename, imgHeight, imgWidth, length/1000);

                            console.Text += output;
                           // console.Text += (a + "||| TYPE|" + ImageChecker(a));
                                                
                            image =  new image(filename, imgWidth, imgHeight, length/1000);
                            imagedatabase.AddToDataBase(image);
                           
                          
                            
                        }
                        else
                        {
                            MessageBox.Show("Path doesnt contain images");
                        }
                        

                    }
                 
                    break;
                case ObjectType.uknown:

                    MessageBox.Show("Something went wrong!");
                    break;
                    
            }

        }

        enum ImageType
        {
            bmp,
            png,
            jpg,
            tiff,
            tiff2,
            undefined

        }
        private static ImageType ImageChecker(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] bytes = new byte[8];
            int fsRead = fs.Read(bytes, 0, 8);
            byte[] bmp = { 0x42, 0x4D };
            byte[] jpg = { 255, 216, 255, 224 };
            byte[] jpgcanon = { 255, 216, 255, 255 };
            byte[] png = { 137, 80, 78, 71, 13, 10, 26, 10 };
            byte[] tiff = { 73, 73, 42 };
            byte[] tiff2 = { 77, 77, 42 };


            //bmp
            if (Enumerable.SequenceEqual(bmp, bytes.Take(bmp.Length)))
            {
                return ImageType.bmp;
            }
            //png
            else if (Enumerable.SequenceEqual(png, bytes.Take(png.Length)))
            {
                return ImageType.png;
            }
            //jpg
            else if (Enumerable.SequenceEqual(jpg, bytes.Take(jpg.Length)))
            {
                return ImageType.jpg;
            }
            //jpg canon
            else if (Enumerable.SequenceEqual(jpgcanon, bytes.Take(jpgcanon.Length)))
            {
                return ImageType.jpg;
            }
            //tiff
            else if (Enumerable.SequenceEqual(tiff, bytes.Take(tiff.Length)))
            {
                return ImageType.tiff;
            }
            //tiff2
            else if (Enumerable.SequenceEqual(tiff2, bytes.Take(tiff2.Length)))
            {
                return ImageType.tiff2;
            }

            return ImageType.undefined;
        }


        enum ObjectType
        {
            folder,
            file,
            uknown
        }

        private static ObjectType Checker(string path)
        {

            if (File.Exists(path))
            {
                //file


                return ObjectType.file;
            }
            else if (Directory.Exists(path))
            {
                //dir
                return ObjectType.folder;
            }
            else
            {
                return ObjectType.uknown;
            }
        }

        private void console_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {

            console.Text = "";
            console.Text += imagedatabase.ShowDataBase();
            console2.Text = imagedatabase.DataBaseStats();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void addfolder_Click(object sender, EventArgs e)
        {
           
            folderBrowserDialog1.ShowDialog();
            string path = folderBrowserDialog1.SelectedPath;
            AddFileOrFolder(path);
            console2.Text = imagedatabase.DataBaseStats();
        }

        private void find_Click(object sender, EventArgs e)
        {
            findTextBox.Visible = true;
            findOk.Visible = true;
        }

        private void findOk_Click(object sender, EventArgs e)
        {
            console.Text = imagedatabase.FindImageInDataBase(findTextBox.Text);
            findTextBox.Visible = false;
            findOk.Visible = false;
        }
    }
    class image
    {
        public string filename;
        public int imgHeight;
        public int imgWidth;
        public long length;

        public image(string name,int width, int height,long length)
        {
            this.filename = name;
            this.imgHeight = height;
            this.imgWidth = width;
            this.length = length;
        }
    }

    class imagedatabase
    {
        List<image> database;
        public imagedatabase()
        {
            database = new List<image>(700);
        }

        public void AddToDataBase(image image)
        {
            if((database.Capacity-database.Count)<10)
            {
                MessageBox.Show("Less than 10 slosts");
            }
            
            if(database.Count< database.Capacity)
            {
                database.Add(image);

            }
            else
            {
                MessageBox.Show("No more space");
            }

        }
        public string ShowDataBase()
        {
            string output = "";

            foreach (image show in database)
            {
                output += String.Format("Name: {0} | Width{1} | Heght {2} | Size {3} KB \n \n \n", show.filename, show.imgHeight, show.imgWidth, show.length);
                
            }
            return output;
        }
        public string DataBaseStats()
        {
            long totallenght=0;
            int imgcount = 0;
            int slots = database.Capacity;
            int slotsused = database.Count;

            foreach(image count in database)
            {
                totallenght += count.length;
                imgcount++;
            }

            string output = String.Format("Total images: {0}\nTotal size(kb): {1}\nTotal slots: {2}/{3}", imgcount, totallenght,slotsused,slots);
            return output;
        }
        public string FindImageInDataBase(string name)
        {
            int position = 0;
            string output="";

            foreach(image find in database)
            {
                if(name == find.filename)
                {
                    output = String.Format("File found at position: {0} \nName: {1} | Width{2} | Height {3} | Size {4} KB \n \n \n", position, find.filename, find.imgWidth, find.imgHeight, find.length);
                    break;

                    
                }
                
                position++;
            }
            return output;
        }
    }
}
