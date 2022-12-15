// Decompiled with JetBrains decompiler
// Type: TimedGameOverHighScore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class TimedGameOverHighScore : MonoBehaviour
{
  public string timehighScore;
  public GameObject highScoreText;
  public GameObject highScoreAward;
  public GameObject particleSystemHighScore;

  private void Start()
  {
    this.timehighScore = PlayerPrefs.GetString("Time High Score", "0");
    Time.timeScale = 1f;
  }

  private void Update()
  {
    this.highScoreText.GetComponent<Text>().text = "HIGH SCORE: " + PlayerPrefs.GetString("Time High Score");
    if ((double) timer.privateTimer <= (double) PlayerPrefs.GetFloat("Time High Score Timer", 0.0f))
      return;
    PlayerPrefs.SetString("Time High Score", timer.minuteCount.ToString() + "m:" + timer.secondsCount.ToString("0") + "s");
    PlayerPrefs.SetFloat("Time High Score Timer", timer.privateTimer);
    this.timehighScore = timer.minuteCount.ToString() + "m:" + timer.secondsCount.ToString() + "s";
    Debug.Log((object) this.timehighScore);
    this.highScoreAward.SetActive(true);
    this.particleSystemHighScore.GetComponent<ParticleSystem>().Play();
  }
}
