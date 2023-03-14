using System;
using _14martt.Models;

namespace _14martt.Services
{
	public class StudentServices : Interfaces.IStudentService
	{
		Student[] Students = { };

		public void Create()
		{

			Student student = new Student();
			Console.WriteLine("Enter Name : ");

			student.Name = Console.ReadLine();

			if (student.Name.Length < 3 || student.Name.Length > 30)
			{
				Console.WriteLine("Enter valid name");
			}
			Console.WriteLine("Enter surname :  ");

			student.Surname = Console.ReadLine();

			if (student.Surname.Length < 3 || student.Surname.Length > 30)
			{
				Console.WriteLine("Enter valid surname");

			}
			Console.WriteLine("Enter groupno : ");
			student.GroupNo = Console.ReadLine();

			if (string.IsNullOrWhiteSpace(student.GroupNo))
				{

				Console.WriteLine("Group can not be empty");
			}
			Array.Resize(ref Students, Students.Length + 1);

			Students[Students.Length - 1] = student;
		}

		public void Show()
		{
			foreach (Student student in Students)
			{
				Console.WriteLine($"Name : {student.Name},Surname : {student.Surname} , GroupNO: {student.GroupNo}");

			}
		}









		
	}
}

