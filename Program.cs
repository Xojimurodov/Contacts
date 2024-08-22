class Program 
{


    public static void Main()
    {
        List<Contact> contacts = new();

        Contact n1 = new Contact();
        n1.phoneNumber = "+998-95-343-35-00";
        n1.Name = ContactNames.Company;

        Contact n2 = new Contact();
        n2.phoneNumber = "+998-33-500-24-52";
        n2.Name = ContactNames.Company;

        Contact n3 = new Contact();
        n3.phoneNumber = "+998-97-707-69-15";
        n3.Name = ContactNames.Friends;

        Contact n4 = new Contact();
        n4.phoneNumber = "+998-33-744-34-44";
        n4.Name = ContactNames.Family;

        Contact n5 = new Contact();
        n5.phoneNumber = "+998-80-256-35-74";
        n5.Name = ContactNames.Friends;

        contacts.Add(n1);
        contacts.Add(n2);
        contacts.Add(n3);
        contacts.Add(n4);
        contacts.Add(n5);

        Console.WriteLine("       Welcome");
        Console.WriteLine("+====Contacts====+");
        Console.WriteLine("|1.Company       |");
        Console.WriteLine("|2.Family        |");
        Console.WriteLine("|3.Friends       |");
        Console.WriteLine("+================+");
        Console.Write("Enter your chouse: ");
        int menu = int.Parse(Console.ReadLine() !);

        switch(menu)
        {
            case 1:
            void ContactCompany(List<Contact> contacts)
            {
                foreach(var contact in contacts)
                {
                    if(contact.Name == ContactNames.Company)
                    {
                        Console.WriteLine(contact.phoneNumber);
                    }
                }

            }
            ContactCompany(contacts);
            break;

            case 2:
            void ContactFamily(List<Contact> contacts)
            {
                foreach(var contact in contacts)
                {
                    if(contact.Name == ContactNames.Family)
                    {
                        Console.WriteLine(contact.phoneNumber);
                    }
                }

            }
            ContactFamily(contacts);
            break;

            case 3:
            void ContactFriends(List<Contact> contacts)
            {
                foreach(var contact in contacts)
                {
                    if(contact.Name == ContactNames.Friends)
                    {
                        Console.WriteLine(contact.phoneNumber);
                    }
                }

            }
            ContactFriends(contacts);
            break;

            default: Console.WriteLine("Error"); break;
        }
            

    }
  
        
}