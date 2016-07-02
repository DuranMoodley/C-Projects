/*Validation.cs           Author: Duran Moodley
 * Validates UserInput
 * Date Modified: 6/24/2015
 * 
*/
using System;
namespace prjDvdShop
{
    public sealed class Validation
    {
        public Validation()
        {
        }
        //***********************************************************************************************
        public void CheckNullValue(ref string line)
        {
            //Check if variable contains a null value
            while (string.IsNullOrEmpty(line))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine("Nothing Was Entered" + Environment.NewLine +
                                        "Please Enter a Valid Input" + Environment.NewLine + "Press E to Exit");
                Console.ResetColor();
                line = Console.ReadLine().ToUpper();

                if (line.Equals("E"))
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
