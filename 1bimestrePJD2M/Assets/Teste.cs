using UnityEngine;

public class Teste : MonoBehaviour
{ 
    carro fusca = new carro();
    carro gol = new carro();
    void Start()
    {
        fusca.setNome("Fusca de Pai");
        fusca.setCor("Verde");

        Debug.Log("0" + fusca.getNome() + " é " + fusca.getCor());
    }
    
        void Update()
        {

        }
    }

