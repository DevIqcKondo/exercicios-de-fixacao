using System;

namespace exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Elabore um algoritmo que calcule a idade média de 5 alunos

        Double media=0;
        Double idade1=0;
        Double idade2=0;
        Double idade3=0;
        Double idade4=0;
        Double idade5=0;

        Console.WriteLine("Programa que calcula a idade media de cinco alunos");
        Console.Write("Informe a idade do 1° aluno : ");

        idade1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe a idade do 2° aluno : ");

        idade2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe a idade do 3° aluno : ");
        
        idade3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe a idade do 4° aluno : ");

        idade4 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe a idade do 5° aluno : ");

        idade5 = Convert.ToDouble(Console.ReadLine());

        media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;

        Console.WriteLine("A ídade média dos alunos é " + media);
        Console.ReadKey();

        //Faça um programa para calcular o estoque médio de uma peça

        int estoqueMedio = 0;
        int qtdMinima = 0;
        int qtdMaxima = 0;

        Console.WriteLine("Calcular o estoque médio de uma peça");

        Console.WriteLine("Defina uma quantidade minima: ");
        qtdMinima = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Defina uma quantidade maxima: ");
        qtdMaxima = Convert.ToInt32(Console.ReadLine());

        estoqueMedio = (qtdMinima + qtdMaxima)/2;

        Console.WriteLine("Estoque médio da peça é igual a: " + estoqueMedio);
        }
    }
}
