using System.Collections;
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
        Shuffle(gamePuzzles);
        gameGuesses = gamePuzzles.Count / 2;

    } 

    void Awake() {
        puzzles = Resources.LoadAll<Sprite> ("Sprites/herbivora");
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

        if(!firstGuess) {

            firstGuess = true;
            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            firstGuessName = gamePuzzles[firstGuessIndex].name;
            buttons[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];

        }else if (!secondGuess)
        {

            secondGuess = true;
            secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            secondGuessName = gamePuzzles[secondGuessIndex].name;
            buttons[secondGuessIndex].image.sprite = gamePuzzles[secondGuessIndex];
            countGuesses++;
            StartCoroutine(CheckIfThePuzzlesMatch());
            
        }
        
    }

    IEnumerator CheckIfThePuzzlesMatch() {
        yield return new WaitForSeconds (1f);
        if (firstGuessName == secondGuessName) {
            yield return new WaitForSeconds (.5f);

            buttons[firstGuessIndex].interactable = false;
            buttons[secondGuessIndex].interactable = false;

            buttons[firstGuessIndex].image.color = new Color(0, 0, 0, 0);
            buttons[secondGuessIndex].image.color = new Color(0, 0, 0, 0);
            
            CheckIfTheGameIsFinished();

        } else {
        
            yield return new WaitForSeconds(.5f);

            buttons[firstGuessIndex].image.sprite = bgImage;
            buttons[secondGuessIndex].image.sprite= bgImage;

        }

        yield return new WaitForSeconds(.5f);

        firstGuess = secondGuess = false;
        
    }

    void CheckIfTheGameIsFinished() {
        countCorrectGuesses++;

        if(countCorrectGuesses == gameGuesses) {
            Debug.Log("Game finished");
            Debug.Log("It took "+ countGuesses + " guesses to finished");
        }
    }

    void Shuffle(List<Sprite> list) {
        for (int i = 0; i < list.Count; i++) {
            
            Sprite temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
}
