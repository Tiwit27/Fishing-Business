using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWorkersBehaviour : MonoBehaviour
{
    public GameBehaviour GB;
    public void Exit()
    {
        GB.background3.SetActive(false);
        GB.myWorkers.SetActive(false);
        GB.MLB.myLakes.SetActive(true);
        GB.SG.MainMenu.SetActive(false);
        GB.SG.background2.SetActive(false);
        GB.obramówka.SetActive(true);
        GB.SG.LB.lakes.SetActive(false);
        GB.SG.LB.lakeInformation.SetActive(false);
        GB.fishingClubs.SetActive(false);
    }
}
