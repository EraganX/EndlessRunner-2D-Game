/*using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManageScript : MonoBehaviour
{
    public static float Finalscore;


    
    public void StartGame()
    {
        Invoke("LoadGameScene", 0.5f);
    }
    
    private void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void EndGame()
    {
        SceneManager.LoadScene("Score Display");
    }

    public void ExitGame()
    {
#if UNITY_STANDALONE
        Application.Quit();
#endif
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManageScript : MonoBehaviour
{
    public static float Finalscore;

    public void StartGame()
    {
        StartCoroutine(DelayedStartGame(0.5f));
    }

    private System.Collections.IEnumerator DelayedStartGame(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("Game");
    }

    public void EndGame()
    {
        StartCoroutine(DelayedEndGame(0.5f));
    }

    private System.Collections.IEnumerator DelayedEndGame(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("Score Display");
    }

    public void ExitGame()
    {
        StartCoroutine(DelayedExitGame(0.5f));
    }

    private System.Collections.IEnumerator DelayedExitGame(float delay)
    {
        yield return new WaitForSeconds(delay);
#if UNITY_STANDALONE
        Application.Quit();
#endif
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
