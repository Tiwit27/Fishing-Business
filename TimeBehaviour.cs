using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimeBehaviour : MonoBehaviour
{
    public StartGame SG;
    public TextMeshProUGUI data;
    public TextMeshProUGUI time;
    public int day = 1;
    public int month = 1;
    public int year = 2022;
    public float timeSpeed;
    public RawImage startStop;
    public Texture[] textures = new Texture[2];
    public GameObject edgeBackground;
    public bool check;
    public float x;
    void Start()
    {
        check = false;
        edgeBackground.SetActive(false);
    }
    void Update()
    {
        if (day == 32 && month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            day = 1;
            month++;
        }
        if (day == 31 && month == 4 || month == 6 || month == 9 || month == 11)
        {
            day = 1;
            month++;
        }
        if (day == 29 && month == 2 && 0 != year % 4)
        {
            day = 1;
            month++;
        }
        if (day == 30 && month == 2 && 0 == year % 4)
        {
            day = 1;
            month++;
        }
        if (day == 32 && month == 12)
        {
            day = 1;
            month = 1;
            year++;
        }
        //przypisanie
        if (SG.MainMenu.activeSelf)
        {
            if (day <= 9 && month <= 9)
            {
                data.text = "0" + day + "." + "0" + month + "." + year;
            }
            else if (day <= 9)
            {
                data.text = "0" + day + "." + month + "." + year;
            }
            else if (month <= 9)
            {
                data.text = day + "." + "0" + month + "." + year;
            }
        }
        //dzia³anie czasu
        if (startStop.texture == textures[1])
        {
            edgeBackground.SetActive(true);
            x += Time.deltaTime;
            if (x >= 3)
            {
                day++;
                x = 0;
            }
        }
        else if(startStop.texture == textures[0])
        {
            edgeBackground.SetActive(false);
            x = 0;
        }
    }
    public void ChangeTexture()
    {
        if (startStop.texture == textures[0])
        {
            startStop.texture = textures[1];
        }
        else if (startStop.texture == textures[1])
        {
            startStop.texture = textures[0];
        }
    }
}
