using UnityEngine;
using UnityEngine.UI;

public class FinalScoreScript : MonoBehaviour
{
    [SerializeField] private Text displayScore;

    private void Start()
    {  
        float score = SceneManageScript.Finalscore;                 //get final score from the Scenemanager script
        displayScore.text = "Score:\n" + score.ToString("0.0");     //display converted score
    }//start
}

