using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public GameObject pLayer;
    public GameObject gameManager;
    public GameObject[] toDisabled;
    public GameObject pauseButton;

    //Private
    PlayerMove playerMove;
    GenerateWall generateWall;

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Play()
    {
        Time.timeScale = 1;

        playerMove = pLayer.GetComponent<PlayerMove>();
        playerMove.enabled = true;

        generateWall = gameManager.GetComponent<GenerateWall>();
        generateWall.enabled = true;

        foreach (GameObject item in toDisabled)
        {
            item.SetActive(false);
        }

        pauseButton.SetActive(true);
    }

    public void Pause()
    {
        Time.timeScale = 0;

        playerMove = pLayer.GetComponent<PlayerMove>();
        playerMove.enabled = false;

        generateWall = gameManager.GetComponent<GenerateWall>();
        generateWall.enabled = false;

        foreach (GameObject item in toDisabled)
        {
            item.SetActive(true);
        }

        pauseButton.SetActive(false);
    }

    public void quit()
    {
        Application.Quit();
    }
}

