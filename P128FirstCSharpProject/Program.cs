using System;

namespace P128FirstCSharpProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Comment
            //var age = 35;
            //var name = "Hamid";
            //var name1 = "HAmid";
            //var check = true;
            //char symbol = '2';
            #endregion

            #region Test
            //string name = "Hamdaf4534 5id"; // { H,a,m,i,d}
            //string name1 = "Hamdaf4534 5id"; // { H,a,m,i,d}
            //string name2 = "Hamdaf4534 5id"; // { H,a,m,i,d}
            //string name3 = "Hamdaf4534 5id"; // { H,a,m,i,d}
            #endregion

            //Variable
            //byte age = 17;
            //sbyte temperature = 127;


            //float pi = 3.14f;
            //decimal pdec = 3.14m;
            //double pdob = 3.14;

            //char symbol = '#';

            //string name = "Hamid";


            //Conditions

            //bool checkaage = age > 18;

            //if (age > 18)
            //{
            //    Console.WriteLine(temperature);
            //    Console.WriteLine("Xosh Gelmisiniz");
            //}
            //else if (age > 16)
            //{
            //    Console.WriteLine("Get Boyu Gel");
            //}
            //else if (age > 16)
            //{
            //    Console.WriteLine("Get Boyu Gel");
            //}
            //else if (age > 16)
            //{
            //    Console.WriteLine("Get Boyu Gel");
            //}
            //else
            //{
            //    Console.WriteLine("Yashiniz Chatmir");
            //}

            //byte day = 5;

            //if (day == 1)
            //{

            //}
            //else if (day == 2)
            //{

            //}
            //else if (day == 3)
            //{

            //}
            //else if (day == 4)
            //{

            //}
            //else if (day == 5)
            //{

            //}


            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Birinci");
            //        break;
            //    case 2:
            //        Console.WriteLine("Ikinci");
            //        break;
            //    case 3:
            //        Console.WriteLine("Ikinci");
            //        break;
            //    case 4:
            //        Console.WriteLine("Ikinci");
            //        break;
            //    case 5:
            //        Console.WriteLine("Ikinci");
            //        break;
            //    default:
            //        break;
            //}

            byte[] nums = { 23, 7, 15, 16, 0, 255 };

            string[] names = { "Hamid", "Murad", "Rehman" };

            //int k = 0;


            //while (k < nums.Length)
            //{
            //    Console.WriteLine(nums[k]);

            //    k++;
            //}

            //do
            //{

            //} while (true);

            //for (int test = 0; test < nums.Length; test++)
            //{
            //    Console.WriteLine(nums[test]);

            //    if (test % 2 == 0)
            //    {

            //    }
            //}

            foreach (byte elememntP128 in nums)
            {
                Console.WriteLine(elememntP128);
            }
        }
    }
}