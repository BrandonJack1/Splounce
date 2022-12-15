// Decompiled with JetBrains decompiler
// Type: TimedGameOver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimedGameOver : MonoBehaviour
{
  public GameObject continueScreen;
  public static int stopContinue;
  public bool localDeleteBall;
  public static bool powerUpActive;
  public GameObject powerUpActiveText;

  private void Start()
  {
  }

  private void Update()
  {
  }

  private void OnTriggerEnter2D(Collider2D col)
  {
    if (col.tag == "Ball" || col.tag == "LastBall")
    {
      if (TimedDeleteBallCode.deleteBall)
      {
        col.gameObject.SetActive(false);
        --TimedBall.timedBallCount;
        UnityEngine.Debug.Log((object) "Ball entered the delete ball trigger area");
      }
      else if (TimedBall.timedBallCount > 1 && TimedGameOver.stopContinue != 1 && !TimedDeleteBallCode.deleteBall && PlayerPrefs.GetString("Show Ads") != "No")
      {
        col.gameObject.SetActive(false);
        Time.timeScale = 0.0f;
        ++TimedGameOver.stopContinue;
        TimedDeleteBallCode.active = true;
      }
      else if (TimedBall.timedBallCount == 1 || TimedGameOver.stopContinue == 1 && !TimedDeleteBallCode.deleteBall || PlayerPrefs.GetString("Show Ads") == "No")
        SceneManager.LoadScene(5);
    }
    if (col.tag == "PowerUp" && !TimedGameOver.powerUpActive)
    {
      TimedGameOver.powerUpActive = true;
      deleteBallCode.deleteBall = true;
      UnityEngine.Debug.Log((object) ("Delete ball" + (object) deleteBallCode.deleteBall));
      deleteBallCode.playerColorActive = true;
      deleteBallCode.finishRoutineActive = true;
      col.gameObject.SetActive(false);
    }
    else
    {
      if (!(col.tag == "PowerUp") || !TimedGameOver.powerUpActive)
        return;
      col.gameObject.SetActive(false);
      this.powerUpActiveText.SetActive(true);
      this.StartCoroutine(this.hidePowerUpText());
    }
  }

}
