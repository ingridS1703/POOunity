using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Animator animator;
    private MovimentoPlayer movimentoPlayer;
    public float velocidadeDaAnimacao = 1;
    private Personagem personagem;
    
    void Start()
    {
        movimentoPlayer = GetComponent<MovimentoPlayer>();
    }
    void Update()
    {
        animator.SetBool("Andando", movimentoPlayer.andando);
        animator.speed = velocidadeDaAnimacao;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Ataque");  
        }

        if (Personagem.Energia() <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
        
        
        
    }
}