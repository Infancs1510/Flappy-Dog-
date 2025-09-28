using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject startText;
    private bool gameStarted = false;

    void Start()
    {
        // Pause game at start
        Time.timeScale = 0f;
        startText.SetActive(true);
    }

    void Update()
    {
        if (!gameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        gameStarted = true;
        startText.SetActive(false);
        Time.timeScale = 1f;
    }
}
