using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMoves : MonoBehaviour
{
    [SerializeField] Vector2 velocity;
    [SerializeField] Rigidbody2D rb2D;
    public int Direction = -1;

    IEnumerator WaitAndPrint()
    {
        // suspend execution for 5 seconds
        yield return new WaitForSeconds(4); 
        Direction = -1;
        float randomDirection = Random.Range(-1, 1);
        if (randomDirection >= 0)
        {
            Direction = 1;
        }
    }
    IEnumerator Start() 
    {
        while (1 > 0)
        {
            yield return StartCoroutine("WaitAndPrint");
        }
    }
    void FixedUpdate()
    {
        if (rb2D.position.x>1 && rb2D.position.x < 15)
        {
            rb2D.MovePosition(rb2D.position + (velocity * Direction) * Time.fixedDeltaTime);
        }
        if(rb2D.position.x < 1)
        {
            Direction = 1;
            rb2D.MovePosition(rb2D.position + (velocity * Direction) * Time.fixedDeltaTime);
        }
        if (rb2D.position.x > 15)
        {
            Direction = -1;
            rb2D.MovePosition(rb2D.position + (velocity * Direction) * Time.fixedDeltaTime);
        }
    }
}
