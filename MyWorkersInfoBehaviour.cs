using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWorkersInfoBehaviour : MonoBehaviour
{
    public GameObject myWorkers;
    public int ID;
    public GameObject[] category = new GameObject[4];
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            category[i].SetActive(false);
        }
    }
    public void Category1()
    {
        ID = 1;
        ChangeCategory();
    }
    public void Category2()
    {
        ID = 2;
        ChangeCategory();
    }
    public void Category3()
    {
        ID = 3;
        ChangeCategory();
    }
    public void Category4()
    {
        ID = 4;
        ChangeCategory();
    }
    void ChangeCategory()
    {
        switch (ID)
        {
            case 1:
                category[0].SetActive(true);
                category[1].SetActive(false);
                category[2].SetActive(false);
                category[3].SetActive(false);
                break;
            case 2:
                category[0].SetActive(false);
                category[1].SetActive(true);
                category[2].SetActive(false);
                category[3].SetActive(false);
                break;
            case 3:
                category[0].SetActive(false);
                category[1].SetActive(false);
                category[2].SetActive(true);
                category[3].SetActive(false);
                break;
            case 4:
                category[0].SetActive(false);
                category[1].SetActive(false);
                category[2].SetActive(false);
                category[3].SetActive(true);
                break;
        }
    }
}
