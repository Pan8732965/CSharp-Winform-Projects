using System.Security.Cryptography;
using System;

namespace learning_code_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string charactorname="John";
            int charactorage;
            charactorage=32;
            Console.WriteLine("There was once a man called "+ charactorname);
            Console.WriteLine("He was "+charactorage+" year old");
            charactorname="Mike";
            Console.WriteLine("he really like this name "+ charactorname);
            Console.WriteLine("but didn't like being "+charactorage);*/
            // ----------data types:
            /*string phrase ="JayPan";
            char grade='a';
            int age=80;
             double gpa=3.3;
             bool isMale=true;

             Console.WriteLine("i want to do a new "+grade+" called "+phrase);*/
            //------Working With Strings:
            /*string phrase ="Hello JayPan "+"is cool!";
            Console.WriteLine(phrase.Substring(6)); //touppeer-->大寫; length-->how many letters in this string.;contain-->means whether this word is in this string or not.*/
            //------working with numbers:
            /*int num=88;
            Console.WriteLine(Math.Pow(99, 5));//Pow次方*/
            //-------getting user input:
            /*Console.Write("pls enter your name: ");
            string name= Console.ReadLine();
            Console.Write("pls enter your age: ");
            string age= Console.ReadLine();
            Console.WriteLine("you are " +name+ " and you are " +age+ " years old.");*/
            //--------building basic calculator:
            /*Console.WriteLine("pls enter your first number: ");
            double num1=Convert.ToDouble(Console.ReadLine());//convert string to number.
            Console.WriteLine("pls enter the second number: ");
            double num2=Convert.ToDouble(Console.ReadLine());
            double num3=num1 + num2;
            
            Console.WriteLine("num1 + num2 is " +num3);*/
            //--------building a mad libs game:
            /*string color, animal, adj;
            Console.Write("enter your color: ");
            color = Console.ReadLine();
            Console.Write("enter your animal: ");
            animal = Console.ReadLine();
            Console.Write("enter your adj: ");
            adj = Console.ReadLine();

            Console.WriteLine("roses are " + color);
            Console.WriteLine(animal + " can swim");
            Console.WriteLine("you are " + adj);*/
            //-------------return statement:
            /*int num1;
            Console.Write("pls enter your number: ");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(cube(num1));*/
            /*static int cube(int num)
        {
            int result=num*num*num;
            return result;
        }*/
            //--------------if statement:
            /*bool ismale=false ;
            bool istall=true;
            if(ismale || istall)
            {
                Console.WriteLine("you are a tall male.");
            }
            else if(ismale && !istall){
                Console.WriteLine("you are male but not tall.");
            }
            else if(!ismale && istall){
                Console.WriteLine("you are not male but you are tall.");
            }
            else
            {
                Console.WriteLine("you not tall and not a male.");
            }*/
            //---------is statement(con't):
            /*int num1, num2,num3;
            Console.Write("pls enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("pls enter a number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("pls enter a number: ");
            num3= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(compare(num1, num2,num3));
            Console.ReadLine();*/
            //--function here:
            /*static int compare(int num1, int num2,int num3)
            {
            int result;
            if (num1 >= num2 && num1>=num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else 
            {
                result = num3;
            }
            return result;
            }*/
            //-----------building better calculator:
            /*double num1;
            string op;
            double num2;
            Console.Write("pls enter a number: ");
            num1= Convert.ToDouble(Console.ReadLine());    

            Console.Write("pls enter a operator: ");
            op= Console.ReadLine();

            Console.Write("pls enter a number: ");
            num2=Convert.ToDouble(Console.ReadLine());     

            if(op=="+"){
            Console.WriteLine(num1+num2);
            }
            else if(op=="-"){
            Console.WriteLine(num1-num2);
            }
            else if(op=="*"){
            Console.WriteLine(num1*num2);
            }
            else if(op=="/"){
            Console.WriteLine(num1/num2);
            }
            else{
            Console.WriteLine("error");
            }*/
            //----------switch statement: 
            /*int daynum;
            Console.Write("pls enter your number.");
            daynum=Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine(getday(daynum)); */   
            /*static string getday(int daynum){
                string dayname;
                switch(daynum){
                    case 0:
                    dayname="sunday";
                    break;
                    case 1:
                    dayname="monday";
                    break;
                    case 2:
                    dayname="tuesday";
                    break;
                    case 3:
                    dayname="wedsday";
                    break;
                    case 4:
                    dayname="thursday";
                    break;
                    case 5:
                    dayname="friday";
                    break;
                    case 6:
                    dayname="saturday";
                    break;
                    default:
                    dayname="error";
                    break;
                }
                return dayname;
            }*/
            //------while loops:
            /*int num=1;
            do{
                Console.WriteLine(num);
                num++;
            }while(num<=5);*/
            //-------building a guessing game:
            /*string secretword="jaypan";
            string guess="";
            int count=0;
            do{
                Console.WriteLine("pls enter the guess word: ");
                guess=Console.ReadLine();
                count++;
                Console.WriteLine(count);
            }while(guess!=secretword && count!=5);
            if(guess==secretword){
                Console.WriteLine("you win");
            }
            else
            {
                Console.WriteLine("you lose.");
            }*/
            //-----for loops:
            /*int i,j;
            for(i=1;i<=22;i++){ 
                    Console.WriteLine("*");
            }*/
            //--------Exception Handling:
            try
            {
            int num1,num2;
            Console.Write("pls enter a number: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("pls enter a number again: ");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 / num2);
            }
            catch(Exception e) //(DivideByZeroException e) only catch DivideByZeroException exception.
            {
                Console.WriteLine(e.Message); //(e.Message)get the error message.
            }
            

            Console.ReadLine();
        }
        
    }
}
