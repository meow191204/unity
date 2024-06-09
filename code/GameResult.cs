// // using System.Collections;
// // using System.Collections.Generic;
// // using UnityEngine;
// // using UnityEngine.UI;
// // using UnityEngine.SceneManagement;

// // public class GameResult : MonoBehaviour
// // {
// //     private int highScore;
// //     public GameObject resultUI;
// //     // Start is called before the first frame update
// //     void Start()
// //     {
        
// //     }

// //     // Update is called once per frame
// //     void Update()
// //     {
// //         if (Goal.goal){
// //             resultUI.SetActive(true);
// //         }
// //     }
// //     public void OnRetry(){
// //         SceneManager.LoadScene(
// //             SceneManager.GetActiveScene().name);
// //     }
// // }
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.SceneManagement;

// public class GameResult : MonoBehaviour
// {
//     private int highScore;
//     public GameObject resultUI;
//     public GameObject explanationPanel;
//     public Button startButton;   
//     void Start()
//     {
//         resultUI.SetActive(false); // 초기에는 resultUI를 비활성화
//         explanationPanel.SetActive(true); // 초기에는 설명창을 활성화
//         startButton.onClick.AddListener(StartGame);
//     }

//     void Update()
//     {
//         if (Goal.goal)
//         {
//             resultUI.SetActive(true);
//             Debug.Log("Goal reached! Displaying result UI.");
//         }
//     }
//     public void StartGame()
//     {
//         explanationPanel.SetActive(false);
//         Time.timeScale = 1f; // 게임을 다시 진행하도록 설정
//     }
//     public void OnRetry()
//     {
//         Debug.Log("Retry button clicked. Reloading scene.");
//         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//     }
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameResult : MonoBehaviour
{
    private int highScore;
    public GameObject resultUI;

    void Start()
    {
        resultUI.SetActive(false); // Ensure the result UI is hidden at the start
    }

    void Update()
    {
        if (Goal.goal)
        {
            resultUI.SetActive(true);
        }
    }

    public void OnRetry()
    {
        Goal.goal = false; // Reset the goal state
        resultUI.SetActive(false); // Hide the result UI
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
