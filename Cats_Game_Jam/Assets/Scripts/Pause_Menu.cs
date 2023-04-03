using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pause_Menu : MonoBehaviour
{
    public Button play;
    public Button pause;
    public GameObject pause_window;
    private void Start()
    {
        Time.timeScale = 1;
        play.onClick.AddListener(togglePause);
        pause.onClick.AddListener(togglePause);
    }
    void togglePause()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            pause_window.SetActive(false);
        }
        else
        {
            Time.timeScale = 0;
            pause_window.SetActive(true);
        }
    }
}
