using System.Collections.Generic;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ComputeTask1());
            Console.WriteLine(ComputeTask2());
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
           
            int result = 0;
            for (int i = 0; i < lists.First.Count; i++)
            {
                result += lists.First[i] * lists.Second.Count(x => x == lists.First[i]);
            }

            return result;
        }

        private static (List<int> First, List<int> Second) ReadLists()
        {
            var first = new List<int>();
            var second = new List<int>();

            string[] lines = File.ReadAllLines("input1.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length > 0)
                {
                    first.Add(int.Parse(parts[0]));
                }
                if (parts.Length > 1)
                {
                    second.Add(int.Parse(parts[1]));
                }
            }

            return (first, second);
        }


    }
}
