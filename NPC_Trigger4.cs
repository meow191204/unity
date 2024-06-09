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

public class NPC_Trigger4 : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public string ChatText = "";
    private GameObject Main;

    void Start()
    {
        Main = GameObject.Find("Main");
        // ChatText = "<size=18>지금부터 \"국제교류관을 추억하며..\"의 게임에 대해 설명해줄게. \n이곳은 국제교류관 4층으로 22,23,24학번이 사용했던 건물이야. \n게임은 총 3개의 게임 퀘스트를 해결하면 돼.\n각 퀘스트에 맞춰 실을 찾아가면 게임 NPC가 찾아가야 하는 곳에 대한 힌트를 줄거야.\n잘못된 실에 들어가면 게임이 <size=19><color=#ffff33>리셋</color>되니까 조심해!!\n위에 있는 버튼을 눌러서 게임을 시작해줘~</size>";}
        ChatText = "<size=18>지금부터 \"국제교류관을 추억하며..\" 게임에 대해 설명해줄게. \n이곳은 국제교류관 4층으로 22,23,24학번이 사용했던 건물이야. \n게임은 총 <color=#0000ff>3개의 게임 퀘스트</color>를 해결하면 돼.\n각 퀘스트에 맞춰 실을 찾아가면 게임 NPC가 찾아가야 하는 곳에 대한 힌트를 줄거야.\n잘못된 실에 들어가면 게임이 <color=#ff0000>리셋</color>되니까 조심해!!\n앞에 있는 펭귄에게 다가가면 퀘스트를 줄거야!</size>";
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
