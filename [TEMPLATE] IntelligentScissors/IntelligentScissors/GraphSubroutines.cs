using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace IntelligentScissors
{
     public static class Assistant
     {
          public static int Tabular(int x, int y, int Height)
          {
               int node_idx;
               node_idx = x + (y * Height);
               return node_idx;
          }
          public static Vector2D Untabular(int node_idx, int Height)
          {
               Vector2D cur_node = new Vector2D();
               cur_node.X = (int)node_idx % Height;
               cur_node.Y = (int)node_idx / Height;
               return cur_node;
          }
          public static bool Vaild_Node(int X, int Y, RGBPixel[,] ImageMatrix)
          {
               bool VX = (X >= 0 && X < ImageOperations.GetWidth(ImageMatrix));
               bool VY = (Y >= 0 && Y < ImageOperations.GetHeight(ImageMatrix));
               return VX && VY;
          }
          public static void DrawCircle( Graphics g, Pen pen, int centerX, int centerY, int radius)
          {
               g.DrawEllipse(pen, centerX - radius, centerY - radius,
                             radius + radius, radius + radius);
          }
          public static void FillCircle( Graphics g, Brush brush,int centerX, int centerY, int radius)
          {
               g.FillEllipse(brush, centerX - radius, centerY - radius,
                             radius + radius, radius + radius);
          }
          public static List<T> AppendToList<T>(List<T> dest, T[] sourc)
          {
               if (dest == null || sourc == null)
               {
                    return null;
                    throw new ArgumentNullException();

               }


               List<T> tmp = dest;
               for (int i = 0; i < sourc.Length; i++)
               {
                    tmp.Add(sourc[i]);
               }
               return tmp;

          }
          public static RGBPixel[,] CopyImage(RGBPixel[,] ImageMatrix,Boundary border)
          {
               int Width = border.MAX_X - border.MIN_X;
               int Height = border.MAX_Y - border.MIN_Y;
               RGBPixel[,] SelectedImage = new RGBPixel[Height + 1, Width + 1];
               for (int i = 0; i <= Height; i++)
               {
                    for (int j = 0; j <= Width; j++)
                    {
                         SelectedImage[i, j] = ImageMatrix[border.MIN_Y + i, border.MIN_X + j];
                    }
               
               }
               return SelectedImage;
          }
     }
     public  class Edge
     {
          public  int From, To;
          public  double Weight;
          public Edge(int from, int to, double weight)
         {
              this.From = from;
              this.To = to;
              this.Weight = weight;

         }
     }
     public static class GraphSubroutines
     {      
          public static List<Edge> Get_neighbours(int node_idx, RGBPixel[,] ImageMatrix)
          {
               List<Edge> neighbours = new List<Edge>();

               int Width = ImageOperations.GetWidth(ImageMatrix);
               int Height = ImageOperations.GetHeight(ImageMatrix);

               var Node_coordinates = Assistant.Untabular(node_idx, Height);
               int X = (int)Node_coordinates.X;
               int Y = (int)Node_coordinates.Y;

               var Energy = ImageOperations.CalculatePixelEnergies(X, Y, ImageMatrix);

               if (X < Width - 1) // Have a right node ?
               {
                    if (Energy.X == 0)
                    {
                         Edge newEdge = new Edge(node_idx, Assistant.Tabular(X + 1, Y, Height), 10000000000000000);
                         neighbours.Add(newEdge);
                    }
                    else
                    {
                         Edge newEdge = new Edge(node_idx, Assistant.Tabular(X + 1, Y, Height), (1 / (Energy.X)));
                         neighbours.Add(newEdge);
                    }

               }
               if (Y < Height - 1) // Have a bottom node ?
               {
                    if (Energy.Y == 0)
                    {
                         Edge newEdge = new Edge(node_idx, Assistant.Tabular(X, Y + 1, Height), 10000000000000000);
                         neighbours.Add(newEdge);
                    }
                    else
                    {
                         Edge newEdge = new Edge(node_idx, Assistant.Tabular(X, Y + 1, Height), (1 / (Energy.Y)));
                         neighbours.Add(newEdge);
                    }


               }
               if (X > 0) // Have a left node ?
               {
                    Energy = ImageOperations.CalculatePixelEnergies(X - 1, Y, ImageMatrix);

                    if (Energy.X == 0)
                    {
                         Edge newEdge = new Edge(node_idx, Assistant.Tabular(X - 1, Y, Height), 10000000000000000);
                         neighbours.Add(newEdge);
                    }
                    else
                    {
                         Edge newEdge = new Edge(node_idx, Assistant.Tabular(X - 1, Y, Height), (1 / (Energy.X)));
                         neighbours.Add(newEdge);
                    }


               }
               if (Y > 0)  // Have a top node ?
               {
                    Energy = ImageOperations.CalculatePixelEnergies(X, Y - 1, ImageMatrix);

                    if (Energy.Y == 0)
                    {
                         Edge newEdge = new Edge(node_idx, Assistant.Tabular(X, Y - 1, Height), 10000000000000000);
                         neighbours.Add(newEdge);
                    }
                    else
                    {
                         Edge newEdge = new Edge(node_idx, Assistant.Tabular(X, Y - 1, Height), (1 / (Energy.Y)));
                         neighbours.Add(newEdge);
                    }

               }
               return neighbours;
          }
          public static List<List<Edge>> GraphConstruction(RGBPixel[,] ImageMatrix)
          {

               int width = ImageOperations.GetWidth(ImageMatrix);
               int Height = ImageOperations.GetHeight(ImageMatrix);
               int ToatalSize = width * Height;
               List<List<Edge>> Graph = new List<List<Edge>>();

               for (int i = 0; i < width; i++)
               {
                    for (int j = 0; j < Height; j++)
                    {
                         int node_idx = Assistant.Tabular(i, j, Height);
                         List<Edge> neighbours = Get_neighbours(node_idx, ImageMatrix);
                         Graph.Add(neighbours);
                    }

               }
               return Graph;
          }
     }
}
