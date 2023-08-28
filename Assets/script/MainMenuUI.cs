using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditButton;

    private void Start()
    {
        playButton.onClick.AddListener(playGame);
        exitButton.onClick.AddListener(ExitGame);
        creditButton.onClick.AddListener(creditGame);

    }

    public void playGame()
    {
        SceneManager.LoadScene("Pinball");
    }

    private void ExitGame()
    {
        Application.Quit();
    }

    public void creditGame()
    {
        SceneManager.LoadScene("Credit");
    }
}
