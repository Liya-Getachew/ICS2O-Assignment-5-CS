// Created by: liya getachew
// Created on: Dec 22 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        string text;
        string reversedText = "";

        Console.WriteLine("Type anything here and watch it get reversed.");
        Console.WriteLine("");

        Console.Write("Let's try: ");
        text = Console.ReadLine();
        Console.WriteLine("");

        for (int counter = text.Length - 1; counter >= 0; counter--)
        {
            // text.Length - 1 takes away the last character of the user's input
            reversedText += text[counter]; // refers to the character at the end of the input
        }
        Console.WriteLine(text + " = " + reversedText + "\nCool!");

        Console.WriteLine("\nDone.");
    }
}