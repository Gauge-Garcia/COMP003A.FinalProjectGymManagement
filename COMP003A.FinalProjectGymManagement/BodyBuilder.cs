using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProjectGymManagement
{
    /// <summary>
    /// This is the Bodybuilder Class. We will build our Bodybuilder using the Base member class!
    /// </summary>
    public class BodyBuilder : Member
    {
        public BodyBuilder(string id, string firstName, string lastName, string middleName, int age) : base(id, firstName, lastName, middleName, age) { }
        
        /// <summary>
        /// This is the implementation of the PrintFullName method initialized in the Member Class
        /// </summary>
        public override void PrintFullName()
        {
            //Checks for middle name and designs output based on if middle name is applied or not.
            if (string.IsNullOrEmpty(MiddleName))
            {
                Console.WriteLine($"Member Name: {FirstName} {LastName}");
            }
            else
            {
                Console.WriteLine($"Member Name: {FirstName} {MiddleName} {LastName}");

            }
        }

        /// <summary>
        /// This is the implementation of the DiplayInfo method initialized in the Member Class
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {Id}");
            PrintFullName();
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine("Memmber type: Bodybuiler (Lifts to build physique)\n");
        }
    }
}
