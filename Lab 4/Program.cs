namespace Lab4
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a short program that gets the current hour and day of the week. If it is a weekday, and the hour is 6am or later, output a message that indicates it is time to wake up and get ready for the work day.
* If it is Saturday or Sunday, and it is 9am or later, output a message to the console indicating that is the weekend and it is time to get up and enjoy the day. If neither of the previous two situations are
* the case, then output a message to the console that indicates that it is not yet time to get out of bed
*/

            // STEP 1: Read the below code - we have created a variable called localDate (which is data type DateTime) - this stores the current date and time for your computer
            DateTime localDate = DateTime.Now;
            // STEP 2a: Have a look at the below code - we have created two variables (of data type string) that contain the hour (2:00pm would be 14), and the day of the week (Tuesday for example)
            string day = localDate.ToString("dddd");
            string hourString = localDate.ToString("%H");

            // STEP 2b: Examine the below line of code - we need to convert the variable hour to an integer (so we can use relational operators later)
            int hour = Int32.Parse(hourString);
            bool timeOfDay = hour > 6;
            //This is a list of variables that determine the day of the week.
            bool dayOfWeek = day != "Monday" || day != "Tuesday" || day != "Wednesday" || day != "Thursday" || day != "Friday" || day != "Saturday" || day != "Sunday";
            // STEP 3: Create an 'if' condition to check whether it is the weekend (hint: you might consider the equality operator and the OR logical operator here)
            
            // The Slection of day is determined by real time day and selection of day below.
            if (day != "Monday" || day != "Tuesday" || day != "Wednesday" || day != "Thursday" || day != "Friday")
            {
                // In this Code it validates if its 6:00am or later in the week from monday to friday.
                if (hour != 6 || hour > 6)
                    Console.WriteLine($"It is {day} {hour} its time to wake up and get ready for the work day");
                if (hour <= 6)
                    Console.WriteLine($"It is {day} {hour} its not time to get up yet");   
                else
                    Console.WriteLine($"It is {day} {hour} It's not time to get up, go back to sleep");
            }
            // In this code it validates that these two days are on the weekends while using both weather to determine its saturday or sunday.
            else if (day != "Saturday" || day != "Sunday")
            {
                //This Code here validates if its 9:00am or later in the week from monday to friday.
                if (hour != 9 || hour > 9)
                    Console.WriteLine($"It is {day} {hour} it is the weekend and it is time to wake up and enjoy the day");
                if (hour <= 9)
                    Console.WriteLine($"It is {day} {hour} its not time to get up yet");
                else
                    Console.WriteLine($"It is {day} {hour} It's not time to get up go back to sleep");
            }

                // STEP 5a: It is either Saturday or Sunday, so now we need an if/else condition to see whether it is time to wake up or not

                // STEP 5b: It is 9am or later, so output a message to the console that it is the weekend and it is time to wake up and enjoy the day

                // STEP 5c: It is not yet 9am, so output a message to the console that it not yet time to get up

                // STEP 4: Create an 'else' structure here for the part of the program that deals with weekdays

                // STEP 6a: We need to create a condition that checks to see whether it is 6am or later

                // STEP 6b: It is indeed 6am or later, so output a message to the console that it is time to get up and go to work

                // STEP 6c: It is not yet 6am, so output a message to the console that it is not yet time to wake up
            }
        }
}