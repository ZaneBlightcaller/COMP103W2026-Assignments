namespace Lab5
{
    using System;
    using System.Reflection.Metadata;
    using System.Security.Cryptography.X509Certificates;

    class Program
    {
        static void Main(string[] args)
        {
            
            /*Here the selection of preset Hardwood choices for the flooring plan.*/
            Console.WriteLine("Welcome to the John's Hardware Store for flooring plans. \nWhat kind of flooring do you plan on buying today? We have (M, P, O, H).");
            /*Here I set up legend aside the names of the hardwood types and the prices along side each one */
            Console.WriteLine("M) Maple Hardwood($8.95)\r\nP) Pine Hardwood($6.95)\r\nO) Oak Hardwood($9.95)\r\nH) Hickory Hardwood($12.95)");
            /*This is an input for the answer to the selected preset options for hardwood*/
            string HardWoodChoice = Console.ReadLine();
            /*This float cost collects the price from the selections from below which ever hardwood type was chosen*/
            float cost = 0;
            string Prices = "$" + cost.ToString();
            HardWoodChoice = HardWoodChoice.Trim().ToUpper();
            bool isparsable = false;
            /*Diffrent outcomes to the choice as well as the print shortcut of choice to the selected woodtype*/
            if (isparsable == true && HardWoodChoice != "") { }

            if (HardWoodChoice == "M")
            {

                Console.WriteLine("You have selected Maple Hardwood. The price is $8.95 per square foot.");
            }
            else if (HardWoodChoice == "P")
            {
                cost = 6.95f;
                Console.WriteLine("You have selected Pine Hardwood. The price is $6.95 per square foot.");
            }
            else if (HardWoodChoice == "O")
            {
                cost = 9.95f;
                Console.WriteLine("You have selected Oak Hardwood. The price is $9.95 per square foot.");
            }
            else if (HardWoodChoice == "H")
            {
                cost = 12.95f;
                Console.WriteLine("You have selected Hickory Hardwood. The price is $12.95 per square foot.");
            }
            else 
            {
                Console.WriteLine("Sorry, ether you selected a invalid answer or that product is out of stock");
                /* find the variable for the selected wood then assign that letter of choice into a variable and then use that variable to find the price of the wood and assign that price to a variable. Then use that variable to calculate the total cost of the flooring. */

            }
            /*Asks the question of the square feet needed for the hardwood and the imput prompt for Lenght and width*/
            Console.WriteLine("How many square feet of flooring do you need? \nPlease input the Length and Width");
            /*Input for the lenght*/
            Console.WriteLine("Please Input the Length:");
            string length = Console.ReadLine();
            float lengthfloat = float.Parse(length);
            /*Input for the width*/
            Console.WriteLine("Please Input the Width:");
            string width = Console.ReadLine();
            float widthfloat = float.Parse(width);
            /*The Layout of variables shortcut to a smaller variable use for multiplecation*/
            float squarefoot = 0;
            float a = lengthfloat;
            float b = widthfloat;
            float c = squarefoot;
            float d = cost;
            /*The calulation of ((L*W)*S)*Cost= the total cost of the product needed.*/
            c = a * b;
            d = c * cost;
            /*stringed together the total cost*/
            string TotalCost = "$" + d.ToString();
            /*Here I styled the cost with a $ sign for better clarity */
            Console.WriteLine($"The Length {a} multiplied by the Width {b} equal to {c} squarefoot followed by multiplying the cost per squarefoot of {cost} equal to your total of {TotalCost} for your selected Hardwood.");
        }     
    }
}