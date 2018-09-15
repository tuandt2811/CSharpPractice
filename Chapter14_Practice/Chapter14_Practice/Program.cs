using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter14_Practice
{
    class Student
    {
        /* Class variable */
        static Int32 NumOfObjects = 0;
        /* Object fields */
        private string full_name;
        private string course;
        private string subject;
        private string university;
        private string email;
        private string phone_number;
        /* Constructors */
        public Student() : this(null)
        {
        }

        public Student(string name) : this (name, null)
        {
        }

        public Student(string name, string course) : this (name, course, null)
        {
        }

        public Student(string name, string course, string subject) : this(name, course, subject, null)
        {
        }

        public Student(string name, string course, string subject, string university) : this (name, course, subject, university, null)
        {
        }

        public Student(string name, string course, string subject, string university, string email) : this(name, course, subject, university, email, null)
        {
        }

        public Student(string name, string course, string subject, string university, string email, string phone)
        {
            this.full_name = name;
            this.course = course;
            this.subject = subject;
            this.university = university;
            this.email = email;
            this.phone_number = phone;
            NumOfObjects++;
        }
        /* Properties*/
        public string FullName
        {
            set { this.full_name = value; }
            get { return this.full_name; }
        }

        public string Course
        {
            set { this.course = value; }
            get { return this.course; }
        }

        public string Subject
        {
            set { this.subject = value; }
            get { return this.subject; }
        }

        public string University
        {
            set { this.university = value; }
            get { return this.university; }
        }

        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }

        public string PhoneNumber
        {
            set { this.phone_number = value; }
            get { return this.phone_number; }
        }
        /* Methords*/
        public void PrintStudentInformation()
        {
            Console.WriteLine("Student name : {0}", this.full_name);
            Console.WriteLine("Course : {0}", this.course);
            Console.WriteLine("Subject : {0}", this.subject);
            Console.WriteLine("University : {0}", this.university);
            Console.WriteLine("E-mail : {0}", this.email);
            Console.WriteLine("Phone number : {0}", this.phone_number);
        }
    }
    class StudentTest
    {
        const int MAX_STUDENTS = 45;
        static Student[] CSharpStudents;
        static int NumOfStudents;
        static Student CSharpStudent
        {
            set { 
                    CSharpStudents[NumOfStudents] = value;
                    NumOfStudents++;
                }

            get {
                    if (NumOfStudents > 0)
                    {
                        NumOfStudents--;
                    }
                    return CSharpStudents[NumOfStudents]; 
                }
        }

        static void OpenClass()
        {
            NumOfStudents = 0;
            CSharpStudents = new Student[MAX_STUDENTS];
        }

        static void Main(string[] args)
        {
            /* int temp = 0;
            OpenClass();
            Student StdNum1 = new Student("Dam Trong Tuan", "C# Programming", "Class and OOP", "Transport and Communication", "asterik2811@gmail.com", "01695171325");
            Student StdNum2 = new Student("Tran Minh Viet", "Java Programming", "Class and OOP", "Telecommunication", "Viet@gmail.com", "01695171325");
            Student StdNum3 = new Student("Nguyen Van Duc", "C Programming", "Basic", "Telecommunication", "Duc@gmail.com", "01695171325");
            StudentTest.CSharpStudent = StdNum1;
            CSharpStudent = StdNum2;
            CSharpStudent = StdNum3;
            temp = NumOfStudents;
            for (int i = 0; i < temp; i++)
            {
                StudentTest.CSharpStudent.PrintStudentInformation();
                Console.WriteLine("");
            }
            Console.WriteLine("End, ahihihi!!!!");*/
            MobilePhone newPhone = new MobilePhone("IPhoneX", "Apple", 12000, "Tuan", new MobilePhone.Energy("Recharge", BatteryType.LiION, 0, 0), new MobilePhone.display(20, 20, "Full HD"));
            string Info = newPhone.ToString();
            Console.WriteLine(Info);
            MobilePhone.DemoInformation();
        }
    }
}
