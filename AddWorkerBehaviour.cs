using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AddWorkerBehaviour : MonoBehaviour
{
    public DataBase DB;
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
    public TMP_Text descriptionA;
    public TMP_Text descriptionB;
    public int ID;
    public GameObject enterButton;
    public RawImage[] rawImages = new RawImage[4];
    public TMP_Text[] names = new TMP_Text[4];
    public Texture button;
    public Texture addButton;
    public int x;
    int z;
    int y;
    public int b;
    public int c;
    public int d;
    int p;
    void Start()
    {
        info.SetActive(false);
        addWorkers.SetActive(false);
    }
    public void Open()
    {
        ID = SIMW.ID;
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
        //bonus
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
                descriptionB.text =  "Ten bonus umo¿liwia zarabianie wiêkszej iloœci pieniêdzy w zale¿noœci od jego poziomu";
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
                descriptionB.text = "Ten bonus umo¿liwia tañsze utrzymanie ³owiska w zale¿noœci od jego poziomu";
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
                descriptionB.text = "Ten bonus umo¿liwia mniej kradzie¿y ryb w zale¿noœci od jego poziomu";
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
                descriptionB.text = "Ten bonus umo¿liwia wiêksz¹ iloœæ klientów w zale¿noœci od jego poziomu";
                break;
        }
        //ambicje
        switch (WNDB.AmbitionsSave[SIMW.ID])
        {
            case 0:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[0];
                descriptionA.text = "Ambicja znikoma, pracownik nie bêdzie rozwija³ swoich umiejêtnoœci.";
                break;
            case 1:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[1];
                descriptionA.text = "Ambicja bardzo ma³a, pracownik bêdzie rozwija³ swoje umiejêtnoœci w bardzo wolnym tempie.";
                break;
            case 2:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[2];
                descriptionA.text = "Ambicja ma³a, pracownik bêdzie rozwija³ swoje umiejêtnoœci w wolnym tempie.";
                break;
            case 3:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[3];
                descriptionA.text = "Ambicja œrednia, pracownik bêdzie rozwija³ swoje umiejêtnoœci w przeciêtnym tempie.";
                break;
            case 4:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[4];
                descriptionA.text = "Ambicja du¿a, pracownik bêdzie rozwija³ swoje umiejêtnoœci w szybkim tempie.";
                break;
            case 5:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[5];
                descriptionA.text = "Ambicja bardzo du¿a, pracownik bêdzie rozwija³ swoje umiejêtnoœci w bardzo szybkim tempie.";
                break;
        }
        //check is worker is employed
        ID = SIMW.ID;
        if (WNDB.IsWorking[ID] == true)
        {
            enterButton.SetActive(false);
        }
        else
        {
            enterButton.SetActive(true);
        }
    }
    public void ID1()
    {
        categoryID = 1;
    }
    public void ID2()
    {
        categoryID = 2;
    }
    public void ID3()
    {
        categoryID = 3;
    }
    public void ID4()
    {
        categoryID = 4;
    }
    public void Confirm()
    {
        //zapis pracownika do WNDB.WorkerOnThisLake
        ID = SIMW.ID;
        for (p = 0; p < WNDB.MyLakeID.Count; p++)
        {
            if (GB.MLB.MLIIO.name1 == WNDB.MyLakeID[p])
            {
                WNDB.WorkerID.Add(SIMW.ID);
                WNDB.NameWorker.Add(Workername.text);
                WNDB.LakeID.Add(p);
                y = p;
                WNDB.CategoryID.Add(categoryID);
                WNDB.IsWorking[ID] = true;
            }
        }
        p = y;
        addWorkers.SetActive(false);
        GB.myWorkers.SetActive(true);
        GB.background4.SetActive(true);
        GB.background3.SetActive(false);
        info.SetActive(false);
        RawImageReset();
    }
    public void RawImageReset()
    {
        if (WNDB.WorkerOnThisLake[c + categoryID] != "")
        {
            bool check = false;
            for (int i = 0; check == false; i++)
            {
                if ((x - 1) == WNDB.LakeID[i] && categoryID == WNDB.CategoryID[i])
                {
                    WNDB.LakeID.RemoveAt(i);
                    WNDB.CategoryID.RemoveAt(i);
                    WNDB.NameWorker.RemoveAt(i);
                    WNDB.IsWorking[WNDB.WorkerID[i]] = false;
                    check = true;
                }
            }
        }
        WNDB.WorkerOnThisLake[c + categoryID] = Workername.text;
        rawImages[categoryID - 1].texture = button;
        names[categoryID - 1].text = Workername.text;
    }
    public void Check()
    {
        //sprawdzenie czy ktoœ jest zatrudniony na tym stanowisku
        for (b = 1; b <= 4;)
        {
            c = (x - 1) * 4;
            if (WNDB.WorkerOnThisLake[c + b] != "" && WNDB.WorkerOnThisLake[c + b] != "NULL")
            {
                rawImages[b - 1].texture = button;
                names[b - 1].text = WNDB.WorkerOnThisLake[c + b];
            }
            b++;
        }
        if (b == 5)
        {
            b = 4;
        }
    }
    public void RawImageClear()
    {
        for (int i = 0; i < 4; i++)
        {
            rawImages[i].texture = addButton;
            names[i].text = "";
        }
    }
    public void IDPrzypisz()
    {
        for (int i = 0; i < WNDB.MyLakeID.Count; i++)
        {
            if (GB.MLB.MLIIO.name1 == WNDB.MyLakeID[i])
            {
                x = i + 1;
            }
        }
    }
}
