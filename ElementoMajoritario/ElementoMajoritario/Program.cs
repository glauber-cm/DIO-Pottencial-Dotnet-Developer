﻿using System;

namespace ElementoMajoritario
{
    class Program
    {

        public static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] num = new int[n];

            // TODO: Crie as outras condições necessárias para a resolução do desafio:
            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(MajorityElement(num));

        }

        public static int MajorityElement(int[] nums)
        {
            int major = nums[0];
            int count = 0;
            for (int i = 0; i != nums.Length; i++)
            {
                if ( count == 0 )
                {
                    major = nums[i];
                    count = 1;
                }
                else
                {
                    if (major == nums[i])
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                }
            }
            return major;
        }

    }
}