using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skin_Manager : MonoBehaviour
{
    public RuntimeAnimatorController[] skins;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //set cat and description
        animator = GetComponent<Animator>();
        animator.runtimeAnimatorController = skins[Game_Manager.current_cat];
    }
}
