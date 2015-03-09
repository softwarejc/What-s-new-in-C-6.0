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

        protected virtual void OnCall()
        {
            EventHandler handler = Call;
            if (handler != null) handler(this, EventArgs.Empty);
        }


        // It is common to have a lot of single line calculated properties 
        // or methods on our code.In lambda expressions it was already 
        // possible to write only the value to return. 
        // Now this is also possible in normal methods:
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