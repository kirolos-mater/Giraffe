using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(" ____");
            // Console.WriteLine("/___|");
            // Console.WriteLine("   ||");
            // Console.WriteLine("  / |");
            // Console.WriteLine(" /  |");
            // Console.WriteLine("/___|");

            // string characterName = "Tom";
            // int characterAge;
            // characterAge = 25;

            // Console.WriteLine("There once was a man named " + characterName);
            // Console.WriteLine("He was " + characterAge + " years old");

            // characterName = "Mike";
            // Console.WriteLine("He really liked the name " + characterName);
            // Console.WriteLine("But didn't like being " + characterAge);

            // string phrase = "Giraffe Academy";
            // char grade = 'A';
            // int age = 30;
            // // float, double, decimal
            // double gpa = 3.3;
            // bool isMale = true;


            // string phrase = "Giraffe Academy" + " is cool";
            // Console.WriteLine(phrase.Contains("Academy")); /* output: true */
            // Console.WriteLine(phrase[0]); /* output: G */
            // Console.WriteLine(phrase.IndexOf("Academy")); /* output: 8 */
            // Console.WriteLine(phrase.Substring(8)); /* output: Academy */
            // Console.WriteLine(phrase.Substring(8, 3)); /* output: Aca */
            // Console.WriteLine(phrase.Substring(phrase.IndexOf("Academy"))); /* output:  Academy is cool*/

            // Console.WriteLine( 5 / 2); /* output: 2 */
            // Console.WriteLine( 5 / 2.0); /* output: 2.5 */

            // Console.WriteLine(Math.Abs(-40)); /* output: 40 */
            // Console.WriteLine(Math.Pow(3, 2)); /* output: 9 */
            // Console.WriteLine(Math.Max(4, 90)); /* output: 90 */
            // Console.WriteLine(Math.Round(4.6)); /* output: 5 */

            // Console.WriteLine("Hello"); 
            // /* quando si usa il "WriteLine" stampa il valore e va a capo */

            // Console.Write("Enter your name: ");
            // /* quando si usa il "Write" stampa il valore e rimane sulla stessa riga */
            // string name = Console.ReadLine();
            // Console.Write("Enter your age: ");
            // string age = Console.ReadLine();
            //
            // Console.WriteLine("Hello " + name + " you are " + age);

            //Console.WriteLine("43" + "56"); 
            ///* output: 4356 */

            //int num = Convert.ToInt32("45");

            //Console.WriteLine(num + 6);
            ///* output: 51 */

            // Console.Write("Enter a number: ");
            // double num1 = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Enter another number: ");
            // double num2 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine(num1 + num2);

            //string color, pluralNoun, celebrity;

            //Console.Write("Enter a color: ");
            //color = Console.ReadLine();

            //Console.Write("Enter a plural noun: ");
            //pluralNoun = Console.ReadLine();

            //Console.Write("Enter a celebrity: ");
            //celebrity = Console.ReadLine();

            //Console.WriteLine("Roses are red " + color);
            //Console.WriteLine(pluralNoun + " are blue");
            //Console.WriteLine("I Love " + celebrity);

            //int[] luckyNumbers = {4, 8, 15, 16, 23, 42};

            //luckyNumbers[1] = 900;

            //string[] friends = new string[10];
            //friends[0] = "Jim";
            //friends[1] = "Kelly";

            //Console.WriteLine(luckyNumbers[2]);
            ///* output: 15 */


            //SayHi("Mike", 33);

            //Console.WriteLine(cube(5));
            //double cubeNumber = cube(5);



            //bool isMale = false;
            //bool isTall = true;



            //if (isMale && isTall)
            //{
            //    Console.WriteLine("You are a tall male");
            //}
            //else if(isMale && !isTall)
            //{
            //    Console.WriteLine("You are a short male");
            //}else if(!isMale && isTall)
            //{
            //    Console.WriteLine("You are not male but you" +
            //        "are tall");
            //}else
            //{
            //    Console.WriteLine("You either not male or not" +
            //        " tall or both");
            //}

            //if(isMale || isTall)
            //{
            //    Console.WriteLine("You are or tall or a male or both");
            //} else
            //{
            //    Console.WriteLine("You either not male or not" +
            //        " tall or both");
            //}

            //Console.WriteLine(GetMax(20, 10, 40));

            //Console.WriteLine("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Operator: ");
            //string op = Console.ReadLine();

            //Console.WriteLine("Enter a number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //if(op == "+")
            //{
            //    Console.WriteLine(num1 + num2);
            //}else if(op == "-")
            //{
            //    Console.WriteLine(num1 - num2);
            //}else if(op == "*")
            //{
            //    Console.WriteLine(num1 * num2);
            //}else if(op == "/")
            //{
            //    Console.WriteLine(num1 / num2);
            //}else if(op == "^")
            //{
            //    Console.WriteLine(Math.Pow(num1, num2));
            //}
            //else
            //{
            //    Console.WriteLine("You have entered an invalid operator");
            //}


            //Console.WriteLine(GetDay(80));

            //int index = 1;
            //while (index <= 5)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}

            //do
            //{
            //    Console.WriteLine(index);
            //    index++;
            //} while (index <= 5);

            //string secretWord = "giraffe";
            //string guess = "";

            //int guessCount = 0;
            //int guessLimit = 3;
            //bool outOfGuesses = false;

            //while(guess != secretWord && !outOfGuesses)
            //{
            //    if (guessCount < guessLimit)
            //    {
            //        Console.Write("Enter Guess: ");
            //        guess = Console.ReadLine();
            //        guessCount++;
            //    } else
            //    {
            //        outOfGuesses = true;
            //    }       
            //}

            //if (outOfGuesses)
            //{
            //    Console.Write("You Lose!");
            //}
            //else
            //{
            //    Console.WriteLine("You Win!");
            //}

            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            //for (int i = 0; i < luckyNumbers.Length; i++)
            //{
            //    Console.WriteLine(luckyNumbers[i]);
            //}
            
            // Console.WriteLine(GetPow(3, 2));

            // int[,] numberGrid =
            // {
            //     {1, 2},
            //     {3, 4},
            //     {5, 6}
            // };
            //
            // Console.WriteLine(numberGrid[1, 0]);
            // /* output: 3 */
            
            // Console.WriteLine("Comments are fun");

            // try
            // {
            //     Console.Write("Enter a number: ");
            //     double num1 = Convert.ToInt32(Console.ReadLine());
            //     Console.Write("Enter another number: ");
            //     double num2 = Convert.ToInt32(Console.ReadLine());
            //
            //     Console.WriteLine(num1 / num2);
            // }
            // catch (DivideByZeroException e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            // catch (FormatException e)
            // {
            //     Console.WriteLine(e.Message);
            // }
            // finally
            // {
            //     Console.WriteLine("Done");
            // }    
            
            // Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            // Book book2 = new Book("Lord of the Rings", "Tolkien", 700);
            //
            // Console.WriteLine(book1.title);
            // Console.WriteLine(book2.author);
            
            // Student student1 = new Student("Jim", "Business", 2.8);
            // Student student2 = new Student("Pam", "Art", 3.6);
            //
            // Console.WriteLine(student1.HasHonors());
            // Console.WriteLine(student2.HasHonors());
            
            // Movie ave
            
            // Song holiday = new Song("Holiday", "Green Day", 200);
            // Console.WriteLine(Song.songCount);
            // Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            // Console.WriteLine(Song.songCount);
            // Console.WriteLine(holiday.title);
            // Console.WriteLine(kashmir.artist);
            // Console.WriteLine(Song.songCount);
            
            // Console.WriteLine(Math.Sqrt(144));
            
            // UsefulTools.SayHi("Mike");
            
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakePasta();
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }

        // static int GetPow(int baseNum, int powNum)
        // {
        //     int result = 1;
        //
        //     for (int i = 0; i < powNum; i++)
        //     {
        //         result = result * baseNum;
        //     }
        //
        //     return result;
        // }

        //static string GetDay(int dayNum)
        //{
        //    string dayName;
        //    switch (dayNum)
        //    {
        //        case 0:
        //            dayName = "Sunday";
        //            break;
        //        case 1:
        //            dayName = "Monday";
        //            break;
        //        case 2:
        //            dayName = "Tuesday";
        //            break;
        //        case 3:
        //            dayName = "Wednesday";
        //            break;
        //        case 4:
        //            dayName = "Thursday";
        //            break;
        //        case 5:
        //            dayName = "Friday";
        //            break;
        //        case 6:
        //            dayName = "Saturday";
        //            break;
        //        default:
        //            dayName = "Invalid Day Number";
        //            break;
        //    }

        //    return dayName;
        //}

        //static int GetMax(int num1, int num2, int num3)
        //{
        //    int result;

        //    if(num1 >= num2 && num1 >= num3)
        //    {
        //        result = num1;
        //    }
        //    else if(num2 >= num1 && num2 >= num3)
        //    {
        //        result = num2;
        //    }
        //    else
        //    {
        //        result = num3;
        //    }


        //    return result;
        //}

        //static double cube(double num)
        //{
        //    double result = num * num * num;
        //    return result;
        //}

        //static void SayHi(string name, int age)
        //{
        //    Console.WriteLine("Hello " + name + " you are " + age);
        //}
    }
}
