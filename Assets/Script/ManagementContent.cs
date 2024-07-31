using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagementContent : MonoBehaviour
{

    public Text Pengertian;
    public Text Kelebihan;
    public Text Kekurangan;
    public Text contoh_1_name;
    public Text contoh_2_name;
    public Text contoh_3_name;
    public GameObject contoh_1_image;
    public GameObject contoh_2_image;
    public GameObject contoh_3_image;
    public GameObject BG;
    public GameObject BadgeTitle;
    public int nomor_content = 1;

    public string[] pengertianContent;
    public string[] kelebihanContent;
    public string[] kekuranganContent;
    public string[] contoh_1_Content;
    public string[] contoh_2_Content;
    public string[] contoh_3_Content;

    public Sprite[] contoh_1_image_content;
    public Sprite[] contoh_2_image_content;
    public Sprite[] contoh_3_image_content;
    public Sprite[] Background;
    public Sprite[] ImgBadge;

    public int[] FontPengertian;
    public int[] FontKelebihan;
    public int[] FontKekurangan;
    public int[] FontContoh1;
    public int[] FontContoh2;
    public int[] FontContoh3;


    public void setContent(int content)
    {
        nomor_content = content;
        Pengertian.text = pengertianContent[nomor_content];
        Kelebihan.text = kelebihanContent[nomor_content];
        Kekurangan.text = kekuranganContent[nomor_content];
        contoh_1_name.text = contoh_1_Content[nomor_content];
        contoh_2_name.text = contoh_2_Content[nomor_content];
        contoh_3_name.text = contoh_3_Content[nomor_content];
        contoh_1_image.GetComponent<Image>().sprite = contoh_1_image_content[nomor_content];
        contoh_2_image.GetComponent<Image>().sprite = contoh_2_image_content[nomor_content];
        contoh_3_image.GetComponent<Image>().sprite = contoh_3_image_content[nomor_content];

        BG.GetComponent<Image>().sprite = Background[nomor_content];
        BadgeTitle.GetComponent<Image>().sprite = ImgBadge[nomor_content];

        Pengertian.fontSize = FontPengertian[nomor_content];
        Kelebihan.fontSize = FontKelebihan[nomor_content];
        Kekurangan.fontSize = FontKekurangan[nomor_content];
        contoh_1_name.fontSize = FontContoh1[nomor_content];
        contoh_2_name.fontSize = FontContoh2[nomor_content];
        contoh_3_name.fontSize = FontContoh3[nomor_content];



    }
}
