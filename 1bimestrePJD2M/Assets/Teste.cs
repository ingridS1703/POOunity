using UnityEngine;

public class teste : MonoBehaviour
{
    carro fusca = new carro();
    carro gol = new carro();
    caminhao caminhao = new caminhao();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fusca.setNome("fusca de pai");
        fusca.setCor("verde");
        fusca.setNumero_de_rodas(4);;
        fusca.setPreco(2050.90f);
        Debug.Log("o" + fusca.getNome() + " é " + fusca.getCor() + "tem " + fusca.Numero_de_rodas() + "e custa R$" + fusca.Preco());
        
        gol.setNome("gol do falstao");
        gol.setCor("verde");
        gol.setNumero_de_rodas(4);;
        gol.setPreco(3000.00f);
        Debug.Log("o" + gol.getNome());
        if (fusca.comparepreco(gol))
        {
            
        }
    }
    
}

