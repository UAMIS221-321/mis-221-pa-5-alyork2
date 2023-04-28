using mis_221_pa_5_alyork2;

//Set variables

int input;
int input2 = 0;
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

int sessionID; 
string cusName;
string cusEmail;
string bookDate;
int trainID;
string trainName;
string bookStatus;

string emailAddressReport;

string title = @" 

 __      __       .__                                  __            ___________             .__         .____    .__ __                     _________ .__                          .__               
/  \    /  \ ____ |  |   ____  ____   _____   ____   _/  |_  ____    \__    ___/___________  |__| ____   |    |   |__|  | __ ____   _____    \_   ___ \|  |__ _____    _____ ______ |__| ____   ____  
\   \/\/   // __ \|  | _/ ___\/  _ \ /     \_/ __ \  \   __\/  _ \     |    |  \_  __ \__  \ |  |/    \  |    |   |  |  |/ // __ \  \__  \   /    \  \/|  |  \\__  \  /     \\____ \|  |/  _ \ /    \ 
 \        /\  ___/|  |_\  \__(  <_> )  Y Y  \  ___/   |  | (  <_> )    |    |   |  | \// __ \|  |   |  \ |    |___|  |    <\  ___/   / __ \_ \     \___|   Y  \/ __ \|  Y Y  \  |_> >  (  <_> )   |  \
  \__/\  /  \___  >____/\___  >____/|__|_|  /\___  >  |__|  \____/     |____|   |__|  (____  /__|___|  / |_______ \__|__|_ \\___  > (____  /  \______  /___|  (____  /__|_|  /   __/|__|\____/|___|  /
       \/       \/          \/            \/     \/                                        \/        \/          \/       \/    \/       \/          \/     \/     \/      \/|__|                  \/ 

";

//cbum is a famous lifter so I thought it fit into the fitness theme of the PA
string cbum = @":::::::::::::::::::::::::::::::::::::::::::::::::^^J#GPBBP5GY!7???7~^:.....:::......:::::::::::::::::::::::::::::::::::::::::
::::::::::::::::::::::::::::::::::::::::::::::::^^^Y#GPGGGBB##B###BGGP?7^...:::::::::::::::::::::::::::::::::::::::::::::::::
:::::::::::::::::::::::::::::::::::::::::::::::::^^Y#GGB##&&&&&###BBGBGBG?^::.:::::::::::::::::::::::::::::::::::::::::::::::
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!77775B#&######BBBGGPPPPPPGGG5J?777777777???????????????????JJJJJJJJJJJJJJJJJJJ
BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBGGGGGGGGGGGGGGB#BGP5PPP555YYYYYJJJJY5GGGG55555555555555555555555555555555555555555555555
55555YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYJJJJG#G555555YYJJJJJJJ??????YPGB5??????????????????????????????????????????????
?????????????????????7777777777777777777777777777?BBPPP5555YYJJJJJ????????J5PBJ^~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~GGPPP555YYYJJJJJJ????????Y5P7::::::::::::::::::::::::::::::::::::::::::::::
::::::::::::::::::::::::::::::::::::::::::::::^^^!GGPPPP55YYJJJJJJ?????????JY5!::::::::::::::::::::::::::::::::::::::::::::::
:::::::::::::::::::::::::::::::::::::::::::::^^^^!GPPBBBBBBG5YJJJJY555555Y??JY!::::::::::::::::::::::::::::::::::::::::::::::
:::^::::::::::::::::^:^^^:^^^^^^^^^^^^^^^^^^^^^^~JP5GGGGGGGGBGPYJYPGGP5555Y?J5!:::::::::::^^^^^^^^^^^::::::::::::::::::::::::
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^JBP5PPGGGG55GGPJ?J5PGP5YYJJ?JYJJ::::^^^^^^^^^^^^^^^^^::::::::::^:::::::::::::
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^?BPPP55Y5555PP5J??JYYYYJJ???JYJ?:::^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^?BPPP5YYYY5PPP5J????JJJ??????JJ!::^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^!GGPPP555PGGGG5JJJJJY55J????JJ?^:^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~?5GGPBBB#####BGPGGPY5PP5JJJ?7^:^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~^JGGG#BB##BGGP55PP5GBGBPYYY7::^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^JBBBPPGGGGP5JJJY?JYY5P5YYY!:^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~!77777??Y###BGPGPP555YYJJJ?JY5555J^::^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~?YGB######&######GGP555YYYJJJYY555P5J?777!!!~~^^~~^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYJ5BB####&#BB#&#B####BGGP555YYY55PPPP5Y5YJYPP5555YJJY555555555555555555555555555555555555
GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGPGPPPPPPPG#B###BGGB#&#BB######BBBBGPGGGGP5YYY5J??YPGBBBBGP555YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY
YJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ5PPGGBBGGGG#&#BBB#######BBBBGGP5YYJY5Y??JJJJYPBBBBBGPYJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ
YYYYYYYYYYYYYYJJJJJJJJJJJJJJJJJJJJJJJJJPPPPPPPGGGB&#BBBBBBBBBBBGGP55YYJY55JJJJJJJJJJYPBB###PJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ
YYYYYYYYYYYYYJJJJJJJJJJJJJJJJJJJJJJJJJJ5PPPPPPPPPPB##BBBBBBGGGGPP5YYJY55YJJJJJJJJJJJJY5GGG5J?JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ
JJJJJJJYYYYYYYYYJJJJJJJJJJJJJJJJJJJJJJY5GGPPPPPPPPPPPBBBBBBBGPPP55YY5P5YJJJJJJJJJJJJJJJJJJJJ??JJJJJJJJJJJJJJJJJ?????????????J
7!!7777JYYYYYYYYYYYYYJJ??7777!!!!7JY5PPPGBBBGPP55555555555555YYJJ??Y5YYJJJJ?????JJJYYY5555YJ?77?JJJJJJJJJJJJJJ??777!!!~~~!!!7
!!!!!!7JYYYYYYYYYY555Y???777!!7?Y5PPPPPPPGGB#BGPPPP55YYYYJJ?77777JYYYJJJJJYY5555PGBGYJJY55YJJJ??????JJJJYYYY5Y???77!!!!!!!!!7
77!!!!7?YYYYYY5555PP5JJJJJJJYY5555555555PPPPGBBGPPGGGPYJJYPJ??JJYYYYY55555PPP555555J??J555YJJJJJJJJJJJJJYY5P5Y?7777!!!!!!!!!7
!!!!!!!!?YYY5555PPP5JJYYY5555555555555555PPPPPGBBBGPP55YYJ55JY5P55P5YYYYYYYYYYYYYJJ??JY555YJJJJJJJJJJJJJJJYPJ??777!!!!!~~~!!!
?7!777?7?Y555PPPPPP5Y555YYYYYYYYYYYYYYY555555PPPGB#BGGPP5YYPJ?Y5YJJJJJJJJJJYJJJJJJ??JY555YJJJYYYJJJJJJJJJ??YJ??77??!!!!77!?!7
5Y!JJ?YJJYYYYYY5555555PPP5YYYYYYJJYYYYYYY5555555PPPGGGGGPP5PJ?Y5YJJJJJJJJJJJJJJJJJ??JY555YJJJY5YJJJJJJJJJJ?????77Y5!!7?YYY57Y
P5?JJ??777!!!!!!?YY55555PP5YYYJJJJJJJJJYY55YYYYY5555PPPPPP5PY?J55JJJJJJJJJJJ?JJJJJ?JJYY55YJJJY5YJJJ?JJJJJJ????7!!JY!7?7Y?!5JY
GPYJJJ??77777!7J55Y555YY5PP55YJJJJJJJJJYY5YYYYYYYYY5555PP55PJ?JY5YYYYJJJJJJ??JJYJJJJJJY55JJJY55YJJ?JJJJJJ???????!JY!JY!J?!5J5
PG5YYP5Y?J7?7?Y555YYYY5YY5PP5YJJJJJJJJJY5YYJJJJYYYYYY55PP55PJ?JYYJYYYYJJJJ?JJJYYJJJJJJY5YJ?J5P5JJ??JJJJJJJJJ?????J5JYY7YYY5J5
Y55Y55YYJJ7J?555PP5YJYYYYY5PP5JJ?JYJJJJYYYJJJJJJYYYYY55PP5YPJ?JYYYYYYYJJJJ?JJJYYJJJJJJY5YJJYPPYJJ??JJJJJJJJ???????777??????JY
5555PP5YJJ?JYPP555PP5YJYYY5PG5JJ?JYYJJJYYJJJJJJJJYYYY55PP5YPY?YY5YYYYJJJJJJJJYYYJJJJJJYYJJJ5P5JJJ?JJJJJJJJJJJJJ???7!!7777??Y5
YYYY555YJJJY5PPPPP5PGGPYYY5PGPYJ?JYYJJYYYJJJJJJJJJYYY55P5YJ55JY55Y5YYJJJJJJJJYYYYJJJJJJJJJ5PPYJYYJJYYJJJJJJJJJ?????!!!7!77??Y
YYYJYYJ????555555PPPPPGGP5YPGGYJ?JJYYYYYYJJJJJJJJJJYY5555YJ55JY55Y5YYJJJJJJJYYYYJJJJJJJJJY5PPYJ5YYYYYYJJJJJJJJ?????7!!!!!77?J";

                                           

//menu
Console.WriteLine(cbum);
Console.WriteLine(title);
string text = "Welcome to Train Like a Champion - Personal Fitness";
foreach(char letter in text)
{
    Console.Write(letter);
    Thread.Sleep(75);
}
Console.WriteLine();
Console.WriteLine("Would you like to manage trainer data (1), manage listing data (2), manage customer booking data (3), run reports (4), or exit(5)");
input = int.Parse(Console.ReadLine());

while(input != 5)
{
    if(input == 1)
    {
        while(input2 != 4)
        {
            Console.WriteLine("Would you like to add (1), edit (2), or delete (3) a trainer (Press 4 for none of the options).");
            input2 = int.Parse(Console.ReadLine());
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
        }
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
            Console.WriteLine("Would you view/book a session (1), cancel a session(2), mark a session as complete (3) or none of the above(4)");
            input2 = int.Parse(Console.ReadLine());
            while(input2 != 4)
            {
                if(input2 == 1)
                {
                    Console.WriteLine("Please enter your booking information, starting with sessionID");
                    sessionID = int.Parse(Console.ReadLine());

                    Console.WriteLine("Now customer name: ");
                    cusName = Console.ReadLine();

                    Console.WriteLine("Now customer Email: ");
                    cusEmail = Console.ReadLine();

                    Console.WriteLine("Now date: ");
                    bookDate = Console.ReadLine();

                    Console.WriteLine("Now trainer ID");
                    trainID = int.Parse(Console.ReadLine());

                    Console.WriteLine("Now trainer name: ");
                    trainName = Console.ReadLine();

                    Console.WriteLine("And finally booking status: ");
                    bookStatus = Console.ReadLine();

                    Booking newBooking = new Booking(sessionID, cusName, cusEmail, bookDate, trainID, trainName, bookStatus);
                    newBooking.GetSessionID();
                    newBooking.GetCusName();
                    newBooking.GetCusEmail();
                    newBooking.GetDate();
                    newBooking.GetTrainID();
                    newBooking.GetTrainName();
                    newBooking.GetStatus();


                    newBooking.ViewSession();
                    newBooking.BookingInformation();

                }
                else if(input2 == 2)
                {
                    Console.WriteLine("Please enter your booking information, starting with sessionID");
                    sessionID = int.Parse(Console.ReadLine());

                    Console.WriteLine("Now customer name: ");
                    cusName = Console.ReadLine();

                    Console.WriteLine("Now customer Email: ");
                    cusEmail = Console.ReadLine();

                    Console.WriteLine("Now date: ");
                    bookDate = Console.ReadLine();

                    Console.WriteLine("Now trainer ID");
                    trainID = int.Parse(Console.ReadLine());

                    Console.WriteLine("Now trainer name: ");
                    trainName = Console.ReadLine();

                    Console.WriteLine("And finally booking status: ");
                    bookStatus = Console.ReadLine();

                    Booking cancelBooking = new Booking(sessionID, cusName, cusEmail, bookDate, trainID, trainName, bookStatus);
                    cancelBooking.GetSessionID();
                    cancelBooking.GetCusName();
                    cancelBooking.GetCusEmail();
                    cancelBooking.GetDate();
                    cancelBooking.GetTrainID();
                    cancelBooking.GetTrainName();
                    cancelBooking.GetStatus();


                    cancelBooking.CancelledSession();
                    cancelBooking.BookingInformation();
                }
                else if(input2 == 3)
                {
                    Console.WriteLine("Please enter your booking information, starting with sessionID");
                    sessionID = int.Parse(Console.ReadLine());

                    Console.WriteLine("Now customer name: ");
                    cusName = Console.ReadLine();

                    Console.WriteLine("Now customer Email: ");
                    cusEmail = Console.ReadLine();

                    Console.WriteLine("Now date: ");
                    bookDate = Console.ReadLine();

                    Console.WriteLine("Now trainer ID");
                    trainID = int.Parse(Console.ReadLine());

                    Console.WriteLine("Now trainer name: ");
                    trainName = Console.ReadLine();

                    Console.WriteLine("And finally booking status: ");
                    bookStatus = Console.ReadLine();

                    Booking completeBooking = new Booking(sessionID, cusName, cusEmail, bookDate, trainID, trainName, bookStatus);
                    completeBooking.GetSessionID();
                    completeBooking.GetCusName();
                    completeBooking.GetCusEmail();
                    completeBooking.GetDate();
                    completeBooking.GetTrainID();
                    completeBooking.GetTrainName();
                    completeBooking.GetStatus();


                    completeBooking.FinishedSession();
                    completeBooking.BookingInformation();
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
                Console.WriteLine();
                Console.WriteLine("Would you view/book a session (1), cancel a session(2), mark a session as complete (3) or none of the above(4)");
                input2 = int.Parse(Console.ReadLine());
            }
        }
        if(input == 4)
        {
            Console.Write("Would you like to see individual report(1), Historical report(2), Revenue(3), or none (4)");
            input2 = int.Parse(Console.ReadLine());
            while(input2 != 4)
            {
                if (input2 == 1)
                {
                    Console.WriteLine("What is the email address for the customer? ");
                    emailAddressReport = Console.ReadLine();
                    Report newReport = new Report();
                    newReport.InvididualReport(emailAddressReport);
                }
                if (input2 == 2)
                {
                    Report totalHistory = new Report();
                    totalHistory.HistoricalSession();
                }
                if(input2 == 3)
                {
                    Report totalRevenue = new Report();
                    totalRevenue.Revenue();
                }
            }
        }
        
    

    
}




