// Decompiled with JetBrains decompiler
// Type: promoCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class promoCode : MonoBehaviour
{
  public InputField input;
  public string code;
  public GameObject unlockText;
  public GameObject promoCodeCanvas;

  private void Start()
  {
  }

  public void enter()
  {
    this.code = this.input.text;
    if (this.input.text == "DAL")
    {
      PlayerPrefs.SetString("Dal Background Unlocked", "True");
      this.StartCoroutine(this.unlockTextMethod("The Dal Background has been added into the background playlist :)"));
    }
    else
      this.StartCoroutine(this.unlockTextMethod("Invalid Code"));
    this.input.text = string.Empty;
  }


  public void back()
  {
    UnityEngine.Debug.Log((object) "Hi");
    this.promoCodeCanvas.SetActive(false);
  }

  public void open() => this.promoCodeCanvas.SetActive(true);
}
