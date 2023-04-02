using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Movement : MonoBehaviour
{
    public TextMeshProUGUI highscore_display;
    public TextMeshProUGUI score_display;
    public TextMeshProUGUI Lhighscore_display;
    public TextMeshProUGUI Lscore_display;
    public float score = 0;
    public float speed = 1;
    private Vector2 mouse_position;

    public GameObject[] normal_UI;
    public float stamina = 1;
    public float time_drain = 0.0083f;
    public Slider slider;
    public GameObject[] lose_screen;
    public float attack_duration = 0.04f;
    public float attack_time = 0;
    public Animator animator;
    public float fall_anim_time = .48f;
    public bool hbEntered = false;
    public bool playing = false;
    private void Start()
    {
        Game_Manager.gameOver = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (!Game_Manager.gameOver)
        {
            score += 100 * Time.deltaTime;
            //update mouse position
            mouse_position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Vector2.MoveTowards(transform.position, mouse_position, speed * Time.deltaTime);

            if (hbEntered && !playing)
            {
                animator.SetBool("Attacking", true);
                playing = true;
            }
            else if (attack_time < attack_duration && hbEntered && playing)
            {
                attack_time += Time.deltaTime;
            }
            else if (attack_time > attack_duration && hbEntered && playing)
            {
                attack_time = 0;
                playing = false;
                hbEntered = false;
                animator.SetBool("Attacking", false);
            }
            stamina -= time_drain * Time.deltaTime;
            if (stamina <= 0)
            {
                animator.SetBool("Game Over", true);
                Game_Manager.gameOver = true;
                foreach (GameObject ui in normal_UI)
                {
                    ui.SetActive(false);
                }
                foreach(GameObject l in lose_screen)
                {
                    l.SetActive(true);
                }
            }
            else
            {
                slider.value = stamina;
            }
        } 
        else
        {
            if (Game_Manager.high_score < score)
            {
                Game_Manager.high_score = (int)score;
            }
        }
        score_display.text = "Score: " + (int)score;
        highscore_display.text = "High: " + Game_Manager.high_score;
        Lscore_display.text = "Score: " + (int)score;
        Lhighscore_display.text = "High: " + Game_Manager.high_score;
    }
}
