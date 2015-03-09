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
        }

        public string Name { get; set; }
        public int Id { get;} = GetNewId();
        public int Age { get; set; } = 18;

        public event EventHandler Call;



        // The new ?. operator check if the expression is null before evaluating it:
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