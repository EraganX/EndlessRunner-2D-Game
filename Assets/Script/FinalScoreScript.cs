using UnityEngine;
using UnityEngine.UI;

public class FinalScoreScript : MonoBehaviour
{
    [SerializeField] private Text displayScore;

    private void Start()
    {
        GameObject gameObject = GameObject.Find("ScoreText");
        float score = SceneManageScript.Finalscore;
        displayScore.text = "Score:\n" + score.ToString("0.0");
    }
}

