// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class NPC_Trigger : MonoBehaviour
// {
//     #public TextMeshProUGUI textMeshPro;
//     public string ChatText = "";
//     private GameObject Main;
//     void Start()
//     {
//         Main = GameObject.Find("Main");
//         string formattedText = "<color=#ff7777>[NPC]</color>자모 월드에는 <size=20><color=#ffff33>즐거움</color></size>이 있어요!\n<size=20>여기에 줄바꿈</size>된 텍스트!";
//         ChatText.text = formattedText;
//     }


//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.tag == "Player")
//         {
//             Main.GetComponent<MainScript>().NPCChatEnter(ChatText);
//         }
//     }

//     private void OnTriggerExit(Collider other)
//     {
//         if (other.tag == "Player")
//         {
//             Main.GetComponent<MainScript>().NPCChatExit();
//         }
//     }
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPC_Trigger1 : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public string ChatText = "";
    private GameObject Main;

    void Start()
    {
        Main = GameObject.Find("Main");
        ChatText = "<size=20>퀘스트 3. 찾아가야하는 실 = 40?[김은경교수님실]</size>\n\n<size=15>Q. C언어에서 프린트하기 위해 사용하는 것은?</size><size=13>\n\n1. printf\n2. println\n3. print\n4. whiteLine</size>";
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
