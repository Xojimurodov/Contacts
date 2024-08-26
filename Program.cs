class Program
{
    static int id = 0;
    public static void Main()
    {
        List<Contact> contacts = new();
        
        while(true)
        {
            Console.WriteLine("+----------Menu---------+");
            Console.WriteLine("|1. Contacts            |");
            Console.WriteLine("|2. Add Contact         |");
            Console.WriteLine("|3. Refresh             |");
            Console.WriteLine("|4. Delete Contact      |");
            Console.WriteLine("|5. Exit                |");
            Console.WriteLine("+-----------------------+");

            Console.Write("Enter your choose: ");
            
            int menuOption = int.Parse(Console.ReadLine()!);

            if (menuOption == 5)
                break;

            switch(menuOption)
            {
                case 1:
                    ShowContacts(contacts);
                break;
                case 2:
                    var contact = AddNewContact();
                    contacts.Add(contact);
                break;
                case 3:
                    UpdateContact(contacts);
                break;
                case 4:
                    DeleteContact(contacts);
                break;
            }
        }
    }

    public static void DeleteContact(List<Contact> contacts)
    {
        Console.Write("Enter the ID contact: ");
        int contactId = int.Parse(Console.ReadLine()!);

        for(int i = 0; i < contacts.Count(); i++)
        {
            if(contacts[i].Id == contactId)
            {
                contacts.Remove(contacts[i]);
                break;
            }
        }
    }

    public static void UpdateContact(List<Contact> contacts)
    {
        Console.Write("Enter the ID contact: ");
        int contactId = int.Parse(Console.ReadLine()!);
        

        Console.WriteLine("---Kontakt turini tanglang---");
        Console.WriteLine("1. Friends");
        Console.WriteLine("2. Collegue");
        Console.WriteLine("3. Family");

        int contactType = int.Parse(Console.ReadLine()!);

        Console.Write("Name contact: ");
        string name = Console.ReadLine()!;

        Console.Write("Address contact: ");
        string address = Console.ReadLine()!;

        Console.Write("Number Contact: ");
        string number = Console.ReadLine()!;

        Contact contact = new Contact
        {
            Name = name,
            Address = address,
            PhoneNumber = number,
            ContactType = (ContactType)contactType
        };

        for(int i = 0; i < contacts.Count(); i++)
        {
            if(contacts[i].Id == contactId)
            {
                contacts[i] = contact;
                break;
            }
        }
    }

    public static Contact AddNewContact()
    {
        Console.WriteLine("+----===Contact===----+");
        Console.WriteLine("|1. Friends           |");
        Console.WriteLine("|2. Collegue          |");
        Console.WriteLine("|3. Family            |");
        Console.WriteLine("+---------------------+");
        Console.Write("Enter your choose: ");

        int option = int.Parse(Console.ReadLine()!);

        Console.Write("Name contact: ");
        string name = Console.ReadLine()!;

        Console.Write("Address contact: ");
        string address = Console.ReadLine()!;

        Console.Write("Number contact: ");
        string number = Console.ReadLine()!;

        //object initializer syntax
        var contact = new Contact
        {
            Id = ++id,
            Name = name,
            Address = address,
            PhoneNumber = number,
            ContactType = (ContactType)option
        };

        return contact;
    }

    public static void ShowContacts(List<Contact> contacts)
    {
        Console.WriteLine("+----===Contact===----+");
        Console.WriteLine("|1. Friends           |");
        Console.WriteLine("|2. Collegue          |");
        Console.WriteLine("|3. Family            |");
        Console.WriteLine("+---------------------+");
        Console.Write("Enter your choose: ");

        int option = int.Parse(Console.ReadLine()!);

        switch((ContactType)option)
        {
            case ContactType.Friend:
                PrintContact(contacts, ContactType.Friend);
            break;
            case ContactType.Collegue:
                PrintContact(contacts, ContactType.Collegue);
            break;
            case ContactType.Family:
                PrintContact(contacts, ContactType.Family);
            break;
        }
    }

    public static void PrintContact(List<Contact> contacts, ContactType contactType)
    {
        int a = 1;
        foreach(var contact in contacts)
        {
            if(contact.ContactType == contactType)
            {
                Console.WriteLine("================================================================================================");
                Console.WriteLine($"ID {a}) Name: {contact.Name}, Address: {contact.Address}, PhoneNumnber: {contact.PhoneNumber}");
                Console.WriteLine("================================================================================================");
            }
        }
    }
}