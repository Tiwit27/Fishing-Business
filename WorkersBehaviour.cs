using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkersBehaviour : MonoBehaviour
{
    public GameBehaviour GB;
    public GameObject workers;
    public GameObject[] workersCategory = new GameObject[4];
    public GameObject[] workersToScroll = new GameObject[4];
    public int x;
    public int speed;
    public GameObject[] first = new GameObject[4];
    public GameObject[] last = new GameObject[4];
    public Transform[] end = new Transform[4];
    public GameObject addWorkers;
    public float y;
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
        int z = 1;
        //przesuwanie pracowników
        //WYWALA B£¥D BO CATEGORYID NIE JEST JESZCZE PRZYPISANY
        if (GB.AWB.categoryID == 0)
        {
            z = 0;
        }
        else
        {
            z = 1;
        }
        if (workersToScroll[GB.AWB.categoryID - z].activeSelf && addWorkers.activeSelf)
        {
            if (GB.AWB.WNDB.WorkerCategoryID[GB.AWB.categoryID - z] >= 5)
            {
                workersToScroll[GB.AWB.categoryID - z].transform.position += new Vector3(0, Input.mouseScrollDelta.y * speed * -1, 0);
                if (workersToScroll[GB.AWB.categoryID - 1].transform.position.y < 640)
                {
                    workersToScroll[GB.AWB.categoryID - 1].transform.position = new Vector3(workersToScroll[GB.AWB.categoryID - 1].transform.position.x, 641, workersToScroll[GB.AWB.categoryID - 1].transform.position.z);
                }
                if (last[GB.AWB.categoryID - 1].transform.position.y >= end[GB.AWB.categoryID - 1].transform.position.y)
                {
                    y = workersToScroll[GB.AWB.categoryID - 1].transform.position.y;
                    workersToScroll[GB.AWB.categoryID - 1].transform.position = new Vector3(workersToScroll[GB.AWB.categoryID - 1].transform.position.x, y - 20 , workersToScroll[GB.AWB.categoryID - 1].transform.position.z);
                }
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
