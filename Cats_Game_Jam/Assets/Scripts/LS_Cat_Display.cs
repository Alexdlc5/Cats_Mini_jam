using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LS_Cat_Display : MonoBehaviour
{
    SpriteRenderer cat;
    // Start is called before the first frame update
    void Start()
    {
        cat = GameObject.FindGameObjectWithTag("Attack").GetComponent<SpriteRenderer>();
        GetComponent<Image>().sprite = cat.sprite;
    }
}
