using System;
using System.Collections.Generic;

namespace FirstNameLastName
{
    class FirstNameLastName
    {
        static void Main(string[] args)
        {
            List<Name> names = new List<Name> {
                new Name {FirstName = "John", LastName = "Smith"},
                new Name {FirstName = "Jane", LastName = "Smith"},
                new Name {FirstName = "Robert", LastName = "Brown"},
                new Name {FirstName = "Sam", LastName = "Jones"},
                new Name {FirstName = "Phil", LastName = "Roberts"},
                new Name {FirstName = "Sara", LastName = "Johnson"},
                new Name {FirstName = "Jane", LastName = "Jones"},
                new Name {FirstName = "Chris", LastName = "Walker"},
                new Name {FirstName = "Sarah", LastName = "Stone"}
            };

            try
            {
                SortList(names);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error running Sort: {0}", ex.Message);
            }
        }

        private static void SortList(List<Name> names)
        {

            for (int i = 0; i < names.Count - 1; i++) {
                for (int j = i + 1; j < names.Count; j++)
                {
                    int compare = String.Compare(names[i].FirstName, names[j].FirstName, true);
                    if ( compare > 0)
                    {
                        var name = names[i];
                        names[i] = names[j];
                        names[j] = name;
                    }
                    else if (compare == 0)
                    {
                        compare = String.Compare(names[i].LastName, names[j].LastName, true);
                        if (compare > 0)
                        {
                            var name = names[i];
                            names[i] = names[j];
                            names[j] = name;
                        }
                    }
                }
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
