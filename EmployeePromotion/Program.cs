using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePromotion
{
    class EmployeePromotion
    {
        static void Main(string[] args)
        {
            String input;
            Console.WriteLine("Please enter the employee names in the order of their eligiblity for promotion (Please enter blank to stop)");
            List<string> Names = new List<string>();
            do
            {
                input = Console.ReadLine();
                Names.Add(input);
            } while (!string.IsNullOrWhiteSpace(input));


            //Console.WriteLine("Please enter the name of the employee to check promotion position");
            //String name = Console.ReadLine();
            //int idx = Names.IndexOf(name);
            //Console.WriteLine("{0} is in the position {1} for promotion.", name, idx + 1);



            //int size = Names.Capacity;
            //Console.WriteLine("The Current Size of the collection is {0}", size);
            //try
            //{
            //    foreach (string nam in Names)
            //    {
            //        if (string.IsNullOrWhiteSpace(nam))
            //        {
            //            Names.Remove(" ");
            //            break;
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception {0}", e);
            //}
            //Names.TrimExcess();
            //Console.WriteLine("The Size after removing the extra space is {0}", Names.Capacity);




            //Names.Sort();
            //foreach (string nam in Names)
            //{
            //    Console.WriteLine(nam);
            //}
            Console.ReadKey();
        }
    }
    
}
