namespace mis_221_pa_5_alyork2
{
    public class Booking
    {
        private int mySessionId;
        private string customerName;
        private string customerEmail;
        private string trainingDate;
        private int trainerID;
        private string trainerName;
        private string status = "booked";

        public Booking(int sessionID, string cusName, string cusEmail, string date, int trainID, string trainName, string bookStatus)
        {
            this.mySessionId = sessionID;
            this.customerName = cusName;
            this.customerEmail = cusEmail;
            this.trainingDate = date;
            this.trainerID = trainID;
            this.trainerName = trainName;
            this.status = "booked";
        }

        public int GetSessionID()
        {
            return mySessionId;
        }

        public void SetSessionID(int sessionID)
        {
            this.mySessionId = sessionID;
        }

        public string GetCusName()
        {
            return customerName;
        }

        public void SetCusrName(string cusName)
        {
            this.customerName = cusName;
        }
        
        public string GetCusEmail()
        {
            return customerEmail;
        }

        public void SetCusEmail(string cusEmail)
        {
            this.customerEmail = cusEmail;
        }

        public string GetDate()
        {
            return trainingDate;
        }

        public void SetTime(string date)
        {
            this.trainingDate = date;
        }

        public int GetTrainID()
        {
            return trainerID;
        }

        public void SetTrainID(int trainID)
        {
            this.trainerID = trainID;
        }

        public string GetTrainName()
        {
            return trainerName;
        }
        public void SetTrainName(string trainName)
        {
            this.trainerName = trainName;
        }

        public string GetStatus()
        {
            return status;
        }

        public void SetListingStatus(string bookStatus)
        {
            this.status = "booked";
        }

        public void CancelledSession()
        {
            status = "cancelled";
        }

        public void FinishedSession()
        {
            status = "complete";
        }

        public void ViewSession()
        {
            string fileText;
            string input;
            string date;
            string[] sections;
            string[] booked = new string[365];
            int count = 0;
            int counter = 0;

            StreamReader fileIn = new StreamReader("transactions.txt");

            while((fileText = fileIn.ReadLine())!= null)
            {
                sections = fileText.Split(" ");
                if(sections[6] == "booked")
                {
                    booked[count] = sections[3];
                    count++;
                }

            }

            Console.WriteLine("The days that are not available for training are: " + booked);
            Console.WriteLine();
            Console.WriteLine("Would you like to book a session");
            input = Console.ReadLine();

            if(input == "Yes")
            {
                Console.WriteLine("What date would you like your session?");
                date = Console.ReadLine();
                
                for(int i = 0; i < booked.Length; i++)
                {
                    if(date == booked[i])
                    {
                        Console.WriteLine("Sorry, that date is booked");
                        counter++;
                    }
                }
                if(counter == 0)
                {
                    Console.WriteLine("Your session is now booked, have a good day!");
                }
            }
        }

        


        public void BookingInformation()
        {
            string fileName3;

            Console.WriteLine("What is the file name that you would like the booking information in?");
            fileName3 = Console.ReadLine();

            StreamWriter file3 = new StreamWriter(fileName3);

            Console.WriteLine(mySessionId + " " + customerName + " " + customerEmail + " " + trainingDate + " " + trainerID + " " + trainerName + " " + status);
            file3.Close();
        }











    }
}