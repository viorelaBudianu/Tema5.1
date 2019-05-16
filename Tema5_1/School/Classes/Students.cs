using System;

namespace School
{
    public class Students : Person,IComment
    {
        // Fields
        private string studentClassNumber;
        public string comment { get; set; }

        // Constructor
        public Students(string firstName, string lastName, string studentClassNumber)
            : base(firstName, lastName)
        {
            this.studentClassNumber = studentClassNumber;
        }

        // Properties
        public Students StudentClassNumber
        {
            get { return this.StudentClassNumber; }
            set
            {
                if (value !=null)
                {
                    throw new ArgumentNullException("Student class number cannot be negative or zero!");
                }
                else
                {
                    this.StudentClassNumber = value;
                }
            }
        }
    }
}
