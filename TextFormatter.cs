using TMPro;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class TextFormatter : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;

    void Start()
    {
        string formattedText = "<color=#ff7777>[NPC]</color>자모 월드에는 <size=20><color=#ffff33>즐거움</color></size>이 있어요!\n<size=20>여기에 줄바꿈</size>된 텍스트!";
        textMeshPro.text = formattedText;
    }
}
