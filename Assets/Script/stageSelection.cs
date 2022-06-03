using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageSelection : LevelSelection 
{
    [SerializeField]
    private Sprite lockSprite2;

    [SerializeField]
    private Sprite unlockSprite2;

    private int levelhasPassed;

    void Start()
    {
       levelhasPassed = PlayerPrefs.GetInt("LevelPassed");

       lvlBtn[0].interactable = false;
       lvlBtn[1].interactable = false;
       levelSprite[0].sprite = lockSprite;
       levelSprite[1].sprite = lockSprite2;

       switch(levelhasPassed)
       {
           case 7:
            lvlBtn[0].interactable = true;
            levelSprite[0].sprite = unlockSprite;
            break;
           case 11:
            lvlBtn[0].interactable = true;
            levelSprite[0].sprite = unlockSprite;
            lvlBtn[0].interactable = true;
            levelSprite[1].sprite = unlockSprite;
            break;

       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
