using BaiTapCSharp.demo1;

class Program
{
    static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook();

        phoneBook.InsertPhone("John", "123-456-7890");
        phoneBook.InsertPhone("John", "000-456-7890");
        phoneBook.InsertPhone("Alice", "987-654-3210");
        phoneBook.InsertPhone("Bob", "555-123-4567");
        phoneBook.UpdatePhone("John", "999-888-7777"); // This should update John's phone number

        phoneBook.SearchPhone("John");
        phoneBook.SearchPhone("Alice");
        phoneBook.SearchPhone("Charlie"); // This should indicate that the contact is not found

        phoneBook.Sort();

        phoneBook.RemovePhone("Bob");
    }
}