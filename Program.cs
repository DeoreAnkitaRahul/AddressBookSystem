namespace AddressBookSystem

{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Address Book System");

            CreateContact contact = new CreateContact("Ankita", "Patil", "Nashik", "Deola", 1234, "Maharashtra", 123456789, "ankitapatil.com");
        }

    }
}