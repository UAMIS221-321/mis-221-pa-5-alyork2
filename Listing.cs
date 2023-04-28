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





    }

}