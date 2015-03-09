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
                // The new “nameOf()” operator allows to remove this “magic” string. 
                // This helps to avoid errors during renaming re-factoring:
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
            Debug.WriteLine(string.Format("New Id = {0}", lastId));
            return lastId;
        }
    }
}