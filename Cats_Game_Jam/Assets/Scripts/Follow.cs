using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public bool follow_mouse = false;
    public GameObject target;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (!Game_Manager.gameOver)
        {
            if (follow_mouse)
            {
                transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
            else
            {
                transform.position = target.transform.position;
            }
        }
    }
}
