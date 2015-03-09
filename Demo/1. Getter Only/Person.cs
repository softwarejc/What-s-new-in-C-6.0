using System;
using System.Diagnostics;

namespace Demo
{
    public class Person
    {
        public Person(string name, int age)
        {
            if (name == null)
            {
                throw new NullReferenceException("name");
            }

            Name = name;
            Age = age;
            Id = GetNewId();
        }

        public string Name { get; set; }



        // We can remove “private set” from read-only properties, 
        // properties with only a “setter” can be initialized only 
        // from the constructor or with auto-initialization.
        public int Id { get;}




        public int Age { get; set; }

        public event EventHandler Call;

        protected virtual void OnCall()
        {
            EventHandler handler = Call;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        public int GetYearOfBirth()
        {
            return DateTime.Now.Year - Age;
        }

        private static int lastId;
        private static int GetNewId()
        {
            lastId++;
            Debug.WriteLine(string.Format("New Id = {0}", lastId));
            return lastId;
        }
    }
}