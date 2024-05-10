using System;
using System.Collections.Generic;
using System.IO; // Importing the System.IO namespace for file handling

// This is the beginning of the Exercise29 class
public class Exercise29
{
    // This is the main method where the program execution starts
    public static void Main()
    {
        // Creating a FileInfo object representing a file at the specified path
        FileInfo f = new FileInfo("D:\\SUMMER2024-Ki5\\PRN212\\BaiTapTuan1\\Bai29\\abc.txt");

        // Displaying the size of the file in bytes using FileInfo's Length property
        Console.WriteLine("\nSize of a file: " + f.Length.ToString());
    }
}
