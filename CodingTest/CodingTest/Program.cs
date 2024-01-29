﻿using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;

namespace CodingTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 바닥 장식
            StringBuilder sb = new StringBuilder();

            string num = Console.ReadLine();
            string[] splited = num.Split(" ");
            int N = int.Parse(splited[0]);
            int M = int.Parse(splited[1]);
            char[,] floor = new char[N, M];

            int coord = 0;
            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                for (int i = 0; i < input.Length; i++)
                    floor[coord, i] = input[i];
                coord++;
                input = Console.ReadLine();
            }
            Console.WriteLine(FloorDecoration.Count(floor));
            */

            /* NQWEEN
            Console.Write("NQween 입력 : ");
            int input = int.Parse(Console.ReadLine());
            int[] qweens = new int[input];
            NQweens.Newboard(ref qweens);
            int result = 0;
            NQweens.NQween(input, 0, qweens, ref result);
            Console.WriteLine("///");
            Console.WriteLine(result);
            */

            /* ChickenTopN
            string input = Console.ReadLine();
            int N = int.Parse(input);
            List<int> grade = new List<int>(N);
            input = Console.ReadLine();
            for (int i = 0; i < N; i++)
                grade.Add(int.Parse((input.Split(" "))[i]));
            input = Console.ReadLine();
            int K = int.Parse(input);
            ChickenTopN.ChickenTOPN(K, N, ref grade);
            Console.WriteLine(string.Join(' ', grade));
            */

            /* 칸토어 집합
            StringBuilder sb = new StringBuilder();

            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                int N = int.Parse(input);
                List<char> output = new List<char>();
                CantorSet.Cantorset(N, -1, ref output);
                foreach (char c in output)
                    sb.Append(c);
                sb.AppendLine();
                input = Console.ReadLine();
            }
            Console.WriteLine(sb.ToString());
            */
        }
    }
}
