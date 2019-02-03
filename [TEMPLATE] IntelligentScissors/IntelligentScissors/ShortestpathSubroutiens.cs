using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace IntelligentScissors
{
    public class PriorityQueue
     {
          private List<Edge> MinHeap;
          public PriorityQueue()
          {
               MinHeap = new List<Edge>();
          }
          private void swap(Edge X, Edge Y)
          {
               Edge temp = X;
               X = Y;
               Y = temp;
          }
          private int left_index(int node)
          { return (node * 2) + 1; }
          private int right_index(int node)
          { return (node * 2) + 2; }
          private int parent_index(int node)
          { return (node - 1) / 2; }
          public bool isEmpty()
          {
               if (MinHeap.Count == 0) return true;
               return false;
          }
          public int Size()
          {
               return MinHeap.Count;
          }
          public Edge Top()
          {
               return MinHeap[0];
          }
          public void Push(Edge node)
          {
               MinHeap.Add(node);
               MoveUp(MinHeap.Count - 1);
          }
          private void MoveUp(int node)
          {
               if (node == 0 || MinHeap[node].Weight >= MinHeap[parent_index(node)].Weight)
                    return;

               Edge temp = MinHeap[node];
               MinHeap[node] = MinHeap[parent_index(node)];
               MinHeap[parent_index(node)] = temp;
               MoveUp(parent_index(node));
          }
          public Edge Pop()
          {
               Edge temp = MinHeap[0];
               MinHeap[0] = MinHeap[MinHeap.Count - 1];
               MinHeap.RemoveAt(MinHeap.Count - 1);
               MoveDown(0);

               return temp;
          }
          private void MoveDown(int node)
          {
               if (left_index(node) >= MinHeap.Count
                    || (left_index(node) < MinHeap.Count && right_index(node) >= MinHeap.Count && MinHeap[left_index(node)].Weight >= MinHeap[node].Weight)
                    || (left_index(node) < MinHeap.Count && right_index(node) < MinHeap.Count) && MinHeap[left_index(node)].Weight >= MinHeap[node].Weight && MinHeap[right_index(node)].Weight >= MinHeap[node].Weight)
                    return;
               if (left_index(node) < MinHeap.Count && MinHeap[left_index(node)].Weight <= MinHeap[node].Weight)
               {
                    //swap(MinHeap[left_index(node)],MinHeap[node]);


                    Edge temp = MinHeap[node];
                    MinHeap[node] = MinHeap[left_index(node)];
                    MinHeap[left_index(node)] = temp;
                    MoveDown(left_index(node));
               }
               if (right_index(node) < MinHeap.Count && MinHeap[right_index(node)].Weight <= MinHeap[node].Weight)
               {
                    // swap(MinHeap[right_index(node)], MinHeap[node]);
                    Edge temp = MinHeap[node];
                    MinHeap[node] = MinHeap[right_index(node)];
                    MinHeap[right_index(node)] = temp;

                    MoveDown(right_index(node));
               }
          }



     }
    public static class ShortestpathSubroutiens
     {
         public static List<int> Dijkstra(int Source,int Dest, RGBPixel[,] ImageMatrix)
         {
              const double oo = 10000000000000000000;
              int Width = ImageOperations.GetWidth(ImageMatrix);
              int Height = ImageOperations.GetHeight(ImageMatrix);
              int TotalSize = Width * Height*2;
              List<double> Distance = new List<double>();
              Distance = Enumerable.Repeat(oo, TotalSize).ToList();
              List<int> ParentNode = new List<int>();
              ParentNode = Enumerable.Repeat(-1, TotalSize).ToList();


              PriorityQueue MinimumPath = new PriorityQueue();
              MinimumPath.Push(new Edge(-1,Source,0));
              while (MinimumPath.Size()!=0)
              {
                   Edge CurrentEdge = MinimumPath.Top();
                   MinimumPath.Pop();

                   

                   if (CurrentEdge.Weight >= Distance[CurrentEdge.To])
                          continue;

                   Distance[CurrentEdge.To] = CurrentEdge.Weight;
                   ParentNode[CurrentEdge.To] = CurrentEdge.From;
                   if (CurrentEdge.To == Dest) break;

                   List<Edge> neighbours = GraphSubroutines.Get_neighbours(CurrentEdge.To,ImageMatrix);
                   for (int i = 0; i < neighbours.Count; i++)
                   {
                        Edge TempEdge = neighbours[i];
                        if (Distance[TempEdge.To] > Distance[TempEdge.From] + TempEdge.Weight)
                        {
                             TempEdge.Weight = Distance[TempEdge.From] + TempEdge.Weight;
                             MinimumPath.Push(TempEdge);
                        }
                   }
              
              }
              return ParentNode;
         }
         public static List<Point> DetermineShortestPath(int Source,int Destination,RGBPixel [,] ImageMatrix)
         {
              List<int> Path = Dijkstra(Source,Destination, ImageMatrix);
              return BackPath(Path, Destination, ImageOperations.GetHeight(ImageMatrix));
         }
         public static List<Point> BackPath(List<int> Path, int dest, int Height)
         {
              List<Point> RealPath = new List<Point>();
              Stack<int> RevPath = new Stack<int>();
              int Temp = Path[dest];
              RevPath.Push(dest);
              while(Temp!=-1)
              {
                   RevPath.Push(Temp);
                   Temp = Path[Temp];   
              }
              while (RevPath.Count != 0)
              {
                   var p = Assistant.Untabular(RevPath.Pop(), Height);
                   Point pp = new Point((int)p.X, (int)p.Y);
                   RealPath.Add(pp);
              }
              return RealPath;
         }

     }
}
