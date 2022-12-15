// Decompiled with JetBrains decompiler
// Type: GlobalScore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
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
  public int multiplierNumber;
  public Text txtScore;
  public Text txtMultiplier;
  public ParticleSystem multiplierPop;
  public int popMethodActive;
  public GameObject fire;
  public int secondActive;

  private void Start()
  {
    this.popMethodActive = 1;
    this.InvokeRepeating("Multiplier", 1f, 1f);
  }

  private void Update()
  {
    this.txtMultiplier.text = "x" + this.multiplierNumber.ToString();
    UnityEngine.Debug.Log((object) this.popMethodActive);
    if (GlobalScore.plusScoreOn && !this.plusRoutineActive)
    {
      this.plusText.SetActive(true);
      this.StartCoroutine(this.showPlus());
    }
    this.highScoreText.GetComponent<Text>().text = "BEST: " + PlayerPrefs.GetInt("High Score").ToString();
    if (Ball.ballCount >= 2 && Ball.ballCount < 4)
    {
      this.multiplierNumber = 1;
      if (this.secondActive != 0)
        ;
      if (this.popMethodActive == 1)
        this.popMethod();
    }
    if (Ball.ballCount >= 4 && Ball.ballCount < 6)
    {
      this.multiplierNumber = 2;
      if (this.secondActive != 0)
        ;
      if (this.popMethodActive == 2)
        this.popMethod();
    }
    if (Ball.ballCount >= 6 && Ball.ballCount < 8)
    {
      this.multiplierNumber = 3;
      if (this.secondActive != 0)
        ;
      if (this.popMethodActive == 3)
        this.popMethod();
    }
    if (Ball.ballCount >= 8 && Ball.ballCount < 10)
    {
      this.multiplierNumber = 4;
      if (this.secondActive != 0)
        ;
      if (this.popMethodActive == 4)
        this.popMethod();
    }
    if (Ball.ballCount >= 10 && Ball.ballCount < 12)
    {
      this.multiplierNumber = 5;
      if (this.secondActive != 0)
        ;
      if (this.popMethodActive == 5)
        this.popMethod();
    }
    if (Ball.ballCount >= 12 && Ball.ballCount < 14)
    {
      this.multiplierNumber = 6;
      if (this.secondActive != 0)
        ;
      if (this.popMethodActive == 6)
        this.popMethod();
    }
    if (Ball.ballCount >= 14 && Ball.ballCount < 16)
    {
      this.multiplierNumber = 7;
      if (this.secondActive != 0)
        ;
      if (this.popMethodActive == 7)
        this.popMethod();
    }
    if (Ball.ballCount >= 16 && Ball.ballCount < 18)
    {
      this.multiplierNumber = 8;
      if (this.secondActive != 0 || Ball.ballCount >= 4)
        ;
      if (this.popMethodActive == 8)
        this.popMethod();
    }
    if (Ball.ballCount >= 18 && Ball.ballCount < 20)
    {
      this.multiplierNumber = 9;
      if (this.secondActive != 0)
        ;
      if (this.popMethodActive == 9)
        this.popMethod();
    }
    if (Ball.ballCount >= 20 && Ball.ballCount < 22)
    {
      this.multiplierNumber = 10;
      if (this.secondActive != 0)
        ;
      if (this.popMethodActive == 10)
        this.popMethod();
    }
    if (this.multiplierNumber >= 5)
      this.fire.SetActive(true);
    else
      this.fire.SetActive(false);
    this.multiplier.GetComponent<Text>().text = "Multiplier Active:";
    this.localScore = GlobalScore.Score;
    this.scoreText.GetComponent<Text>().text = "SCORE: ";
    this.txtScore.GetComponent<Text>().text = this.localScore.ToString();
  }

  private void Multiplier()
  {
    GlobalScore.Score += Ball.ballCount * this.multiplierNumber;
    this.localScore = GlobalScore.Score;
    this.txtScore.GetComponent<Text>().text = this.localScore.ToString();
  }

  public void popMethod()
  {
    this.txtMultiplier.GetComponent<Animation>().Play("multiplierScale");
    this.multiplierPop.Play();
    UnityEngine.Debug.Log((object) "Test");
    ++this.popMethodActive;
    this.StartCoroutine(this.multiplierMovingAnim());
  }

}
