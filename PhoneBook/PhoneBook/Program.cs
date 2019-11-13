using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact contactEric = new Contact("Eric", "1234");
            Contact contactJon = new Contact("Jon", "1235");
            Contact contactEric2 = new Contact("Eric", "1236");
            Contact contactEricClone = new Contact("Eric", "1234");
            Contact contactRob = new Contact("Rob", "1237");
            Contact contactMax = new Contact("Max", "2345");
            Contact contactLee = new Contact("Lee", "2345");
            Contact contactNick = new Contact("Nick", "9876");
            Phonebook phonebook1 = new Phonebook();
            Phonebook phonebook2 = new Phonebook();

            Console.WriteLine("**********");
            Console.WriteLine(contactEric);
            Console.WriteLine(contactJon);
            Console.WriteLine(contactEric2);
            Console.WriteLine(contactRob);
            Console.WriteLine(contactMax);
            Console.WriteLine(contactLee);
            Console.WriteLine("-----------");
            Console.WriteLine(phonebook1);
            Console.WriteLine(phonebook2);

            //test contact equality
            if (contactEric.equals(contactEricClone))
            {
                Console.WriteLine("Both contacts are the same");
            }
            else
            {
                Console.WriteLine("This message should not print");
            }
            if (contactEric.equals(contactEric2))
            {
                Console.WriteLine("This message should not print");
            }
            else
            {
                Console.WriteLine("The two Erics are not the same since they have different phone numbers");
            }
            if (contactLee.equals(contactMax))
            {
                Console.WriteLine("This message should not print");
            }
            else
            {
                Console.WriteLine("Not equal since names are different");
            }

            //test phonebook addContact
            if (!phonebook1.addContact(contactEric))
            {
                Console.WriteLine("This should not print -- cannot add new contact");
            }
            if (!phonebook1.addContact(contactEric))
            {
                Console.WriteLine("This should print -- cannot add duplicate contact");
            }
            if (!phonebook1.addContact(contactEric2))
            {
                Console.WriteLine("This should not print -- cannot add new contact");
            }
            if (!phonebook1.addContact(contactJon))
            {
                Console.WriteLine("This should not print -- cannot add new contact");
            }
            if (!phonebook1.addContact(contactRob))
            {
                Console.WriteLine("This should not print -- cannot add new contact");
            }
            if (!phonebook2.addContact(contactLee))
            {
                Console.WriteLine("This should not print -- cannot add new contact");
            }
            if (!phonebook1.addContact(contactLee))
            {
                Console.WriteLine("This should print -- cannot add contact that already belongs to another phonebook");
            }
            if (!phonebook1.addContact(contactMax))
            {
                Console.WriteLine("This should not print -- cannot add new contact");
            }
            if (!phonebook1.addContact(contactNick))
            {
                Console.WriteLine("This should print -- contact list is full");
            }

            Console.WriteLine("**********");
            Console.WriteLine(contactEric);
            Console.WriteLine(contactJon);
            Console.WriteLine(contactEric2);
            Console.WriteLine(contactRob);
            Console.WriteLine(contactMax);
            Console.WriteLine(contactLee);
            Console.WriteLine("-----------");
            Console.WriteLine(phonebook1);
            Console.WriteLine(phonebook2);

            //test PhoneBook deleteContact and searchContact
            Console.WriteLine("Searched for Eric: " + phonebook1.searchContact("Eric"));
            if (phonebook1.deleteContact(contactLee))
            {
                Console.WriteLine("Error: Cannot delete contact that is not in phonebook");
            }
            else
            {
                Console.WriteLine("This should print as you cannot delete contact that is not in phonebook");
            }
            if (phonebook1.deleteContact(contactEric2))
            {
                Console.WriteLine("Deleted a contact");
            }
            if (phonebook1.deleteContact(contactRob))
            {
                Console.WriteLine("Deleted a contact");
            }

            Console.WriteLine("**********");
            Console.WriteLine(contactEric);
            Console.WriteLine(contactJon);
            Console.WriteLine(contactEric2);
            Console.WriteLine(contactRob);
            Console.WriteLine(contactMax);
            Console.WriteLine(contactLee);
            Console.WriteLine("-----------");
            Console.WriteLine(phonebook1);
            Console.WriteLine(phonebook2);

            //test Phonebook searchContact
            Console.WriteLine("Searched for Eric: " + phonebook1.searchContact("Eric"));
            Console.WriteLine("Searched for Rob: " + phonebook1.searchContact("Rob"));
            Console.WriteLine("Searched for eric: " + phonebook1.searchContact("eric"));
        }
    }
    class Contact
    {
        String name;
        String phoneNumber;
        Phonebook PhoneBook;

        public Contact()
        {
            name = " ";
            phoneNumber = " ";
            PhoneBook = new Phonebook();
        }

        public Contact(String nam, String phoneNum)
        {
            name = nam;
            phoneNumber = phoneNum;
            PhoneBook = new Phonebook();
        }

        public Contact(String na, String phoneNu, Phonebook phone)
        {
            name = na;
            phoneNumber = phoneNu;
            PhoneBook = phone;
        }

        public String getName()
        {
            return name;
        }

        public String getPhoneNumber()
        {
            return phoneNumber;
        }

        public Boolean equals(Contact k)
        {
            if (k.getName() == this.getName() && k.getPhoneNumber() == this.getPhoneNumber())
            {
                return true;
            }
            return false;
        }
        public String toString()
        {
            String ans = null;
            ans = name + phoneNumber;
            return ans;
        }
    }
    class Phonebook
    {
        private Contact[] contacts;
        private int numberOfItems;

        public Phonebook()
        {
            contacts = new Contact[5];
            numberOfItems = 0;
        }

        public Boolean addContact(Contact c)
        {
            /*
             * if contacts has less than 5 in it now
             * 	and c is not already in this phone book
             *  and c does not belong to any other phone book
             *  
             *  then add c to this phone book, increase numberOfItems by 1
             *  return true
             *  
             *  else return false
             */

            if (numberOfItems < 5)
            {
                for (int i = 0; i < numberOfItems; i++)
                {
                    if (contacts[i].equals(c))
                    {
                        return false;
                    }
                }
                contacts[numberOfItems] = c;
                numberOfItems++;
            }
            return true;
        }
        public Boolean deleteContact(Contact a)
        {
            for (int j = 0; j < numberOfItems; j++)
            {
                if (contacts[j].equals(a))
                {
                    for (int h = j; h < numberOfItems - 1; h++)
                    {
                        contacts[h] = contacts[h + 1];
                    }
                    contacts[numberOfItems] = null;
                    numberOfItems -= 1;
                    return true;
                }
            }
            return false;
        }
        public Contact searchContact(String Name)
        {
            String temp = " ";
            for (int l = 0; l < numberOfItems; l++)
            {
                temp = contacts[l].getName();
                if (string.Equals(temp,Name))
                {
                    return contacts[l];
                }
            }
            return null;
        }
        public String toString()
        {
            String ans = null;
            for (int m = 0; m < numberOfItems; m++)
            {
                ans = ans + contacts[m].getName() + contacts[m].getPhoneNumber();
            }
            return ans;
        }
    }
}
