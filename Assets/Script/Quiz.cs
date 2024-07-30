using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    public Text soalText;
    public string[] soal;
    public string[] jawaban;
    public string JawabanKu;
    public Text BtnA;
    public Text BtnB;
    public Text BtnC;
    public Text BtnD;
    public string[] pilihanA;
    public string[] pilihanB;
    public string[] pilihanC;
    public string[] pilihanD;
    public int skor;
    public int nomor;
    public GameObject QuizPanel;
    public GameObject SkorPanel;
    public Text SkorText;



    void Start()
    {
        generateSoal();
    }
    void Update()
    {
        if (nomor == 10)
        {
            QuizPanel.SetActive(false);
            SkorPanel.SetActive(true);
            SkorText.text = skor.ToString();
        }
    }

    public void pilihJawaban(string answer)
    {
        nomor += 1;
        JawabanKu = answer;
        if (JawabanKu == jawaban[nomor])
        {
            skor += 10;
        }

        generateSoal();
    }
    public void generateSoal()
    {
        int soalIndex = UnityEngine.Random.Range(0, soal.Length);

        soalText.text = soal[soalIndex];
        BtnA.text = pilihanA[soalIndex];
        BtnB.text = pilihanB[soalIndex];
        BtnC.text = pilihanC[soalIndex];
        BtnD.text = pilihanD[soalIndex];
        Debug.Log(soalIndex);
    }
    public void resetSoal()
    {
        nomor = 0;
        skor = 0;

    }
}
