﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hash table demo");
            //MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            //hash.Add("0", "To");
            //hash.Add("1", "be");
            //hash.Add("2", "or");
            //hash.Add("3", "not");
            //hash.Add("4", "to");
            //hash.Add("5", "be");
            //string hash5 = hash.Get("5");
            //Console.WriteLine("5th index value: " + hash5);
            //string hash2 = hash.Get("2");
            //Console.WriteLine("2th index value: " + hash2);
            Count_Frequency("to be or not to be");
            Console.ReadKey();
        }
        public static void Count_Frequency(string line)
        {
            string[] lineArray = line.Split(' ');
            List<MyMapNode<string,int>> hash = new List<MyMapNode<string, int>>();
            foreach (string word in lineArray)
            {
                if (true)
                {
                    //int count = hash.Values;
                    //hash.Add(word, count + 1);
                }
                else
                {
                    //hash.Add(word, 1);
                }
            }
        }
    }

}
