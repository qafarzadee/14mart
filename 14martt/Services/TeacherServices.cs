using System;
using _14martt.Models;

namespace _14martt.Services
{
	public class TeacherServices : Interfaces.ITeacherService
	{
        Teacher[] Teachers = { };

        public void Create()
        {

            Teacher teacher = new Teacher();
            Console.WriteLine("Enter Name : ");

            Teacher.Name = Console.ReadLine();

            if (teacher.Name.Length < 3 || teacher.Name.Length > 30)
            {
                Console.WriteLine("Enter valid name");
            }
            Console.WriteLine("Enter surname :  ");

            teacher.Surname = Console.ReadLine();

            if (teacher.Surname.Length < 3 || teacher.Surname.Length > 30)
            {
                Console.WriteLine("Enter valid surname");

            }
            Console.WriteLine("Enter groupno : ");
            teacher.GroupNo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(teacher.GroupNo))
            {

                Console.WriteLine("Group can not be empty");
            }
            Array.Resize(ref Teachers, Teachers.Length + 1);

            Teachers [Teachers.Length - 1] = teacher;
        }

        public void Show()
        {
            foreach (Student student in Teachers)
            {
                Console.WriteLine($"Name : {Teacher.Name},Surname : {Teacher.Surname} , GroupNO: {teacher.GroupNo}");

            }






        }
}

