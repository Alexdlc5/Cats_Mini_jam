using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touching_Enemy : MonoBehaviour
{
    public Movement movement;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        movement.hbEntered = true;
    }
}
