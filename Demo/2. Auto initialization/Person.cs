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



        // Using auto initialization we can auto initialize 
        // the Id property calling a method. It is also possible 
        // to set a default value to editable properties:
        public int Id { get;} = GetNewId();
        public int Age { get; set; } = 18;



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