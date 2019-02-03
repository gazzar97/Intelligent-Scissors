using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace IntelligentScissors
{
     public struct Boundary
     {
          public int MIN_X, MAX_X, MIN_Y, MAX_Y;
     }
     public static class CropSubroutines
     {
          private static RGBPixel[,] SelectedImage;
       public static RGBPixel[,] CropedImage(List<Point> BorderPoints,RGBPixel[,] ImageMatrix)
       {
            Boundary border = Get_Border(BorderPoints);
            SelectedImage = Assistant.CopyImage(ImageMatrix,border);
            MarkBorderImage(BorderPoints,border);
            FloodFillAlgo(ImageOperations.GetWidth(SelectedImage)-1,ImageOperations.GetHeight(SelectedImage)-1);
          return SelectedImage;
       }
       private static void FloodFillAlgo(int Width, int Height)
       {
            for (int i = 0; i <= Width; i++)
                 if (!SelectedImage[0, i].block)
                      DFS(new Vector2D(i, 0));

            for (int i = 0; i <= Width; i++)
                 if (!SelectedImage[Height, i].block)
                      DFS(new Vector2D(i, Height));


            for (int i = 0; i <= Height; i++)
                 if (!SelectedImage[i, 0].block)
                      DFS(new Vector2D(0, i));

            for (int i = 0; i <= Height; i++)
                 if (!SelectedImage[i, Width].block)
                      DFS(new Vector2D(Width, i));


       }
       private static void DFS(Vector2D START)
       {
            Stack<Vector2D> DFS_Stack = new Stack<Vector2D>();
            DFS_Stack.Push(START);
            while (DFS_Stack.Count > 0)
            {
                 Vector2D Curr = DFS_Stack.Pop();
                 if (Assistant.Vaild_Node((int)Curr.X, (int)Curr.Y, SelectedImage))
                 {
                      if (!SelectedImage[(int)Curr.Y, (int)Curr.X].block)
                      {
                           SelectedImage[(int)Curr.Y, (int)Curr.X].block = true;

                           //black or whiteen the pixel 
                           SelectedImage[(int)Curr.Y, (int)Curr.X].blue = 240; //bgclor
                           SelectedImage[(int)Curr.Y, (int)Curr.X].green = 240;
                           SelectedImage[(int)Curr.Y, (int)Curr.X].red = 240;


                           DFS_Stack.Push(new Vector2D(Curr.X, Curr.Y + 1));
                           DFS_Stack.Push(new Vector2D(Curr.X, Curr.Y - 1));
                           DFS_Stack.Push(new Vector2D(Curr.X + 1, Curr.Y));
                           DFS_Stack.Push(new Vector2D(Curr.X - 1, Curr.Y));
                      }
                 }

            }

       }
       private static void MarkBorderImage(List<Point> BorderPoints,Boundary border)
       {
            for (int i = 0; i < BorderPoints.Count; i++)
            {
                 int TempX = BorderPoints[i].X - border.MIN_X;
                 int TempY = BorderPoints[i].Y - border.MIN_Y;
                 SelectedImage[TempY, TempX].block = true;
            }        
       }
       private static Boundary Get_Border(List<Point> BorderPoints)
       {
            Boundary nborder;
            nborder.MAX_X = nborder.MAX_Y = -1000000000;
            nborder.MIN_X = nborder.MIN_Y = 1000000000;
            for (int i = 0; i < BorderPoints.Count; i++)
            {
                 int TempX = BorderPoints[i].X;
                 int TempY = BorderPoints[i].Y;

                 if (TempX > nborder.MAX_X) nborder.MAX_X = TempX;
                 if (TempX < nborder.MIN_X) nborder.MIN_X = TempX;
                 if (TempY > nborder.MAX_Y) nborder.MAX_Y = TempY;
                 if (TempY < nborder.MIN_Y) nborder.MIN_Y = TempY;
            }
                 return nborder;
       }

     }
}
