using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject explanationPanel;
    public Button startButton;

    void Start()
    {
        // 게임 시작 시 설명창을 활성화
        explanationPanel.SetActive(true);
        // 시작 버튼 클릭 이벤트 추가
        startButton.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        // 설명창을 비활성화하고 게임 시작
        explanationPanel.SetActive(false);
        // 게임 시작 로직 추가 (필요한 경우)
        Time.timeScale = 1f; // 게임을 다시 진행하도록 설정
    }
}
