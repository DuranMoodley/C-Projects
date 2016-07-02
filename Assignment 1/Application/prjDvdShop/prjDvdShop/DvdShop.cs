/**********************************************
 * DvdShop.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 1
 * Keeps Track of all Dvds Hired
 * Searches a Dvd
 * Accumalates the total Sales for the day
 * Displays a report of Dvds
 * Saves to A Text File
 * Date Modified : 6/13/2015
***********************************************/
using System;
using System.Collections;
using System.Windows.Forms;

/*********************************************
* Note To Programmer
 * The Program must first Recieve the full name of all dvds hired,
 * Before any other processing can take place like 
 * Search, Display, Save Records to Text File
***********************************************/
namespace prjDvdShop
{
    class DvdShop
    {
        static void Main()
        {        
           //Changes Console window properties
            ChangeConsolePropertise();
   
            //Creates Speech class object, Fills the arrays with user input
            SpeechOutput objSpeechOutput = new SpeechOutput();
            OutputInstructions(objSpeechOutput);
            string [,] arrHiredDvds = LoadHiredDvdArray();
            string [,] arrCustomerDetails = LoadCustomerDetails(arrHiredDvds);

            //Recieves User menu option,Validates it, Checks that option 
            DisplayMenu();
            String userOption = GetUserOption();
            ValidateUserOption(ref userOption);
            CheckOption(userOption , arrHiredDvds , arrCustomerDetails);
        }
        //*******************************************************
        public static void DisplayMenu()
        {
            //Menu Option that the user needs to Select
            Console.Clear();   
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please Enter your Option\nUsing the Corresponding Letter eg.A");
            Console.WriteLine("A)\tSearch Dvd" + Environment.NewLine +
                              "B)\tDisplay Dvd List" + Environment.NewLine + 
                              "C)\tSave Records" + Environment.NewLine +
                              "E)\tExit Application ");
        }
        //*******************************************************
        public static String GetUserOption()
        {
            //Reads the user input for the menu options
            string userChoice = Console.ReadLine().ToUpper();

            return userChoice;
        }

        //*******************************************************
        public static void CheckOption(string inputFromUser , string [,] dvdRecords , string [,] customerRecords)
        {    
            //Checks which option the user wants to do
            if(inputFromUser.Equals("A"))
            {
                SearchDvds(dvdRecords, customerRecords);
            }
            else if(inputFromUser.Equals("B"))
            {            
                PrintArray(dvdRecords , customerRecords);
            }
            else if(inputFromUser.Equals("C"))
            {
                SaveRecords(dvdRecords, customerRecords);
            }           
            else
            {
                ValidateExitEvent(dvdRecords,customerRecords);
            }
        }
        //*******************************************************
        public static void ValidateUserOption(ref string userInput)
        {
            //Flag Variable to stop Loop
            bool isValid = false;
            Validation objValidate = new Validation();
           
            //Checks if the user a inputted a null value
            objValidate.CheckNullValue(ref userInput);

            //Validation of User input
            while (isValid == false)
            {             
                //Checks user option
                if (userInput.Equals("A") || userInput.Equals("B") || userInput.Equals("C") || userInput.Equals("E"))
                {
                    isValid = true;
                }
                else
                {
                    //Change Text Colour
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Enter a Correct Option");
                    Console.ResetColor();
                    userInput = Console.ReadLine().ToUpper();
                }
            }
        }
        //*******************************************************
        public static string [ , ] LoadHiredDvdArray()
        { 
            string userInputVal = "";
            string[,] arrHireDvd;          
            ArrayList arrDvds = new ArrayList();
            string dvds = "";
            int amtOfDvd = 0;
            double temporaryValue;
            string dvdBarcode = "";
            Random objBarcode = new Random();
            string[] arrHeadingNames = {" ", " " , " Genre "," Dvd Price eg.12 instead Of R12", };
            Validation objValidate = new Validation();

            //Get User input values
            while(!dvds.Equals("XXX"))
            {
                //Reads a line, checks for null
                string tempVariable = Console.ReadLine();               
                objValidate.CheckNullValue(ref tempVariable);
                
                //fill Array List
                dvds = tempVariable.ToUpper();             
                amtOfDvd++;
                arrDvds.Add(dvds);
            }

            //Checks if a dvd was Entered
            IsDvdHiredEntered(arrDvds);

            arrDvds.RemoveAt(arrDvds.Count-1);

            //Instantiate 2-dimensional array updating the size of the rows
            arrHireDvd = new string[(amtOfDvd - 1), 4];

            for (int row = 0; row < arrHireDvd.GetLength(0); row++ )
            {
                //Method Call
                GenerateBarcode(ref dvdBarcode , objBarcode);

                //Assign Unique Barcode & Dvd Names
                arrHireDvd[row,0] = dvdBarcode;
                arrHireDvd[row, 1] = arrDvds[row].ToString();

                for(int col = 2 ; col<arrHireDvd.GetLength(1); col++)
                {                                      
                    //Display user instructions
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please Enter in " + arrHeadingNames[col] + 
                        " for " + arrHireDvd[row,1]);
                    Console.ResetColor();

                    //Read user input, check for null value
                    userInputVal = Console.ReadLine().ToUpper();
                    objValidate.CheckNullValue(ref userInputVal);
                    arrHireDvd[row, col] = userInputVal;

                    if(col == 3)
                    {     
                        //Validate Price Figure
                        while(double.TryParse(arrHireDvd[row,col],out temporaryValue) == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please Enter a Valid Price eg 12 instead of R12");
                            Console.ResetColor();
                            arrHireDvd[row, col] = Console.ReadLine();
                        }
                    }
                }
            }
      
