using System.Collections.Generic;
using System.Diagnostics;

namespace Day1CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a task number (1 or 2) as a command-line argument.");
                return;
            }

            var timer = new Stopwatch();
            int taskNumber;

            if (!int.TryParse(args[0], out taskNumber) || (taskNumber != 1 && taskNumber != 2))
            {
                Console.WriteLine("Invalid task number. Please provide 1 or 2 as a command-line argument.");
                return;
            }

            if (taskNumber == 1)
            {
                timer.Start();
                var task1Result = ComputeTask1();
                timer.Stop();
                Console.WriteLine($"Task 1: Time elapsed: {timer.ElapsedMilliseconds} ms. Result is {task1Result}.");
                timer.Reset();
            }

            if (taskNumber == 2)
            {
                timer.Start();
                var task2Result = ComputeTask2();
                timer.Stop();
                Console.WriteLine($"Task 2: Time elapsed: {timer.ElapsedMilliseconds} ms. Result is {task2Result}.");
                timer.Reset();
            }            
        }

        private static int ComputeTask1()
        {
            var lists = ReadLists();
           
            lists.First.Sort();
            lists.Second.Sort();

            int result = 0;
            for (int i = 0; i < lists.First.Count; i++)
            {
                result += Math.Abs(lists.First[i] - lists.Second[i]);
            }

            return result;
        }

        private static int ComputeTask2()
        {
            var lists = ReadLists();

            // Create a dictionary to store the counts of each element in the Second list
            var secondCounts = new Dictionary<int, int>();
            foreach (var number in lists.Second)
            {
                if (secondCounts.ContainsKey(number))
                {
                    secondCounts[number]++;
                }
                else
                {
                    secondCounts[number] = 1;
                }
            }

            int result = 0;
            foreach (var number in lists.First)
            {
                if (secondCounts.TryGetValue(number, out int count))
                {
                    result += number * count;
                }
            }

            return result;            
        }

        private static TwoLists ReadLists()
        {
            var twoLists = new TwoLists();

            string[] lines = File.ReadAllLines("input1.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length > 0)
                {
                    twoLists.First.Add(int.Parse(parts[0]));
                }
                if (parts.Length > 1)
                {
                    twoLists.Second.Add(int.Parse(parts[1]));
                }
            }

            return twoLists;
        }

        private class TwoLists
        {
            public List<int> First { get; set; } = new List<int>();
            public List<int> Second { get; set; } = new List<int>();
        }
    }    
}
