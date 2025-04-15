using UnityEngine;

public class caminhao :carro
{
    private string tipo_de_carroceria;

    public void setTipoDeCarroceira(string tipo_de_carroceria)
    {
        this.tipo_de_carroceria = tipo_de_carroceria;
    }

    public string TipoDeCarroceria()
    {
        return this.tipo_de_carroceria;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
