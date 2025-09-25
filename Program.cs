﻿using System;

class Program
{
    static void Main()
    {
        // Nome fixo
        string nome = "Leticia";
        string sobrenome = "Assis";

        // Saídas
        Console.WriteLine("Nome completo: " + nome + " " + sobrenome);
        Console.WriteLine("Nome de catálogo: " + sobrenome.ToUpper() + ", " + nome);
    }
}
