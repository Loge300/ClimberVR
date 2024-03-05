using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TMP_Text timer;
    [SerializeField] private double minutes = 0;
    [SerializeField] private double seconds = 0;
    [SerializeField] private double height = 0;
    [SerializeField] private TMP_Text heightCounter;
    [SerializeField] private GameObject playerHolder;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
        UpdateHeight();
    }

    public void UpdateTimer()
    {
        seconds += Time.deltaTime;

        if (seconds >= 60)
        {
            minutes++;
            seconds = 0;
        }

        if (seconds < 10)
        {
            timer.text = "Time - " + (int)minutes + ":0" + (int)seconds;
        }
        else
        {
            timer.text = "Time - " + (int)minutes + ":" + (int)seconds;
        }
    }

    public void UpdateHeight()
    {
        height = playerHolder.transform.position.y;

        heightCounter.text = "Height - " + (int)height + "m";
    }
}
