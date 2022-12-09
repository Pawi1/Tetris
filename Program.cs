using System;
using System.Threading;
internal class Tetris
{
        static void Main(string[] args)
        {
          Console.OutputEncoding = System.Text.Encoding.UTF8;
          string[] A = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 1
          string[] B = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 2
          string[] C = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 3
          string[] D = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 4
          string[] E = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 5
          string[] F = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 6
          string[] G = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 7
          string[] H = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 8
          string[] I = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 9
          string[] J = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 10
          string[] K = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 11
          string[] L = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 12
          string[] M = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 13
          string[] N = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 14
          string[] O = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 15
          string[] P = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 16
          string[] R = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 17
          string[] S = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 18
          string[] T = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 19
          string[] U = new string[10] {" "," "," "," "," "," "," "," "," "," "}; // 20
          string[][] YX = new string[20][] {A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,R,S,T,U};
          int punkty = 0;
          while(true)
        { 
          int figura = 1;
          int przyszlaFigura = Losowanie();
          if (figura == 1)FiguraT(YX,przyszlaFigura,punkty);
          figura = przyszlaFigura;
        }
        }
        static int Losowanie()
        {
        Random los = new Random();        
        int Figura = los.Next(1,7);
        return Figura;
        }


        
        // static void SilnikGryFigury()
        // {

        // }


        // static void SilnikGryInput()
        // {

        // }
        static void FiguraT(string[][] YX,int przyszlaFigura = 0,int punkty = 0)
        {
          Console.CursorVisible = false;
          for (int i = 0, a = 0;i<18;i++)
        { int b = 0;      
          while(b<600)
            {
                if (Console.KeyAvailable == true)
                {
                  ConsoleKeyInfo cki = Console.ReadKey(true);
                  if (cki.Key == ConsoleKey.RightArrow && a<4) a++;
                  else if (cki.Key == ConsoleKey.LeftArrow && a>-4) a--;
                  YX[0+i][4+a] = "■";
                  YX[1+i][4+a] = "■";
                  YX[1+i][5+a] = "■";
                  YX[2+i][4+a] = "■";
                  Render(YX,przyszlaFigura,punkty);
                  YX[0+i][4+a] = " ";
                  YX[1+i][4+a] = " ";
                  YX[1+i][5+a] = " ";
                  YX[2+i][4+a] = " ";
                }
                Thread.Sleep(1);
                b++;            
            }          
          if (YX[0+i][4+a] == " ")
            {
               YX[0+i][4+a] = "■";
               YX[1+i][4+a] = "■";
               YX[1+i][5+a] = "■";
               YX[2+i][4+a] = "■";
               Render(YX,przyszlaFigura,punkty);
               YX[0+i][4+a] = " ";
               YX[1+i][4+a] = " "; 
               YX[1+i][5+a] = " ";
               YX[2+i][4+a] = " ";
            }
        }
          Console.CursorVisible = true;
      }
        static void Render(string[][] YX,int przyszlaFigura = 0,int punkty = 0)
        {
          Console.Clear();
          for (int y = 0;y<20;y++)
          {
            Console.Write("\t┃ ");
              for (int x = 0;x<10;x++)
              {
                Console.Write($"{YX[y][x]} "); 
              }
            Console.Write("┃");
            
            if(y == 0) Console.Write("\t Następna Figura:");
            if(y == 2)
            {
              if (przyszlaFigura != 3 && przyszlaFigura != 5) Console.Write("\t\t■");
              else Console.Write("\t\t ");
              if (przyszlaFigura == 3 || przyszlaFigura == 5 || przyszlaFigura == 6) Console.Write(" ■");
              else Console.Write("  ");
            }
           else if (y == 3)
            {
              if (przyszlaFigura != 3) Console.Write("\t\t■");
              else Console.Write("\t\t ");
              if (przyszlaFigura != 7 && przyszlaFigura != 2) Console.Write(" ■");
              else Console.Write("  ");
            }  
            else if (y == 4)
            {
              if (przyszlaFigura != 4 && przyszlaFigura != 6) Console.Write("\t\t■");
              else Console.Write("\t\t ");
              if (przyszlaFigura == 2 || przyszlaFigura == 3 || przyszlaFigura == 4) Console.Write(" ■");
              else Console.Write("  ");
            } 
            else if (y == 5 && przyszlaFigura == 7) Console.Write("\t\t■");        
            if (y==7) Console.Write("\t Punktacja:");
            if (y==8) Console.Write($"\t {punkty}");
            Console.WriteLine();
          }
          Console.WriteLine($"\t┗━━━━━━━━━━━━━━━━━━━━━┛");
          Console.WriteLine("\t\t DEMO");
          
        }
}
