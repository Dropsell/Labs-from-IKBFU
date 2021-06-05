using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class People
    {
        public People()
        {
            Name = "No";
            Age = 0;
        }
        private int age;
        private string University;
        private programEducation programStudent;

        public string Name
        {
            get; set;
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value >= 0)
                {
                    age = value;
                }
            }
        }

        public void Entrance(string universityIn, programEducation programmIn)
        {
            University = universityIn;
            programStudent = programmIn;
        }
        public string GetUnversity()
        {
            return University;
        }
        public programEducation GetProgram()
        {
            return programStudent;
        }



    }
}
