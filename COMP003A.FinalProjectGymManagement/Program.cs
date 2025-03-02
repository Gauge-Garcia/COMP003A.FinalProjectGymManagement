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
    }
}
