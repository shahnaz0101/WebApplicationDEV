using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace WebApplicationDEV.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SorterController : ControllerBase
    {
       public class SortingString
        {
            [HttpPost("StringSorter")]
            public static void Main(string[] args)
            {
                string[] values = { "Samaya", "Vugar", "Novruz", "Narmina", "Edward" };

                foreach (string value in values)
                {
                    Console.Write(value + ' ');
                }
                Array.Sort(values);
                Console.WriteLine("Sorted; ");
                foreach (string value in values)
                {
                    Console.Write(value + ' ');
                }
                Console.WriteLine();
            }

        }
        public class Program
        {
            [HttpPost("IntSorter")]
            public static void GetSort(string[] array)
            {

                int[] Sort(int[] unsorted)
                {
                    //int[] longsortedarray = { 3, 2, 1 };
                    int[] sortedarray = new int[unsorted.Length];

                    for (int i = 0; i < unsorted.Length - 1; i++)

                    {
                        for (int j = 0; j < unsorted.Length - i - 1; j++)
                        {

                            if (unsorted[j] > unsorted[j + 1])
                            {
                                int temp = sortedarray[j];
                                sortedarray[j] = sortedarray[j + 1];
                                sortedarray[j + 1] = temp;
                            }
                        }

                    }
                    return sortedarray;


                }
            }

            public class Sorter
            {
                [HttpPost("CharSorter")]
            public char[] Sort(char[] unsorted)
            {
                char[] longsortedarray = new char[unsorted.Length];
                for (int i = 0; i < unsorted.Length - 1; i++)

                {
                    for (int j = 0; j < unsorted.Length - i - 1; j++)
                    {
                        int l = (int)unsorted[j];
                        int n = (int)unsorted[j + 1];

                        if (l > n)
                        {
                            char temp = longsortedarray[j];
                            longsortedarray[j] = longsortedarray[j + 1];
                            longsortedarray[j + 1] = temp;
                        }
                    }

                }
                return longsortedarray;
            }

            }



        }
    }
}
