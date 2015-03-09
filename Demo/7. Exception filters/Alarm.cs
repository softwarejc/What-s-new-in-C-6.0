using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Demo
{
    public static class MyAlarm
    {
        public static void RunAlarm()
        {
            try
            {
                // Run my phone alarm every morning, 
                // if something was wrong run the backup alarm 
                RunPhoneAlarm();
            }
            catch (Exception)
            {
                // Run backup alarm
                RunBackupAlarm();
            }
        }





        /// <summary>
        /// Run the phone alarm.
        /// If there is a problem with the phone and today is not Sunday -> throw an exception.
        /// </summary>
        public static void RunPhoneAlarm()
        {
            try
            {
                // Imagine this is implemented...
                // phone.Beep();
            }

            // New C# 6.0: catch conditions
            catch (Exception) if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                // If my phone is broken on Sunday, 
                // I don't wake up early to write code
                Debug.WriteLine("Phone's alarm error. ");
            }
        }





















        private static Task CreateRemainder(string v)
        {
            throw new NotImplementedException();
        }

        private static void RunBackupAlarm()
        {
            throw new NotImplementedException();
        }
    }
}