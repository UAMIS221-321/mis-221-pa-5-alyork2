namespace mis_221_pa_5_alyork2
{
    public class Trainer
    {
        private int trainerID = 1;
        private string trainerName = "";
        private string trainerMailingAddress = "";
        private string trainerEmailAddress = "";
        


        public Trainer(int ID, string name, string mailingAddress, string emailAddress)
        {
            this.trainerID = ID;
            this.trainerName = name;
            this.trainerMailingAddress = mailingAddress;
            this.trainerEmailAddress = emailAddress;
            TrainerInfo();
        }

        public Trainer(string name)
        {
            this.trainerID = trainerID++;
            this.trainerName = name;
            Console.WriteLine("What is the mailing address for this trainer?");
            this.trainerMailingAddress = Console.ReadLine();
            Console.WriteLine("What is the email address for this trainer?");
            this.trainerEmailAddress = Console.ReadLine();
        }

        public int GetID()
        {
            return trainerID;
        }

        public void SetID(int ID)
        {
            this.trainerID = ID;
        }
        
        public string GetName()
        {
            return trainerName;
        }

        public void SetName(string name)
        {
            this.trainerName = name;
        }

        public string GetMailingAddress()
        {
            return trainerMailingAddress;
        }

        public void SetMailingAddress(string mailingAddress)
        {
            this.trainerMailingAddress = mailingAddress;
        }

        public string GetEmailAddress()
        {
            return trainerEmailAddress;
        }

        public void SetEmailAddress(string emailAddress)
        {
            this.trainerEmailAddress = emailAddress;
        }

         public void EditTrainer(string ID, string name, string mailingAddress, string emailAddress)
        {
            bool foundTrainer = false;
            string input;
            string fileName;
            string fileText;
            string[] sections;
            





            Console.WriteLine("What part of the trainer information that you would like to edit?");
            input = Console.ReadLine();

            Console.WriteLine("What is the file that you would like to edit the trainer in? ");
            fileName = Console.ReadLine();

            StreamReader fileIn = new StreamReader(fileName);
            
            while((fileText = fileIn.ReadLine())!= null)
            {
                sections = fileText.Split(' ');
                if(input == "name")
                {
                    if (sections[0] == name)
                    {
                        foundTrainer = true;
                        sections[0] = "";
                        Console.WriteLine("What is the new name? ");
                        name = Console.ReadLine();
                        sections[0] = name;
                        fileIn.Close();
                    }
                    else 
                    {
                        foundTrainer = false;
                    }
                }

                else if (input == "ID")
                {
                    if (sections[1] == ID)
                    {
                        foundTrainer = true;
                        sections[1] = "";
                        Console.WriteLine("What is the new ID? ");
                        ID = Console.ReadLine();
                        sections[1] = ID;
                        fileIn.Close();

                    }
                    else 
                    {
                        foundTrainer = false;
                    }
                }
                else if(input == "mailing address")
                {
                    if(sections[2] == mailingAddress)
                    {
                        foundTrainer = true;
                        sections[2] = "";
                        Console.WriteLine("What is the new mailing address? ");
                        mailingAddress = Console.ReadLine();
                        sections[2] = mailingAddress;
                        fileIn.Close();
                    }
                    else
                    {
                        foundTrainer = false;
                    }
                }
            
                else if(input == "email address")
                {
                    if(sections[3] == emailAddress)
                    {
                        foundTrainer = true;
                        sections[3] = "";
                        Console.WriteLine("What is the new email address? ");
                        emailAddress = Console.ReadLine();
                        sections[3] = emailAddress;
                        fileIn.Close();
                    }
                    else
                    {
                        foundTrainer = false;
                    }
                }
                else
                {
                    foundTrainer = false;
                    fileIn.Close();
                }

                if(foundTrainer == true)
                {
                    Console.WriteLine("The trainer information has been edited");
                }
                else
                {
                Console.WriteLine("The trainer was not found");
                }
            }
        }
        
        public void DeleteTrainer(string ID, string name, string mailingAddress, string emailAddress)
        {
            bool foundTrainer = false;
            string input;
            string fileName;
            string fileText;
            string[] sections;
            





            Console.WriteLine("What part of the trainer information that you would like to delete?");
            input = Console.ReadLine();

            Console.WriteLine("What is the file that you would like to edit the trainer in? ");
            fileName = Console.ReadLine();

            StreamReader fileIn = new StreamReader(fileName);
            
            while((fileText = fileIn.ReadLine())!= null)
            {
                sections = fileText.Split(' ');
                if(input == "name")
                {
                    if (sections[0] == name)
                    {
                        foundTrainer = true;
                        sections[0] = "";
                        fileIn.Close();
                    }
                    else 
                    {
                        foundTrainer = false;
                    }
                }

                else if (input == "ID")
                {
                    if (sections[1] == ID)
                    {
                        foundTrainer = true;
                        sections[1] = "";
                        fileIn.Close();

                    }
                    else 
                    {
                        foundTrainer = false;
                    }
                }
                else if(input == "mailing address")
                {
                    if(sections[2] == mailingAddress)
                    {
                        foundTrainer = true;
                        sections[2] = "";
                        fileIn.Close();
                    }
                    else
                    {
                        foundTrainer = false;
                    }
                }
            
                else if(input == "email address")
                {
                    if(sections[3] == emailAddress)
                    {
                        foundTrainer = true;
                        sections[3] = "";
                        fileIn.Close();
                    }
                    else
                    {
                        foundTrainer = false;
                    }
                }
                else
                {
                    foundTrainer = false;
                    fileIn.Close();
                }

                if(foundTrainer == true)
                {
                    Console.WriteLine("The trainer information has been deleted");
                }
                else
                {
                Console.WriteLine("The trainer was not found");
                }
            }
        }
        



        public void TrainerInfo()
        {
            string fileName;

            Console.WriteLine("What is the file name that you would like the trainer information in? ");
            fileName = Console.ReadLine();

            StreamWriter file = new StreamWriter(fileName);
            file.WriteLine(trainerName + " " + trainerID + " " + trainerMailingAddress + " " + trainerEmailAddress); 

            file.Close();
        }











    }
}