﻿using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book System");
            Console.WriteLine("Welcome to the Address Book System");
            Console.ReadLine();
            NewAddressBook.GetCustomer();
            NewAddressBook.ListingPeople();
            NewAddressBook.RemovePeople();
        }
    }
}