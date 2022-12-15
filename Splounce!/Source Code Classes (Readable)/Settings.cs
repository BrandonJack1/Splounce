// Decompiled with JetBrains decompiler
// Type: Settings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
  public GameObject settings;
  public GameObject soundButton;

  private void Start()
  {
    if (!PlayerPrefs.HasKey("sound"))
      PlayerPrefs.SetString("sound", "on");
    if (PlayerPrefs.GetString("sound").Equals("on"))
      this.soundButton.GetComponentInChildren<Text>().text = "Sound Effects Enabled";
    else
      this.soundButton.GetComponentInChildren<Text>().text = "Sound Effects Disabled";
  }

  private void Update()
  {
  }

  public void muteAudio()
  {
    if (PlayerPrefs.GetString("sound").Equals("on"))
    {
      PlayerPrefs.SetString("sound", "off");
      this.soundButton.GetComponentInChildren<Text>().text = "Sound Effects Disabled";
    }
    else
    {
      PlayerPrefs.SetString("sound", "on");
      this.soundButton.GetComponentInChildren<Text>().text = "Sound Effects Enabled";
    }
  }

  public void closeSettings() => this.settings.SetActive(false);

  public void openSettings() => this.settings.SetActive(true);

  public void resetHighScore() => PlayerPrefs.SetInt("High Score", 0);
}
