﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_1day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //"string is a sequence of characters inside of double loops"

            /*    Console.WriteLine("this is a tab \t.");
                Console.WriteLine("this is a  \"quote\".");
                Console.WriteLine("this is a backslash \\");
                Console.WriteLine("this is a  \n new line. ");
             Console.WriteLine("this is a  bell \a ");
             */
            //// this is a format of (c)
            //string dogName = "Harley";
            //string firstName = "Joderrick";
            //Console.WriteLine("My name is {0} and my dog is {1}.", firstName, dogName);

            //string bestFriends = firstName + " " + dogName;
            //Console.WriteLine(bestFriends);

            //Console.WriteLine(firstName.Length);

            //Console.WriteLine(bestFriends.Length);


            // finding the Length



            //Console.WriteLine("what is your First Name");
            //string firstName = Console.ReadLine();

            //Console.WriteLine("what is your Last Name");
            //string lastName = Console.ReadLine();


            //int firstN = firstName.Length;
            //int lastN = lastName.Length;

            //if (firstN > lastN)
            //{

            //    Console.WriteLine("first is longer");

            //}
            //else if (lastN < firstN)
            //{
            //    Console.WriteLine("Last is longer");
            //}
            //else if (firstN == lastN)
            //{

            //    Console.WriteLine("samsis");
            //}
            //else {
            //    Console.WriteLine("Last must be longer");

            //}

            //ask for name see if they are eqaul or not
            //Console.WriteLine("what is your name?");
            //string person1 = Console.ReadLine();


            //Console.WriteLine("what is your name?");
            //string person2 = Console.ReadLine();

            //bool equal =(person1 == person2);
            //bool nequal =(person1 != person2);

            //if (equal)
            //{
            //    Console.WriteLine("The names are the same.");

            //}
            //else
            //{
            //    Console.WriteLine("The names are different.");
            //}

            // name concad
            //Console.WriteLine("what is your First Name");
            //string firstName = Console.ReadLine();

            //Console.WriteLine("what is your Last Name");
            //string lastName = Console.ReadLine();

            //Console.WriteLine(firstName + " " + lastName);


            Console.WriteLine("Guess a type of pet");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "cat")
            {
                Console.WriteLine("You guessed correctly!");

            }
            else
            {

                Console.WriteLine("You guessed incorrectly!");
            }





        }
    }
}
