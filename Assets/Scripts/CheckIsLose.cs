using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckIsLose : MonoBehaviour
{
    public void IsLose(GameObject[] ArrayBlocks, int curentlength)
    {
        if (ArrayBlocks.Length == curentlength)
        {
            SceneManager.LoadScene(0);
        }
    }
}
