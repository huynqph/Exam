using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Student
    {
        public List<Student> ListStudent;
        public static int nextID = 1;
        public int Id { get; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; set; }
        public String Class { get; set; }
        public float Mark1 { get; set; }
        public float Mark2 { get; set; }
        public float Mark3 { get; set; }
        public float mark_AVG { get; set; }
        public string xepLoai { get; set; }

        public Student()
        {
            ListStudent = new List<Student>();
        }

        public Student( string Name, string Gender, int Age, DateTime Date,string Class, float Mark1, float Mark2, float Mark3)
        {
            
            Id = nextID++;
            this.Name = Name;
            this.Gender = Gender;
            this.Age = Age;
            this.Date = Date;
            this.Class = Class;
            this.Mark1 = Mark1;
            this.Mark2 = Mark2;
            this.Mark3 = Mark3;
            Mark_AVG();
            XepLoaiHocLuc();
        }
        private void Mark_AVG()
        {
            mark_AVG = (Mark1 + Mark2 + Mark3) / 3;

        }
        private void XepLoaiHocLuc()
        {
            if(mark_AVG > 8.5)
            {
                xepLoai = "Gioi";
            }else if (mark_AVG > 6.5)
            {
                xepLoai = "Kha";
            }else if(mark_AVG > 5)
            {
                xepLoai = "Trung Binh";
            }
            else
            {
                xepLoai = "Yeu";
            }
        }
        public void AddStudent()
        {
            Console.Write("Nhap ho ten: ");
            string Name = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            string Gender = Console.ReadLine();
            Console.Write("Nhap Tuoi: ");
            int Age = int.Parse(Console.ReadLine());
            Console.Write("Nhap Sinh Nhat: ");
            DateTime Date = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap lop: ");
            string Class = Console.ReadLine();
            Console.Write("Nhap diem Mark1: ");
            float Mark1 = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Mark2: ");
            float Mark2 = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Mark3: ");
            float Mark3 = float.Parse(Console.ReadLine());
            Student st = new Student(Name,Gender,Age,Date,Class,Mark1,Mark2,Mark3);
            ListStudent.Add(st);

            Console.WriteLine("Them student thanh cong");
        }
        public void OutputStudent()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Tuoi: {Age}");
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Mark1: {Mark1}");
            Console.WriteLine($"Mark2: {Mark2}");
            Console.WriteLine($"Mark3: {Mark3}");
            Console.WriteLine($"Mark_AVG: {Mark_AVG}");
            Console.WriteLine($"XepLoai: {XepLoaiHocLuc}");
            Console.WriteLine();
        }
        public int LStudent()
        {
            return ListStudent.Count;
        }
        
        public void DeleteStudent()
        {
            Console.Write("Nhap Id student can xoa: ");
            int Id = int.Parse(Console.ReadLine());

            Student st = ListStudent.Find(st => st.Id == Id);
            if(st != null)
            {
                ListStudent.Remove(st);
                Console.WriteLine("Xoa Student thanh cong!");
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien can xoa!");
            }
        }
        public void FindStudentName()
        {
            Console.Write("Nhap ten student can tim: ");
            string Name = Console.ReadLine();
            List<Student> result = ListStudent.FindAll(st => st.Name.Contains(Name));
            if(result.Count > 0)
            {
                Console.WriteLine("Ket qua tim kiem: ");
                foreach  (Student st in result)
                {
                    st.OutputStudent();
                }
            }
        }
        public void SortingStudentMark()
        {
            ListStudent.Sort((st1, st2) => st2.mark_AVG.CompareTo(st1.mark_AVG));
            Console.WriteLine("Danh sach sinh vien sau khi sap xep theo diem trung binh: ");
            DisplayListStudent();
        }
        public void DisplayListStudent()
        {
            if (ListStudent.Count > 0)
            {
                foreach (Student st in ListStudent)
                {
                    st.OutputStudent();
                }
            }
            else
            {
                Console.WriteLine("Danh sach hoc sinh trong");
            }
            }
        }
    }
    

