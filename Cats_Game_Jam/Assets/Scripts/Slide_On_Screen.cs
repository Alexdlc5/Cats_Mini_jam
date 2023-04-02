using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slide_On_Screen : MonoBehaviour
{
    private RectTransform RT;
    public float RTposition;
    private void Start()
    {
        RT = GetComponent<RectTransform>();
    }
    private void Update()
    {
        if (RT.position.x < 650)
        {
            RT.position += new Vector3(4, 0, 0);
        }
        else
        {
            RT.position = new Vector3(650, RT.position.y, RT.position.z);
            Destroy(gameObject.GetComponent<Slide_On_Screen>());
        }
    }
}
