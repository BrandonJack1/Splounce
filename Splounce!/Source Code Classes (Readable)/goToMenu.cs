// Decompiled with JetBrains decompiler
// Type: goToMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.SceneManagement;

public class goToMenu : MonoBehaviour
{
  public GameObject pauseMenu;
  public GameObject pauseButton;

  private void Start() => this.pauseMenu.SetActive(false);

  private void Update()
  {
  }

  public void Menu()
  {
    SceneManager.LoadScene(0);
    Time.timeScale = 1f;
    GameOver.stopContinue = 0;
    TimedGameOver.stopContinue = 0;
    TimedDeleteBallCode.active = false;
    deleteBallCode.active = false;
  }

  public void openPause()
  {
    this.pauseMenu.SetActive(true);
    Time.timeScale = 0.0f;
    this.pauseButton.SetActive(false);
  }

  public void closePause()
  {
    this.pauseMenu.SetActive(false);
    Time.timeScale = 1f;
    this.pauseButton.SetActive(true);
  }

  public void gameOver() => SceneManager.LoadScene(3);

  public void timedGameOver() => SceneManager.LoadScene(5);

  public void timedRetry() => SceneManager.LoadScene(4);
}
