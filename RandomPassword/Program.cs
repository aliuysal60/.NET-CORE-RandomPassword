﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CreateRandomPassword());
        Console.WriteLine(CreateRandomPassword(10));
        Console.WriteLine(CreateRandomPassword(30));

        Console.WriteLine(CreateRandomPasswordWithRandomLength());

        Console.ReadKey();
    }


    // Default size of random password is 15  
    private static string CreateRandomPassword(int length = 15)
    {
        // Create a string of characters, numbers, special characters that allowed in the password  
        string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
        Random random = new Random();

        // Select one random character at a time from the string  
        // and create an array of chars  
        char[] chars = new char[length];
        for (int i = 0; i < length; i++)
        {
            chars[i] = validChars[random.Next(0, validChars.Length)];
        }
        return new string(chars);
    }

    private static string CreateRandomPasswordWithRandomLength()
    {
        // Create a string of characters, numbers, special characters that allowed in the password  
        string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
        Random random = new Random();

        // Minimum size 8. Max size is number of all allowed chars.  
        int size = random.Next(8, validChars.Length);

        // Select one random character at a time from the string  
        // and create an array of chars  
        char[] chars = new char[size];
        for (int i = 0; i < size; i++)
        {
            chars[i] = validChars[random.Next(0, validChars.Length)];
        }
        return new string(chars);
    }
}