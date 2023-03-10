// Decompiled with JetBrains decompiler
// Type: deleteBallCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class deleteBallCode : MonoBehaviour
{
  public GameObject continueMenu;
  public static bool active;
  public GameObject player;
  public static bool playerColorActive;
  public static bool finishRoutineActive;
  public static bool methodActive;
  public GameObject invincibleCountdown;
  public bool timerStarted;
  public static float _timer = 5f;
  public float countDownTime = 10f;
  public static bool deleteBall;
  public bool localPowerUpActive;
  public GameObject shield;

  private void Start()
  {
    deleteBallCode.deleteBall = false;
    deleteBallCode.playerColorActive = false;
    deleteBallCode.finishRoutineActive = false;
  }

  private void Update()
  {
    this.localPowerUpActive = GameOver.powerUpActive;
    if (deleteBallCode.active)
      this.continueMenu.SetActive(true);
    else
      this.continueMenu.SetActive(false);
    if (!deleteBallCode.playerColorActive)
    {
      if (PlayerPrefs.GetString("Active Player Skin") == "Purple")
        this.player.GetComponent<SpriteRenderer>().color = new Color(0.7176471f, 0.184313729f, 1f);
      else if (PlayerPrefs.GetString("Active Player Skin") == "Red")
        this.player.GetComponent<SpriteRenderer>().color = new Color(1f, 0.09019608f, 0.09019608f);
      else if (PlayerPrefs.GetString("Active Player Skin") == "Green")
        this.player.GetComponent<SpriteRenderer>().color = new Color(0.3254902f, 1f, 0.235294119f);
      else if (PlayerPrefs.GetString("Active Player Skin") == "Dark Yellow")
        this.player.GetComponent<SpriteRenderer>().color = new Color(0.9254902f, 0.7529412f, 0.03529412f);
      else
        this.player.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
    }
    if (deleteBallCode.finishRoutineActive && !deleteBallCode.methodActive)
    {
      this.invincibleCountdown.SetActive(true);
      if (!this.timerStarted)
        this.timerStarted = true;
      this.StartCoroutine(this.waitToFinish());
    }
    if (this.timerStarted)
    {
      deleteBallCode._timer -= Time.deltaTime;
      this.invincibleCountdown.GetComponent<Text>().text = "Invincible for: " + deleteBallCode._timer.ToString("0.0");
    }
    if ((double) deleteBallCode._timer > 0.0)
      return;
    this.invincibleCountdown.SetActive(false);
    this.timerStarted = false;
    deleteBallCode._timer = 5f;
  }

}
