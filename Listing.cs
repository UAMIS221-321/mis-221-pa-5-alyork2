namespace mis_221_pa_5_alyork2
{
    public class Listing
    {
        private int listingID;
        private string trainerName = "";
        private string sessionDate = "";
        private string sessionTime = "";
        private int sessionCost;
        private bool listingTaken;


        public Listing(int myID, string myTrainerName, string mySessionDate, string mySessionTime, int mySessionCost, bool isListingTaken)
        {
            this.listingID = myID;
            this.trainerName = myTrainerName;
            this.sessionDate = mySessionDate;
            this.sessionTime = mySessionTime;
            this.sessionCost = mySessionCost;
            this.listingTaken = isListingTaken;
        }

        public int GetListingID()
        {
            return listingID;
        }

        public void SetListingID(int myID)
        {
            this.listingID = myID;
        }

        public string GetTrainerName()
        {
            return trainerName;
        }

        public void SetTrainerName(string myTrainerName)
        {
            this.trainerName = myTrainerName;
        }
        
        public string GetDate()
        {
            return sessionDate;
        }

        public void SetDate(string mySessionDate)
        {
            this.sessionDate = mySessionDate;
        }

        public string GetTime()
        {
            return sessionTime;
        }

        public void SetTime(string mySessionTime)
        {
            this.sessionTime = mySessionTime;
        }

        public int GetCost()
        {
            return sessionCost;
        }

        public void SetCost(int mySessionCost)
        {
            this.sessionCost = mySessionCost;
        }

        public bool GetListingStatus()
        {
            return listingTaken;
        }

        public void SetListingStatus(bool isListingTaken)
        {
            this.listingTaken = isListingTaken;
        }

        public void EditListing(string myID, string myTrainerName, string mySessionDate, string mySessionTime, int mySessionCost, bool isListingTaken)
        {
            bool foundListing = false;
            string input;
            string fileName;
            string fileText;
            string[] sections;


            Console.WriteLine("What part of the listing would you like to edit?");
            input = Console.ReadLine();

            Console.WriteLine("What file would you like to edit the listing in?");
            fileName = Console.ReadLine();

            StreamReader fileIn = new StreamReader(fileName);

            while((fileText = fileIn.ReadLine())!= null)
            {
                sections = fileText.Split(" ");
                if(input == "trainer name")
                {
                    if(sections[0] == trainerName)
                    {
                        foundListing = true;
                        sections[0] = "";
                        Console.WriteLine("What is the new trainer name? ");
                        trainerName = Console.ReadLine();
                        sections[0] = trainerName;
                        fileIn.Close();
                    } 
                    else
                    {
                        foundListing = false;
                        fileIn.Close();
                    }
                }
                else if(input == "id")
                {
                    if(sections[1] == myID)
                    {
                        foundListing = true;
                        sections[1] = "";
                        Console.WriteLine("What is the new listing ID? ");
                        myID = Console.ReadLine();
                        sections[1] = myID;
                        fileIn.Close();
                    }
                    else
                    {
                        foundListing = false;
                        fileIn.Close();
                    }
                }
                else if(input == "date")
                {
                    if(sections[2] == mySessionDate)
                    {
                        foundListing = true;
                        sections[2] = "";
                        Console.WriteLine("When is the new date? ");
                        mySessionDate = Console.ReadLine();
                        sections[2] = mySessionDate;
                        fileIn.Close();
                    }
                    else
                    {
                        foundListing = false;
                        fileIn.Close();
                    }
                }
                else if(input == "time")
                {
                    if(sections[3] == mySessionTime)
                    {
                        foundListing = true;
                        sections[3] = "";
                        Console.WriteLine("When is the new time? ");
                        mySessionTime = Console.ReadLine();
                        sections[3] = mySessionTime;
                        fileIn.Close();
                    }
                    else
                    {
                        foundListing = false;
                        fileIn.Close();
                    }
                }
                else if(input == "cost")
                {
                    string newCost = mySessionCost.ToString();
                    if(sections[4] == newCost)
                    {
                        foundListing = true;
                        sections[4] = "";
                        Console.WriteLine("What is the new cost of the listing? ");
                        newCost = Console.ReadLine();
                        sections[4] = newCost;
                        fileIn.Close();
                    }
                    else
                    {
                        foundListing = false;
                        fileIn.Close();
                    }
                }
                else if(input == "session status")
                {
                    if(listingTaken == true)
                    {
                        sections[5] = "booked";
                    }
                    else 
                    {
                        sections[5] = "open";
                    }
                    
                }
                else
                {
                    foundListing = false;
                    fileIn.Close();
                }
                
            }
            if(foundListing == true)
            {
                Console.WriteLine("The Listing was found and the changes were made.");
            }

            if(foundListing == false)
            {
                Console.WriteLine("The Listing was not found.");
            }

        }


        public void DeleteListing(string myID, string myTrainerName, string mySessionDate, string mySessionTime, int mySessionCost, bool isListingTaken)
        {
            bool foundListing = false;
            string input;
            string fileName;
            string fileText;
            string[] sections;


            Console.WriteLine("What part of the listing would you like to delete?");
            input = Console.ReadLine();

            Console.WriteLine("What file would you like to delete the listing in?");
            fileName = Console.ReadLine();

            StreamReader fileIn = new StreamReader(fileName);

            while((fileText = fileIn.ReadLine())!= null)
            {
                sections = fileText.Split(" ");
                if(input == "trainer name")
                {
                    if(sections[0] == trainerName)
                    {
                        foundListing = true;
                        sections[0] = "";
                        fileIn.Close();
                    } 
                    else
                    {
                        foundListing = false;
                        fileIn.Close();
                    }
                }
                else if(input == "id")
                {
                    if(sections[1] == myID)
                    {
                        foundListing = true;
                        sections[1] = "";
                        fileIn.Close();
                    }
                    else
                    {
                        foundListing = false;
                        fileIn.Close();
                    }
                }
                else if(input == "date")
                {
                    if(sections[2] == mySessionDate)
                    {
                        foundListing = true;
                        sections[2] = "";
                        fileIn.Close();
                    }
                    else
                    {
                        foundListing = false;
                        fileIn.Close();
                    }
                }
                else if(input == "time")
                {
                    if(sections[3] == mySessionTime)
                    {
                        foundListing = true;
                        sections[3] = "";
                        fileIn.Close();
                    }
                    else
                    {
                        foundListing = false;
                        fileIn.Close();
                    }
                }
                else if(input == "cost")
                {
                    string newCost = mySessionCost.ToString();
                    if(sections[4] == newCost)
                    {
                        foundListing = true;
                        sections[4] = "";
                        fileIn.Close();
                    }
                    else
                    {
                        foundListing = false;
                        fileIn.Close();
                    }
                }
                else if(input == "session status")
                {
                    if(listingTaken == true)
                    {
                        sections[5] = "booked";
                    }
                    else 
                    {
                        sections[5] = "open";
                    }
                    
                }
                else
                {
                    foundListing = false;
                    fileIn.Close();
                }
                
            }
            if(foundListing == true)
            {
                Console.WriteLine("The Listing was found and the changes were made.");
            }

            if(foundListing == false)
            {
                Console.WriteLine("The Listing was not found.");
            }

        }

        public void ListingInfo()
        {
            string fileName2;

            Console.WriteLine("What is the file name that you would like the listing information in?");
            fileName2 = Console.ReadLine();

            StreamWriter file2 = new StreamWriter(fileName2);

            if (listingTaken == true)
            {
                Console.WriteLine(trainerName + " " + listingID + " " + sessionDate + " " + sessionTime + " " + sessionCost + " Booked" );
            }
            else
            {
                Console.WriteLine(trainerName + " " + listingID + " " + sessionDate + " " + sessionTime + " " + sessionCost + " Open" );
            }
            file2.Close();
        }

    }

}