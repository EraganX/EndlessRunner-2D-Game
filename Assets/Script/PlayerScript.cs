using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float _jumpforce;  
    [SerializeField] ParticleSystem  _runParticles;  

    private Rigidbody2D _rBody;
    private Animator _anime;
    private SceneManageScript _sceneManager;
    private GamePlaySounds _sounds;

    private bool _isGrounded;

    public bool isDead;


    void Awake()
    {
        _rBody = GetComponent<Rigidbody2D>();
        _anime = GetComponent<Animator>();
        _sceneManager = GetComponent<SceneManageScript>();
        _sounds = GetComponent<GamePlaySounds>();

        isDead = false;
    }//Awake

    void Update()
    {
        if((Input.GetKeyDown(KeyCode.Space)&&_isGrounded))
        {
            _rBody.AddForce(Vector2.up*_jumpforce, ForceMode2D.Impulse);
            _sounds.JumpSound();
            _anime.SetBool("Jump",true);
           
            _isGrounded = false;

            RunParticles(0);
        } // only jump when the player is grounded

        if(isDead)
        {
            Invoke("ShowScore",1f);     //add delay on game end before the End Scene apper
        }
        
    } //update

    private void ShowScore() {
        _sceneManager.EndGame();
    }   // load Final Score scene

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            _anime.SetBool("Jump",false);       //jump animation stop
            _isGrounded = true;                 //set player grounded
            RunParticles(1);
        }

        if (collision.gameObject.CompareTag("Obstacles"))
        {
            _anime.SetBool("Die", true);
            _sounds.BoomSound();                //play boom sound
            isDead = true;
            RunParticles(0);
        }
    }//OnCollition Enter 2d

    private void RunParticles(int active)
    {
        if (active == 1)
        {
            _runParticles.Play();
        }
        else
        {
            _runParticles.Stop();
        }
    }//Run particle active and deactive

}
