using System;

namespace CAB301Ass1
{
    class Program
    {
        static void Main(string[] args)
        {

            MemberCollection aCollection = new MemberCollection(7);

            Member newmember1 = new Member("Bill", "Gates", "12345678", "222"); //Phone: Invalid; Pin: Invalid
            Member newmember2 = new Member("Melinda", "Gates", "0234567891", "98764"); //Phone: Valid; Pin: Valid
            Member newmember3 = new Member("Lori", "Harvey", "0234567890", "23456789"); // Phone Valid; Pin: valid
            Member newmember4 = new Member("Elon", "Musk", "098564321654", "222"); // Phone: Invalid; Pin: Invalid
            Member newmember5 = new Member("Jeff", "Bezos", "2234567780", "266666"); //Phone Invalid; Pin: InValid
            Member newmember6 = new Member("Anna", "Bezos", "023456550", "2666"); //Phone: Invalid; Pin: InValid
            Member newmember7 = new Member("Anna", "Bezos", "023456550", "2666"); //Phone: Invalid; Pin: Valid
            Member newmember8 = new Member("Rona", "Rosal", "023456550", "2666"); //Phone: Invalid; Pin: Valid

            Console.WriteLine("-- Adding members to the list.--");
            aCollection.Add(newmember1);
            aCollection.Add(newmember2);
            aCollection.Add(newmember3);
            aCollection.Add(newmember4);
            aCollection.Add(newmember5);
            aCollection.Add(newmember6);
            
            Console.WriteLine(aCollection.ToString());

            Console.WriteLine("-- Deleting members to the list.-- ");
            aCollection.Delete(newmember3); // Delete Lori Harvey in the list; SUCCESS!
            Console.WriteLine(aCollection.ToString());

            Console.WriteLine("-- Searching Items in the list --\n");
            Console.WriteLine(aCollection.Search(newmember3)); // False
            

            Console.WriteLine("-- Attempt to add duplicate in the list --\n");
            aCollection.Add(newmember7);
            aCollection.Add(newmember8);
            Console.WriteLine(aCollection.ToString());

            Console.WriteLine("-- Verifying if Contact Number is valid.-- \n");
            Console.WriteLine(IMember.IsValidContactNumber(newmember1.ContactNumber));
            Console.WriteLine(IMember.IsValidContactNumber(newmember2.ContactNumber));
            Console.WriteLine(IMember.IsValidContactNumber(newmember3.ContactNumber));
            Console.WriteLine(IMember.IsValidContactNumber(newmember4.ContactNumber));
            Console.WriteLine(IMember.IsValidContactNumber(newmember5.ContactNumber));
            Console.WriteLine(IMember.IsValidContactNumber(newmember6.ContactNumber));
            Console.WriteLine("\n\n");


            Console.WriteLine(" -- Verifying if Pin is valid.-- \n");
            Console.WriteLine(IMember.IsValidPin(newmember1.Pin));
            Console.WriteLine(IMember.IsValidPin(newmember2.Pin));
            Console.WriteLine(IMember.IsValidPin(newmember3.Pin));
            Console.WriteLine(IMember.IsValidPin(newmember4.Pin));
            Console.WriteLine(IMember.IsValidPin(newmember5.Pin));
            Console.WriteLine(IMember.IsValidPin(newmember6.Pin));

        }


    }
}