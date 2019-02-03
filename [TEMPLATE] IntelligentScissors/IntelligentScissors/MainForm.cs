using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace IntelligentScissors
{
    public partial class MainForm : Form
    {
         bool isMouseMove;
         List<Point> AnchorList;
         List<Point> MainSelection;
        public MainForm()
        {
            InitializeComponent();
            AnchorList = new List<Point>();
            MainSelection = new List<Point>();
            isMouseMove = false;
           
        }
        RGBPixel[,] ImageMatrix;
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
            txtWidth.Text = ImageOperations.GetWidth(ImageMatrix).ToString();
            txtHeight.Text = ImageOperations.GetHeight(ImageMatrix).ToString();
        }
        private void btnGaussSmooth_Click(object sender, EventArgs e)
        {
            double sigma = double.Parse(txtGaussSigma.Text);
            int maskSize = (int)nudMaskSize.Value ;
            ImageMatrix = ImageOperations.GaussianFilter1D(ImageMatrix, maskSize, sigma);
            ImageOperations.DisplayImage(ImageMatrix, pictureBox2);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
             isMouseMove = true;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
             isMouseMove = false;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
             textBox1.Text = e.X.ToString();
             textBox2.Text = e.Y.ToString();


        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
             Point FreePoint = new Point(e.X, e.Y);
             if (ImageMatrix != null)
             { AnchorList.Add(FreePoint); }

             if (AnchorList.Count !=0 && ImageMatrix!=null)
             {
                  Graphics g = pictureBox1.CreateGraphics();
                  Pen pencil = new Pen(Brushes.Black);
                  Assistant.DrawCircle(g, pencil, AnchorList[AnchorList.Count - 1].X, AnchorList[AnchorList.Count - 1].Y,2);
                  Assistant.FillCircle(g, Brushes.Black, AnchorList[AnchorList.Count - 1].X, AnchorList[AnchorList.Count - 1].Y,2);

             }
             if (AnchorList.Count> 1 && ImageMatrix!=null)
             {        
                  int Source = Assistant.Tabular(AnchorList[AnchorList.Count - 2].X, AnchorList[AnchorList.Count - 2].Y, ImageOperations.GetHeight(ImageMatrix));
                  int Dest = Assistant.Tabular(AnchorList[AnchorList.Count - 1].X, AnchorList[AnchorList.Count - 1].Y, ImageOperations.GetHeight(ImageMatrix));
                  List<Point> path = ShortestpathSubroutiens.DetermineShortestPath(Source, Dest, ImageMatrix);
                  Assistant.AppendToList<Point>(MainSelection,path.ToArray());
                  Graphics g = pictureBox1.CreateGraphics();
                  Pen Pencil = new Pen(Color.Yellow);
                  for (int i = 0; i < path.Count - 1; i++)
                  {
                       g.DrawLine(Pencil, path[i], path[i + 1]);
                
                  }
             }
        }
        private void rest_Click(object sender, EventArgs e)
        {
             AnchorList.Clear();
             pictureBox1.Refresh();
             pictureBox2.Refresh();
             pictureBox2.Image = null;
             MainSelection.Clear();
        }
        private void closeShape_Click(object sender, EventArgs e)
        {
             if (ImageMatrix != null && AnchorList.Count>1)
             {
                  int src = Assistant.Tabular(AnchorList[0].X, AnchorList[0].Y, ImageOperations.GetHeight(ImageMatrix));
                  int dest = Assistant.Tabular(AnchorList[AnchorList.Count - 1].X, AnchorList[AnchorList.Count - 1].Y, ImageOperations.GetHeight(ImageMatrix));
                  List<Point> path = ShortestpathSubroutiens.DetermineShortestPath(src, dest, ImageMatrix);
                  Assistant.AppendToList(MainSelection,path.ToArray());
                  Graphics g = pictureBox1.CreateGraphics();
                  Pen Pencil = new Pen(Color.Yellow);
                  for (int i = 0; i < path.Count - 1; i++)
                  {
                       g.DrawLine(Pencil, path[i], path[i + 1]);

                  }
             }
        }
        private void Crop_Click(object sender, EventArgs e)
        {
             RGBPixel[,] SelectedImage = CropSubroutines.CropedImage(MainSelection,ImageMatrix);
             ImageOperations.DisplayImage(SelectedImage,pictureBox2);
        }
        private void save_Click(object sender, EventArgs e)
        {
             // Displays a SaveFileDialog so the user can save the Image
             // assigned to Button2.
             SaveFileDialog saveFileDialog1 = new SaveFileDialog();
             saveFileDialog1.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
             saveFileDialog1.Title = "Save an Image File";
             saveFileDialog1.ShowDialog();
             // If the file name is not an empty string open it for saving.
             if (saveFileDialog1.FileName != "")
             {
                  // Saves the Image via a FileStream created by the OpenFile method.
                  System.IO.FileStream fs =
                     (System.IO.FileStream)saveFileDialog1.OpenFile();
                  // Saves the Image in the appropriate ImageFormat based upon the
                  // File type selected in the dialog box.
                  // NOTE that the FilterIndex property is one-based.
                  switch (saveFileDialog1.FilterIndex)
                  {
                       case 1:
                            pictureBox2.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                       case 2:
                            pictureBox2.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Bmp);
                            break;

                       case 3:
                            pictureBox2.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                  }

                  fs.Close();
             }
        }
    }
}