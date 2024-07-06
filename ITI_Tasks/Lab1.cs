using System.Diagnostics;

namespace Lab1{
    public class Lab1{
            
        // Problem 1
        private void findTheLongestDist()
        {
            int ArrSize;
            ArrSize = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[1];
            Array.Resize(ref Arr, ArrSize);

            for (int i = 0; i < ArrSize; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int MxLength = 0;

            for (int i = 0; i < Arr.Length; i++)
                MxLength = Math.Max(MxLength, Array.LastIndexOf(Arr, Arr[i]) - i - 1);
            

            Console.WriteLine(MxLength);   
        }

        private void reverseAWord()
        {
            String str = Console.ReadLine();

            String[] splits = str.Split();
            
            Array.Reverse(splits);
            for(int i = 0 ; i < splits.Length ; i ++)
            {
                Console.Write($"{splits[i]} ");
            }
            
        }

        private void countOnes()
        {
            Stopwatch stopwatch = new Stopwatch();
            
            stopwatch.Start();

            int total1 = 0;
            // method 1 
            for (int i = 1; i < 1e8; i++)
            {
                String digits = i.ToString();
                total1 += digits.Count(ch => ch == '1');
               
            }

            int total2 = 0;
            // method 2 
            for (int i = 1; i < 1e8; i++)
            {
                int num = i; 
                while (num != 0)
                {
                    int firstDigit = num % 10;
                    if (firstDigit == 1)
                        total2++;
                    
                    num /= 10;
                }
            }

            // Method 3 : Math formula 
            int total3 = Convert.ToInt32(8 * Math.Pow(10, 8 - 1));
            
            
            Console.WriteLine(total1);
            Console.WriteLine(total2);
            Console.WriteLine(total3);
            
            
            stopwatch.Stop();
                
                
            
            
            
        }
        public static void Main()
        {
            Lab1 l = new Lab1();
            // l.findTheLongestDist();

            // l.reverseAWord();
            l.countOnes();
        }
    }
}