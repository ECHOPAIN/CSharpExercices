using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CS.Impl._03_Linq
{
    public class Linq
    {
        public IEnumerable<string> FindStringsWhichStartsAndEndsWithSpecificCharacter(string startCharacter, string endCharacter, IEnumerable<string> strings)
        {
            List<String> res = new List<string>();
            foreach(String s in strings)
            {
                if(startCharacter.Equals(s.Substring(0, 1))  &&  (endCharacter.Equals(s.Substring(s.Length-1)))){
                    res.Add(s);
                }
            }
            return res;
        }

        public IEnumerable<int> GetGreaterNumbers(int limit, IEnumerable<int> numbers)
        {
            List<int> res = new List<int>();
            foreach (int i in numbers)
            {
                if (i>limit)
                {
                    res.Add(i);
                }
            }
            return res;
        }

        public IEnumerable<int> GetTopNRecords(int limit, IEnumerable<int> numbers)
        {
            
            List<int> res = new List<int>();
            foreach (int i in numbers)
            {
                res.Add(i);
            }

            res.Sort((a, b) => b.CompareTo(a));
            return res.Take(limit);
        }

        public IDictionary<string, int> GetFileCountByExtension(IEnumerable<string> files)
        {
            var res =
                from s in files
                group s by (Path.GetExtension(s.ToLower())) into g
                select new
                {
                    Key = Path.GetExtension(g.Key.ToLower()),
                    Value = g.Count()
                };

            return res.ToDictionary(x => x.Key.Substring(1), x => x.Value);


            throw new NotImplementedException();
        }

        public IEnumerable<Tuple<string, string, int, double>> GetFinalReceipe(List<Item> items, List<Client> clients, List<Purchase> purchases)
        {
            throw new NotImplementedException();
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public double Price { get; set; }
    }

    public class Purchase
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int ClientId { get; set; }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
