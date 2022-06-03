using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelScript : MonoBehaviour
{

    private int sceneIndex;
    [SerializeField]
    private int menuSceneIndex;
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex; 
        // Debug.Log(sceneIndex);
    }

    public void nextLevel()
    {
        PlayerPrefs.SetInt("LevelPassed", sceneIndex);
        SceneManager.LoadScene(menuSceneIndex);
    }


}
