using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cat_Selection : MonoBehaviour
{
    public TextMeshProUGUI coins;
    public TextMeshProUGUI gems;
    public TextMeshProUGUI nameDisplay;
    public TextMeshProUGUI descriptionDisplay;
    public TextMeshProUGUI priceDisplay;
    public Button Right;
    public Button Left;
    public Button select;
    private int current_viewing;
    public Image display;
    public GameObject selected;
    public Sprite[] cat_icons;
    public int[] prices;
    public string[] names;
    public string[] descriptions;
    private void Start()
    {
        current_viewing = Game_Manager.current_cat;
        Right.onClick.AddListener(right_shift_selection);
        Left.onClick.AddListener(left_shift_selection);
        select.onClick.AddListener(select_cat);
    }
    // Update is called once per frame
    void Update()
    {
        coins.text = "Coins:" + Game_Manager.coins;
        gems.text = "Gems:" + Game_Manager.gems;
        display.sprite = cat_icons[current_viewing];
        nameDisplay.text = names[current_viewing];
        priceDisplay.text = "Cost: " + prices[current_viewing] + " coins";
        descriptionDisplay.text = "Description:\n" + descriptions[current_viewing];
        if (current_viewing == Game_Manager.current_cat)
        {
            selected.SetActive(true);
        }
        else
        {
            selected.SetActive(false);
        }
        if (Game_Manager.unlocked_cats.Contains(current_viewing))
        {
            select.gameObject.transform.GetComponentInChildren<TextMeshProUGUI>().text ="Equip";
        }
        else
        {
            select.gameObject.transform.GetComponentInChildren<TextMeshProUGUI>().text = "Buy";
        }
    }
    void select_cat()
    {
        if (Game_Manager.unlocked_cats.Contains(current_viewing))
        {
            Game_Manager.current_cat = current_viewing;
        }
        else if (prices[current_viewing] <= Game_Manager.coins)
        {
            Game_Manager.unlocked_cats.Add(current_viewing);
            Game_Manager.coins -= prices[current_viewing];
            Game_Manager.current_cat = current_viewing;
        }
    }
    void right_shift_selection()
    {
        shift_selection(true);
    }
    void left_shift_selection()
    {
        shift_selection(false);
    }
    void shift_selection(bool isRight)
    {
        if (isRight)
        {
            if (current_viewing == cat_icons.Length - 1)
            {
                current_viewing = 0;
            }
            else
            {
                current_viewing++;
            }
        }
        else
        {
            if (current_viewing == 0)
            {
                current_viewing = cat_icons.Length - 1;
            }
            else
            {
                current_viewing--;
            } 
        }
    }
}
