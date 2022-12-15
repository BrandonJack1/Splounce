// Decompiled with JetBrains decompiler
// Type: HowTOPlayScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class HowTOPlayScript : MonoBehaviour
{
  public GameObject howToCanvas;
  public GameObject timedHowToCanvas;
  public GameObject adRemoveCanvas;

  private void Start() => this.howToCanvas.SetActive(false);

  private void Update()
  {
  }

  public void openHowTo() => this.howToCanvas.SetActive(true);

  public void closeHowTo() => this.howToCanvas.SetActive(false);

  public void timedOpenHowTo() => this.timedHowToCanvas.SetActive(true);

  public void timedCloseHowTo() => this.timedHowToCanvas.SetActive(false);

  public void AdRemoveClose() => this.adRemoveCanvas.SetActive(false);

  public void adRemoveOpen() => this.adRemoveCanvas.SetActive(true);
}
