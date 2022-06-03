using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoverMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject panelHover;


    public void closeMenu()
    {
        panelHover.SetActive(false);    

    }

    public void settingMenu()
    {
        panelHover.SetActive(true);    
    }

    public void pauseMenu()
    {
        panelHover.SetActive(true);
        Time.timeScale = 0;
    }

    public void resumeGame()
    {
        panelHover.SetActive(false);
        Time.timeScale = 1;
    }

}
