using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using ClassLibrary1;
namespace SummerTraining_Lec1


{
    public struct complex
    {
        public int real;
        public int img;
        public void display()
        {
            Console.Write(real);
            if (img > 0)
            {
                Console.Write('+');
                Console.WriteLine($"{img}i");
            }
            else if (img < 0)
            {
                Console.WriteLine($"{img}i");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

          
            

            Employee_data emp1 = new Employee_data(/*12,"ahmed",1200,Employee_data.Gender.male,23*/);
            /*
            
            string[] display_text = { "New", "Display", "Exit" };
            int col_shift = Console.WindowWidth / 2;
            int row_shift = Console.WindowHeight / (display_text.Length + 1);
            int highlight = 0;
            bool looping = true;
            bool Go_back = true;
            string[] user_data = new string[3];

            do
            {
                Console.ResetColor();
                Console.Clear();
                for (int i = 0; i < display_text.Length; i++)
                {
                    if (i == highlight)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.SetCursorPosition(col_shift, row_shift * (i + 1));
                    Console.WriteLine(display_text[i]);
                }

                ConsoleKeyInfo key_pressed = Console.ReadKey();

                switch (key_pressed.Key)
                {
                    case ConsoleKey.DownArrow:
                        highlight++;
                        if (highlight > display_text.Length - 1)
                        {
                            highlight = 0;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        highlight--;
                        if (highlight < 0)
                        {
                            highlight = display_text.Length - 1;
                        }
                        {

                        }

                        break;

                    case ConsoleKey.Home:
                        highlight = 0;
                        break;


                    case ConsoleKey.End:
                        highlight = 2;
                        break;

                    case ConsoleKey.Escape:
                        looping = false;


                        break;

                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch (highlight)
                        {
                            case 0: //new buttton
                                Console.WriteLine("New");
                                New_button_routine(emp1);
                                break;
                            case 1:
                                Console.WriteLine("Display");
                                Display_button_routine(emp1);
                                while (Go_back)
                                {
                                    key_pressed = Console.ReadKey();
                                    if (key_pressed.Key == ConsoleKey.Escape)
                                    {
                                        Go_back = false;
                                    }
                                }
                                Go_back = true;
                                break;

                            case 2:
                                looping = false;
                                break;
                        }

                        break;
                }


            }
            while (looping);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            


            */

            Stack ahmed = new Stack(100);
            ahmed.size = 100;

            ahmed.Push(12);
            ahmed.Push(13);
            ahmed.Push(14);
            Console.WriteLine(ahmed.Pop());
            Console.WriteLine(ahmed.Pop());
            Console.WriteLine(ahmed.Pop());
            Console.WriteLine(ahmed.Pop());

        }




        public static void add_complex ( complex c1, complex c2,ref complex result){  //we add ref to change in the struct itself
            result.real = c1.real + c2.real;    
            result.img = c1.img + c2.img;   
            }

        public static void subtract_complex(complex c1, complex c2, ref complex result)
        {  //we add ref to change in the struct itself
            result.real = c1.real - c2.real;
            result.img = c1.img - c2.img;

        }

        public static void New_button_routine(Employee_data emp)
        {


            
            {
                Console.WriteLine($"Enter Data of Employee ");
                Console.Write("Enter Name :");
                emp.name = Console.ReadLine();
                Console.Write("Enter Your ID :");
                emp.ID = int.Parse(Console.ReadLine());
                Console.Write("Enter Your Salary :");
                emp.Salary = int.Parse(Console.ReadLine());

                Console.Write("Enter your gender : ");
                string user_input = Console.ReadLine();
                user_input.ToLower();
                if(user_input == "male")
                {
                    emp.g = Employee_data.Gender.male;
                }
                else if(user_input == "female")
                {
                    emp.g = Employee_data.Gender.female;
                }

                Console.Write("Enter your Age :");
                emp.age = int.Parse(Console.ReadLine());
            }


        }
        public static void Display_button_routine(Employee_data emp)
        {

            emp.Display_data();
            
        }
    }
}