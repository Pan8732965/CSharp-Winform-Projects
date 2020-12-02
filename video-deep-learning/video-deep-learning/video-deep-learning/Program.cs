using System;

namespace video_deep_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] board;
            /*board=new int[4,4]; //2d arrays
            board[0,1]=10;*/

            //int[] scores=new int[]{12,30,100}; 1d array
            /*board=new int[,]{{0,1},{2,3}};
            Console.WriteLine(+board[1,0]);*/
            //------------
            int x,y;
            int[,] a={{1,2},
                      {3,4}};
            int[,] b={{2,2},
                      {4,5}};

            string result = "";

            for(x=0;x<2;x++){
                for(y=0;y<2;y++){
                    result +=" "+A[x,y];
                }
                result +="\n";
            }
            Console.Write(result);
            //----------
            
        }
         
    }
}
