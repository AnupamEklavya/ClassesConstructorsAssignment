using System;
namespace ClassesConstructorsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Instructor instructor1=new Instructor("Anupam", new string[3]{"JAVA","C#","SQL"},3,4);
            /*Instructor instructor2 = new Instructor("Akshay", new string[1] { "Java"}, 2, 3);*/
            string Technology;
            Console.Write("Enter the Technology You want to learn :");
            Technology = Console.ReadLine();
            //lower to upper
            Technology = Technology.ToUpper();
            if (instructor1.CheckSkill(Technology))
            {
                Console.WriteLine("You can join our ABC Technology Training Center ");
                Console.WriteLine("Your Instructor will be :");
                //Details() method will provide the all information about instructor.
                instructor1.Details();
            }
            else
            {
               Console.WriteLine("Sorry we can't provide you The course! Come back Later");
            }
        }
    }
}
