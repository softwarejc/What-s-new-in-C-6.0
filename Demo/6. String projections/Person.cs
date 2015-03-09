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
                throw new NullReferenceException(nameof(name));
            }

            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Id { get;} = GetNewId();
        public int Age { get; set; } = 18;

        public event EventHandler Call;
        protected virtual void OnCall() => Call?.Invoke(this, EventArgs.Empty);
        public int GetYearOfBirth() => DateTime.Now.Year - Age;

        private static int lastId;
        private static int GetNewId()
        {
            lastId++;

            // String projections are an improvement of “string.Format”
            Debug.WriteLine(string.Format("New Id = \{lastId}"));
            return lastId;
        }
    }
}