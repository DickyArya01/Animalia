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
}
