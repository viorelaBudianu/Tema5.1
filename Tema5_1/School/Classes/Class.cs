using System;
using System.Collections.Generic;

namespace School
{
    public class Class : IComment
    {
        // Fields
        private List<Students> students;
        private List<Teachers> teachers;
        private string classID;
        public string comment { get; set; }

        // Constructor
        public Class(List<Students> students, List<Teachers> teachers, string classID)
        {
            this.students = students;
            this.teachers = teachers;
            this.classID = classID;
            
        }

        // Properties
        public List<Students> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public List<Teachers> Teachers
        {
            get { return this.teachers; }
            set { this.teachers = value; }
        }

     

        public string ClassID
        {
            get { return this.classID; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Class ID cannot be null!");
                }
                else
                {
                    this.classID = value;
                }
            }
        }

        // Methods
        
        public void DisplayStudentsAndTeachersInClass()
        {
            // Print Students
            Console.WriteLine("Students");
            foreach (var element in Students)
            {
                Console.WriteLine("Full name: {0}, Class: {1}, ClassID: {2}", element.FirstName + " " + element.LastName, element.StudentClassNumber, ClassID);
            }
            Console.WriteLine();

            // Print information about teachers
            Console.WriteLine("Teachers .....");
            foreach (var element in Teachers)
            {
                Console.WriteLine("Full name: {0} \n\nDisciplines: ", element.FirstName + " " + element.LastName);

                foreach (var item in element.Discipline)
                {
                    Console.WriteLine("Discipline name: " + item.DisciplineName);
                    Console.WriteLine("Number of lectures: " + item.NumberOfLectures);
                    Console.WriteLine("Number of exercises: " + item.NumberOfExercises);
                    Console.WriteLine();
                }
            }

            
        }
    }
}