            return arrHireDvd;
        }
        //**********************************************************************
        public static void GenerateBarcode(ref string barcode , Random objUniqueBarcode)
        {
            //Declarations
            char randomCharacter;
            
            //Generate 8 Digits
            barcode = objUniqueBarcode.Next(10000000, 99999999).ToString();

            //Generate 2 Random Characters
            for(int count = 0 ; count < 2 ; count++)
            {
                randomCharacter = (char) objUniqueBarcode.Next(65, 90);
                barcode += randomCharacter;
            }
        }
        //**********************************************************************
        public static void PrintArray(string [,] recordsOfDvds , string [,] detailsOfCustomers)
        {
            //Generate totals and assign variable with value
            double totalSales = CalculateTotalSales(recordsOfDvds);

            //Dvd Headings
            Console.Clear();
            Console.WriteLine("Dvd List");
            Console.WriteLine("------------------------------------------------------------------");
            Console.Write("Dvd Barcode      Dvd Name        Genre        Price" + Environment.NewLine);
            Console.WriteLine("------------------------------------------------------------------");

            //Go through each Dvd Elements
            for (int row = 0; row < recordsOfDvds.GetLength(0); row++)
            {
                for (int col = 0; col < recordsOfDvds.GetLength(1); col++)
                {
                    if(col == 3)
                    {
                        //Format Currency                      
                        var costOfDvd = double.Parse(recordsOfDvds[row, col]);
                        Console.WriteLine("{0:c}", costOfDvd);
                        continue;
                    }

                    //Print Each Element
                    Console.Write(recordsOfDvds[row, col] + "       ");
                }
                Console.WriteLine();
            }

            //Customer Headings 
            Console.WriteLine();
            Console.WriteLine("Customer Details");
            Console.WriteLine("-----------------------------------------------------------------" +
                              "-------------------------------------");
            Console.WriteLine("Name\t\t\t  Customer ID       Contact Number           Address");
            Console.WriteLine("---------------------------------------------------------------" +
                              "---------------------------------");

            //Go through each Customer Elements
            for (int row = 0; row < detailsOfCustomers.GetLength(0); row++)
            {
                for (int col = 0; col < detailsOfCustomers.GetLength(1); col++)
                {
                    //Print Each Element
                    Console.Write(detailsOfCustomers[row, col] + "            ");
                }
                Console.WriteLine();
            }

            //Output Total Sales 
            Console.WriteLine("Total Sales for the day is {0:c}", totalSales);

            ////Allows user to go back and forth between options and the main menu
            AdditionalInstructions(recordsOfDvds, detailsOfCustomers);
        }
        //**********************************************************************
        public static void AdditionalInstructions(string [,] dvdRecs , string [,] custDetails)
        {
            //Instructions to user
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press V to go Back to Main Menu" + Environment.NewLine + "E to Exit Application");
          
            //Reads line, checks for null, once checked assign inputFromUser variable
            Validation objValidate = new Validation();
            var readLine = Console.ReadLine();          
            objValidate.CheckNullValue(ref readLine);          
            var inputFromUser = readLine.ToUpper(); 

            //Check if user input does not equal V and E
            while (!inputFromUser.Equals("V") && !inputFromUser.Equals("E"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect Option" + Environment.NewLine + 
                                  "Please Enter V to go back to Main Menu or E to Exit");
                Console.ResetColor();
                inputFromUser = Console.ReadLine().ToUpper();
            }

            if (inputFromUser.Equals("V"))
            {
                DisplayMenu();
                inputFromUser = GetUserOption();
                ValidateUserOption(ref inputFromUser);
                CheckOption(inputFromUser, dvdRecs, custDetails);
            }
            else if (inputFromUser.Equals("E"))
            {
                MessageBox.Show("Goodbye", "Message", MessageBoxButtons.OK);
                Environment.Exit(0);
            }
        }
        //**********************************************************************
        public static string [,] LoadCustomerDetails(string [,] dvdsHired)
        {        
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please Enter the following Customer Details:");           
            string[,] arrCustDetails = new string[dvdsHired.GetLength(0), 4];
            string[] arrHeadings = { "Name", "ID","Contact Number", "Address" };
            string valueFromUser;
            string customerName;
            string customerContactNumber;
            Random objCustomerId = new Random();
            Validation objValidate = new Validation();

            //fill Array with user input values
            for (int row = 0; row < arrCustDetails.GetLength(0); row++)
            {
                Console.WriteLine(dvdsHired[row, 1] + " is Hired to :");
               
                for (int col = 0; col < arrCustDetails.GetLength(1); col++)
                {
                    if(col == 1)
                    {
                        //Generate random 3 Digit Number and 2 random Characters for custID
                        customerName = arrCustDetails[row, 0];
                        arrCustDetails[row, col] = GenerateCustomerId(customerName, objCustomerId);
                        continue;
                    }

                    //Prompt user for Input values to fill customer array                   
                    Console.WriteLine(arrHeadings[col] + ":");
                    Console.ResetColor();

                    //Read a line, check if its a null value
                    valueFromUser = Console.ReadLine().ToUpper();
                    objValidate.CheckNullValue(ref valueFromUser);
                    arrCustDetails[row, col] = valueFromUser;

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    if(col == 2)
                    {
                        //Temporary variable to hold customer phone number
                        customerContactNumber = arrCustDetails[row,2];

                        //Check if customer phone number is 10 digits
                        while(ValidateCustDetails(customerContactNumber) == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Incorrect Phone Number,Must be 10 Digits" + Environment.NewLine 
                                               + arrHeadings[col] + ":");
                            Console.ResetColor();
                            customerContactNumber = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        arrCustDetails[row, col] = customerContactNumber;
                    }
                }
                Console.WriteLine();
            }       
          
            return arrCustDetails;
        }
        //******************************************************************************
        public static string GenerateCustomerId(String custName , Random objUniqueCustId)
        {
            //Generate Random 3 digit Number, Break Full Name into Char Array
            string customerId = objUniqueCustId.Next(100,999).ToString();
            Char[] arrCustomerName = custName.ToCharArray();
            bool spaceFound = false;
            int count = 0;
                     
             //Find First Letter Of Surname
             while (spaceFound == false && count < arrCustomerName.Length)
               {
                    if (arrCustomerName[count].Equals(' '))
                     {                      
                       //Concatenate 3 Digit number with first Character of first name and Last Name 
                       customerId += arrCustomerName[0] + "" + arrCustomerName[(count + 1)];
                       spaceFound = true;
                    }
                    count++;
                }
           
            return customerId;
        }
        //**********************************************************************************
        public static bool ValidateCustDetails(string custContactNum)
        {
            //Set flag variable, get lengeth of customer phone number
            bool isValid = false;
            int lengthOfContactNum = custContactNum.Length;

            //Checks customer phone if its equal to 10
            if(lengthOfContactNum == 10)
            {
                isValid = true;
            }

            return isValid;        
        }
        //*********************************************************************************
        public static void SearchDvds(string [,] arrDvdRecords , string [,] arrCustomerDetails)
        {
            //Instructions to user
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter in the Dvd Barcode to Find out if its Available eg.67500094IR");
            Console.ResetColor();
            Validation objValidate = new Validation();

            //Reads a line, checks if its null
            var readLine = Console.ReadLine();
            objValidate.CheckNullValue(ref readLine);
            
            //read user input, create flag variable
            string dvdBarcode = readLine.ToUpper();
            bool isFound = false;
            int rowNumber = 0;
                       
            //Search for Specified Barcode
            while(isFound == false && rowNumber < arrDvdRecords.GetLength(0))
            {
                //If Barcode Found
                if(arrDvdRecords[rowNumber,0].Equals(dvdBarcode))
                {
                    //Change Flag Variable to stop loop
                    isFound = true;

                    //Display information to user,validate user input
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dvd Unavailable"+ Environment.NewLine + 
                                       "It is currently Hired by : " + arrCustomerDetails[rowNumber,0] + 
                                       "ID Number : " + arrCustomerDetails[rowNumber,1] 
                                       + Environment.NewLine +
                                      "Enter in a Dvds Barcode to search for another Dvd or S to stop");
                    Console.ResetColor();
                    readLine = Console.ReadLine().ToUpper();
                   
                    //Displays user search Result , Prompts user to search again or Stop
                    OutputSearchResult(readLine,arrDvdRecords,arrCustomerDetails,ref dvdBarcode, 
                                       ref isFound, ref rowNumber);
                }         
                    
                //If Dvd not found
                else if ((rowNumber == (arrDvdRecords.GetLength(0) - 1)))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Dvd is Available" + Environment.NewLine + 
                                      "Enter in a Dvds Barcode to search for another Dvd or" +
                                      " S to stop ");
                    Console.ResetColor();
                    readLine = Console.ReadLine().ToUpper();                  
                    OutputSearchResult(readLine, arrDvdRecords, arrCustomerDetails, ref dvdBarcode, 
                                       ref isFound, ref rowNumber);                 
                }
                rowNumber++;
            }          
        }
      //******************************************************************************
        public static void SaveRecords(string [,] dvdHiredRecs , string [,] customerInformation)
        {          
            StoreRecords objDvdRecords;
            double sumOfSales = CalculateTotalSales(dvdHiredRecs);
            string dvdRecords = "DVD HIRED LIST" + Environment.NewLine + 
                                 "----------------------------------------------------------"+ Environment.NewLine +
                                "DVD BARCODE\t\tDVD NAME\tGenre\t\tPrice" + Environment.NewLine 
                                +"-----------------------------------------------------------" + Environment.NewLine;
            string customerDetailRecords = "CUSTOMER DETAILS LIST" + Environment.NewLine +
                                           "-------------------------------------------------"+ Environment.NewLine +
                                           Environment.NewLine +
                                           "CUSTOMER NAME\t\t" +                                    
                                           "CUSTOMER ID\t " +
                                           "CUSTOMER CONTACT\t   CUSTOMER ADDRESS" + Environment.NewLine +
                                           "-----------------------------------------------" +
                                           "------------------------------------------" + Environment.NewLine;


            //Take Each dvd Element, append it to a variable
            for (int row = 0; row < dvdHiredRecs.GetLength(0); row++)
            {
                for (int col = 0; col < dvdHiredRecs.GetLength(1); col++)
                {
                    if (col == 3)
                    {
                        dvdRecords += string.Format("{0:c}", double.Parse(dvdHiredRecs[row, col]));
                        continue;
                    }
                    dvdRecords += dvdHiredRecs[row, col] + "           ";
                }

                dvdRecords += "\r\n";
            }

            dvdRecords += "----------------------------------------------------------"+ Environment.NewLine; 
            dvdRecords += "Total Sales for the day is " + string.Format("{0:c}",sumOfSales) + Environment.NewLine;
            dvdRecords += "----------------------------------------------------------" + Environment.NewLine;

            ////Take Each customer Element, append it to a variable
            for (int row = 0; row < customerInformation.GetLength(0); row++)
            {
                for (int col = 0; col < customerInformation.GetLength(1); col++)
                {
                    customerDetailRecords += customerInformation[row, col] + "             ";
                }
                customerDetailRecords += Environment.NewLine;
            }

            //Parse variables with records, write to Text file
            objDvdRecords = new StoreRecords(dvdRecords, customerDetailRecords);
            objDvdRecords.WriteToTextFile();

            //Allows user to go back and forth between options and the main menu
            AdditionalInstructions(dvdHiredRecs, customerInformation);
        }
        //******************************************************************************
        public static double CalculateTotalSales(string [,] allDvdsHired)
        {
            //Stores the total sales for the month
            double salesTotal = 0;

            //takes the cost of each dvd and adds it together
            for (int row = 0; row < allDvdsHired.GetLength(0); row++ )
            {
                salesTotal += double.Parse(allDvdsHired[row, 3]);
            }

            return salesTotal;
        }
        //******************************************************************************
        public static void ValidateExitEvent(string [,] dvds , string [,] custDetails)
        {
            //Prompt user of he/she wants to Exit
            SpeechOutput objOutputOfSpeech = new SpeechOutput();
            DialogResult objResult = MessageBox.Show("Are sure you want to Exit", "Message", MessageBoxButtons.YesNo);
            objOutputOfSpeech.ConvertTextToSpeech("Are You Sure you want to Exit");

            //Checks which button was pressed
            if (objResult == DialogResult.Yes)
            {
                objOutputOfSpeech.ConvertTextToSpeech("GoodBye");
                Environment.Exit(0);
            }
            else
            {
                //Allows user to go back and forth between options and the main menu
                AdditionalInstructions(dvds,custDetails);
            }
        }
        //****************************************************************************
        public static void ChangeConsolePropertise()
        {
            Console.Title = "DVD BLOCKBUSTERS APPLICATION";           
        }
        //****************************************************************************
        public static void IsDvdHiredEntered(ArrayList objDvdsHired)
        {
            //Checks the first element of Array List
            if (objDvdsHired[0].Equals("XXX"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No Dvd was entered" + Environment.NewLine + "Application Will Exit Automatically");
                Environment.Exit(0);
            }
        }
        //****************************************************************************
        public static void OutputSearchResult(string readsLine , string [,] dvdArrRecords, string [,] customerArrRecords, ref string barcodeOfDvd, ref bool found , ref int counter)
        {
            Validation objValidate = new Validation();

            //Checks input for null value
            objValidate.CheckNullValue(ref readsLine);

            //Checks if user has stopped searching
            if (readsLine.Equals("S"))
            {               
                AdditionalInstructions(dvdArrRecords, customerArrRecords);
            }
            else
            {              
                barcodeOfDvd = readsLine;
                found = false;
                counter = -1;
            }

        }
        //****************************************************************************
        public static void OutputInstructions(SpeechOutput objOutputSpeech)
        {
            DateTime todaysDate = DateTime.Today;
            
            //Displays and Voice outputs a Message to user
            MessageBox.Show("WELCOME TO DURAN'S BLOCKBUSTERS", "Information", MessageBoxButtons.OK);
            objOutputSpeech.ConvertTextToSpeech("WELCOME TO DURAN'S BLOCKBUSTERS");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please Enter the Dvds Hired full name for : "
                + todaysDate.ToString("D")
                + Environment.NewLine + "Then Press Enter"
                + Environment.NewLine + "Enter in XXX to Stop Entering");
            objOutputSpeech.ConvertTextToSpeech("Please Enter the Full Name of the Dvd Hired");
            Console.ResetColor();
        }
    }
}
