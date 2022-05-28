using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkersBehaviour : MonoBehaviour
{
    public GameBehaviour GB;
    public GameObject workers;
    public GameObject[] workersCategory = new GameObject[4];
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && workers.activeSelf)
        {
            GB.background3.SetActive(false);
            GB.SG.background.SetActive(false);
            GB.SG.background2.SetActive(true);
            GB.WB.workers.SetActive(false);
            GB.SG.MainMenu.SetActive(true);
            for (int i = 0; i < 4; i++)
            {
                workersCategory[i].SetActive(false);
            }
        }
    }
    public void Category1()
    {
        for (int i = 0; i < 4; i++)
        {
            workersCategory[i].SetActive(false);
        }
        workersCategory[0].SetActive(true);
    }
    public void Category2()
    {
        for (int i = 0; i < 4; i++)
        {
            workersCategory[i].SetActive(false);
        }
        workersCategory[1].SetActive(true);
    }
    public void Category3()
    {
        for (int i = 0; i < 4; i++)
        {
            workersCategory[i].SetActive(false);
        }
        workersCategory[2].SetActive(true);
    }
    public void Category4()
    {
        for (int i = 0; i < 4; i++)
        {
            workersCategory[i].SetActive(false);
        }
        workersCategory[3].SetActive(true);
    }
}
