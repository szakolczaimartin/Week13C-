using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        private string name;
        private DateTime birthDate;
        public enum Genders : int { Male, Female };
        public Genders gender;

        public Person(string name, DateTime birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
                
        }

        

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }




        public override string ToString()
        {
            return (String.Format("name: {0}, birth date: {1}", this.name, this.birthDate));
        }


    }
}
