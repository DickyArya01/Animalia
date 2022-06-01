using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField]
    private int SceneIndex;

    public void forwardScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void backScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("back");

    }

    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void moveToScene()
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
