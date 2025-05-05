using UnityEngine;

public class Personagem : MonoBehaviour
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

    public void AtribuirEnergia(int energia)
    {
        this.energia = energia;
    }
    public int Energia()
    {
        return this.energia;
    }

    public void AtribuirForca_ataque(int forca_ataque)
    {
        this.forca_ataque = forca_ataque;
    }

    public int Forca_ataque()
    {
        return this.forca_ataque;
    }
    
    public void AtribuirForca_pulo(float forca_pulo)
    {
        this.forca_pulo = forca_pulo;
    }

    public float Forca_pulo()
    {
        return this.forca_pulo;
    }
    
    public void AtribuirVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }
    public float Velocidade()
    {
        return this.velocidade;
    }
    
    public void AtribuirNumero_de_pe(int numero_de_pe)
    {
        this.numero_de_pe = numero_de_pe;
    }
    public int Numero_de_pe()
    {
        return this.numero_de_pe;
    }
    
    public void AtribuirNumero_de_maos(int numero_de_maos)
    {
        this.numero_de_maos = numero_de_maos;
    }
    public int Numero_de_maos()
    {
        return this.numero_de_maos;
    }
}

