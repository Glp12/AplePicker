using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnderFloat : MonoBehaviour
{
    DelateBlocks DelateBlock;

    private void Start()
    {
        DelateBlock = FindObjectOfType<DelateBlocks>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DelateBlock.DestroyBlock();
    } 
}
