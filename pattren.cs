using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class pattren
    {
        public void SLetter()
        {
            //s letter
            for(int i = 1; i <=1; i++)
            {
                for(int j = 1; j <=6; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(int i = 1;i <=3;i++)
            {
                for(int j=1; j <=1; j++)
                {
                    Console.Write("*");
                }
                
                if (i == 3)
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            for(int i = 1;i <=2; i++)
            {

                for(int j = 1; j <= 6; j++)
                {
                    if(j==6)
                    {
                        Console.Write("*");
                    }
                    Console.Write(" ");
                }
                
                Console.WriteLine();
        
            }
            for(int i = 1; i <= 1; i++)
            {
                for(int j = 1; j <= 6; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //u letter
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 6; j++)
                {
                    
                     if (j == 1||j==6||i==5)
                    {
                        Console.Write("*");
                    }

                   
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            //R Letter
            for(int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if (i == 1 && j == 6)
                    {
                        Console.Write(" ");
                    }
                    else if (i == 4 && j == 6)
                    {
                        Console.Write(" ");
                    }
                   else if (i == 1 || j == 1 || j == 6 || i == 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (i == 1||j==1) 
                    { 
                        Console.Write("*"); 
                    }
                    else if (i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            //E letter
            for (int i = 1; i <= 1; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 1; j++)
                {
                    Console.Write("*");
                }

                if (i == 3)
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 1; j++)
                {
                    Console.Write("*");
                }

                if (i == 3)
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
