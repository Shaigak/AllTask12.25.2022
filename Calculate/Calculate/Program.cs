
using ServiceLayer;
using ServiceLayer.Interfaces;

ICalculateService calculateService = new CalculateService();

int[] arrs = { 1, 5, 6, 2, 3, 5 };
    Console.WriteLine(calculateService.Arry(arrs));

//int[] arrd = { 1, 4, 3, 5, 6, 4 };
Console.WriteLine(calculateService.Calculate(arrs, 2));