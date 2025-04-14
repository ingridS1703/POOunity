using UnityEngine;

public class carro
{
    private string nome;
    private int numero_de_rodas;
    private string cor;
    private float preco;

    public string getNome()
    {
        return nome;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public string getCor()
    {
        return this.cor;
    }

    public void setCor(string cor)
    {
        this.cor = cor;
    }

    public int setNumero_de_rodas(string numero_de_rodas)
    {
        return this.numero_de_rodas;
    }

    public void setPreco(float preco)
    {
        this.preco = preco;
    }

    public float Preco()
    {
        return this.preco;
    }

    public bool comparepreco(carro carro)
    {
        if (this.preco > carro.Preco())
        {
            return true;
        }
        return false;
    }

    
}