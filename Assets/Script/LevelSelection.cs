using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour 
{
    public Button[] lvlBtn;
    
    public Image[] levelSprite;

    public Sprite lockSprite;

    public Sprite unlockSprite;

    [SerializeField]
    private GameObject[] btnText;
    
    

    int levelPassed;

    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");

        for(int i = 0; i < lvlBtn.Length; i++)
        {
            lvlBtn[i].interactable = false;
            levelSprite[i].sprite = lockSprite;
            btnText[i].SetActive(false);

        }

        switch (levelPassed)
        {
            case 3:
                lvlBtn[0].interactable = true;
                levelSprite[0].sprite = unlockSprite;
                btnText[0].SetActive(true);
                break;
            case 4:
                lvlBtn[0].interactable = true;
                lvlBtn[1].interactable = true;
                break;
            case 5:
                lvlBtn[0].interactable = true;
                lvlBtn[1].interactable = true;
                lvlBtn[2].interactable = true;
                break;
            case 6:
                lvlBtn[0].interactable = true;
                lvlBtn[1].interactable = true;
                lvlBtn[2].interactable = true;
                lvlBtn[3].interactable = true;
                break;
        }
        
    }
}
