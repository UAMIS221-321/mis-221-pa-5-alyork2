namespace mis_221_pa_5_alyork2
{
    public class Report
    {

        public Report()
        {

        }
        public void InvididualReport(string email)
        {
            string fileText;
            string[] sections;
            string[] booked = new string[365];
            int count = 0;
            string answer;

            StreamReader fileIn = new StreamReader("transactions.txt");
            
            while((fileText= fileIn.ReadLine()) != null)
            {
                sections= fileText.Split(" ");

                if(sections[3] == email)
                {
                    booked[count] = email;
                    count++;
                }
            }
            fileIn.Close();

            Console.WriteLine("Individual Customer Report: ");
            Console.WriteLine();

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(booked[i]);
            }

            Console.WriteLine("Would you like to save this report?");
            answer = Console.ReadLine();

            if(answer == "yes")
            {
                StreamWriter reportOut = new StreamWriter("report.txt");

                for(int i = 0; i < count; i++)
                {
                    Console.WriteLine(booked[i]);
                }
                reportOut.Close();
            }
        }

            public void HistoricalSession()
            {
                string fileText;
                string[] sections;
                string[] booked = new string[365];
                int[] amount = new int[100];
                int count = 0;
                int counter = 0;
                string order;
                string answer;
                string name = "";
                string date = "";

                StreamReader fileIn = new StreamReader("transactions.txt");


                while((fileText= fileIn.ReadLine()) != null)
                {
                    count++;
                    sections = fileText.Split(" ");
                    for(int i = 0; i < sections.Length; i++)
                    {
                        name = sections[1];
                        booked[i] = name;
                        counter++;
                        date = sections[3];

                    }
                
                }

                fileIn.Close();

                Console.WriteLine("Historical Customer Report: ");
                Console.WriteLine();


                for(int i = 0; i < booked.Length; i++)
                {
                    for(int j = i + 1; j < booked.Length; j++)
                    {
                        if(booked[j][0] > booked[i][0])
                        {
                            order = booked[i];
                            booked[i] = booked[j];
                            booked[j] = order;
                        }
                        
                    }
                }

                for(int k = 0; k < count; k++)
                {
                    Console.WriteLine("Name: " + booked[k] +" Number of Sessions: " + counter + "Date: " + date);
                }

                Console.WriteLine("Would you like to save this report?");
                answer = Console.ReadLine();

                if(answer == "yes")
                {
                    StreamWriter reportOut = new StreamWriter("report.txt");

                    for(int k = 0; k < count; k++)
                    {
                        Console.WriteLine("Name: " + booked[k] +" Number of Sessions: " + counter + "Date: " + date);
                    }
                    reportOut.Close();
                }
            }
        public void Revenue()
        {
            
            string fileText;
            string[] sections;
            string[] booked = new string[365];
            int[] amount = new int[100];
            int number;
            int revenue = 0;
            string answer;

            StreamReader fileIn = new StreamReader("listing.txt");


            while((fileText= fileIn.ReadLine()) != null)
            {
                sections = fileText.Split(" ");
                for(int i = 0; i < sections.Length - 1; i++)
                {
                    number = int.Parse(sections[4]);
                    amount[i] = number;
                }
                    
            }
            for(int j = 0; j < amount.Length - 1; j++)
            {
                revenue = revenue + amount[j];
            }
            Console.WriteLine("Revenue: ");
            Console.WriteLine();
            Console.WriteLine("$" + revenue);

            Console.WriteLine("Would you like to save this report?");
                answer = Console.ReadLine();

                if(answer == "yes")
                {
                    StreamWriter reportOut = new StreamWriter("report.txt");

                    Console.WriteLine("Revenue: ");
                    Console.WriteLine();
                    Console.WriteLine(revenue);

                    reportOut.Close();
                }
        }
    }

}
    
