// Decompiled with JetBrains decompiler
// Type: GameEndHighScore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class GameEndHighScore : MonoBehaviour
{
  public int highScore;
  public GameObject highScoreText;
  public GameObject highScoreAward;
  public GameObject particleSystemHighScore;

  private void Start()
  {
    this.highScore = PlayerPrefs.GetInt("High Score", 0);
    Time.timeScale = 1f;
  }

  private void Update()
  {
    this.highScoreText.GetComponent<Text>().text = "HIGH SCORE: " + (object) this.highScore;
    if (GlobalScore.Score <= PlayerPrefs.GetInt("High Score", 0))
      return;
    PlayerPrefs.SetInt("High Score", GlobalScore.Score);
    this.highScore = GlobalScore.Score;
    this.highScoreAward.SetActive(true);
    this.particleSystemHighScore.GetComponent<ParticleSystem>().Play();
  }
}
