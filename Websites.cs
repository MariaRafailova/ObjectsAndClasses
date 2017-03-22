using System;
using System.Collections.Generic;
using System.Linq;

namespace Websites
{
   public class Websites
    {
        public static void Main()
        {
            List<Website> output = new List<Website>();

            var input = Console.ReadLine();            

            while (input != "end")
            {
                var parts = input
                    .Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var host = parts[0];
                var domain = parts[1];

                List<string> query = parts
                     .Skip(2)
                     .ToList();

                Website newWebsite = new Website();

                if (parts.Count >1)
                {                    
                        newWebsite.Host = host;
                        newWebsite.Domain = domain;
                        newWebsite.Queries = query;                   

                    output.Add(newWebsite);
                }
                else
                {                   
                        newWebsite.Host = host;
                        newWebsite.Domain = domain;                                          

                    output.Add(newWebsite);
                }                

                input = Console.ReadLine();                
            }

            foreach (Website item in output)
            {
                if (item.Queries.Count > 1)
                {
                    Console.WriteLine($"https://www.{item.Host}.{item.Domain}/query?=[{string.Join("]&[", item.Queries)}]");
                }
                else 
                {
                    Console.WriteLine($"https://www.{item.Host}.{item.Domain}");
                }             
            }
        }
    }


}
