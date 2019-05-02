using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class CircleApp
    {
        public List<Circle> Circles = new List<Circle>() { };

        public void Run()
        {
            
            while (true)
            {
                Console.WriteLine("Please enter a radius");
                try
                {
                    

                    double input = double.Parse(Console.ReadLine());
                    if (input > 0)

                    {
                        Circles.Add(new Circle(input));
                    }
                    else
                    {
                        throw new Exception("Enter a valid radius");
                    }


                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                
                Console.WriteLine("Try Again? (Yes or No)");
                string answer = Console.ReadLine();
                answer = answer.ToLower();
                if (answer == "yes" || answer == "y")
                {
                    continue;
                }
                else if (answer == "no" || answer == "n")
                {
                    PrintCircles(); 
                    break;
                }
                //else
                //{
                //    Console.WriteLine("Answer with a yes or no");
                //    continue;
                //}
                
            }
        }
        public void PrintCircles()
        {
            foreach(Circle circle in Circles)
            {
                circle.PrintInfo();
            }
        }




    }
}
