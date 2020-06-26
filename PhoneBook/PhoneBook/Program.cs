using System;
using System.Collections.Generic;
using System.IO;

class Solution

    /// .... Improvements - Ask user to enter in correct format
    ///                   - Include Table to Display phoneBook 
{
    static void Main(String[] args)
    {
        Console.WriteLine("Please enter the number of PhoneBook enteries you wish to add.");
        int loopCount = Convert.ToInt32(Console.ReadLine()); 

        Dictionary<string, long> phoneBook = new Dictionary<string, long>(loopCount);
        //added long as int32 had touble storing 11 digits of numbers
        
        Console.WriteLine(); // 

        for (int i = 0; i < loopCount; i++)
        {
            Console.WriteLine("Please Write You First Name follow by your Phone Number");
            string[] temp = Console.ReadLine().Split(' ');
            //temporary array initialized //

            if (temp[1].Length == 11) //Stores 11 digit strings in form of int for phone number
            {
                phoneBook.Add(temp[0], Convert.ToInt64(temp[1]));
            }

        }

        Console.WriteLine("\nEnter name to get Number Associated to it");

        string nameToSearch = ""; //like initializing int nameToSearch = 0 but with string
        while ((nameToSearch = Console.ReadLine()) != null)
        { //Error1 with nameToSearch b4 bcuz it didnt account for spaces so null errors

            int flagFound = 0;
            if (nameToSearch != "")
            {
                if (phoneBook.ContainsKey(nameToSearch))
                {
                    flagFound = 1;
                }
            }
            if (flagFound == 1)
            {
                Console.WriteLine(nameToSearch + "=" + phoneBook[nameToSearch] + "\n");
            }
            else
            {
                Console.WriteLine("Not found\n");
            }
        }

    }
}