using Projet_DAL.Entities;
using Projet_DAL.Services;
using System;
using System.Collections.Generic;

namespace Test_DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperService devService = new DeveloperService();
            IEnumerable<Developer> devs = devService.Get();

            foreach (Developer dev in devs)
            {
                Console.WriteLine(dev.DevName);
                Console.WriteLine(dev.IdDev);
            }

            Developer dev1 = devService.Get(1);
            Console.WriteLine(dev1.DevName);

            Developer dev2 = new Developer()
            {
                DevName = "Orianne",
                DevFirstName = "Maya",
                DevBirthDate = new DateTime(1987, 06, 18),
                DevHourCost = 80,
                DevDayCost = 500,
                DevMonthCost = 6000,
                DevMail = "maya.orianne@gmail.com",
            };
            int idInserted = devService.Insert(dev2);

            Console.WriteLine(idInserted);
            foreach (Developer dev in devs)
            {
                Console.WriteLine(dev.DevName);
                Console.WriteLine(dev.IdDev);
            }

        }


    }
}
