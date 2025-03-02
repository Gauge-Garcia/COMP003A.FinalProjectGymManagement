namespace COMP003A.FinalProjectGymManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>();
            int choice = 0;
            string memberId;
            int memberType = 0;

            while (choice != 5)
            {
                try
                {
                    Console.WriteLine("\n Welcome to the Gym Membership Management System!\n Please choose what you would like to execute:");
                    Console.WriteLine(" 1. Add Member.");
                    Console.WriteLine(" 2. Remove Member.");
                    Console.WriteLine(" 3. Display Members");
                    Console.WriteLine(" 4. Exit.");

                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            {
                                AddMember(members, memberType);
                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine("Please enter the Id of the member you wish to remove:");
                                memberId = (Console.ReadLine());
                                RemoveMember(members, memberId);
                                break;
                            }

                        case 3:
                            {
                                DisplayMembers(members);
                                break;
                            }

                        case 4:
                            {
                                choice = 5;
                                Console.WriteLine("GoodBye!!!");
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Invalid input, Please Try Again.");
                                choice = 0;
                                break;
                            }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
        }

        static void AddMember(List<Member> members, int memberType)
        {
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

                Console.Write($"Enter the type of the member: (1. Powerlifter, 2. Bodybuilder, or 3. Casual) ");
                memberType = int.Parse(Console.ReadLine());


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
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input!");
            }
        }

        static void RemoveMember(List<Member> members, string _memberId)
        {
            Member member = members.Find(m => m.Id == _memberId);

            if (member == null)
            {
                Console.WriteLine("Member not found");
            }
            else
            {
                members.Remove(member);
                Console.WriteLine("Member Removed!");
            }
        }
    }
}
