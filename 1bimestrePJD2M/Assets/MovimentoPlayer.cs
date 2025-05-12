using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.Video;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    
    public float velocidade = 10;
    void Start()
    {
        
        _rigidbody = GetComponent<Rigidbody>();
    }

              
    void Update()
    {
        Vector3 posicao = transform.position;
        //esquerda X-
        if (Input.GetKeyDown(KeyCode.A))
        {
            posicao.x = transform.position.x - velocidade * Time.captureDeltaTime;
        }
        
        //direita x+
        if (Input.GetKeyDown(KeyCode.D))
        {
            posicao.x = transform.position.x + velocidade * Time.captureDeltaTime;
        }
        
        //cima Z+
        if (Input.GetKeyDown(KeyCode.W))
        {
            
        }
        
        //baixo Z-
        if (Input.GetKeyDown(KeyCode.S))
        {
     
        }

        transform.position = posicao;
    }
}
