// Decompiled with JetBrains decompiler
// Type: btnLevel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.SceneManagement;

public class btnLevel : MonoBehaviour
{
  public GameObject highScoreAward;

  private void Start()
  {
  }

  private void Update()
  {
  }

  public void goToLevel() => SceneManager.LoadScene(1);

  public void goToEndless()
  {
    SceneManager.LoadScene(2);
    GlobalScore.Score = 0;
    Ball.ballCount = 1;
    deleteBallCode.active = false;
  }

  public void retry()
  {
    SceneManager.LoadScene(2);
    GlobalScore.Score = 0;
    Ball.ballCount = 1;
    Time.timeScale = 1f;
    this.highScoreAward.SetActive(false);
    deleteBallCode.active = false;
    GameOver.stopContinue = 0;
  }

  public void timedRetry()
  {
    SceneManager.LoadScene(4);
    TimeGlobalScore.Score = 0;
    TimedBall.timedBallCount = 1;
    Time.timeScale = 1f;
    this.highScoreAward.SetActive(false);
    TimedDeleteBallCode.active = false;
    TimedGameOver.stopContinue = 0;
  }
}
