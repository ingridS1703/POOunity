using UnityEngine;

public class Inimigo : Personagem
{
    
    public enum ArmaduraDoInimigo
    {
      esquiva, controle_de_distancia, leitura_do_adversario
    }

    public enum ArmaDoInimigo
    {
        estilo_Koei,demonio_caido,estilo_Niko
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
    
    
    public int DanoDoInimigo()
    {
        int dano = 0;

        switch (arma)
        {
            case ArmaDoInimigo.estilo_Koei:
                dano = Forca_ataque() + 75;
                break;
            case ArmaDoInimigo.demonio_caido:
                dano = Forca_ataque() + 88;
                break;
            case ArmaDoInimigo.estilo_Niko:
                dano = Forca_ataque() + 83;
                break;
        }
        
        // dano do ataque com a arma
        
        return dano;
    }

    
    
    
    
    
    
}

