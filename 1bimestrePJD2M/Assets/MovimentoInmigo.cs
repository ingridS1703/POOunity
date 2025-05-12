using UnityEngine;

public class movimentoinimigo : MonoBehaviour
{
    private GameObject player;
    public float raioDeVisao;
    private Rigidbody _rigidbody;
    private float _velocidade;
   
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _velocidade = gameObject.GetComponent<Rigidbody>().linearVelocity.magnitude;
        
        player = GameObject.FindWithTag("Player");
        
    }
    

    
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < raioDeVisao);
        {
            transform.LookAt(player.transform.position);
        }
    }
}