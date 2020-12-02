using System.Reflection.Metadata;
using System.Collections.Concurrent;
using System.Buffers;
using System.Reflection.Emit;
using System.Data;
using System.Net.NetworkInformation;
using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1,num2,num3=0;
            string oper,option;
            Console.WriteLine("this is a calcultor program with using c#.\n");
            do{
                Console.Write("pls enter a number: ");
                num1= Convert.ToDouble(Console.ReadLine());  

                Console.Write("pls enter a operator(*,/,+,-,%): ");
                oper= Console.ReadLine();

                Console.Write("pls enter a number: ");
                num2=Convert.ToDouble(Console.ReadLine());  

                
                switch(oper){
                    
                    case "+" :

                        num3 = num1 + num2;
                        break;
                    case "-": 

                        num3 = num1 - num2;
                        break;

                    case "*":
                        num3 = num1 * num2;
                        break;

                    case "/":
                        num3 = num1 / num2;
                        break;

                    case "%":
                        num3 = num1 % num2;
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }

                Console.WriteLine(+num1 + oper+ num2 + "=" + num3);
                option = Console.ReadLine();
                
            }while(option=="y");
        }
        
    }
}
