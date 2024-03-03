using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
  public Button playButton;
  public Button CreditsButton;
  public Button ExitButton;

  private void Start()
  {
    playButton.onClick.AddListener(PlayGame);
    CreditsButton.onClick.AddListener(Credits);
    ExitButton.onClick.AddListener(Exit);
  }

  public void PlayGame()
  {
    SceneManager.LoadScene("Pinball_Game");
  }

  public void Credits()
  {
    SceneManager.LoadScene("Credits");
  }

  public void Exit()
  {
    Application.Quit();
  }
}
