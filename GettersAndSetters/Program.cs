using System;

namespace GettersAndSetters
{
    class Program
    {
        class person
        {
             string name;
             int age;
             string gender;
             string idcode;
            public person(string _name, string _gender, int _age, string _idcode)
            {
                name = _name;
                Gender = _gender;
                age = _age;
                IdCode = _idcode;
            }
            public string Name
            {
                get { return name; }
            }
            public string Gender
            {
                get { return gender; }
                set
                {
                    if(value == "Male" || value == "Female")
                    {
                        gender = value;
                    }
                    else
                    {
                        gender = "Undefined unicorn";
                    }
                }
            }
            public string IdCode
            {
                get { return idcode; }
                set
                {
                    if(value.Length == 11)
                    {
                        idcode = value;
                    }
                    else
                    {
                        idcode = "Undefined";
                    }
                }
            }
            public void ChanceName(string newName)
            {
                name = newName;
            }
            public void ChanceIdCode(string newCode)
            {
                IdCode = newCode;
            }
        }
        static void Main(string[] args)
        {
            person newPerson = new person("Harry Potter", "gmale", 35, "38112182225");
            Console.WriteLine(newPerson.Name);
            //Console.WriteLine(newPerson.age);
            Console.WriteLine(newPerson.Gender);
            Console.WriteLine(newPerson.IdCode);
            newPerson.ChanceName("Harry Plotter");
            newPerson.ChanceIdCode("12345");
            //newPerson.name = "Harry Plotter";
            //newPerson.gender = "Female";
            //newPerson.age = 21;
            //Console.WriteLine(newPerson.Name);
            //Console.WriteLine(newPerson.age);
            //Console.WriteLine(newPerson.gender);
        }
    }
}
