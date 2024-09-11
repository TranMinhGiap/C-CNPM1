using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP1
{
    public class SinhVien
    {
        public void B1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("input number element: ");
            int n = int.Parse(Console.ReadLine());
            while (n < 0)
            {
                Console.WriteLine("input number element: ");
                n = int.Parse(Console.ReadLine());
            }
            int[] Arr = new int[n];
            int sum = 0;
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                Arr[i] = rd.Next(1, 21);
                sum += Arr[i];
            }
            foreach (int i in Arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("tổng các phần tử có trong mảng là : {0}", sum);
        }
        public void B2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("input string : ");
            string str = Console.ReadLine();
            int ans = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]) || Char.IsLetter(str[i]))
                {
                    ans++;
                }
            }
            Console.WriteLine("số lương ký tự trong chuỗi là : {0}", ans);
        }
        public void B3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("input number element: ");
            int n = int.Parse(Console.ReadLine());
            while (n < 0)
            {
                Console.WriteLine("input number element: ");
                n = int.Parse(Console.ReadLine());
            }
            int[] Arr = new int[n];
            int ans = int.MinValue;
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                Arr[i] = rd.Next(1, 21);
                ans = Math.Max(Arr[i], ans);
            }
            foreach (int i in Arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("giá trị max trong mảng là : {0}", ans);
        }
        public void B4()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập 1 chuỗi bất kỳ : ");
            string str = Console.ReadLine();
            char[] Arr = str.ToCharArray();
            Array.Reverse(Arr);
            string str1 = new string(Arr);
            Console.WriteLine("chuỗi ban đầu : {0} || chuỗi đảo ngược là : {1}", str, str1);
        }
        public void B5()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập số lượng phần tử của mảng");
            int n = int.Parse(Console.ReadLine());
            while (n < 0)
            {
                Console.WriteLine("input number : ");
                n = int.Parse(Console.ReadLine());
            }
            int[] Arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhập phần tử thứ {0} : ", i + 1);
                Arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in Arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            bool check = true;
            for (int i = 0; i < n / 2; i++)
            {
                if (Arr[i] != Arr[n - i - 1])
                {
                    check = false;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine("đối xứng");
            }
            else
            {
                Console.WriteLine("không đối xứng");
            }
        }
        public void B6()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập chuỗi ký tự bất kỳ : ");
            string str = Console.ReadLine();
            Console.WriteLine("nhập ký tự : ");
            char c = char.Parse(Console.ReadLine());
            int ans = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    ans++;
                }
            }
            Console.WriteLine("có {0} ký tự {1} trong chuỗi !", ans, c);
        }
    }
}