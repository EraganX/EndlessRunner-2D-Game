using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovementScript : MonoBehaviour
{
    [SerializeField] private float _moveSpeed=50f;
    public GameObject player;

    private Rigidbody2D _rbody;
    private Animator _rocketAnime;
    private PlayerScript _playerScript;


    void Start()
    {
        _rbody = GetComponent<Rigidbody2D>();
        _rocketAnime = GetComponent<Animator>();
        _playerScript = player.GetComponent<PlayerScript>();
        _playerScript.isDead = false;
    }


    private void FixedUpdate()
    {
        MovementObstacle(_playerScript.isDead);
    }

    private void MovementObstacle(bool deadPlayer) 
    {
        if (deadPlayer)
        {
            _rbody.velocity = Vector2.zero;
            Destroy(gameObject,1f);
        }
        else
        {
            _rbody.velocity = new Vector2(-_moveSpeed, _rbody.velocity.y) * Time.fixedDeltaTime;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            _rocketAnime.SetBool("Explotion",true);
            _playerScript.isDead = true;
        }
    }
}
