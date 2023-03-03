using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        } 
        else
        {
            if (Game_Manager.high_score < score)
            {
                Game_Manager.high_score = score;
            }
        }
        score_display.text = "Score: " + score;
        highscore_display.text = "High: " + Game_Manager.high_score;
        Lscore_display.text = "Score: " + score;
        Lhighscore_display.text = "High: " + Game_Manager.high_score;
    }
}
