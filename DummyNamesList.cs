using System;
using System.Collections.Generic;

namespace DummyNames
{
    class DummyNames
    {
        static void Main(string[] args)
        {
             List<Name> lastNames = new List<Name>
             {
                 new Name{FirstName = "", LastName = "Smith"},
                 new Name{FirstName = "", LastName = "Jones"},
                 new Name{FirstName = "", LastName = "Roberts"},
                 new Name{FirstName = "", LastName = "Brown"},
                 new Name{FirstName = "", LastName = "Walker"},
                 new Name{FirstName = "", LastName = "Johnson"},
                 new Name{FirstName = "", LastName = "Stone"},
                 new Name{FirstName = "", LastName = "Holmes"},
                 new Name{FirstName = "", LastName = "Anderson"},
                 new Name{FirstName = "", LastName = "Peterson"}

             }; 

            List<Name> firstNames = new List<Name>
            {
                new Name{FirstName = "John", LastName = ""},
                 new Name{FirstName = "Jane", LastName = ""},
                 new Name{FirstName = "Robert", LastName = ""},
                 new Name{FirstName = "Sam", LastName = ""},
                 new Name{FirstName = "Phil", LastName = ""},
                 new Name{FirstName = "Sara", LastName = ""},
                 new Name{FirstName = "Chris", LastName = ""},
                 new Name{FirstName = "Mike", LastName = ""},
                 new Name{FirstName = "Andrea", LastName = ""},
                 new Name{FirstName = "Randy", LastName = ""}
            }; 

            try
            {
                CompileList(lastNames, firstNames);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error compiling List: {0}", ex.Message);
            }
        }

        private static void CompileList(List<Name> lastNames, List<Name> firstNames)
        {
            List<Name> names = new List<Name>();

            for (int i = 0; i < 10; i++)
            {
                int j = ((2^16 + i) * DateTime.Now.Millisecond % 10);
                int k = ((2^16 - i) * DateTime.Now.Millisecond % 10);
                var name = new Name() {FirstName = firstNames[j].FirstName, LastName = lastNames[k].LastName};
                names.Add(name);
            }

            WriteList(names);
        }

        private static void WriteList(List<Name> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }
        }
    }

    public class Name
    {
        public string FirstName;
        public string LastName;
    }
}

