using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonSet : MonoBehaviour
{
    [SerializeField]
    private Button btn;

    [SerializeField]
    private bool isEnabled;

    public Image levelSprite;
    
    public Sprite lockSprite;

    public GameObject btnText; 

    void Start()
    {

        btnEnabled(isEnabled); 

    }

    public void btnEnabled(bool enable)
    {
        if (enable == true)
        {
            btn.enabled = enable; 

        } else {
            levelSprite.sprite = lockSprite;
            btnText.SetActive(enable);
            btn.enabled = enable;

        }
    }

}
