// See https://aka.ms/new-console-template for more information
using Algorithm;

var source = new int[] { 3, 48, 28, 15, 2, 50, 32 }; 
var source1 = new int[] { 4, 7, 9, 6, 5, 3, 10, 2, 8, 1 };
var source2 = new int[] { 7, 6, 5, 4, 3, 2, 1 };
//插入排序
Sort.Insertion(source);

//快速排序
Sort.Quick(source);

//冒泡排序
Sort.Bubble(source);


Console.ReadLine();