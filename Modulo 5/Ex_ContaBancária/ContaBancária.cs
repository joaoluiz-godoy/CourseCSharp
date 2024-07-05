using System;

namespace Course;
class ContaBancária
{
    public int Id { get; private set;}
    public string Nome;
    private double Saldo { get; private set; }

    public ContaBancária(int id, string nome)
    {
        this.Id = id;
        this.Nome = nome;
        this.Saldo = 0;
    }

    public ContaBancária(int id, string nome, double saldo) : this(id, nome)
    {
        Saldo = saldo;
    }


    
    public void depósito(double caixa)
    {
        Saldo += caixa;
    }

    public void saque(double caixa)
    {
        Saldo -= (5.00 + caixa); //Banco Cobra $5.00 de taxa para sacar dinheiro
    }

    public override string ToString()
    {
        return $"Conta: {Id}, Titular: {Nome}, Saldo: $ {Saldo}";
    }

}

