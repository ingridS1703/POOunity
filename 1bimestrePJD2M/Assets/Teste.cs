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
        fusca.Atribuirnumero_de_rodas(4);;
        fusca.AtribuirPreco(2050.90f);
        Debug.Log("o" + fusca.getnome() + " é " + fusca.setCor() + "tem " + fusca.Numero_de_rodas() + "e custa R$" + fusca.Preco());
        
        gol.setNome("gol do falstao");
        gol.setCor("verde");
        gol.Atribuirnumero_de_rodas(4);;
        gol.AtribuirPreco(3000.00f);
        Debug.Log("o" + gol.getnome());

    }
    
}

