using System;

namespace Course;

class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotalEmEstoque()
    {
        return this.Quantidade * this.Preco;
    }

    public void AdicionarProdutos(int quantity)
    {
        this.Quantidade += quantity;
    }

    public void RemoverProdutos(int quantity)
    {
        this.Quantidade -= quantity;
    }

    public override string ToString()
    {
        return Nome + ", $" + Preco + ", " + Quantidade + " unidades, Total: $ "
            + ValorTotalEmEstoque();
    }
}