﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public Dictionary<string, object> sweepstakesDictionary;
        public Random rng;
        int registration;
        public string name;
        public Sweepstakes(string name)
        {
            sweepstakesDictionary = new Dictionary<string, object>();
            rng = new Random();
            this.name = name;
        }
        public void RunSweepstakes() //master method
        {
            for (int i = 0; i < 5; i++)
            {
                AddContestant();
            }
        }
        public void AddContestant()
        {
            Console.WriteLine("Enter contestant's first name.");
            string nameFirst = Console.ReadLine();

            Console.WriteLine("Enter contestant's last name.");
            string nameLast = Console.ReadLine();

            Console.WriteLine("Enter contestant's email address.");
            string email = Console.ReadLine();

            Console.WriteLine("Registering customer's ID.");
            registration = rng.Next(0, 100);

            Contestant newContestant = new Contestant(nameFirst, nameLast, email, registration);
            RegisterContestant(newContestant);
        }
        public void RegisterContestant(Contestant contestant)
        {
            sweepstakesDictionary.Add(registration.ToString(), contestant);
            Console.WriteLine("Contestant Registered");
        }
        public void SweepstakesDecision()
        {
            int choice = UserInterface.GetSweepstakesManager();

            switch (choice)
            {
                case 1:
                    SweepstakesStackManager sweepstakesStackManager = new SweepstakesStackManager();
                    MarketingFirm marketingFirm = new MarketingFirm(sweepstakesStackManager);
                    break;

                case 2:
                    SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
                    MarketingFirm marketingFirm2 = new MarketingFirm(sweepstakesQueueManager);
                    break;
            }
        }
    }
}
