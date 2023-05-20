using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoretext;
    [SerializeField] private float _multiple = 1f;      //Change the speed up time

    private float  _score;
    PlayerScript playerScript;

    public GameObject player;
    public float finalScore = 0f;


    void Start()
    {
        _score = 0;
        playerScript = player.GetComponent<PlayerScript>();

    } //Start

    void Update()
    {
        if(!playerScript.isDead)
        {
            _scoretext.text = "Score : " + _score.ToString("0.0");  //Score display in game window
            _score += Time.deltaTime;                               //Add score according to the time
            SpeedUP();                                              //Calling Speed Up function
        }
        else
        {
            _scoretext.text = "";
            finalScore = _score;
            Time.timeScale = 1f;                            //Reset game play speed 1x
            SceneManageScript.Finalscore = finalScore;      //Final score value send to the Scenemanager
        }
    }// update

    private void SpeedUP()
    {
        if (_score < 10*_multiple)
        {
            Time.timeScale = 1f;
        }
        else if (_score < 20 * _multiple)
        {
            Time.timeScale = 1.3f;
        }
        else if (_score < 30 * _multiple)
        {
            Time.timeScale = 1.6f;
        }
        else if (_score < 40 * _multiple)
        {
            Time.timeScale = 1.9f;
        }
        else if (_score < 50 * _multiple)
        {
            Time.timeScale = 2.2f;
        }
        else if (_score < 60 * _multiple)
        {
            Time.timeScale = 2.5f;
        }
        else if (_score < 100 * _multiple)
        {
            Time.timeScale = 3f;
        }
        else {
            Time.timeScale = 5f;
        }
    }//Game speed up accoding to the score
}
