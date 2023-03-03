using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public GameObject[] normal_UI;
    private Vector2 mouse_position;
    public GameObject[] attack_hbs;
    private GameObject closestHB = null;
    public float stamina = 1;
    private float attack_drain = 0.001f;
    public float time_drain = 0.0083f;
    public GameObject attack_hb;
    public Slider slider;
    public GameObject lose_screen;
    public float attack_duration = 0.5f;
    private float attack_time;
    public float angle_offset = 0;
    // Update is called once per frame
    void Update()
    {
        if (!Game_Manager.gameOver)
        {
            if (Input.GetMouseButtonDown(0) && closestHB == null)
            {
                chooseHB();
                closestHB.SetActive(true);
                stamina -= attack_drain;
            }
            else if (closestHB != null && closestHB.activeSelf && attack_time < attack_duration)
            {
                attack_time += Time.deltaTime;
            }
            else if (closestHB != null && closestHB.activeSelf)
            {
                closestHB.SetActive(false);
                closestHB = null;
                attack_time = 0;
            }
            stamina -= time_drain * Time.deltaTime;
            if (stamina <= 0)
            {
                Game_Manager.gameOver = true;
                foreach (GameObject ui in normal_UI)
                {
                    ui.SetActive(false);
                }
                lose_screen.SetActive(true);
            }
            else
            {
                slider.value = stamina;
            }
        }
    }
    private void chooseHB()
    {
        mouse_position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject closest = null;
        foreach (GameObject hb in attack_hbs)
        {
            if (closest == null)
            {
                closest = hb;
            }
            else if (Vector2.Distance(closest.transform.position, mouse_position) > Vector2.Distance(hb.transform.position, mouse_position))
            {
                closest = hb;
            }
        }
        closestHB = closest;
    }
}

