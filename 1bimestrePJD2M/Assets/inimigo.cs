using UnityEngine;

public class inimigo : personagem
{
    [SerializeField]
    private string armadura;
    [SerializeField]
    private string armas;
    [SerializeField]

    public void AtribuirArmadura(string armadura)
    {
        this.armadura = armadura;
    }

    public string Armadura()
    {
        return this.armadura;
    }
    
    public void AtribuirArma(string arma)
    {
        this.armas = arma;
    }

    public string Arma()
    {
        return this.armas;
    }
    
}

