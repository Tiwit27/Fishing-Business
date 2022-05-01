using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkersBehaviour : MonoBehaviour
{
    public GameBehaviour GB;
    public GameObject workers;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && workers.activeSelf)
        {
            GB.background3.SetActive(false);
            GB.SG.background.SetActive(false);
            GB.SG.background2.SetActive(true);
            GB.WB.workers.SetActive(false);
            GB.SG.MainMenu.SetActive(true);
        }
    }
}
