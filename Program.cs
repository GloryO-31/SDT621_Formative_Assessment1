using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmfuleniMunicipality_SectionB1
{
    // 1. The Resident Class (Required for LO5)
    public class Resident
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }

        public Resident(string name, int age)
        {
            Name = name;
            Age = age;
            // Logical check for groups
            Group = (age >= 60) ? "Senior Citizen" : "General Resident";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. LO11: Using a Queue to model the workflow
            Queue<Resident> serviceQueue = new Queue<Resident>();

            Console.WriteLine("--- Emfuleni Municipality Service Desk ---");

            // Adding residents to the queue to simulate a "Workflow"
            serviceQueue.Enqueue(new Resident("Glory", 30));
            serviceQueue.Enqueue(new Resident("Tshire", 26));
            serviceQueue.Enqueue(new Resident("Onthatile", 70));

            Console.WriteLine($"\n{serviceQueue.Count} residents are currently in the queue...");
            Console.WriteLine("Processing workflow...\n");

            // 3. Processing the queue (The actual simulation)
            while (serviceQueue.Count > 0)
            {
                Resident current = serviceQueue.Dequeue();
                Console.WriteLine("PROCESSING");
                Console.WriteLine($"Name: {current.Name}");
                Console.WriteLine($"Age: {current.Age}");
                Console.WriteLine($"Assigned to: {current.Group}");
                Console.WriteLine("Status: Ticket Resolved.");
                Console.WriteLine("----------------------------");
            }

            Console.WriteLine("\nAll residents processed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}