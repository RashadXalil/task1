using System;

namespace Hometask1
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
        }

        static void task1()

        {
            #region task1
            //Array-də(minimum 5 element olsun) 2-yə bölünən elementlərin sayının çap edilməsi algorithmini qurun
            int[] a = { 3, 5, 8, 9, 11, 13, 13535646 };
            int count = 0;
            if (a.Length >= 5)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] % 2 == 0)
                    {

                        count++;

                    }
                }
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("Minimum 5 elemet daxil et : ");
            }
            #endregion
        }
        static void task2()
        {
            #region task2
            //Array-də(minimum 5 element olsun) elementlərdən ən azı 1-i n ədədindən böyükdürsə true əks halda false çap etmək algorithmi qurun
            Console.WriteLine("N ededini daxil edin : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = { 3, 4, 1, 45, 32, 12, };

            if (arr.Length >= 5)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > n)
                    {
                        Console.WriteLine("True");
                        return;
                    }
                }
                Console.WriteLine("False");

            }
            else
            {
                Console.WriteLine("Minimum 5 eded daxil et : ");
            }
            #endregion
        }
        static void task3()
        {
            #region task3
            //Array-də(minimum 5 element olsun) bütün elementlər cütdürsə true əks halda false çap etmək algorithmi qurun
            int[] arr = { 4, 8, 10, 14, 12, 31 };
            int k = 0;
            if (arr.Length >= 5)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        k++;
                    }

                }
                if (k == arr.Length)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }

            }
            else
            {
                Console.WriteLine("Minimum 5 eded daxil et : ");
            }
            #endregion
        }
        static void task4()
        {
            #region task4   
            //Array-də(minimum 5 element olsun) tək index-də duran elementlərin cəmini tapma
            int[] arr = { 6, 7, 4, 3, 6, 7, 8, 9, 12 };
            //sum -tek index elemet cemi
            int sum = 0;

            if (arr.Length >= 5)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        sum = sum + arr[i];
                    }
                    i++;
                }
                Console.WriteLine("cem = " + sum);
            }
            else
            {
                Console.WriteLine("Minimum 5 eded daxil et : ");
            }
            #endregion
        }
        static void task5()
        {
            #region task5
            //Ədədin cüt rəqəmlərini çap edən alqoritmi qurun
            Console.WriteLine("Ededi daxil edin : ");
            int m = Convert.ToInt32(Console.ReadLine());
            // m- daxil etdiyimiz eded



            while (m!=0)
            {

                int n = m % 10;
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                    m = (m - m % 10) / 10;
                }
                else
                {
                    m = (m - m % 10) / 10;
                }
            }

            #endregion
        }
        static void task6()
        {
            #region task6
            //Ədədin istənilən qüvvətini tapan alqoritmi qurmaq
            Console.WriteLine("Ededi daxil edin : ");
            int m = Convert.ToInt32(Console.ReadLine());
            // m - eded 
            Console.WriteLine("Quvveti daxil edin : ");
            int n = Convert.ToInt32(Console.ReadLine());
            // n- quvvet 
            int t = 1;
            int i = 1;
            while (i <= n)
            {
                t = t * m;
                i++;
            }
            Console.WriteLine(t);

            #endregion
        }
        static void task7()
        {
            #region task7
            //Array - də(minimum 5 element olsun) cüt ədədlərlə tək ədədlərin fərqini tapan algorithmi qurun

            int[] arr = { 2, 3, 4, 5, 6, 7, 8 };
            int cut = 0;
            int tek = 0;
            if (arr.Length >= 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        cut = cut + arr[i];
                    }
                    else
                    {
                        tek = tek + arr[i];
                    }

                }
                if (cut > tek)
                {
                    Console.WriteLine(cut - tek);
                }
                else if (cut == tek)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(tek - cut);
                }

            }
            else
            {
                Console.WriteLine("Minimum 5 eded daxil et : ");
            }




            #endregion
        }
        static void task8()
        {
            #region task8
            //Array-də(minimum 5 element olsun) 3 rəqəmli ədədlərlə digər ədədlər arasındakı fərqi tapan algorithmi qurun
            //2721
            int[] arr = { 40, 153, 126, 2586, 95, 124 };
            int ucreqemli = 0;
            int diger = 0;
            //i = index
            int i = 0;
            int dovrsayi = 0;
            // t- for dovr sai

            if (arr.Length >= 5)
            {
                while (i < arr.Length)
                {
                    int arr1 = arr[i];
                    while (arr[i] > 0)
                    {
                        arr[i] = (arr[i] - arr[i] % 10) / 10;
                        dovrsayi++;
                    }

                    if (dovrsayi == 3)
                    {
                        ucreqemli = ucreqemli + arr1;
                    }
                    else
                    {
                        diger = diger + arr1;
                    }
                    i++;
                    dovrsayi = 0;
                }
                if (ucreqemli > diger)
                {
                    Console.WriteLine(ucreqemli - diger);
                }
                else
                {
                    Console.WriteLine(diger - ucreqemli);
                }

            }
            else
            {
                Console.WriteLine("Minimum 5 eded daxil edin :");
            }
            #endregion
        }
        static void task9()
        {
            #region task9
            // Array-i(minimum 5 element olsun) tərsinə çevirən(reverse) algorithmi qurun(Misal: [10, 45, 32, 48, 72] => [72, 48, 32, 45, 10]
            int[] arr = { 11, 33, 324, 129, 328, 436, 4345 };
            if (arr.Length >= 5)
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("Minimum 5 eded daxil et ; ");
            }
            #endregion
        }

    }

}


    

