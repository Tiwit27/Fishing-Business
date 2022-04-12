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
    int hour;
    int minute;
    public int day = 1;
    public int month = 1;
    public int year = 2022;
    public float timeSpeed;
    public bool timeIsOn;
    public int arrowID = 0;
    public bool check;
    public Color color;
    void Start()
    {
        check = false;
        //minute = 0;
        //hour = 0;
    }
    void Update()
    {

        //dzia³anie czasu
        /*if (minute >= 60)
        {
            minute = 0;
            hour++;
        }
        if (hour >= 24)
        {
            day++;
            hour = 0;
        }*/
        if (day == 32 && month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            day = 1;
            month++;
        }
        if(day == 31 && month == 4 || month == 6 || month == 9 || month == 11)
        {
            day = 1;
            month++;
        }
        if(day == 29 && month == 2 && 0 != year % 4)
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
            /*if (minute <= 9 && hour <= 9)
            {
                time.text = "0" + hour + ":0" + minute;
            }
            else if (minute <= 9)
            {
                time.text = hour + ":0" + minute;
            }
            else if (hour <= 9)
            {
                time.text = "0" + hour + ":" + minute;
            }*/
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
    }
    public void TimeStart()
    {
        StartCoroutine(Czas());
    }
    IEnumerator Czas()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeSpeed);
            day++;
        }
    }
    public void TimeArrows()
    {
        //kolory
        if (arrowID == 1)
        {
            //arrow.GetComponent<RawImage>().color = Color.white;
            //arrow1.GetComponent<RawImage>().color = Color.white;
            //arrow2.GetComponent<RawImage>().color = Color.white;
            //arrow.GetComponent<RawImage>().color = color;
        }
        if (arrowID == 2)
        {
            //arrow.GetComponent<RawImage>().color = color;
            //arrow1.GetComponent<RawImage>().color = color;
        }
        if (arrowID == 3)
        {
            //arrow.GetComponent<RawImage>().color = color;
            //arrow1.GetComponent<RawImage>().color = color;
            //arrow2.GetComponent<RawImage>().color = color;
        }
        //szybkoœæ czasu
        /*if (arrowID == 1)
        {
            timeSpeed = 60;
        }
        if (arrowID == 2)
        {
            timeSpeed = 50;
        }
        if (arrowID == 3)
        {
            timeSpeed = 40;
        }*/
    }
    /*
    public void TimeStart()
    {
        StartCoroutine(TimeWork());
    }
    public IEnumerator TimeWork()
    {
        while(timeIsOn)
        {
            yield return new WaitForSeconds(40 / timeSpeed * Time.deltaTime);
            minute++;
        }
    }
    */
    public void Arrows()
    {
        arrowID++;
        if (arrowID == 4)
        {
            arrowID = 1;
        }
        TimeArrows();
    }
}
