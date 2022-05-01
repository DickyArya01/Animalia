﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private Sprite bgImage;

    public Sprite[] puzzles;

    public List<Sprite> gamePuzzles = new List<Sprite>();

    public List<Button> buttons = new List<Button>();

    private bool firstGuess, secondGuess;

    private int countGuesses, countCorrectGuesses, gameGuesses;

    private int firstGuessIndex, secondGuessIndex;

    private string firstGuessName, secondGuessName;

    void Start() {
        
        GetButton();
        AddListeners();
        AddGamePuzzles();

    } 

    void Awake() {
        puzzles = Resources.LoadAll<Sprite> ("Sprites/animals");
    }

    void GetButton() {

        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");

        for (int i=0; i < objects.Length; i++) {
            buttons.Add(objects[i].GetComponent<Button>());
            buttons[i].image.sprite = bgImage;
        }
    }

    void AddGamePuzzles() {
        int looper = buttons.Count;
        int index = 0;

        for (int i=0; i < looper; i++) {
            if(index == looper /2) {
                index = 0;
            }
            gamePuzzles.Add(puzzles[index]);

            index++;
        }
    }

    void AddListeners() {
        foreach (Button button in buttons) {
            button.onClick.AddListener(() => PickUpPuzzle());
        }
    }

    public void PickUpPuzzle() {
        string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(name +" is clicked");
    }

}
