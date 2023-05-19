using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float _jumpforce;

    private Rigidbody2D _rBody;
    private Animator _anime;
    private SceneManageScript _sceneManager;

    private bool _isGrounded;

    public bool isDead;


    void Awake()
    {
        _rBody = GetComponent<Rigidbody2D>();
        _anime = GetComponent<Animator>();
        _sceneManager = GetComponent<SceneManageScript>();

        isDead = false;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&_isGrounded)
        {
            _rBody.AddForce(Vector2.up*_jumpforce, ForceMode2D.Impulse);
            _anime.SetBool("Jump",true);
            _isGrounded = false;
        }

        if(isDead)
        {
            _sceneManager.EndGame();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            _anime.SetBool("Jump",false);
            _isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Obstacles"))
        {
            _anime.SetBool("Die", true);
            isDead = true;
        }
    }


}
