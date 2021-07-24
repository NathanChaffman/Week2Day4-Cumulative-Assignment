using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week2Day4_Cumulative_Assignment
{ 
    class Program
    {
        static void Main(string[] args)
        {
            decimal width;
            decimal depth;
            decimal height1;
            decimal area;
            decimal stories;
            char playerChoice;
            int choice;
            string cityName;
            string path = @"C:\MSSA\";
            string fileName;
            string kingKongchoice;
            string[] stringArray = new string[20];
            int[] integerArray = new int[20];
            decimal[] decimalArray = new decimal[20];

            StreamWriter strmwriter = null;
            Courthouse newCourthouse = new Courthouse();
            Skyscraper newSkyscraper = new Skyscraper();
            Mall newMall = new Mall();
            Restaurant newRestaurant = new Restaurant();
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "NN   NN EEEEEEE WW      WW     SSSSS  IIIII MM    MM     CCCCC  IIIII TTTTTTT YY   YY"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "NNN  NN EE      WW      WW    SS       III  MMM  MMM    CC    C  III    TTT   YY   YY"));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "NN N NN EEEEE   WW   W  WW     SSSSS   III  MM MM MM    CC       III    TTT    YYYYY "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "NN  NNN EE       WW WWW WW         SS  III  MM    MM    CC    C  III    TTT     YYY  "));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "NN   NN EEEEEEE   WW   WW      SSSSS  IIIII MM    MM     CCCCC  IIIII   TTT     YYY  "));
            Console.WriteLine();
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Are you ready Player 1?"));
            Console.WriteLine();
            Console.Write(String.Format("{0," + Console.WindowWidth / 2 + "}", "Press 'y' to begin   "));
            playerChoice = Convert.ToChar(Console.ReadLine());
            if (playerChoice =='Y' || playerChoice == 'y')
            {
                Console.WriteLine("Lets Begin!");
            }
            else
            {
                Console.WriteLine("Then why are you here?");
            }
            Console.WriteLine();
            Console.WriteLine("First, we need to create a save file.");
            Console.WriteLine();
            Console.WriteLine("Enter the name you want to give your file: ");
            fileName = Console.ReadLine() + ".txt";
            path += fileName;
            if (!File.Exists(path))
                try
                {
                    {
                        strmwriter = File.CreateText(path);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    strmwriter.Close();
                }
            else
            {
                Console.WriteLine("That file name already exists, so we'll overwrite it.");
            }
            Console.WriteLine();
            Console.WriteLine($"A file with name: {fileName} has been created to save your data!");
            Console.WriteLine();
            Console.WriteLine("Now that we've created a file, it's time to name your city and start designing.");
            Console.WriteLine();
            Console.Write("So tell me, what name shall we give your city? ");
            cityName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Okay! You've decided to name your city {cityName}!");
            Console.WriteLine();
            Console.WriteLine("Now let's start my picking a building type and then we'll add some features to it.");
            Console.WriteLine();
            Console.WriteLine("What type of building would you like to add?");
            Console.WriteLine();
            Console.WriteLine("Press the number associated with each building type to add it:");
            Console.WriteLine();
            Console.WriteLine("     1 - Courthouse");
            Console.WriteLine("     2 - Skyscraper");
            Console.WriteLine("     3 - Mall");
            Console.WriteLine("     4 - Restaurant");
            Console.WriteLine();
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("You've chosen a courthouse; please enter choices for the following features below:");
                    Console.WriteLine();
                    Console.Write("how many stories will the courthouse have? (enter using numbers only!): ");
                    newCourthouse._numberOfstories = Convert.ToInt32(Console.ReadLine());
                    integerArray[0] = newCourthouse._numberOfstories;
                    height1 = (newCourthouse._numberOfstories * 12);
                    Console.WriteLine();
                    Console.Write("What is the width of the building in feet? (enter using numbers only!) ");
                    width = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("What is the depth of the building in feet? (enter using numbers only!) ");
                    depth = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"The approximate area of your courthouse is: {newCourthouse.AreaFunction(width, depth, height1)} square feet");
                    decimalArray[0] = newCourthouse.AreaFunction(width, depth, height1);
                    Console.WriteLine();
                    Console.Write("What is the color of your building? ");
                    newCourthouse._colorOfbuilding = Console.ReadLine();
                    stringArray[0] = newCourthouse._colorOfbuilding;
                    Console.WriteLine();
                    Console.Write("What is the material of the building? ");
                    newCourthouse._materialOfbuilding = Console.ReadLine();
                    stringArray[1] = newCourthouse._materialOfbuilding;
                    Console.WriteLine();
                    Console.Write("How many lion statues should the courthouse have? (enter using numbers only!) ");
                    newCourthouse._numberOflions = Convert.ToInt32(Console.ReadLine());
                    integerArray[1] = newCourthouse._numberOflions;
                    Console.WriteLine();
                    Console.Write("How many columns should the courthouse have out front? ");
                    newCourthouse._numberOfcolumns = Convert.ToInt32(Console.ReadLine());
                    integerArray[2] = newCourthouse._numberOfcolumns;
                    Console.WriteLine();
                    Console.Write("How many courtrooms should your courthouse have (enter using numbers only!)? ");
                    newCourthouse._numberOfcourtrooms = Convert.ToInt32(Console.ReadLine());
                    integerArray[3] = newCourthouse._numberOfcourtrooms;
                    Console.WriteLine();
                    Console.WriteLine("Okay, great! Let's save that information to the file we created earlier, and then we can verify the information");
                    try
                    {
                        strmwriter = File.CreateText(path);
                        strmwriter.WriteLine(cityName);
                        strmwriter.WriteLine("Stories: " + integerArray[0]);
                        strmwriter.WriteLine("Area: " + decimalArray[0]);
                        strmwriter.WriteLine("Color: " + stringArray[0]);
                        strmwriter.WriteLine("Material: " + stringArray[1]);
                        strmwriter.WriteLine("Number of lion statues: " + integerArray[1]);
                        strmwriter.WriteLine("Number of columns: " + integerArray[2]);
                        strmwriter.WriteLine("Number of courtrooms: " + integerArray[3]);
                    }
                    catch (Exception ex2)
                    {

                        Console.WriteLine(ex2);
                    }
                    finally
                    {
                        strmwriter.Close();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Ok, I think everything saved OK, let's check it out just to make sure!");
                    StreamReader streamReader1 = File.OpenText(path);
                    string sampleText1;
                    while ((sampleText1 = streamReader1.ReadLine()) != null)
                    {
                        Console.WriteLine(sampleText1);
                    }
                    streamReader1.Close();
                    Console.WriteLine();
                    Console.WriteLine("Great! Everything seems to have worked! Unfortunately, the City's budget is depleted and your limited to one building today :(");
                    Console.WriteLine("Thanks for playing, and have a great day!");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("You've chosen a Skyscraper; please enter choices for the following features below:");
                    Console.WriteLine();
                    Console.Write("how many stories will the Skyscraper have? (enter using numbers only!): ");
                    newSkyscraper._numberOfstories = Convert.ToInt32(Console.ReadLine());
                    integerArray[0] = newSkyscraper._numberOfstories;
                    height1 = (newSkyscraper._numberOfstories * 12);
                    Console.WriteLine();
                    Console.Write("What is the width of the building in feet? (enter using numbers only!) ");
                    width = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("What is the depth of the building in feet? (enter using numbers only!) ");
                    depth = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"The approximate area of your Skyscraper is: {newSkyscraper.AreaFunction(width, depth, height1)} square feet.");
                    decimalArray[0] = newSkyscraper.AreaFunction(width, depth, height1);
                    Console.WriteLine();
                    Console.Write("What is the color of your building? ");
                    newSkyscraper._colorOfbuilding = Console.ReadLine();
                    stringArray[0] = newSkyscraper._colorOfbuilding;
                    Console.WriteLine();
                    Console.Write("What is the material of the building? ");
                    newSkyscraper._materialOfbuilding = Console.ReadLine();
                    stringArray[1] = newSkyscraper._materialOfbuilding;
                    Console.WriteLine();
                    Console.Write("How many elevators should the skyscraper have? (enter using numbers only!) ");
                    newSkyscraper._numberOfelevators = Convert.ToInt32(Console.ReadLine());
                    integerArray[1] = newSkyscraper._numberOfelevators;
                    Console.WriteLine();
                    Console.Write("How many observation decks should the skyscraper have? (enter using numbers only!) ");
                    newSkyscraper._numberOfobservationdecks = Convert.ToInt32(Console.ReadLine());
                    integerArray[2] = newSkyscraper._numberOfobservationdecks;
                    Console.WriteLine();
                    Console.Write("Should King Kong call this Skyscraper home (Y/N)? ");
                    newSkyscraper._kingKong = Console.ReadLine();
                    stringArray[2] = newSkyscraper._kingKong;
                    Console.WriteLine();
                    Console.WriteLine("Okay, great! Let's save that information to the file we created earlier, and then we can verify the information");
                    try
                    {
                        strmwriter = File.CreateText(path);
                        strmwriter.WriteLine(cityName);
                        strmwriter.WriteLine("Stories: " + integerArray[0]);
                        strmwriter.WriteLine("Area: " + decimalArray[0]);
                        strmwriter.WriteLine("Color: " + stringArray[0]);
                        strmwriter.WriteLine("Material: " + stringArray[1]);
                        strmwriter.WriteLine("Number of elevators: " + integerArray[1]);
                        strmwriter.WriteLine("Number of observation decks: " + integerArray[2]);
                        strmwriter.WriteLine("Is King Kong present?: " + stringArray[2]);
                    }
                    catch (Exception ex2)
                    {

                        Console.WriteLine(ex2);
                    }
                    finally
                    {
                        strmwriter.Close();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Ok, I think everything saved OK, let's check it out just to make sure!");
                    StreamReader streamReader2 = File.OpenText(path);
                    string sampleText2;
                    while ((sampleText2 = streamReader2.ReadLine()) != null)
                    {
                        Console.WriteLine(sampleText2);
                    }
                    streamReader2.Close();
                    Console.WriteLine();
                    Console.WriteLine("Great! Everything seems to have worked! Unfortunately, the City's budget is depleted and your limited to one building today :(");
                    Console.WriteLine("Thanks for playing, and have a great day!");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("You've chosen a Mall; please enter choices for the following features below:");
                    Console.WriteLine();
                    Console.Write("Give the Mall a name: ");
                    newMall._mallName = Console.ReadLine();
                    stringArray[0] = newMall._mallName;
                    height1 = 30;
                    Console.WriteLine();
                    Console.Write("What is the width of the building in feet? (enter using numbers only!) ");
                    width = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("What is the depth of the building in feet? (enter using numbers only!) ");
                    depth = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"The approximate area of {stringArray[0]} Mall is: {newMall.AreaFunction(width, depth, height1)} square feet.");
                    decimalArray[0] = newMall.AreaFunction(width, depth, height1);
                    Console.WriteLine();
                    Console.Write($"What is the color of {stringArray[0]} mall? ");
                    newMall._colorOfbuilding = Console.ReadLine();
                    stringArray[1] = newMall._colorOfbuilding;
                    Console.WriteLine();
                    Console.Write($"What is the material of {stringArray[0]} mall? ");
                    newMall._materialOfbuilding = Console.ReadLine();
                    stringArray[2] = newMall._materialOfbuilding;
                    Console.WriteLine();
                    Console.Write($"How many fountains are inside {stringArray[0]} mall? (enter using numbers only!) ");
                    newMall._fountainsInside = Convert.ToInt32(Console.ReadLine());
                    integerArray[0] = newMall._fountainsInside;
                    Console.WriteLine();
                    Console.Write($"How many stores are inside {stringArray[0]} mall? (enter using numbers only!) ");
                    newMall._storesInside = Convert.ToInt32(Console.ReadLine());
                    integerArray[1] = newMall._storesInside;
                    Console.WriteLine();
                    Console.WriteLine("Okay, great! Let's save that information to the file we created earlier, and then we can verify the information");
                    try
                    {
                        strmwriter = File.CreateText(path);
                        strmwriter.WriteLine(cityName);
                        strmwriter.WriteLine(stringArray[0]);
                        strmwriter.WriteLine("Area: " + decimalArray[0]);
                        strmwriter.WriteLine("Color: " + stringArray[1]);
                        strmwriter.WriteLine("Material: " + stringArray[2]);
                        strmwriter.WriteLine("Number of fountains inside: " + integerArray[0]);
                        strmwriter.WriteLine("Number of stores: " + integerArray[1]);
                    }
                    catch (Exception ex2)
                    {

                        Console.WriteLine(ex2);
                    }
                    finally
                    {
                        strmwriter.Close();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Ok, I think everything saved OK, let's check it out just to make sure!");
                    StreamReader streamReader3 = File.OpenText(path);
                    string sampleText3;
                    while ((sampleText3 = streamReader3.ReadLine()) != null)
                    {
                        Console.WriteLine(sampleText3);
                    }
                    streamReader3.Close();
                    Console.WriteLine();
                    Console.WriteLine("Great! Everything seems to have worked! Unfortunately, the City's budget is depleted and your limited to one building today :(");
                    Console.WriteLine("Thanks for playing, and have a great day!");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("You've chosen a Restaurant; please enter choices for the following features below:");
                    height1 = 20;
                    Console.WriteLine();
                    Console.Write("What is the width of the building in feet? (enter using numbers only!) ");
                    width = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("What is the depth of the building in feet? (enter using numbers only!) ");
                    depth = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"The approximate area of your Restaurant is: {newCourthouse.AreaFunction(width, depth, height1)} square feet.");
                    decimalArray[0] = newRestaurant.AreaFunction(width, depth, height1);
                    Console.Write("What is the color of your building? ");
                    newRestaurant._colorOfbuilding = Console.ReadLine();
                    stringArray[0] = newRestaurant._colorOfbuilding;
                    Console.WriteLine();
                    Console.Write("What is the material of the building? ");
                    newRestaurant._materialOfbuilding = Console.ReadLine();
                    stringArray[1] = newRestaurant._materialOfbuilding;
                    Console.WriteLine();
                    Console.Write("What type of cuisine will the Restaurant serve? (enter using numbers only!) ");
                    newRestaurant._typeOfcuisine = Console.ReadLine();
                    stringArray[2] = newRestaurant._typeOfcuisine;
                    Console.WriteLine();
                    Console.Write("How many diners can the Restaurant fit at once? ");
                    newRestaurant._dinerCount = Convert.ToInt32(Console.ReadLine());
                    integerArray[0] = newRestaurant._dinerCount;
                    Console.WriteLine();
                    Console.Write("What is the average cost of a meal at this Restaurant? (Enter using decimal numbers only please!) $");
                    newRestaurant._costofEating = Convert.ToDecimal(Console.ReadLine());
                    decimalArray[1] = newRestaurant._costofEating;
                    Console.WriteLine();
                    Console.WriteLine("Okay, great! Let's save that information to the file we created earlier, and then we can verify the information");
                    try
                    {
                        strmwriter = File.CreateText(path);
                        strmwriter.WriteLine(cityName);
                        strmwriter.WriteLine("Area: " + decimalArray[0]);
                        strmwriter.WriteLine("Color: " + stringArray[0]);
                        strmwriter.WriteLine("Material: " + stringArray[1]);
                        strmwriter.WriteLine("Type of cuisine: " + stringArray[2]);
                        strmwriter.WriteLine("Occupancy: " + integerArray[0]);
                        strmwriter.WriteLine("Average cost: $" + decimalArray[1]);
                    }
                    catch (Exception ex2)
                    {

                        Console.WriteLine(ex2);
                    }
                    finally
                    {
                        strmwriter.Close();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Okay, I think everything saved, let's check it out just to make sure!");
                    StreamReader streamReader4 = File.OpenText(path);
                    string sampleText4;
                    while ((sampleText4 = streamReader4.ReadLine()) != null)
                    {
                        Console.WriteLine(sampleText4);
                    }
                    streamReader4.Close();
                    Console.WriteLine();
                    Console.WriteLine("Great! Everything seems to have worked! Unfortunately, the City's budget is depleted and your limited to one building today :(");
                    Console.WriteLine("Thanks for playing, and have a great day!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
