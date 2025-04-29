using UnityEngine;

public class Inimigo : Personagem
{
    
    public enum ArmaduraDoInimigo
    {
      couraça, vembraço, coxotes
    }

    public enum ArmaDoInimigo
    {
        espada, machado, adaga
    }
    
    
    [SerializeField]
    private ArmaduraDoInimigo armadura;
    [SerializeField]
    private ArmaDoInimigo arma;
    
    public void AtribuirArmadura(ArmaduraDoInimigo armadura)
    {
        this.armadura = armadura;
    }

    public ArmaduraDoInimigo Armadura()
    {
        return this.armadura;
    }
    
    public void AtribuirArma(ArmaDoInimigo arma)
    {
        this.arma = arma;
    }

    public ArmaDoInimigo Arma()
    {
        return this.arma;
    }
    
}

