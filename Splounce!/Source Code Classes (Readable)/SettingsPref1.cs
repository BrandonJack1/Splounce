// Decompiled with JetBrains decompiler
// Type: SettingsPref1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class SettingsPref1 : MonoBehaviour
{
  public GameObject btnShowRL;

  private void Start()
  {
    if (PlayerPrefs.HasKey("Show RL"))
      return;
    PlayerPrefs.SetString("Show RL", "True");
  }

  private void Update()
  {
    if (PlayerPrefs.GetString("Show RL") == string.Empty || PlayerPrefs.GetString("Show RL") == "True")
      this.btnShowRL.GetComponentInChildren<Text>().text = "Show R and L: On";
    else
      this.btnShowRL.GetComponentInChildren<Text>().text = "Show R and L: Off";
  }

  public void setRLActive()
  {
    if (PlayerPrefs.GetString("Show RL") == string.Empty || PlayerPrefs.GetString("Show RL") == "True")
      PlayerPrefs.SetString("Show RL", "False");
    else
      PlayerPrefs.SetString("Show RL", "True");
  }
}
