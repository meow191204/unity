// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using TMPro;

// public class hangle : MonoBehaviour
// {
//     public TextMeshProUGUI textMeshPro;

//     void Start()
//     {
//         string ChatText = "안녕, 반가워~ \n지금부터 \"국제교류관을 추억하며..\"의 게임에 대해 설명해줄게. \n이곳은 국제교류관 4층으로 22,23,24학번이 사용했던 건물이야. \n게임은 총 3개의 게임 퀘스트를 해결하면 돼.\n각 퀘스트에 맞춰 실을 찾아가면 게임 NPC가 찾아가야 하는 곳에 대한 힌트를 줄거야.\n잘못된 실에 들어가면 게임이 리셋되니까 조심해!!\n옆에 있는 버튼을 눌러서 게임을 시작해줘~";
//         textMeshPro.text = ChatText;
//     }
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class hangle : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public GameObject panel; // Panel containing the explanation text and Start button
    public Button startButton; // Start button

    void Start()
    {
        string ChatText = " 안녕, 반가워~ \n지금부터 \"국제교류관을 추억하며..\"의 게임에 대해 설명해줄게. \n이곳은 국제교류관 4층으로 22,23,24학번이 사용했던 건물이야. \n게임은 총 3개의 게임 퀘스트를 해결하면 돼.\n각 퀘스트에 맞춰 실을 찾아가면 게임 NPC가 찾아가야 하는 곳에 대한 힌트를 줄거야.\n잘못된 실에 들어가면 게임이 리셋되니까 조심해!!\n밑에 있는 버튼을 눌러서 게임을 시작해줘~";
        textMeshPro.text = ChatText;

        // Add listener to the button
        startButton.onClick.AddListener(OnStartButtonClick);
    }

    void OnStartButtonClick()
    {
        // Hide the panel when the Start button is clicked
        panel.SetActive(false);
    }
}
