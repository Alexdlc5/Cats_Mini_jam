using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splat_Despawn : MonoBehaviour
{
    float timer = 4;
    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
