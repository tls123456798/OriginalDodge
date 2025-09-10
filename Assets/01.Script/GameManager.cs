using UnityEngine;
using UnityEngine.UI; // UI ���� ���̺귯��
using UnityEngine.SceneManagement; // �� ���� ���� ���̺귯��

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText; // ���ӿ��� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public Text timeText; // ���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText; // �ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ

    private float survivetime; // ���� �ð�
    private bool isGameover; // ���ӿ��� ����
    
    void Start()
    {
        // ���� �ð��� ���ӿ��� ���¸� �ʱ�ȭ
        survivetime = 0f;
        isGameover = false;
    }

    
    void Update()
    {
        // ���ӿ����� �ƴ� ����
        if (!isGameover)
        {
            // ���� �ð� ����
            survivetime += Time.deltaTime;
            // ������ ���� �ð��� timeText �ؽ�Ʈ ������Ʈ�� ���� ǥ��
            timeText.text = "Time: " + (int) survivetime;
        }
        else
        {
            // ���ӿ����� ���¿��� RŰ�� ���� ���
            if (Input.GetKeyDown(KeyCode.R))
            {
                // SampleScene ���� �ε�
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void EndGame() // ���� ������ ���ӿ��� ���·� �����ϴ� �޼���
    {
        // ���� ���¸� ���ӿ��� ���·� ��ȯ
        isGameover = true;
        // ���ӿ��� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ
        gameoverText.SetActive(true);

        // BestTime Ű�� ����� ���������� �ְ� ��� ��������
        float bestTime = PlayerPrefs.GetFloat("BestTime");

        // ���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ�ٸ�
        if (survivetime > bestTime)
        {

        }

        
    }
}
