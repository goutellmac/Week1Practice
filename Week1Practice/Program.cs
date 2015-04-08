using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARING VARIABLES
            // 1. Declare a string variable called "myName" and set it equal to your name
            string myName = "Mac";
            // 2. Declare a number varible called "myAge" and set it equal to your age
            int myAge = 23;
            // 3. Declare a boolean value called "myBool" and set it equal to true or false;
            bool myBool = true;
            // 4. Declare a new list of strings called "productsList" and set it equal to "basketball", "baseball glove", "tennis shoes", "hockey puck"
            List<string> productsList = new List<string>();
            productsList.Add("basketball");
            productsList.Add("baseball glove");
            productsList.Add("tennis shoes");
            productsList.Add("hockey puck");
            
            

            // PRINTING VARIABLES TO THE CONSOLE USING CONSOLE.WRITELINE()
            // 1. Print your name to the console using the format: "My name is <myName> and I'm a beast of a programmer"
            Console.WriteLine("My name is " + myName + " and I'm a beast of a programmer");
            // 2. Print out your age to the console using the format: "I am <myAge> years awesome."
            Console.WriteLine("I am " + myAge + " years awesome.");
            // 3. Print out your boolean value using the format: "I set my boolean value equal to <myBool>"
            Console.WriteLine("I set my boolean value equal to: " + myBool + ".");
            // 4. Using a For loop, print out each value in productsList.
            // ??

            // FOR LOOP PRACTICE
            // 1. Create a for loop that prints out the numbers 1 to 10.
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            // 2. Create a for loop that prints out the numbers 10 to 1.
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            // 3. Create a for loop that prints out the numbers 10 to 30, only printing the even numbers
            for (int i = 10; i <= 30; i+=2)
            {
                Console.WriteLine(i);
            }
            // 4. Create a for loop that prints out the numbers 100 to 75, only printing every 5th number (100, 95, 90, 85, 80, 75)
            for (int i = 100; i >= 75; i-=5)
            {
                Console.WriteLine(i);
            }
            // WHILE LOOP PRACTICE
            // 1. Create a while loop that prints out the numbers from 1 to 10.
            int x = 0;
            while (x < 11)
            {
                Console.WriteLine(x);
                x++;
            }
            // 2. Create a while loop that prints out the numbers from 10 to 1.
            int x1 = 10;
            while (x1 > 0)
            {
                Console.WriteLine(x1);
                x1--;
            }
            // 3. Create a while loop that prints out the numbers from 15 to 30, only printing the even numbers
            int x2 = 16;
            while (x2 <= 30)
            {
                Console.WriteLine(x2);
                x2 += 2;
            }
            // 4. Create a while loop that prints out the numbers from 100 to 75, only printing every 5th number (100, 95, 90, 85, 80, 75)
            int x3 = 100;
            while (x3 >= 75)
            {
                Console.WriteLine(x3);
                x3 -= 5;
            }
            // 5. Create a while loop that prints out the numbers from 1 to 10 until it reaches one that is divisible by 4.
            int x4 = 1;
            while (x4 % 4 != 0)
            {
                Console.WriteLine(x4);
                x4++;
            }
            

            // PUTTING IT TOGETHER
            // Use either FOR or WHILE loops to accomplish the following:
            // 1. Print out the number of letters in your name using the format: "My name, <myName>, has <number of letters> in it."
            for (int i = 0; i <= myName.Length; i++)
            {
                if (i == myName.Length)
                {
                    Console.WriteLine("My name: " + myName + " has " + i + " letters in it.");
                }
                
            }
            
            

            // 2. Print out the number of items in your list using the format: "My product list has <number of items> in it."
            Console.WriteLine("My product list has " + productsList.Count + " items in it.");
            // 3. Print out the number of letters of each item in productsList using the format: "<product> has <number of letters> in it."
            // ?? 

            // DECLARING AND CALLING FUNCTIONS
            // 1. Create a function called "Greeting" that takes one string parameter called "name".  This function will print "Hello <name>"
            // 2. Call the Greeting function by passing in "Geronimo Jackson" as your parameter.
            Greeting("Geronimo Jackson");
            // 3. Call the Greeting function by passing in myName as your parameter.
            Greeting(myName);
            
             
            // 4. Create a function called "DoubleIt" that takes one integer parameter called "number".  This function will print "<number> doubled is <number * 2>"
            // 5. Call your DoubleIt Function by passing in 1337 as your parameter.
            DoubleIt(1337);
            // 6. Call your DoubleIt function by passing in myAge as your parameter.
            DoubleIt(myAge);
            

            // 7. Create a function called "Multiply" that takes two integer parameters called "num1" and "num2".  This function will print "<num1> times <num2> is <num1 * num2>"
            
            // 8. Call your Multiply function by passing in 2 and 8 as your parameters.
            Multiply(2, 8);
            // 9. Call your Multiply function by passing in 3 and myAge as your parameters.
            Multiply(3, myAge);
            

            // 10. Create a function called "LoopThis" that takes two integer parameters called "startNum" and "endNum".  
            //      This function will print out: 
            //          a. "I'm looping from <startNum> to <endNum>."  
            //          b. The numbers from startNum to endNum, one per line.
            // 11. Call your LoopThis function by passing in 20 and 30 as your parameters.
            LoopThis(20, 30);
            // 12. Call your LoopThis function by passing in 0 and myAge as your parameters.
            LoopThis(0, myAge);
            

            // 13. Create a function called "SuperLoop" that takes three integer parameters called "startNum", "endNum", and "increment".  
            //      You will need to track how many times the loop has been executed in a variable called "loopCount".
            //      This function will print out: 
            //          a. "I'm looping from <startNum> to <endNum>, incrementing <increment> each time"  
            //          b. The numbers from startNum to endNum, one per line.
            //          c. "That loop was craaaaaazy, we looped X times"
            // 14. Call your SuperLoop function by passing in 0, 100, and 15 as your parameters.
            SuperLoop(0, 100, 15);
            // 15. Call your SuperLoop function by passing in 0, 200, and myAge as your parameters.
            SuperLoop(0, 200, myAge);
           
            

            //DECLARING AND CALLING RETURN FUNCTIONS
            // 1. Create a function called "NewGreeting" that takes one string parameter called "name".  This function will return a string in the format of "Hello, <name>"
            // 2. Using your NewGreeting function as the parameter for Console.WriteLine(), call your NewGreeting function using the parameter "Neil deGrasse-Tyson"
            //          EX: Console.WriteLine(FunctionCall("myParameter"));
            Console.WriteLine(newGreeting("Neil deGrasse-Tyson"));
       
            // 3. Using your NewGreeting function as the parameter for Console.WriteLine(), call your NewGreeting function using the parameter myName.
            Console.WriteLine(newGreeting(myName));
            
            // 4. Create a function called "TripleIt" that takes one integer parameter called "number".  This function will return the number times 3.
            // 5. Using your TripleIt function as part of the parameter for Console.WriteLine(), 
            //      call your TripleIt function using the parameter of 10 to print out "10 tripled is <TripleIt Function Call>"
            Console.WriteLine("10 tripled is " + TripleIt(10) + ".");
            // 6. Using your TripleIt function as part of the parameter for Console.WriteLine(), 
            //      call your TripleIt function using the parameter of myAge to print out "<myAge> tripled is <TripleIt Function Call>"
            Console.WriteLine(myAge + " tripled is " + TripleIt(myAge) + ".");

            // 7. Create a function called "RealMultiply" that takes two integer parameters called "num1", and "num2".  This function will return the num1 * num2.
            // 8. Using your RealMultiply function as part of the parameter for Console.WriteLine(), 
            //      call your RealMultiply function using the parameter of 5 and 10 to print out the returned value from your function.
            Console.WriteLine(RealMultiply(5, 10));
            // 9. Using your RealMultiply function as part of the parameter for Console.WriteLine(), 
            //      call your RealMultiply function using the parameter of 2 and myAge to print out the returned value from your function.
            Console.WriteLine(RealMultiply(2, myAge));

            //FUNCTION CALL MADNESS!
            // 1. Call your SuperLoop function using the following parameters:
            //      startNum = Call RealMultiply with the parameters 1, 5
            SuperLoop(RealMultiply(1, 5), 10, 2);
            //      endNum = Call TripleIt with the parameter myAge
            SuperLoop(1, TripleIt(myAge), 2);
            //      increment = Call TripleIt with the parameter of myAge minus 10
            SuperLoop(1, 200, TripleIt(myAge) - 10);

            // 2. Call your SuperLoop function using the following parameters:
            //      startNum = Call RealMultiply with the parameters 1, and TripleIt with the parameter of 3.
            SuperLoop(RealMultiply(1, TripleIt(3)), 100, 2);
            //      endNum = Call TripleIt with the parameter RealMultiply with the parameters: myAge, 7
            SuperLoop(1, TripleIt(RealMultiply(myAge, 7)), 2);
            //      increment = Call TripleIt with the parameter of myAge minus RealMultiply with the parameters 2, 4.
            SuperLoop(1, 100, RealMultiply(2, 4));
            


        }

        //START -- FUNCTION DECLARATIONS 

        //Example function declaration
        public static void MyFunction(string myParameter)
        {
            //Code block
        }

        public static void Greeting(string theName)
        {
            Console.WriteLine("Hello " + theName + "!");
        }

        public static void DoubleIt(int number)
        {
            Console.WriteLine("Number doubled is " + number * 2);
        }

        public static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 + " times " + num2 + " is " + num1 * num2);
        }

        public static void LoopThis(int startNum, int endNum)
        {
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum);
            for (int i = startNum; i < endNum; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void SuperLoop(int startNum, int endNum, int increment)
        {
            int loopCount = 0;
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum + " and incrementing by " + increment + " each time.");
            for (int i = startNum; i < endNum; i+=increment)
            {
                Console.WriteLine(i);
                loopCount++;
            }
            Console.WriteLine("That loop was craaaaaazy!  We looped " + loopCount + " times!");
        }

        public static string newGreeting(string name)
        {
            return "Hello " + name + "!";
        }

        public static int TripleIt(int number)
        {
            return number * 3;
        }

        public static int RealMultiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int WordCounter(string inputText)
        {
            List<string> wordList = new List<string>();
            wordList = inputText.Split(' ').ToList();
            return wordList.Count;
        }
        //END   -- FUNCTION DECLARATIONS
    }
}
