using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blocks : MonoBehaviour
{
    ScorePlus plusScore;

    private void Start() 
    {
        plusScore = FindObjectOfType<ScorePlus>();    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        plusScore.scoreplus();
    }
}
    