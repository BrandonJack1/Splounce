// Decompiled with JetBrains decompiler
// Type: paymentSuccseful
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class paymentSuccseful : MonoBehaviour
{
  public GameObject paymentButton;
  public GameObject paymentText;
  public GameObject removeAdsButton;

  private void Start()
  {
  }

  private void Update()
  {
    if (!(PlayerPrefs.GetString("Show Ads") == "No"))
      return;
    this.paymentButton.SetActive(false);
    this.paymentText.GetComponent<Text>().text = "Thank you so much!";
    this.removeAdsButton.GetComponent<Text>().text = "ADS REMOVED";
  }
}
