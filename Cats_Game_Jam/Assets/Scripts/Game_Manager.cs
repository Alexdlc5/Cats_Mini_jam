using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager
{
    public static bool gameOver = false;
    public static float high_score = 0;
    public static HashSet<int> unlocked_cats = new HashSet<int>() {0};
    public static int coins = 100;
    public static int current_cat = 0;
    //settings
    public static float volume = 1;
    public static bool mute = false;
    public static bool normalControls = true;
}
