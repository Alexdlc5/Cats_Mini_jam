using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look_At_Mouse : MonoBehaviour
{
    private Vector2 mouse_position;
    public float offset = 0;
    // Update is called once per frame
    void Update()
    {
        if (!Game_Manager.gameOver)
        {
            mouse_position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //get angle between mouse and object, rotate accordingly
            Vector3 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle + offset, Vector3.forward);
        }
    }
}
