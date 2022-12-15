// Decompiled with JetBrains decompiler
// Type: BlitzGlobalScore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class BlitzGlobalScore : MonoBehaviour
{
  public static int Score;
  public int localScore;
  public GameObject scoreText;
  public GameObject highScoreText;
  public static bool plusScoreOn;
  public GameObject plusText;
  public bool plusRoutineActive;
  public GameObject multiplier;
  public GameObject flash;
  public static bool flashNow;
  public int secondActive;

  private void Start()
  {
  }

  private void Update()
  {
    if (BlitzGlobalScore.plusScoreOn && !this.plusRoutineActive)
    {
      this.plusText.SetActive(true);
      this.StartCoroutine(this.showPlus());
    }
    this.highScoreText.GetComponent<Text>().text = "BEST: " + PlayerPrefs.GetInt("Blitz High Score").ToString();
    this.localScore = BlitzGlobalScore.Score;
    this.scoreText.GetComponent<Text>().text = "SCORE: " + (object) this.localScore;
  }

}
