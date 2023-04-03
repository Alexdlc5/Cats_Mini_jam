using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Settings_Manager : MonoBehaviour
{
    //audio
    public Slider volume_slider;
    public TextMeshProUGUI volume_output;
    public Toggle mute;
    //Controls
    public Toggle controls_slider;
    public TextMeshProUGUI controls_output;
    private void Start()
    {
        volume_output.text = (int)(volume_slider.value * 100) + "%";
        volume_slider.value = Game_Manager.volume;
        mute.isOn = Game_Manager.mute;
        controls_slider.isOn = Game_Manager.normalControls;
        if (controls_slider.isOn == true)
        {
            controls_output.text = "Follow Finger";
        }
        else
        {
            controls_output.text = "Joystick";
        }
    }
    // Update is called once per frame
    void Update()
    {
        volume_output.text = (int)(volume_slider.value * 100) + "%";
        Game_Manager.volume = volume_slider.value;
        Game_Manager.mute = mute.isOn;
        Game_Manager.normalControls = controls_slider.isOn;
        if (controls_slider.isOn == true)
        {
            controls_output.text = "Follow Finger";
        }
        else
        {
            controls_output.text = "Joystick";
        }
    }
}
