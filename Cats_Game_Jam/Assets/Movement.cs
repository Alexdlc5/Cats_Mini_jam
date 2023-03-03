using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector2 mouse_position;
    // Update is called once per frame
    void Update()
    {
        //update mouse position
        mouse_position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
