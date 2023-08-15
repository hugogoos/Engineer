using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Sort
    {
        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static int[] Insertion(int[] source)
        {
            Console.WriteLine("快速排序");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"数据源：{string.Join(',', source)}");

            //将a[]按升序排列
            int len = source.Length;
            for (int i = 1; i < len; i++)
            {
                //将a[i]插入到a[i-1]，a[i-2]，a[i-3]……之中
                for (int j = i; j > 0 && (source[j] < source[j - 1]); j--)
                {
                    (source[j - 1], source[j]) = (source[j], source[j - 1]);

                    Console.WriteLine($"第 {i} {j} 次：{string.Join(',', source)}");
                }
            }
            

            Console.WriteLine("--------------------------------------------");
            return source;
        }

        /// <summary>
        /// 快速排序
        /// 1. 从当前元素起，向后依次比较每一对相邻元素，若逆序则交换
        /// 2. 对所有元素均重复以上步骤，直至最后一个元素
        /// </summary>
        /// <param name="source">排序目标数组</param>
        /// <returns></returns>
        public static int[] Quick(int[] source)
        {
            Console.WriteLine("快速排序");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"数据源：{string.Join(',', source)}");
            QuickSort(source, 0, source.Length - 1);
            Console.WriteLine("--------------------------------------------");
            return source;
        }

        /// <summary>
        /// 一次单元排序
        /// </summary>
        /// <param name="source">排序数组 </param>
        /// <param name="low">排序起始位置</param>
        /// <param name="high">排序结束位置</param>
        /// <returns>排序后的数组</returns>
        private static void QuickSort(int[] source, int low, int high)
        {
            if (low >= high)
                return;
            //完成一次单元排序
            int index = QuickSortUnit(source, low, high);
            //对左边单元进行排序
            QuickSort(source, low, index - 1);
            //对右边单元进行排序
            QuickSort(source, index + 1, high);
        }
        
        private static int QuickSortUnit(int[] source, int low, int high)
        {
            int key = source[low];
            Console.WriteLine($"key : {key}");
            while (low < high)
            {
                /*从后向前搜索比key小的值*/
                while (source[high] >= key && high > low)
                {
                    --high;
                }

                if (high == low)
                {
                    continue;
                }

                /*比key小的放左边*/
                source[low] = source[high];
                Console.WriteLine($"{string.Join(',', source)}");

                /*从前向后搜索比key大的值，比key大的放右边*/
                while (source[low] <= key && high > low)
                {
                    ++low;
                }

                if (high == low)
                {
                    continue;
                }

                /*比key大的放右边*/
                source[high] = source[low];
                Console.WriteLine($"{string.Join(',', source)}");
            }

            /*左边都比key小，右边都比key大。//将key放在游标当前位置。//此时low等于high */
            source[low] = key;
            Console.WriteLine($"{string.Join(',', source)}");

            return high;
        }

        /// <summary>
        /// 冒泡排序
        /// 1. 从当前元素起，向后依次比较每一对相邻元素，若逆序则交换
        /// 2. 对所有元素均重复以上步骤，直至最后一个元素
        /// </summary>
        /// <param name="source">排序目标数组</param>
        /// <returns></returns>
        public static int[] Bubble(int[] source)
        {
            Console.WriteLine("冒泡排序");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"数据源：{string.Join(',', source)}");
            var len = source.Length;

            //外循环为排序趟数，len个数进行len-1趟
            for (int i = 0; i < len - 1; i++)
            {
                //内循环为每趟比较的次数，第i趟比较len-1-i次
                for (int j = 0; j < len - 1 - i; j++)
                {
                    //相邻元素比较，若逆序（升序为左大于右，降序反之） 则交换
                    if (source[j] > source[j + 1])
                    {
                        (source[j], source[j + 1]) = (source[j + 1], source[j]);
                    }

                    Console.WriteLine($"第 {i} {j} 次：{string.Join(',', source)}");
                }
            }

            Console.WriteLine("--------------------------------------------");

            return source;
        }
    }
}
