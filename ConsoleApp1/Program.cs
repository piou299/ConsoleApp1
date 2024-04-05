// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

int a = 2; int b = 2;

//Operation op1 = new Operation();

//Console.WriteLine(op1.IsEqual(a,b));

//Console.WriteLine("fin OP1");

//int c = 4; int d = 6;

//Console.WriteLine(op1.IsEqual2(c, d));

//Console.WriteLine("fin OP2");

OperationGene <int>op = new OperationGene<int>();

Console.WriteLine(op.IsEqual(2, 2));

OperationGene<double> op2 = new OperationGene<double>();

Console.WriteLine(op2.IsEqual(1.6, 2));



