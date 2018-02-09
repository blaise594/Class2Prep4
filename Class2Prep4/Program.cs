using System;
using System.Collections.Generic;
using System.Linq;

namespace Class2Prep4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            int newStudent;
            Console.WriteLine("Enter your students (enter any non integer key to exit)");
            try
            {
                do
                {

                    Console.WriteLine("Enter student Id (must be integer)");
                    newStudent = int.Parse(Console.ReadLine());
                    if (newStudent != 0)
                    {
                        Console.WriteLine("Enter student name");
                        string newName = Console.ReadLine();

                        students.Add(newStudent, newName);
                    }


                }
                while (newStudent != 0);
            }
            catch(Exception)
            {
                foreach (KeyValuePair<int, string> student in students)
                {
                    Console.WriteLine(student.Key + ": " + student.Value);
                    
                }
                Console.ReadLine();
            }
        }
            
                   
                        
            
    }
}