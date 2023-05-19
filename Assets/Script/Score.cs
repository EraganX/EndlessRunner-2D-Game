using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _scoretext;
    [SerializeField] private float _multiple = 1f;

    private float  _score;
    PlayerScript playerScript;

    public GameObject player;
    public float finalScore = 0f;


    void Start()
    {
        _score = 0;
        playerScript = player.GetComponent<PlayerScript>();

    }

    void Update()
    {
        if(!playerScript.isDead)
        {
            _scoretext.text = "Score : " + _score.ToString("0.0");
            _score += Time.deltaTime;
            SpeedUP();
        }
        else
        {
            _scoretext.text = "";
            finalScore = _score;
            Time.timeScale = 1f;
            SceneManageScript.Finalscore = finalScore;
        }
    }

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
    }
}
