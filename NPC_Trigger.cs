using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPC_Trigger : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public string ChatText = "";
    private GameObject Main;

    void Start()
    {
        Main = GameObject.Find("Main");
        ChatText = "<size=20>퀘스트 1. 찾아가야 하는 실 = 41?[학과사무실]\n\n</size><size=15>Q. 다음 중 인공지능의 스펠링으로 맞는 것은?</size>\n\n<size=13>1. ARIFICIAL INTELLIGENCE\n2. ARITICIAL INTELLIGENCE\n3. ARTIFICIAL INTELIGENCE\n4. ARTIFICIAL INTELLIGENCE</size>";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Main.GetComponent<MainScript>().NPCChatEnter(ChatText);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Main.GetComponent<MainScript>().NPCChatExit();
        }
    }
}
