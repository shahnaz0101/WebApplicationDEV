using Microsoft.AspNetCore.Mvc;


namespace WebApplicationDEV.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SorterController : ControllerBase
    {
        
       public SorterController()
        { }
            [HttpPost("StringSorter")]
            public void GetSortString(string[] valuee)
            {
                string[] values = { "Samaya", "Vugar", "Novruz", "Narmina", "Edward" };

                foreach (string value in values)
                {
                    return  ;
                }
                Array.Sort(values);
                
                foreach (string value in values)
                {
                   return ;
                }
                
            }



            [HttpPost("IntSorter")]
            public void GetSort(string[] array)
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



        [HttpPost("CharSorter")]
        public static char[] Sort(char[] unsorted)
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
    

