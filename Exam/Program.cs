using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Exam;

namespace GreenAcademy
{
    class main
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            int n = 1;
            while(n != 6)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1. Input information");
                Console.WriteLine("2. Sorting student asccending by average mark.");
                Console.WriteLine("3. Display all the student.");
                Console.WriteLine("4. Search Student by Name");
                Console.WriteLine("5. Delete Student by student ID");
                Console.WriteLine("6. Exit program.");
                Console.WriteLine("-------------------------------------");
                Console.Write("Moi ban chon chuc nang: ");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Ban da chon chuc nang 1!");
                        Console.WriteLine("***************************");
                        st.AddStudent();
                        break;
                    case 2:
                        Console.WriteLine("Ban da chon chuc nang 2!");
                        Console.WriteLine("***************************");
                        st.SortingStudentMark();
                        break;
                    case 3:
                        Console.WriteLine("Ban da chon chuc nang 3!");
                        Console.WriteLine("***************************");
                        st.DisplayListStudent();
                        break;
                    case 4:
                        Console.WriteLine("Ban da chon chuc nang 4!");
                        Console.WriteLine("***************************");
                        st.FindStudentName();
                        break;
                    case 5:
                        Console.WriteLine("Ban da chon chuc nang 5!");
                        Console.WriteLine("***************************");
                        st.DeleteStudent();
                        break;
                    case 6:
                        Console.WriteLine("Ban da chon chuc nang 6!");
                        Console.WriteLine("***************************");
                        Console.WriteLine("Ban da thoat khoi chuong trinh!");
                        break;
                    default:
                        Console.WriteLine("Ban da chon sai chuc nang xin moi chon lai!");
                        break;
                }
            }
        }
    }
}