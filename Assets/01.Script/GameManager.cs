using UnityEngine;
using UnityEngine.UI; // UI 관련 라이브러리
using UnityEngine.SceneManagement; // 씬 관리 관련 라이브러리

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText; // 게임오버 시 활성화할 텍스트 게임 오브젝트
    public Text timeText; // 생존 시간을 표시할 텍스트 컴포넌트
    public Text recordText; // 최고 기록을 표시할 텍스트 컴포넌트

    private float survivetime; // 생존 시간
    private bool isGameover; // 게임오버 상태
    
    void Start()
    {
        // 생존 시간과 게임오버 상태를 초기화
        survivetime = 0f;
        isGameover = false;
    }

    
    void Update()
    {
        // 게임오버가 아닌 동안
        if (!isGameover)
        {
            // 생존 시간 갱신
            survivetime += Time.deltaTime;
            // 갱신한 생존 시간을 timeText 텍스트 컴포넌트를 통해 표시
            timeText.text = "Time: " + (int) survivetime;
        }
        else
        {
            // 게임오버인 상태에서 R키를 누른 경우
            if (Input.GetKeyDown(KeyCode.R))
            {
                // SampleScene 씬을 로드
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void EndGame() // 현재 게임을 게임오버 상태로 변경하는 메서드
    {
        // 현재 상태를 게임오버 상태로 전환
        isGameover = true;
        // 게임오버 텍스트 게임 오브젝트를 활성화
        gameoverText.SetActive(true);

        // BestTime 키로 저장된 이전까지의 최고 기록 가져오기
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        // 이전까지의 최고 기록보다 현재 생존 시간이 더 크다면
        if (survivetime > bestTime)
        {

        }

        
    }
}
