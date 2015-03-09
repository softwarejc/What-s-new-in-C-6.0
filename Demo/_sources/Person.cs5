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
        public int Id { get; private set; }
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