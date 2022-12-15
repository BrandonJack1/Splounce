// Decompiled with JetBrains decompiler
// Type: timedSpeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class timedSpeed : MonoBehaviour
{
  public GameObject speedTxt;
  public int speedNumber;

  private void Start()
  {
  }

  private void Update()
  {
    if (roundWipe.roundCount >= 1 && roundWipe.roundCount < 3)
    {
      this.speedNumber = 1;
      this.speedTxt.GetComponent<Text>().text = string.Empty + (object) this.speedNumber;
    }
    else if (roundWipe.roundCount >= 3 && roundWipe.roundCount < 6)
    {
      this.speedNumber = 2;
      this.speedTxt.GetComponent<Text>().text = string.Empty + (object) this.speedNumber;
    }
    else
    {
      if (roundWipe.roundCount < 6)
        return;
      this.speedNumber = 3;
      this.speedTxt.GetComponent<Text>().text = string.Empty + (object) this.speedNumber;
    }
  }
}
