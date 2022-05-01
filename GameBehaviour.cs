using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameBehaviour : MonoBehaviour
{
    public StartGame SG;
    public MyLakesBehaviour MLB;
    public FishingClubsBehaviour FCB;
    public WorkersBehaviour WB;
    public GameObject buyLakes;
    public bool buyLakesIsOn;
    public GameObject obram�wka;
    public GameObject obram�wka1;
    public TextMeshProUGUI LakesQuantity;
    public GameObject stopWindow;
    public GameObject fishingClubs;
    public GameObject background3;
    public GameObject myWorkers;
    void Start()
    {
        obram�wka1.SetActive(false);
        background3.SetActive(false);
        fishingClubs.SetActive(false);
        stopWindow.SetActive(false);
        Time.timeScale = 1;
        myWorkers.SetActive(false);
    }
    //lakes
    public void OpenLakes()
    {
        //otwieranie okna z kupowaniem �owisk
        buyLakes.SetActive(true);
        buyLakesIsOn = true;
        obram�wka.SetActive(true);
        SG.MainMenu.SetActive(false);
        SG.background2.SetActive(false);
        WB.workers.SetActive(false);
    }
    public void OpenMyLakes()
    {
        MLB.myLakes.SetActive(true);
        SG.MainMenu.SetActive(false);
        SG.background2.SetActive(false);
        obram�wka.SetActive(true);
        SG.LB.lakes.SetActive(false);
        SG.LB.lakeInformation.SetActive(false);
        fishingClubs.SetActive(false);
        background3.SetActive(false);
        myWorkers.SetActive(false);
        WB.workers.SetActive(false);
    }
    //fishingClubs
    public void OpenFishingClubs()
    {
        fishingClubs.SetActive(true);
        SG.MainMenu.SetActive(false);
        background3.SetActive(true);
        obram�wka1.SetActive(true);
        FCB.list.SetActive(true);
        FCB.Info.SetActive(false);
        WB.workers.SetActive(false);
    }
    public void OpenMyWorkers()
    {
        MLB.myLakes.SetActive(false);
        myWorkers.SetActive(true);
        background3.SetActive(true);
        WB.workers.SetActive(false);
    }
    public void OpenWorkers()
    {
        background3.SetActive(false);
        SG.background.SetActive(true);
        SG.background2.SetActive(false);
        WB.workers.SetActive(true);
        MLB.myLakes.SetActive(false);
        SG.MainMenu.SetActive(false);
    }
    void Update()
    {
        //stop Game
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            stopWindow.SetActive(true);
        }
    }
    public void Return()
    {
        Time.timeScale = 1;
        stopWindow.SetActive(false);
    }
    public void Settings()
    {
        Debug.Log("Settings");
    }
    public void Exit()
    {
    }
}
