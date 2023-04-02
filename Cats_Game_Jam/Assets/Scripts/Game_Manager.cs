using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager
{
    public static bool gameOver = false;
    public static float high_score = 0;
    public static HashSet<int> unlocked_cats = new HashSet<int>();
    public static int coins = 100;
    public static int gems = 5;
    public static int current_cat = 0;
}
