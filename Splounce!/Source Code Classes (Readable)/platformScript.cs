// Decompiled with JetBrains decompiler
// Type: platformScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class platformScript : MonoBehaviour
{
  public GameObject[] platforms;
  public GameObject platform1;
  public GameObject platform2;
  public GameObject platform3;
  public GameObject platform4;
  public bool platformTimerActive;
  private int currentPlatformIndex;
  public GameObject platformText;

  private void Start()
  {
  }

  private void Update()
  {
    if (TimedBall.timedBallCount > 10)
    {
      this.platformText.SetActive(true);
      if (this.platformTimerActive)
        return;
      this.platformTimerActive = true;
      UnityEngine.Debug.Log((object) this.platformTimerActive);
      this.newRandomPlatform();
      this.StartCoroutine(this.platformTimer());
    }
    else
      this.platformText.SetActive(false);
  }

  public void newRandomPlatform()
  {
    this.currentPlatformIndex = Random.Range(0, this.platforms.Length);
    this.platforms[this.currentPlatformIndex].SetActive(true);
  }

}
