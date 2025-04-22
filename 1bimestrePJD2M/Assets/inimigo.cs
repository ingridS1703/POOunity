using UnityEngine;

public class inimigo : MonoBehaviour
{
    private string nome;
    private int energia;
    private int forca_ataque;
    private float forca_pulo;
    private float velocidade;
    private int numero_de_pe;
    private int numero_de_maos;
    private string armadura;
    private string armas;

    public void AtribuirArmadura(string armadura)
    {
        this.armadura = armadura;
    }

    public string armadura()
    {
        return this.armadura;
    }
    
    public void AtribuirArma(string arma)
    {
        this.arma = arma;
    }

    public string arma()
    {
        return this.arma;
    }
    
}

