using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject apple;

    IEnumerator WaitAndPrint()
    {
        yield return new WaitForSeconds(2);
        float minX = transform.position.x - 0.5f;
        float maxX = transform.position.x + 0.51f;
        float minY = transform.position.y - 0.5f; 
        float maxY = transform.position.y + 0.51f;
        float positionX = Random.Range(minX, maxX);
        float positionY = Random.Range(minY, maxY);
        Instantiate(apple, new Vector2(positionX, positionY), Quaternion.identity);
    }
    IEnumerator Start()
    {
        while (1 > 0)
        {
            yield return StartCoroutine("WaitAndPrint");
        }
    }
}
