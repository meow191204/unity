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

public class NPC_Trigger2 : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public string ChatText = "";
    private GameObject Main;

    void Start()
    {
        Main = GameObject.Find("Main");
        ChatText = "\n<size=20>퀘스트 2. 찾아가야하는 실 = 41?[실습실]</size>\n\n<size=15>Q. 다음은 파이썬 연산이다 그 결과는?\n\n119 % 8 = ?</size>";
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
