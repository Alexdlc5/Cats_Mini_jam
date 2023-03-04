using UnityEngine;
using TMPro;

public class High_Score_Display : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = "High Score: " + Game_Manager.high_score;
    }
}
