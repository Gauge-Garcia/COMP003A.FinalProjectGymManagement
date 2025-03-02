namespace COMP003A.FinalProjectGymManagement
{
    internal class Program
    {
        /// <summary>
        /// This is where the function runs
        /// </summary>
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>();
            int choice = 0;
            string memberId;
            int memberType = 0;

            while (choice != 5)
            {
                //Validation on our choice Selections
                try
                {
                    //Membership Menu
                    Console.WriteLine("\n Welcome to the Gym Membership Management System!\n Please choose what you would like to execute:");
                    Console.WriteLine(" 1. Add Member.");
                    Console.WriteLine(" 2. Remove Member.");
                    Console.WriteLine(" 3. Display Members");
                    Console.WriteLine(" 4. Exit.");

                    //Choose what to do
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        //Runs Add Member Method
                        case 1:
                            {
                                AddMember(members, memberType);
                                break;
                            }

                        //Identifies Member and Run Remove Member Method
                        case 2:
                            {
                                Console.WriteLine("Please enter the Id of the member you wish to remove:");
                                memberId = (Console.ReadLine());
                                RemoveMember(members, memberId);
                                break;
                            }

                        // Runs Display Member Method
                        case 3:
                            {
                                DisplayMembers(members);
                                break;
                            }

                        //Exits the Program
                        case 4:
                            {
                                choice = 5;
                                Console.WriteLine("GoodBye!!!");
                                break;
                            }

                        //Invalidates choice and sets choice to zero to rerun the function.
                        default:
                            {
                                Console.WriteLine("Invalid input, Please Try Again.");
                                choice = 0;
                                break;
                            }
                    }
                }
                    //Catches Format Error
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Input!");
                    }
            }
        }

        /// <summary>
        /// This is the Add Member method, it adds a member with a specific member type.
        /// </summary>
        /// <param name="members"></param>
        /// <param name="memberType"></param>
        static void AddMember(List<Member> members, int memberType)
        {
            //Validates Member Information
            try
            {
                Console.Write($"Enter the id of the member: ");
                string id = Console.ReadLine();

                Console.Write($"Enter the first name of the member: ");
                string firstName = Console.ReadLine();

                Console.Write($"Enter the middle name of the member: ");
                string middleName = Console.ReadLine();

                Console.Write($"Enter the last name of the member: ");
                string lastName = Console.ReadLine();

                Console.Write($"Enter the age of the member: ");
                int age = int.Parse(Console.ReadLine());

                //Chooses what kind of member is being added
                Console.Write($"Enter the type of the member: (1. Powerlifter, 2. Bodybuilder, or 3. Casual) ");
                memberType = int.Parse(Console.ReadLine());

                //Adds Specific member
                if (memberType == 1)
                {
                    members.Add(new Powerlifter(id, firstName, middleName, lastName, age));
                    Console.WriteLine(" Powerlifter added successfully!");
                }
                else if (memberType == 2)
                {
                    members.Add(new BodyBuilder(id, firstName, middleName, lastName, age));
                    Console.WriteLine(" Bodybuilder added successfully!");
                }
                else if (memberType == 3)
                {
                    members.Add(new Casual(id, firstName, middleName, lastName, age));
                    Console.WriteLine("Gym Casual added successfully!");
                }
                else
                {
                    Console.WriteLine("Member Type not recognized, please try again.");
                }
            }
            //Catches Parameter Error
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            //Catches Format Error
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input!");
            }
        }

        /// <summary>
        /// This is the Remove Member Method. It identifies a member by their id and removes them
        /// </summary>
        /// <param name="members"></param>
        /// <param name="_memberId"></param>
        static void RemoveMember(List<Member> members, string _memberId)
        {
            //Finds Member based on their ID
            Member member = members.Find(m => m.Id == _memberId);

            //Checks that the Member is found
            if (member == null)
            {
                Console.WriteLine("Member not found");
            }
            else
            {
                //Removes Meber from the List
                members.Remove(member);
                Console.WriteLine("Member Removed!");
            }
        }

        /// <summary>
        /// This Is the Display Members Method. It displays the Member info using methods from the member class
        /// </summary>
        /// <param name="members"></param>
        static void DisplayMembers(List<Member> members)
        {
            Console.WriteLine("\nDisplaying all members:\n");
            //Loop to display Each member
            foreach (Member member in members)
            {
                //Display using display function derived in member class.
                member.DisplayInfo();
            }
        }
    }
}
