// Decompiled with JetBrains decompiler
// Type: TimeGlobalScore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class TimeGlobalScore : MonoBehaviour
{
  public static int Score;
  public int localScore;
  public GameObject highScoreText;
  public static bool plusScoreOn;
  public GameObject plusText;
  public bool plusRoutineActive;
  public GameObject multiplier;
  public GameObject flash;
  public static bool flashNow;
  public int multiplierNumber;
  public int secondActive;

  private void Start()
  {
  }

  private void Update() => this.highScoreText.GetComponent<Text>().text = "BEST: " + PlayerPrefs.GetString("Time High Score").ToString();
}
