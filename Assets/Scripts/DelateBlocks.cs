using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelateBlocks : MonoBehaviour
{
    [SerializeField] GameObject[] ArrayBlocks;
    private int length = 0;
    CheckIsLose Check;

    private void Start() 
    {
        Check = FindObjectOfType<CheckIsLose>();
    }

    public void DestroyBlock()
    {
        Destroy(ArrayBlocks[length]);
        length++;
        Check.IsLose(ArrayBlocks, length);
    }
}
