using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControler : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minscrenx = 1;
    [SerializeField] float maxscrenx = 15f;

    void Update()
    {
        float mouseposx = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 padlePosition = new Vector2(transform.position.x, transform.position.y);
        padlePosition.x = Mathf.Clamp(mouseposx, minscrenx, maxscrenx);
        transform.position = padlePosition;
    }
}
