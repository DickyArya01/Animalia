using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private Sprite bgImage;

    public List<Button> buttons = new List<Button>();

    void Start() {
        
        GetButton();

    } 

    void GetButton() {

        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");

        for (int i=0; i < objects.Length; i++) {
            buttons.Add(objects[i].GetComponent<Button>());
            buttons[i].image.sprite = bgImage;
        }
    }

}
