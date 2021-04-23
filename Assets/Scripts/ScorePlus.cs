using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePlus : MonoBehaviour
{
    [SerializeField] Text Score;
     int curentScore = 0;
    private void Start()
    {
        Score.text = curentScore.ToString();
    }
    public void scoreplus()
    {
        curentScore++;
        Score.text = curentScore.ToString();
    }
}
