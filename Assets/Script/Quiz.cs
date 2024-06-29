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
    public string[] pilihanA;
    public string[] pilihanB;
    public string[] pilihanC;
    public string[] pilihanD;
    public int skor;
    public int nomor;


    void Start()
    {
        int soalIndex = UnityEngine.Random.Range(0, soal.Length);

        soalText.text = soal[soalIndex];

        Debug.Log(soalIndex);
    }

    public void pilihJawaban(string answer)
    {
        JawabanKu = answer;
        Debug.Log(JawabanKu);
    }
}
