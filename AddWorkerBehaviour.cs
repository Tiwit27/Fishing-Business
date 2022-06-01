using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AddWorkerBehaviour : MonoBehaviour
{
    public WorkersNameDataBase WNDB;
    public ScriptInMyWorker SIMW;
    public GameObject addWorkers;
    public GameBehaviour GB;
    public GameObject prefab;
    public Transform start;
    public Transform end;
    GameObject worker;
    public GameObject[] parents = new GameObject[4];
    public int categoryID;
    public GameObject[] workers = new GameObject[4];
    int[] nextWorker = new int[4];
    public string Wname;
    public TMP_Text Workername;
    public GameObject info;
    public TMP_Text skills;
    public TMP_Text ambitions;
    public TMP_Text bonus;
    public int i;
    void Start()
    {
        info.SetActive(false);
        addWorkers.SetActive(false);
    }
    public void Open()
    {
        addWorkers.SetActive(true);
        GB.myWorkers.SetActive(false);
        GB.background4.SetActive(false);
        GB.background3.SetActive(true);
    }
    public void AddWorker()
    {
        switch (categoryID)
        {
            case 1:
                worker = Instantiate(prefab, start);
                worker.transform.parent = parents[0].transform.parent;
                worker.transform.position = start.transform.position;
                worker.transform.position -= new Vector3(0, nextWorker[0],0);
                nextWorker[0] += 190;
                worker.GetComponentInChildren<TMP_Text>().text = Wname;
                SIMW = worker.GetComponentInChildren<ScriptInMyWorker>();
                worker.GetComponentInChildren<ScriptInMyWorker>().AWB = this.gameObject.GetComponent<AddWorkerBehaviour>();
                SIMW.ID = i;
                i++;
                break;
            case 2:
                worker = Instantiate(prefab, start);
                worker.transform.parent = parents[1].transform.parent;
                worker.transform.position = start.transform.position;
                worker.transform.position -= new Vector3(0, nextWorker[1], 0);
                nextWorker[1] += 190;
                worker.GetComponentInChildren<TMP_Text>().text = Wname;
                SIMW = worker.GetComponentInChildren<ScriptInMyWorker>();
                worker.GetComponentInChildren<ScriptInMyWorker>().AWB = this.gameObject.GetComponent<AddWorkerBehaviour>();
                SIMW.ID = i;
                i++;
                break;
            case 3:
                worker = Instantiate(prefab, start);
                worker.transform.parent = parents[2].transform.parent;
                worker.transform.position = start.transform.position;
                worker.transform.position -= new Vector3(0, nextWorker[2], 0);
                nextWorker[2] += 190;
                worker.GetComponentInChildren<TMP_Text>().text = Wname;
                SIMW = worker.GetComponentInChildren<ScriptInMyWorker>();
                worker.GetComponentInChildren<ScriptInMyWorker>().AWB = this.gameObject.GetComponent<AddWorkerBehaviour>();
                SIMW.ID = i;
                i++;
                break;
            case 4:
                worker = Instantiate(prefab, start);
                worker.transform.parent = parents[3].transform.parent;
                worker.transform.position = start.transform.position;
                worker.transform.position -= new Vector3(0, nextWorker[3], 0);
                nextWorker[3] += 190;
                worker.GetComponentInChildren<TMP_Text>().text = Wname;
                SIMW = worker.GetComponentInChildren<ScriptInMyWorker>();
                worker.GetComponentInChildren<ScriptInMyWorker>().AWB = this.gameObject.GetComponent<AddWorkerBehaviour>();
                SIMW.ID = i;
                i++;
                break;
        }
    }
    public void Exit()
    {
        addWorkers.SetActive(false);
        GB.myWorkers.SetActive(true);
        GB.background4.SetActive(true);
        GB.background3.SetActive(false);
        info.SetActive(false);
    }
    public void Cashier()
    {
        workers[1].SetActive(false);
        workers[2].SetActive(false);
        workers[3].SetActive(false);
        workers[0].SetActive(true);
    }
    public void Service()
    {
        workers[1].SetActive(true);
        workers[2].SetActive(false);
        workers[3].SetActive(false);
        workers[0].SetActive(false);
    }
    public void Security()
    {
        workers[1].SetActive(false);
        workers[2].SetActive(true);
        workers[3].SetActive(false);
        workers[0].SetActive(false);
    }
    public void ADManager()
    {
        workers[1].SetActive(false);
        workers[2].SetActive(false);
        workers[3].SetActive(true);
        workers[0].SetActive(false);
    }
    public void MoreInfo()
    {
        info.SetActive(true);
        skills.text = "Umiejêtnoœci: " + WNDB.SkillsSave[SIMW.ID];
        AmbitionandBonus();
    }
    public void AmbitionandBonus()
    {
        switch (categoryID)
        {
            case 1:
                if (WNDB.SkillsSave[SIMW.ID] <= 15)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC1[0];
                }
                if (WNDB.SkillsSave[SIMW.ID] <= 30 && WNDB.SkillsSave[SIMW.ID] > 15)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC1[1];
                }
                if (WNDB.SkillsSave[SIMW.ID] <= 50 && WNDB.SkillsSave[SIMW.ID] > 30)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC1[2];
                }
                if (WNDB.SkillsSave[SIMW.ID] <= 80 && WNDB.SkillsSave[SIMW.ID] > 50)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC1[3];
                }
                if (WNDB.SkillsSave[SIMW.ID] <= 100 && WNDB.SkillsSave[SIMW.ID] > 80)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC1[4];
                }
                break;
            case 2:
                if (WNDB.SkillsSave[SIMW.ID] <= 15)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC2[0];
                }
                if (WNDB.SkillsSave[SIMW.ID] <= 30 && WNDB.SkillsSave[SIMW.ID] > 15)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC2[1];
                }
                if (WNDB.SkillsSave[SIMW.ID] <= 50 && WNDB.SkillsSave[SIMW.ID] > 30)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC2[2];
                }
                if (WNDB.SkillsSave[SIMW.ID] <= 80 && WNDB.SkillsSave[SIMW.ID] > 50)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC2[3];
                }
                if (WNDB.SkillsSave[SIMW.ID] <= 100 && WNDB.SkillsSave[SIMW.ID] > 80)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC2[4];
                }
                break;
            case 3:
                if (WNDB.SkillsSave[SIMW.ID] <= 15)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC3[0];
                }
                if (WNDB.SkillsSave[SIMW.ID] <= 30 && WNDB.SkillsSave[SIMW.ID] > 15)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC3[1];
                }
                if (WNDB.SkillsSave[SIMW.ID] <= 50 && WNDB.SkillsSave[SIMW.ID] > 30)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC3[2];
                }
                if (WNDB.SkillsSave[SIMW.ID] <= 80 && WNDB.SkillsSave[SIMW.ID] > 50)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC3[3];
                }
                if (WNDB.SkillsSave[SIMW.ID] <= 100 && WNDB.SkillsSave[SIMW.ID] > 80)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC3[4];
                }
                break;
            case 4:
                if (WNDB.SkillsSave[SIMW.ID] <= 15)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC4[0];
                }
                if (WNDB.SkillsSave[SIMW.ID] <= 30 && WNDB.SkillsSave[SIMW.ID] > 15)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC4[1];
                }
                if (WNDB.SkillsSave[SIMW.ID] <= 50 && WNDB.SkillsSave[SIMW.ID] > 30)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC4[2];
                }
                if (WNDB.SkillsSave[SIMW.ID] <= 80 && WNDB.SkillsSave[SIMW.ID] > 50)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC4[3];
                }
                if (WNDB.SkillsSave[SIMW.ID] <= 100 && WNDB.SkillsSave[SIMW.ID] > 80)
                {
                    bonus.GetComponentInChildren<RawImage>().texture = WNDB.bonusC4[4];
                }
                break;
        }
        switch (WNDB.AmbitionsSave[SIMW.ID])
        {
            case 0:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[0];
                break;
            case 1:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[1];
                break;
            case 2:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[2];
                break;
            case 3:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[3];
                break;
            case 4:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[4];
                break;
            case 5:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[5];
                break;
        }
        
    }
}
