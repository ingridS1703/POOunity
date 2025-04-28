using UnityEngine;

public class personagem
{
    [SerializeField]
    private string nome;
    [SerializeField]
    private int energia;
    [SerializeField]
    private int forca_ataque;
    [SerializeField]
    private float forca_pulo;
    [SerializeField]
    private float velocidade;  
    [SerializeField]
    private int numero_de_pe;
    [SerializeField]
    private int numero_de_maos;
    [SerializeField]

    public void AtribuirNome(string Nome)
    {
        this.nome = Nome;
    }
public string Nome()
    {
        return this.nome;
    }

    public void AtribuirEnergia(string Energia)
    {
        this.energia = energia;
    }
    public int Energia()
    {
        return this.energia;
    }

    public void AtribuirForca_ataque(string Forca_ataque)
    {
        this.forca_ataque = forca_ataque;
    }

    public int Forca_ataque()
    {
        return this.forca_ataque;
    }
    
    public void AtribuirForca_pulo(string Forca_pulo)
    {
        this.forca_pulo = forca_pulo;
    }

    public float Forca_pulo()
    {
        return this.forca_pulo;
    }
    
    public void AtribuirVelocidade(string Velocidade)
    {
        this.velocidade = velocidade;
    }
    public float Velocidade()
    {
        return this.velocidade;
    }
    
    public void AtribuirNumero_de_pe(string Numero_de_pe)
    {
        this.numero_de_pe = numero_de_pe;
    }
    public int Numero_de_pe()
    {
        return this.numero_de_pe;
    }
    
    public void AtribuirNumero_de_maos(string Numero_de_maos)
    {
        this.numero_de_maos = numero_de_maos;
    }
    public int Numero_de_maos()
    {
        return this.numero_de_maos;
    }
}

