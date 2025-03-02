using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProjectGymManagement
{
    /// <summary>
    /// This is the Member Class. This is where we build the different outputs of our soon to member input by the user
    /// </summary>
    public abstract class Member
    {
        private string _id;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private int _age;

        /// <summary>
        /// Member ID value
        /// </summary>
        public string Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Member firstname. This method sets a string value for the first name and ensures that it is not null or blank.
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First Name is required");
                }
            }
        }

        /// <summary>
        /// Member LastName. This method sets a string value for the last name and ensures that it is not null or blank.
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last Name is required");
                }
            }
        }
        /// <summary>
        /// Member MiddleName. This method sets a string value for the middle name and ensures that it is not null.
        /// </summary>
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (value == null)
                {
                    _middleName = " ";
                }
                _middleName = value;
            }
        }
        /// <summary>
        /// Member Age. This method sets a integer value for the age and ensures that it is not negative.
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                if (_age < 0)
                {
                    throw new ArgumentException("You cannot have a negative age");
                }
                _age = value;
            }
        }

        /// <summary>
        /// This Public Member constructor sets each function equal to a variable in order to ensure our checks in the Member. 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        public Member(string id, string firstName, string middleName, string lastName, int age)
        {
            _id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Age = age;
        }


        /// <summary>
        /// The PrintFullName will print the members full name.
        /// </summary>
        public abstract void PrintFullName(); 

        /// <summary>
        /// The DisplayInfo function will display the members info.
        /// </summary>
        public abstract void DisplayInfo();
    }
}
