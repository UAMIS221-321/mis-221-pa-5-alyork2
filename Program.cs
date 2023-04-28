using mis_221_pa_5_alyork2;

//Set variables

int input;
int input2;
string name;
string ID;
string mailingAddress;
string emailAddress;

int listingID;
string trainerName;
string date;
string time;
int cost;
bool status2;
string status;



//Menu

Console.WriteLine("Welcome to Train Like a Champion - Personal Fitness");
Console.WriteLine();
Console.WriteLine("Would you like to manage trainer data (1), manage listing data (2), manage customer booking data (3), run reports (4), or exit(5)");
input = int.Parse(Console.ReadLine());

while(input != 5)
{
    if(input == 1)
    {
        Console.WriteLine("Would you like to add (1), edit (2), or delete (3) a trainer (Press 4 for none of the options).");
        input2 = int.Parse(Console.ReadLine());
        while(input2 != 4)
        {
            if(input2 == 1)
            {
                Console.WriteLine("Please enter the name of the new trainer");
                name = Console.ReadLine();
                Trainer newTrainer = new Trainer(name);
                newTrainer.TrainerInfo();
            }
        
            else if(input2 == 2)
            {
                Console.WriteLine("What is the information for the trainer that you would like to edit, first enter name");
                name = Console.ReadLine();

                Console.WriteLine("Now ID ");
                ID = (Console.ReadLine());

                Console.WriteLine("Now mailing address");
                mailingAddress = Console.ReadLine();

                Console.WriteLine("And now email address");
                emailAddress = Console.ReadLine();


                int newID = int.Parse(ID);

                Trainer oldTrainer = new Trainer(newID, name, mailingAddress, emailAddress);
                oldTrainer.GetName();
                oldTrainer.GetID();
                oldTrainer.GetMailingAddress();
                oldTrainer.GetEmailAddress();

                oldTrainer.EditTrainer(ID, name, mailingAddress, emailAddress);
                oldTrainer.TrainerInfo();
            }
            else if(input2 == 3)
            {
                Console.WriteLine("What is the information for the trainer that you would like to delete, first enter name");
                name = Console.ReadLine();

                Console.WriteLine("Now ID ");
                ID = (Console.ReadLine());

                Console.WriteLine("Now mailing address");
                mailingAddress = Console.ReadLine();

                Console.WriteLine("And now email address");
                emailAddress = Console.ReadLine();


                int newID = int.Parse(ID);

                Trainer removeTrainer = new Trainer(newID, name, mailingAddress, emailAddress);
                removeTrainer.GetName();
                removeTrainer.GetID();
                removeTrainer.GetMailingAddress();
                removeTrainer.GetEmailAddress();

                removeTrainer.DeleteTrainer(ID, name, mailingAddress, emailAddress);
                removeTrainer.TrainerInfo();
                
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
            Console.WriteLine();
            Console.WriteLine("Would you like to add (1), edit (2), or delete (3) a trainer (Press 4 for none of the options).");
            input2 = int.Parse(Console.ReadLine());
        }




        if(input == 2)
        {
            Console.WriteLine("Would you like to add(1), edit(2), or delete(3) a listing. (Press 4 for none of the options).");
            input2 = int.Parse(Console.ReadLine());
            if(input2 == 1)
            {
                Console.WriteLine("Please enter enter all the information for the new listing, starting with listing ID:");
                listingID = int.Parse(Console.ReadLine());

                Console.WriteLine("Now trainer name:");
                trainerName = Console.ReadLine();

                Console.WriteLine("Now date:");
                date = Console.ReadLine();

                Console.WriteLine("Now time:");
                time = Console.ReadLine();

                Console.WriteLine("Now cost:");
                cost = int.Parse(Console.ReadLine());

                Console.WriteLine("And finally status");
                status = Console.ReadLine();

                if(status == "booked")
                {
                    status2 = true;
                }
                else
                {
                    status2 = false;
                }

                Listing newListing = new Listing(listingID, trainerName, date, time, cost, status2);
                newListing.ListingInfo();

            }
            else if(input2 == 2)
            {
                Console.WriteLine("Please enter enter all the information for the listing, starting with listing ID:");
                listingID = int.Parse(Console.ReadLine());

                Console.WriteLine("Now trainer name:");
                trainerName = Console.ReadLine();

                Console.WriteLine("Now date:");
                date = Console.ReadLine();

                Console.WriteLine("Now time:");
                time = Console.ReadLine();

                Console.WriteLine("Now cost:");
                cost = int.Parse(Console.ReadLine());

                Console.WriteLine("And finally status");
                status = Console.ReadLine();

                if(status == "booked")
                {
                    status2 = true;
                }
                else
                {
                    status2 = false;
                }

                Listing editListing = new Listing(listingID, trainerName, date, time, cost, status2);
                editListing.GetListingID();
                editListing.GetTrainerName();
                editListing.GetDate();
                editListing.GetTime();
                editListing.GetCost();
                editListing.GetListingStatus();

                string newListingId = listingID.ToString();

                editListing.EditListing(newListingId, trainerName, date, time, cost, status2);
                editListing.ListingInfo();

            }
            else if(input2 == 3)
            {
                Console.WriteLine("Please enter enter all the information for the listing, starting with listing ID:");
                listingID = int.Parse(Console.ReadLine());

                Console.WriteLine("Now trainer name:");
                trainerName = Console.ReadLine();

                Console.WriteLine("Now date:");
                date = Console.ReadLine();

                Console.WriteLine("Now time:");
                time = Console.ReadLine();

                Console.WriteLine("Now cost:");
                cost = int.Parse(Console.ReadLine());

                Console.WriteLine("And finally status");
                status = Console.ReadLine();

                if(status == "booked")
                {
                    status2 = true;
                }
                else
                {
                    status2 = false;
                }

                Listing deleteListing = new Listing(listingID, trainerName, date, time, cost, status2);
                deleteListing.GetListingID();
                deleteListing.GetTrainerName();
                deleteListing.GetDate();
                deleteListing.GetTime();
                deleteListing.GetCost();
                deleteListing.GetListingStatus();

                string newListingId = listingID.ToString();

                deleteListing.DeleteListing(newListingId, trainerName, date, time, cost, status2);
                deleteListing.ListingInfo();
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
            Console.WriteLine();
            Console.WriteLine("Would you like to add(1), edit(2), or delete(3) a listing. (Press 4 for none of the options).");
            input2 = int.Parse(Console.ReadLine());
        }
        if(input == 3)
        {
            
        }
        
    }

    
}




