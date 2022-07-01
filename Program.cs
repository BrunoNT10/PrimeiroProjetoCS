﻿using System;

namespace meuPrimeiroProjeto
{
    class Program
    {    
        static void Main(string[] args)
        {
            ContaCorrente contaDaBarbara = new ContaCorrente("Barbara", 863, 863146, 100);
            ContaCorrente contaDoBruno = new ContaCorrente("Bruno", 863, 123456, 1000);
            ContaCorrente contaDaGabriel = new ContaCorrente("Gabriel", 863, 124578, 2000);

            Console.WriteLine("************** RELATÓRIO GERAL DA CONTA **************");
            Console.WriteLine("Titular: " + contaDaBarbara.titular);
            Console.WriteLine("Agência: " + contaDaBarbara.agencia);
            Console.WriteLine("Número da conta: " + contaDaBarbara.numero);
            Console.WriteLine("Saldo: " + contaDaBarbara.saldo);
            Console.WriteLine("******************************************************");

            Console.WriteLine("************** RELATÓRIO GERAL DA CONTA **************");
            Console.WriteLine("Titular: " + contaDoBruno.titular);
            Console.WriteLine("Agência: " + contaDoBruno.agencia);
            Console.WriteLine("Número da conta: " + contaDoBruno.numero);
            Console.WriteLine("Saldo: " + contaDoBruno.saldo);
            Console.WriteLine("******************************************************");

            Console.WriteLine("************** RELATÓRIO GERAL DA CONTA **************");
            Console.WriteLine("Titular: " + contaDaGabriel.titular);
            Console.WriteLine("Agência: " + contaDaGabriel.agencia);
            Console.WriteLine("Número da conta: " + contaDaGabriel.numero);
            Console.WriteLine("Saldo: " + contaDaGabriel.saldo);
            Console.WriteLine("******************************************************");
            
        }
       
    }
}
