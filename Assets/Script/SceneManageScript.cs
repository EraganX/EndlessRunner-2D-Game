using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManageScript : MonoBehaviour
{
    public static float Finalscore;
    private float _gameDelya = 0.5f;    //change delay time

    public void StartGame()
    {
        StartCoroutine(DelayedStartGame(_gameDelya));     //Add Delay
    } //add delay Start game

    private System.Collections.IEnumerator DelayedStartGame(float delay)
    {
        yield return new WaitForSeconds(delay);         //set Delay
        SceneManager.LoadScene("Game"); 
    } //set delay Start

    public void MainMenu()
    {
        StartCoroutine(DelayedMainMenu(_gameDelya));     //Add Delay
    } //add delay Start game

    private System.Collections.IEnumerator DelayedMainMenu(float delay)
    {
        yield return new WaitForSeconds(delay);         //set Delay
        SceneManager.LoadScene("Main Menu");
    }

    public void EndGame()
    {
        StartCoroutine(DelayedEndGame(_gameDelya));     //Add Delay
    } //add delay End

    private System.Collections.IEnumerator DelayedEndGame(float delay)
    {
        yield return new WaitForSeconds(delay);         //set Delay
        SceneManager.LoadScene("Score Display");        //Load Final Score scene
    }//set EndGame / Score Display

    public void ExitGame()
    {
        StartCoroutine(DelayedExitGame(_gameDelya));     //Add Delay
    }//add delay Exit

    private System.Collections.IEnumerator DelayedExitGame(float delay)
    {
        yield return new WaitForSeconds(delay);
#if UNITY_STANDALONE
        Application.Quit();
#endif
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    } //set Game Exit / closed 
}
