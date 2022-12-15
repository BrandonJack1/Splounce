// Decompiled with JetBrains decompiler
// Type: UIPref
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class UIPref : MonoBehaviour
{
  public Text right;
  public Text left;

  private void Start()
  {
  }

  private void Update()
  {
    if (PlayerPrefs.GetString("Show RL") == "False")
    {
      this.right.GetComponent<Text>().text = string.Empty;
      this.left.GetComponent<Text>().text = string.Empty;
    }
    else
    {
      this.right.GetComponent<Text>().text = "R";
      this.left.GetComponent<Text>().text = "L";
    }
  }
}
