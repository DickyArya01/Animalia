using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    public Image uiFill;

    [SerializeField]
    public Text uiText;

    [SerializeField]
    public int Duration;

    private int remainingDuration; 



    private void Start()
    {
        Being(Duration);
        // gc = new GameController();
    }

    private void Being(int Second)
    {
        remainingDuration = Second;
        StartCoroutine(UpdateTimer());
    }

    public IEnumerator UpdateTimer()
    {
        while (remainingDuration >= 0 )
        {
            uiText.text = $"{remainingDuration / 60:00} : {remainingDuration % 60:00}";
            uiFill.fillAmount = Mathf.InverseLerp(0, Duration, remainingDuration);
            remainingDuration--;
            yield return new WaitForSeconds(1f);
            //  Debug.Log(remainingDuration);
            
        }
    }

   
}
