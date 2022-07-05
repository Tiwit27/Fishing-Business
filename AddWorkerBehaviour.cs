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
    public GameObject worker;
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
    public TMP_Text workerAmbitionsD;
    public TMP_Text descriptionB;
    public int ID;
    public GameObject enterButton;
    public RawImage[] rawImages = new RawImage[4];
    public TMP_Text[] names = new TMP_Text[4];
    public Texture button;
    public Texture addButton;
    public GameObject error;
    public GameObject employed;
    public int x;
    int z;
    int y;
    public int b;
    public int c;
    public int d;
    int p;
    int r;
    //employed
    public TMP_Text workerName;
    public TMP_Text workerSkills;
    public RawImage workerAmbitions;
    public TMP_Text workerAmbitionsD1;
    public RawImage workerBonus;
    public TMP_Text workerBonusD;
    public int skillID;
    public TMP_Text salary;
    void Start()
    {
        employed.SetActive(false);
        info.SetActive(false);
        addWorkers.SetActive(false);
        error.SetActive(false);
    }
    public void Open()
    {
        if (WNDB.NameSave.Count >= 1 && rawImages[categoryID - 1].texture == addButton)
        {
            error.SetActive(false);
            ID = SIMW.ID;
            addWorkers.SetActive(true);
            GB.myWorkers.SetActive(false);
            GB.background4.SetActive(false);
            GB.background3.SetActive(true);
        }
        else if (WNDB.NameSave.Count >= 1 && rawImages[categoryID - 1].texture == button)
        {
            error.SetActive(false);
            ID = SIMW.ID;
            GB.myWorkers.SetActive(false);
            GB.background4.SetActive(true);
            employed.SetActive(true);
            bool check = false;
            for (int i = 0; check == false; i++)
            {
                if ((x - 1) == WNDB.LakeID[i] && categoryID == WNDB.CategoryID[i])
                {
                    z = i;
                    check = true;
                }
            }
            workerName.text = WNDB.WorkerOnThisLake[c + categoryID];
            workerSkills.text = "Umiejêtnoœci: " + WNDB.SkillsSave[WNDB.WorkerID[r]];
            //ambicje
            workerAmbitions.texture = WNDB.ambitions[WNDB.AmbitionsSave[WNDB.WorkerID[r]]];
            switch (WNDB.AmbitionsSave[WNDB.WorkerID[r]])
            {
                case 0:
                    workerAmbitionsD1.text = "Ambicja znikoma, pracownik nie bêdzie rozwija³ swoich umiejêtnoœci.";
                    break;
                case 1:
                    workerAmbitionsD1.text = "Ambicja bardzo ma³a, pracownik bêdzie rozwija³ swoje umiejêtnoœci w bardzo wolnym tempie.";
                    break;
                case 2:
                    workerAmbitionsD1.text = "Ambicja ma³a, pracownik bêdzie rozwija³ swoje umiejêtnoœci w wolnym tempie.";
                    break;
                case 3:
                    workerAmbitionsD1.text = "Ambicja œrednia, pracownik bêdzie rozwija³ swoje umiejêtnoœci w przeciêtnym tempie.";
                    break;
                case 4:
                    workerAmbitionsD1.text = "Ambicja du¿a, pracownik bêdzie rozwija³ swoje umiejêtnoœci w szybkim tempie.";
                    break;
                case 5:
                    workerAmbitionsD1.text = "Ambicja bardzo du¿a, pracownik bêdzie rozwija³ swoje umiejêtnoœci w bardzo szybkim tempie.";
                    break;
            }
            //bonus
            switch (categoryID)
            {
                case 1:
                    workerBonusD.text = "Ten bonus umo¿liwia zarabianie wiêkszej iloœci pieniêdzy w zale¿noœci od jego poziomu";
                    break;
                case 2:
                    workerBonusD.text = "Ten bonus umo¿liwia tañsze utrzymanie ³owiska w zale¿noœci od jego poziomu";
                    break;
                case 3:
                    workerBonusD.text = "Ten bonus umo¿liwia mniej kradzie¿y ryb w zale¿noœci od jego poziomu";
                    break;
                case 4:
                    workerBonusD.text = "Ten bonus umo¿liwia wiêksz¹ iloœæ klientów w zale¿noœci od jego poziomu";
                    break;
            }
            if (WNDB.SkillsSave[WNDB.WorkerID[r]] <= 15)
            {
                skillID = 1;
            }
            if (WNDB.SkillsSave[WNDB.WorkerID[r]] <= 30 && WNDB.SkillsSave[WNDB.WorkerID[r]] > 15)
            {
                skillID = 2;
            }
            if (WNDB.SkillsSave[WNDB.WorkerID[r]] <= 50 && WNDB.SkillsSave[WNDB.WorkerID[r]] > 30)
            {
                skillID = 3;
            }
            if (WNDB.SkillsSave[WNDB.WorkerID[r]] <= 80 && WNDB.SkillsSave[WNDB.WorkerID[r]] > 50)
            {
                skillID = 4;
            }
            if (WNDB.SkillsSave[WNDB.WorkerID[r]] <= 100 && WNDB.SkillsSave[WNDB.WorkerID[r]] > 80)
            {
                skillID = 5;
            }
            //sprawdzenie kategorii
            if (categoryID == 1)
            {
                switch (skillID)
                {
                    case 1:
                        workerBonus.texture = WNDB.bonusC1[0];
                        break;
                    case 2:
                        workerBonus.texture = WNDB.bonusC1[1];
                        break;
                    case 3:
                        workerBonus.texture = WNDB.bonusC1[2];
                        break;
                    case 4:
                        workerBonus.texture = WNDB.bonusC1[3];
                        break;
                    case 5:
                        workerBonus.texture = WNDB.bonusC1[4];
                        break;
                }
            }
            if (categoryID == 2)
            {
                switch (skillID)
                {
                    case 1:
                        workerBonus.texture = WNDB.bonusC2[0];
                        break;
                    case 2:
                        workerBonus.texture = WNDB.bonusC2[1];
                        break;
                    case 3:
                        workerBonus.texture = WNDB.bonusC2[2];
                        break;
                    case 4:
                        workerBonus.texture = WNDB.bonusC2[3];
                        break;
                    case 5:
                        workerBonus.texture = WNDB.bonusC2[4];
                        break;
                }
            }
            if (categoryID == 3)
            {
                switch (skillID)
                {
                    case 1:
                        workerBonus.texture = WNDB.bonusC3[0];
                        break;
                    case 2:
                        workerBonus.texture = WNDB.bonusC3[1];
                        break;
                    case 3:
                        workerBonus.texture = WNDB.bonusC3[2];
                        break;
                    case 4:
                        workerBonus.texture = WNDB.bonusC3[3];
                        break;
                    case 5:
                        workerBonus.texture = WNDB.bonusC3[4];
                        break;
                }
            }
            if (categoryID == 4)
            {
                switch (skillID)
                {
                    case 1:
                        workerBonus.texture = WNDB.bonusC4[0];
                        break;
                    case 2:
                        workerBonus.texture = WNDB.bonusC4[1];
                        break;
                    case 3:
                        workerBonus.texture = WNDB.bonusC4[2];
                        break;
                    case 4:
                        workerBonus.texture = WNDB.bonusC4[3];
                        break;
                    case 5:
                        workerBonus.texture = WNDB.bonusC4[4];
                        break;
                }
            }
            salary.text = "Wyp³ata: " + WNDB.SalarySave[WNDB.WorkerID[r]] + " z³";
        }
        else
        {
            error.SetActive(true);
        }
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
                int x1 = 0;
                if (x1 == 0)
                {
                    GB.WB.first[0] = worker;
                    x1++;
                }
                GB.WB.last[0] = worker;
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
                int x2 = 0;
                if (x2 == 0)
                {
                    GB.WB.first[1] = worker;
                    x2++;
                }
                GB.WB.last[1] = worker;
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
                int x3 = 0;
                if (x3 == 0)
                {
                    GB.WB.first[2] = worker;
                    x3++;
                }
                GB.WB.last[2] = worker;
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
                int x4 = 0;
                if (x4 == 0)
                {
                    GB.WB.first[3] = worker;
                    x4++;
                }
                GB.WB.last[3] = worker;
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
                workerAmbitionsD.text = "Ambicja znikoma, pracownik nie bêdzie rozwija³ swoich umiejêtnoœci.";
                break;
            case 1:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[1];
                workerAmbitionsD.text = "Ambicja bardzo ma³a, pracownik bêdzie rozwija³ swoje umiejêtnoœci w bardzo wolnym tempie.";
                break;
            case 2:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[2];
                workerAmbitionsD.text = "Ambicja ma³a, pracownik bêdzie rozwija³ swoje umiejêtnoœci w wolnym tempie.";
                break;
            case 3:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[3];
                workerAmbitionsD.text = "Ambicja œrednia, pracownik bêdzie rozwija³ swoje umiejêtnoœci w przeciêtnym tempie.";
                break;
            case 4:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[4];
                workerAmbitionsD.text = "Ambicja du¿a, pracownik bêdzie rozwija³ swoje umiejêtnoœci w szybkim tempie.";
                break;
            case 5:
                ambitions.GetComponentInChildren<RawImage>().texture = WNDB.ambitions[5];
                workerAmbitionsD.text = "Ambicja bardzo du¿a, pracownik bêdzie rozwija³ swoje umiejêtnoœci w bardzo szybkim tempie.";
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
            FireFromJob();
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
    public void FireFromJob()
    {
        bool check = false;
        for (int i = 0; check == false; i++)
        {
            if ((x - 1) == WNDB.LakeID[i] && categoryID == WNDB.CategoryID[i])
            {
                WNDB.LakeID.RemoveAt(i);
                WNDB.CategoryID.RemoveAt(i);
                WNDB.NameWorker.RemoveAt(i);
                WNDB.WorkerOnThisLake[c + categoryID] = "";
                WNDB.IsWorking[WNDB.WorkerID[i]] = false;
                WNDB.WorkerID.RemoveAt(i);
                check = true;
            }
        }
        rawImages[categoryID - 1].texture = addButton;
        names[categoryID - 1].text = "";
    }
    public void Exit1()
    {
        GB.myWorkers.SetActive(true);
        GB.background4.SetActive(true);
        employed.SetActive(false);
    }
}
