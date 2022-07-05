using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WorkersBuyBehaviour : MonoBehaviour
{
    public MoneyBehaviour MB;
    public WorkersScriptInObject WSIO;
    public GameBehaviour GB;
    int Man;
    public WorkersNameDataBase WNDB;
    public TMP_Text[] cashier = new TMP_Text[8];
    public TMP_Text[] service = new TMP_Text[8];
    public TMP_Text[] security = new TMP_Text[8];
    public TMP_Text[] manager = new TMP_Text[8];
    int nameID;
    public GameObject workersInfo;
    public GameObject background;
    public TMP_Text name;
    public RawImage bonus;
    int ID;
    int skillID;
    public TMP_Text description;
    public int categoryID;
    public RawImage ambitions;
    public TMP_Text descriptionA;
    public TMP_Text skills;
    public TMP_Text wantingSalary;
    int i;
    public TMP_InputField proposedSalary;
    public RawImage face;
    public GameObject buyButton;
    public GameObject stopBuy;
    int x;
    public GameObject tooSmall;

    void Start()
    {
        workersInfo.SetActive(false);
        for (i = 0; i < 8; i++)
        {
            Man = Random.Range(1, 20);
            if (Man <= 10)
            {
                nameID = Random.Range(0, WNDB.Mnames.Count);
                cashier[i].text = WNDB.Mnames[nameID];
            }
            if (Man > 10)
            {
                nameID = Random.Range(0, WNDB.Wnames.Count);
                cashier[i].text = WNDB.Wnames[nameID];
            }
            WNDB.Skills[i] = Random.Range(0, 30);
            WNDB.Ambitions[i] = Random.Range(0, 5);
            if (WNDB.Skills[i] <= 15)
            {
                WNDB.WantingSalary[i] = Random.Range(1600, 1750);
            }
            if (WNDB.Skills[i] <= 45 && WNDB.Skills[i] > 15)
            {
                WNDB.WantingSalary[i] = Random.Range(1751, 1900);
            }
            if (WNDB.Skills[i] <= 75 && WNDB.Skills[i] > 45)
            {
                WNDB.WantingSalary[i] = Random.Range(1901, 2100);
            }
            if (WNDB.Skills[i] <= 100 && WNDB.Skills[i] > 75)
            {
                WNDB.WantingSalary[i] = Random.Range(2101, 2400);
            }
        }
        for (i = 0; i < 8; i++)
        {
            Man = Random.Range(1, 20);
            if (Man <= 10)
            {
                nameID = Random.Range(0, WNDB.Mnames.Count);
                service[i].text = WNDB.Mnames[nameID];
            }
            if (Man > 10)
            {
                nameID = Random.Range(0, WNDB.Wnames.Count);
                service[i].text = WNDB.Wnames[nameID];
            }
            WNDB.Skills[i + 8] = Random.Range(0, 30);
            WNDB.Ambitions[i + 8] = Random.Range(0, 5);
            if (WNDB.Skills[i + 8] <= 15)
            {
                WNDB.WantingSalary[i + 8] = Random.Range(2000, 2200);
            }
            if (WNDB.Skills[i + 8] <= 45 && WNDB.Skills[i + 8] > 15)
            {
                WNDB.WantingSalary[i + 8] = Random.Range(2201, 2500);
            }
            if (WNDB.Skills[i + 8] <= 75 && WNDB.Skills[i + 8] > 45)
            {
                WNDB.WantingSalary[i + 8] = Random.Range(2501, 2750);
            }
            if (WNDB.Skills[i + 8] <= 100 && WNDB.Skills[i + 8] > 75)
            {
                WNDB.WantingSalary[i + 8] = Random.Range(2751, 3000);
            }
        }
        for (i = 0; i < 8; i++)
        {
            Man = Random.Range(1, 20);
            if (Man <= 19)
            {
                nameID = Random.Range(0, WNDB.Mnames.Count);
                security[i].text = WNDB.Mnames[nameID];
            }
            if (Man > 19)
            {
                nameID = Random.Range(0, WNDB.Wnames.Count);
                security[i].text = WNDB.Wnames[nameID];
            }
            WNDB.Skills[i + 16] = Random.Range(0, 30);
            WNDB.Ambitions[i + 16] = Random.Range(0, 5);
            if (WNDB.Skills[i + 16] <= 15)
            {
                WNDB.WantingSalary[i + 16] = Random.Range(2300, 2500);
            }
            if (WNDB.Skills[i + 16] <= 45 && WNDB.Skills[i + 16] > 15)
            {
                WNDB.WantingSalary[i + 16] = Random.Range(2501, 2750);
            }
            if (WNDB.Skills[i + 16] <= 75 && WNDB.Skills[i + 16] > 45)
            {
                WNDB.WantingSalary[i + 16] = Random.Range(2751, 3000);
            }
            if (WNDB.Skills[i + 16] <= 100 && WNDB.Skills[i + 16] > 75)
            {
                WNDB.WantingSalary[i + 16] = Random.Range(3001, 3500);
            }
        }
        for (i = 0; i < 8; i++)
        {
            Man = Random.Range(1, 20);
            if (Man <= 10)
            {
                nameID = Random.Range(0, WNDB.Mnames.Count);
                manager[i].text = WNDB.Mnames[nameID];
            }
            if (Man > 10)
            {
                nameID = Random.Range(0, WNDB.Wnames.Count);
                manager[i].text = WNDB.Wnames[nameID];
            }
            WNDB.Skills[i + 24] = Random.Range(0, 30);
            WNDB.Ambitions[i + 24] = Random.Range(0, 5);
            if (WNDB.Skills[i + 24] <= 15)
            {
                WNDB.WantingSalary[i + 24] = Random.Range(3000, 3250);
            }
            if (WNDB.Skills[i + 24] <= 45 && WNDB.Skills[i + 24] > 15)
            {
                WNDB.WantingSalary[i + 24] = Random.Range(3251, 3550);
            }
            if (WNDB.Skills[i + 24] <= 75 && WNDB.Skills[i + 24] > 45)
            {
                WNDB.WantingSalary[i + 24] = Random.Range(3551, 3800);
            }
            if (WNDB.Skills[i + 24] <= 100 && WNDB.Skills[i + 24] > 75)
            {
                WNDB.WantingSalary[i + 24] = Random.Range(3801, 4200);
            }
        }
    }
    public void OpenInfo()
    {
        WSIO.Przypisz();
        workersInfo.SetActive(true);
        GB.background3.SetActive(false);
        background.SetActive(true);
        GB.SG.background2.SetActive(false);
        GB.WB.workers.SetActive(false);
        name.text = WSIO.name;
        ID = WSIO.ID - 1;
        //przypisanie skilla do skillID
        if (WNDB.Skills[ID] <= 15)
        {
            skillID = 1;
        }
        if (WNDB.Skills[ID] <= 30 && WNDB.Skills[ID] > 15)
        {
            skillID = 2;
        }
        if (WNDB.Skills[ID] <= 50 && WNDB.Skills[ID] > 30)
        {
            skillID = 3;
        }
        if (WNDB.Skills[ID] <= 80 && WNDB.Skills[ID] > 50)
        {
            skillID = 4;
        }
        if (WNDB.Skills[ID] <= 100 && WNDB.Skills[ID] > 80)
        {
            skillID = 5;
        }
        //sprawdzenie kategorii
        if (ID <= 7)
        {
            switch (skillID)
            {
                case 1:
                    bonus.texture = WNDB.bonusC1[0];
                    break;
                case 2:
                    bonus.texture = WNDB.bonusC1[1];
                    break;
                case 3:
                    bonus.texture = WNDB.bonusC1[2];
                    break;
                case 4:
                    bonus.texture = WNDB.bonusC1[3];
                    break;
                case 5:
                    bonus.texture = WNDB.bonusC1[4];
                    break;
            }
            categoryID = 1;
        }
        if (ID <= 15 && ID > 7)
        {
            switch (skillID)
            {
                case 1:
                    bonus.texture = WNDB.bonusC2[0];
                    break;
                case 2:
                    bonus.texture = WNDB.bonusC2[1];
                    break;
                case 3:
                    bonus.texture = WNDB.bonusC2[2];
                    break;
                case 4:
                    bonus.texture = WNDB.bonusC2[3];
                    break;
                case 5:
                    bonus.texture = WNDB.bonusC2[4];
                    break;
            }
            categoryID = 2;
        }
        if (ID <= 23 && ID > 15)
        {
            switch (skillID)
            {
                case 1:
                    bonus.texture = WNDB.bonusC3[0];
                    break;
                case 2:
                    bonus.texture = WNDB.bonusC3[1];
                    break;
                case 3:
                    bonus.texture = WNDB.bonusC3[2];
                    break;
                case 4:
                    bonus.texture = WNDB.bonusC3[3];
                    break;
                case 5:
                    bonus.texture = WNDB.bonusC3[4];
                    break;
            }
            categoryID = 3;
        }
        if (ID <= 31 && ID > 23)
        {
            switch (skillID)
            {
                case 1:
                    bonus.texture = WNDB.bonusC4[0];
                    break;
                case 2:
                    bonus.texture = WNDB.bonusC4[1];
                    break;
                case 3:
                    bonus.texture = WNDB.bonusC4[2];
                    break;
                case 4:
                    bonus.texture = WNDB.bonusC4[3];
                    break;
                case 5:
                    bonus.texture = WNDB.bonusC4[4];
                    break;
            }
            categoryID = 4;
        }
        //przypisywanie opisu bonusu
        switch (categoryID)
        {
            case 1:
                description.text = "Ten bonus umo¿liwia zarabianie wiêkszej iloœci pieniêdzy w zale¿noœci od jego poziomu";
                break;
            case 2:
                description.text = "Ten bonus umo¿liwia tañsze utrzymanie ³owiska w zale¿noœci od jego poziomu";
                break;
            case 3:
                description.text = "Ten bonus umo¿liwia mniej kradzie¿y ryb w zale¿noœci od jego poziomu";
                break;
            case 4:
                description.text = "Ten bonus umo¿liwia wiêksz¹ iloœæ klientów w zale¿noœci od jego poziomu";
                break;
        }
        //przypisywanie ambicjii
        switch (WNDB.Ambitions[ID])
        {
            case 0:
                ambitions.texture = WNDB.ambitions[0];
                descriptionA.text = "Ambicja znikoma, pracownik nie bêdzie rozwija³ swoich umiejêtnoœci.";
                break;
            case 1:
                ambitions.texture = WNDB.ambitions[1];
                descriptionA.text = "Ambicja bardzo ma³a, pracownik bêdzie rozwija³ swoje umiejêtnoœci w bardzo wolnym tempie.";
                break;
            case 2:
                ambitions.texture = WNDB.ambitions[2];
                descriptionA.text = "Ambicja ma³a, pracownik bêdzie rozwija³ swoje umiejêtnoœci w wolnym tempie.";
                break;
            case 3:
                ambitions.texture = WNDB.ambitions[3];
                descriptionA.text = "Ambicja œrednia, pracownik bêdzie rozwija³ swoje umiejêtnoœci w przeciêtnym tempie.";
                break;
            case 4:
                ambitions.texture = WNDB.ambitions[4];
                descriptionA.text = "Ambicja du¿a, pracownik bêdzie rozwija³ swoje umiejêtnoœci w szybkim tempie.";
                break;
            case 5:
                ambitions.texture = WNDB.ambitions[5];
                descriptionA.text = "Ambicja bardzo du¿a, pracownik bêdzie rozwija³ swoje umiejêtnoœci w bardzo szybkim tempie.";
                break;
        }
        skills.text = "Umiejêtnoœci: " + WNDB.Skills[ID] + "/100";
        wantingSalary.text = "Oczekiwana wyp³ata miesiêczna: " + WNDB.WantingSalary[ID] + "zl";
        if (WNDB.StopBuy[ID] == true)
        {
            stopBuy.SetActive(true);
        }
        else
        {
            stopBuy.SetActive(false);
        }
        tooSmall.SetActive(false);
        face.gameObject.SetActive(false);
        proposedSalary.text = "";
    }
    public void Back()
    {
        GB.OpenWorkers();
        workersInfo.SetActive(false);
        background.SetActive(false);
    }
    public void ProposedSalary()
    {
        if (proposedSalary.gameObject.GetComponent<TMP_InputField>().text != "")
        {
            WNDB.IsWorking.Add(false);
            face.gameObject.SetActive(true);
            if (int.Parse(proposedSalary.gameObject.GetComponent<TMP_InputField>().text) <= WNDB.WantingSalary[ID] * 0.75f)
            {
                face.texture = WNDB.faces[2];
                stopBuy.SetActive(true);
                WNDB.StopBuy[ID] = true;
                tooSmall.SetActive(true);
            }
            if (int.Parse(proposedSalary.gameObject.GetComponent<TMP_InputField>().text) > WNDB.WantingSalary[ID] * 0.75f && int.Parse(proposedSalary.gameObject.GetComponent<TMP_InputField>().text) < WNDB.WantingSalary[ID] * 0.94f)
            {
                face.texture = WNDB.faces[1];
                x++;
                if (x >= 3)
                {
                    stopBuy.SetActive(true);
                    WNDB.StopBuy[ID] = true;
                }
                tooSmall.SetActive(true);
            }
            if (int.Parse(proposedSalary.gameObject.GetComponent<TMP_InputField>().text) >= WNDB.WantingSalary[ID] * 0.94f)
            {
                face.texture = WNDB.faces[0];
                x = 0;
                tooSmall.SetActive(false);
                AddWorker();
                GB.AWB.categoryID = categoryID;
                GB.AWB.Wname = name.text;
                GB.AWB.AddWorker();
            }
        }
    }
    public void AddWorker()
    {
        MB.money -= int.Parse(proposedSalary.text);
        WNDB.NameSave.Add(name.text);
        WNDB.SkillsSave.Add(WNDB.Skills[ID]);
        WNDB.AmbitionsSave.Add(WNDB.Ambitions[ID]);
        WNDB.SalarySave.Add(int.Parse(proposedSalary.text));
        Back();
        switch (categoryID)
        {
            case 1:
                Cat1();
                WNDB.WorkerCategoryID[0]++;
                break;
            case 2:
                Cat2();
                WNDB.WorkerCategoryID[1]++;
                break;
            case 3:
                Cat3();
                WNDB.WorkerCategoryID[2]++;
                break;
            case 4:
                Cat4();
                WNDB.WorkerCategoryID[3]++;
                break;
        }
    }
    public void Cat1()
    {
        Man = Random.Range(1, 20);
        if (Man <= 10)
        {
            nameID = Random.Range(0, WNDB.Mnames.Count);
            cashier[ID].text = WNDB.Mnames[nameID];
        }
        if (Man > 10)
        {
            nameID = Random.Range(0, WNDB.Wnames.Count);
            cashier[ID].text = WNDB.Wnames[nameID];
        }
        WNDB.Skills[ID] = Random.Range(0, 30);
        WNDB.Ambitions[ID] = Random.Range(0, 5);
        if (WNDB.Skills[ID] <= 15)
        {
            WNDB.WantingSalary[ID] = Random.Range(1600, 1750);
        }
        if (WNDB.Skills[ID] <= 45 && WNDB.Skills[ID] > 15)
        {
            WNDB.WantingSalary[ID] = Random.Range(1751, 1900);
        }
        if (WNDB.Skills[ID] <= 75 && WNDB.Skills[ID] > 45)
        {
            WNDB.WantingSalary[ID] = Random.Range(1901, 2100);
        }
        if (WNDB.Skills[ID] <= 100 && WNDB.Skills[ID] > 75)
        {
            WNDB.WantingSalary[ID] = Random.Range(2101, 2400);
        }
    }
    public void Cat2()
    {
        Man = Random.Range(1, 20);
        if (Man <= 10)
        {
            nameID = Random.Range(0, WNDB.Mnames.Count);
            service[ID - 8].text = WNDB.Mnames[nameID];
        }
        if (Man > 10)
        {
            nameID = Random.Range(0, WNDB.Wnames.Count);
            service[ID - 8].text = WNDB.Wnames[nameID];
        }
        WNDB.Skills[ID] = Random.Range(0, 30);
        WNDB.Ambitions[ID] = Random.Range(0, 5);
        if (WNDB.Skills[ID] <= 15)
        {
            WNDB.WantingSalary[ID] = Random.Range(2000, 2200);
        }
        if (WNDB.Skills[ID] <= 45 && WNDB.Skills[ID] > 15)
        {
            WNDB.WantingSalary[ID] = Random.Range(2201, 2500);
        }
        if (WNDB.Skills[ID] <= 75 && WNDB.Skills[ID] > 45)
        {
            WNDB.WantingSalary[ID] = Random.Range(2501, 2750);
        }
        if (WNDB.Skills[ID] <= 100 && WNDB.Skills[ID] > 75)
        {
            WNDB.WantingSalary[ID] = Random.Range(2751, 3000);
        }
    }
    public void Cat3()
    {
        Man = Random.Range(1, 20);
        if (Man <= 19)
        {
            nameID = Random.Range(0, WNDB.Mnames.Count);
            security[ID - 16].text = WNDB.Mnames[nameID];
        }
        if (Man > 19)
        {
            nameID = Random.Range(0, WNDB.Wnames.Count);
            security[ID - 16].text = WNDB.Wnames[nameID];
        }
        WNDB.Skills[ID] = Random.Range(0, 30);
        WNDB.Ambitions[ID] = Random.Range(0, 5);
        if (WNDB.Skills[ID] <= 15)
        {
            WNDB.WantingSalary[ID] = Random.Range(2300, 2500);
        }
        if (WNDB.Skills[ID] <= 45 && WNDB.Skills[ID] > 15)
        {
            WNDB.WantingSalary[ID] = Random.Range(2501, 2750);
        }
        if (WNDB.Skills[ID] <= 75 && WNDB.Skills[ID] > 45)
        {
            WNDB.WantingSalary[ID] = Random.Range(2751, 3000);
        }
        if (WNDB.Skills[ID] <= 100 && WNDB.Skills[ID] > 75)
        {
            WNDB.WantingSalary[ID] = Random.Range(3001, 3500);
        }
    }
    public void Cat4()
    {
        Man = Random.Range(1, 20);
        if (Man <= 10)
        {
            nameID = Random.Range(0, WNDB.Mnames.Count);
            manager[ID - 24].text = WNDB.Mnames[nameID];
        }
        if (Man > 10)
        {
            nameID = Random.Range(0, WNDB.Wnames.Count);
            manager[ID - 24].text = WNDB.Wnames[nameID];
        }
        WNDB.Skills[ID] = Random.Range(0, 30);
        WNDB.Ambitions[ID] = Random.Range(0, 5);
        if (WNDB.Skills[ID] <= 15)
        {
            WNDB.WantingSalary[ID] = Random.Range(3000, 3250);
        }
        if (WNDB.Skills[ID] <= 45 && WNDB.Skills[ID] > 15)
        {
            WNDB.WantingSalary[ID] = Random.Range(3251, 3550);
        }
        if (WNDB.Skills[ID] <= 75 && WNDB.Skills[ID] > 45)
        {
            WNDB.WantingSalary[ID] = Random.Range(3551, 3800);
        }
        if (WNDB.Skills[ID] <= 100 && WNDB.Skills[ID] > 75)
        {
            WNDB.WantingSalary[ID] = Random.Range(3801, 4200);
        }
    }
}
