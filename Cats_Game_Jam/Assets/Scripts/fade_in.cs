using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class fade_in : MonoBehaviour
{
    public float speed = 1;
    public TextMeshProUGUI[] text;
    public Image[] Images;
    private void Start()
    {
        GetComponent<RawImage>().color = new Color(GetComponent<RawImage>().color.r, GetComponent<RawImage>().color.g, GetComponent<RawImage>().color.b,0);
        foreach (TextMeshProUGUI t in text)
        {
            t.GetComponent<TextMeshProUGUI>().color = new Color(t.GetComponent<TextMeshProUGUI>().color.r, t.GetComponent<TextMeshProUGUI>().color.g, t.GetComponent<TextMeshProUGUI>().color.b, 0);
        }
        foreach (Image i in Images)
        {
            i.GetComponent<Image>().color = new Color(i.GetComponent<Image>().color.r, i.GetComponent<Image>().color.g, i.GetComponent<Image>().color.b, 0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (GetComponent<RawImage>().color.a < 1)
        {
            GetComponent<RawImage>().color = new Color(GetComponent<RawImage>().color.r, GetComponent<RawImage>().color.g, GetComponent<RawImage>().color.b, GetComponent<RawImage>().color.a + speed * Time.deltaTime);
            foreach (TextMeshProUGUI t in text)
            {
                t.GetComponent<TextMeshProUGUI>().color = new Color(t.GetComponent<TextMeshProUGUI>().color.r, t.GetComponent<TextMeshProUGUI>().color.g, t.GetComponent<TextMeshProUGUI>().color.b, t.GetComponent<TextMeshProUGUI>().color.a + speed * Time.deltaTime);
            }
            foreach (Image i in Images)
            {
                i.GetComponent<Image>().color = new Color(i.GetComponent<Image>().color.r, i.GetComponent<Image>().color.g, i.GetComponent<Image>().color.b, i.GetComponent<Image>().color.a + speed * Time.deltaTime);
            }
        }
        else
        {
            GetComponent<RawImage>().color = new Color(GetComponent<RawImage>().color.r, GetComponent<RawImage>().color.g, GetComponent<RawImage>().color.b, 1);
            foreach (TextMeshProUGUI t in text)
            {
                t.GetComponent<TextMeshProUGUI>().color = new Color(t.GetComponent<TextMeshProUGUI>().color.r, t.GetComponent<TextMeshProUGUI>().color.g, t.GetComponent<TextMeshProUGUI>().color.b, 1);
            }
            foreach (Image i in Images)
            {
                i.GetComponent<Image>().color = new Color(i.GetComponent<Image>().color.r, i.GetComponent<Image>().color.g, i.GetComponent<Image>().color.b, 1);
            }
        }
    }
}
