﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("【プログラムの作成・実行　問題1】");
            Console.WriteLine("海藤一臣");
            Console.WriteLine("");

            Console.WriteLine("【プログラムの作成・実行　問題2】");
            string s1 = Console.ReadLine();
            Console.WriteLine(s1);
            Console.WriteLine(s1);
            Console.WriteLine("");

            Console.WriteLine("【組込み演算子　問題1】");
            Console.WriteLine("2つの数値を入力して下さい：");
            string line = Console.ReadLine();
            string[] array = line.Split(' ');
            int num1 = int.Parse(array[0]);
            int num2 = int.Parse(array[1]);
            Console.WriteLine("＋：{0}", num1 + num2);
            Console.WriteLine("－：{0}", num1 - num2);
            Console.WriteLine("×：{0}", num1 * num2);
            Console.WriteLine("÷：{0}", num1 / num2);
            Console.WriteLine("");

            Console.WriteLine("【組込み演算子　問題2】");
            //Console.WriteLine("2つの数値を入力して下さい：");
            //string line2 = Console.ReadLine();
            //string[] array2 = line2.Split(' ');
            //short num12 = short.Parse(array2[0]);
            //double num22 = double.Parse(array2[1]);
            //Console.WriteLine("＋：{0}", num1 + num2);
            //Console.WriteLine("－：{0}", num1 - num2);
            //Console.WriteLine("×：{0}", num1 * num2);
            //Console.WriteLine("÷：{0}", num1 / num2);
            //Console.WriteLine("");
            Console.Write("input a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("input b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("{0} + {1} = {2}\n", a, b, a + b);
            Console.Write("{0} - {1} = {2}\n", a, b, a - b);
            Console.Write("{0} * {1} = {2}\n", a, b, a * b);
            Console.Write("{0} / {1} = {2}\n", a, b, a / b);

            Console.WriteLine("【組込み演算子　問題3】");
            Console.Write("実部を入力してください: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("虚部を入力してください: ");
            double y = double.Parse(Console.ReadLine());
            double norm = x * x + y * y;
            Console.Write("{0} + i({1}) の逆数は {2} + i({3})\n)", x, y, x / norm, -y / norm);

            Console.WriteLine("【組込み演算子　問題4】");
            Console.Write("半径を入力してください: ");
            int h = int.Parse(Console.ReadLine());
            int mnsk = (int)(h * h * 3.14);
            Console.Write("面積は {0} 平方センチメートル", mnsk);

            Console.WriteLine("【組込み演算子　問題5】");
            Console.Write("身長を入力してください: ");
            double x2 = int.Parse(Console.ReadLine());
            Console.Write("体重を入力してください: ");
            double y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("BMI = 体重(kg)÷{ 身長(m)×身長(m)}");
            double x2_ = x2 / 100;
            double bmi = y2 / (x2_ * x2_);
            //double bmi = y2 / ((x2/100) * (x2/100));
            Console.Write("{0} = {1} ÷ [ {2}  x  {3}] ", bmi, y2, x2 / 100, x2 / 100);

            Console.WriteLine("【組込み型変換　問題1】");
            char[] c;
            c = new char[] { 'A', 'B', 'C' };
            Console.Write("文字を入力してください: ");
            var str = Console.ReadLine();
            c = str.ToCharArray();
            int i = (int)c[0];
            Console.Write("文字コード:" + i );

            Console.WriteLine("【組込み型変換　問題2】");
            Console.Write("数値1を入力してください: ");
            double dx = double.Parse(Console.ReadLine());
            Console.Write("数値2を入力してください: ");
            double dy = double.Parse(Console.ReadLine());
            double dz = dx/ dy;
            long dz_ = (long)(dx / dy);
            Console.WriteLine("割り算の結果　（整数）：{0}" , dz_);
            Console.WriteLine("割り算の結果（非整数）：{0}", dz);

            Console.WriteLine("【組込み型変換　問題3】");
            Console.Write("数値（正の数）を入力してください: ");
            double dx2 = double.Parse(Console.ReadLine());
            int ix2 = (int)dx2;
            Console.Write("数値（負の数）を入力してください: ");
            double dx2_ = double.Parse(Console.ReadLine());
            int ix2_ = (int)dx2_;
            Console.WriteLine("切り詰め結果（正の数）：{0}", ix2);
            Console.WriteLine("切り詰め結果（負の数）：{0}", ix2_);
            Console.WriteLine("結論：切捨てられました。");

            Console.WriteLine("【条件分岐　問題1】");
            Console.Write("数値を入力してください: ");
            int in3 = int.Parse(Console.ReadLine());
            int syou = Math.DivRem(in3, 2, out int remainder);
            if (0 == remainder)
            {
                Console.WriteLine("偶数です。");
            }
            else
            {
                Console.WriteLine("奇数です。");
            }

            Console.WriteLine("【条件分岐　問題2】");
            Console.Write("身長を入力してください: ");
            double x3 = int.Parse(Console.ReadLine());
            Console.Write("体重を入力してください: ");
            double y3 = int.Parse(Console.ReadLine());
            Console.WriteLine("BMI = 体重(kg)÷{ 身長(m)×身長(m)}");
            double x3_ = x3 / 100;
            double bmi2 = y3 / (x3_ * x3_);
            Console.WriteLine("{0} = {1} ÷ [ {2}  x  {3}]", bmi, y3, x3 / 100, x3 / 100);
            if (bmi2 < 19.8)
            {
                Console.Write("やせ型");
            }
            if (19.8 <= bmi2 && bmi2 < 24.2)
            {
                Console.Write("普通");
            }
            if (24.2 <= bmi2 && bmi2 < 26.4)
            {
                Console.Write("やや肥満（過体重）");
            }
            if (26.4 <= bmi2 && bmi2 < 35.0)
            {
                Console.Write("肥満");
            }
            if (35.0 <= bmi2)
            {
                Console.Write("高度肥満（要治療）");
            }

            Console.WriteLine("【条件分岐　問題3】");
            Console.Write("整数を入力してください: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                Console.Write("{0} は平方数です。\n", n);
                break;
                case 2 * 2: goto case 1;
                case 3 * 3: goto case 1;
                case 4 * 4: goto case 1;
                case 5 * 5: goto case 1;
                case 6 * 6: goto case 1;
                case 7 * 7: goto case 1;
                case 8 * 8: goto case 1;
                case 9 * 9: goto case 1;
                case 10 * 10: goto case 1;
                case 11 * 11: goto case 1;
                case 12 * 12: goto case 1;
                default:
                Console.Write("{0} は平方数ではない、又は、150以上です\n", n);
                break;
            }

            Console.WriteLine("【条件分岐　問題4】");
            Console.Write("整数を入力してください1: ");
            double x4 = double.Parse(Console.ReadLine());
            Console.Write("整数を入力してください: ");
            double y4 = double.Parse(Console.ReadLine());
            Console.Write("整数を入力してください: ");
            double z4 = double.Parse(Console.ReadLine());
            if (x4 > y4)
            {
                if (x4 > z4)
                {
                    if (y4 > z4) Console.Write("最大 {0}, 中間 {1}, 最小 {2}\n", x4, y4, z4);
                    else Console.Write("最大 {0}, 中間 {1}, 最小 {2}\n", x4, z4, y4);
                }
                else Console.Write("最大 {0}, 中間 {1}, 最小 {2}\n", z4, x4, y4);
            }
            else
            {
                if (y4 > z4)
                {
                    if (x4 > z4) Console.Write("最大 {0}, 中間 {1}, 最小 {2}\n", y4, x4, z4);
                    else Console.Write("最大 {0}, 中間 {1}, 最小 {2}\n", y4, z4, x4);
                }
                else Console.Write("最大 {0}, 中間 {1}, 最小 {2}\n", z4, y4, x4);
            }

            Console.WriteLine("【反復処理　問題1】");
            Console.Write("整数を入力してください1: ");
            int i5 = int.Parse(Console.ReadLine());
            int sum1 = 0;
            for (int i = 0; i <= i5; i++)
            {
                sum1 = i + sum1;
            }
            Console.Write("loop処理の和は {0}です。\n", sum1);
            int sum2 = 0;
            sum2 = (i5 * (i5 + 1)) / 2;
            Console.Write("公式による和は {0}です。\n", sum2);

            Console.WriteLine("【反復処理　問題2】");
            Console.Write("整数を入力してください: ");
            int i6 = int.Parse(Console.ReadLine());
            int i_;
            for (i_ = 0; i_ <= i6; i_++ )
            {
                if (i6 == i_*i_) break;
            }
            if (i_ <= i6) Console.Write("{0} = {1} × {1} は平方数です\n", i6, i_);
            else Console.Write("{0} は平方数ではありません\n", i6);

            */



            Console.ReadKey();



        }


    }
}
