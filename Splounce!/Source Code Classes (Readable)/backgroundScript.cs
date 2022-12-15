// Decompiled with JetBrains decompiler
// Type: backgroundScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class backgroundScript : MonoBehaviour
{
  public GameObject background;
  public Sprite[] sprites;

  private void Start() => this.pickBackground();

  private void Update()
  {
  }

  public void pickBackground()
  {
    int num = Random.Range(1, 6);
    if (num == 1)
      this.background.GetComponent<SpriteRenderer>().sprite = this.sprites[0];
    if (num == 2)
      this.background.GetComponent<SpriteRenderer>().sprite = this.sprites[1];
    if (num == 3)
      this.background.GetComponent<SpriteRenderer>().sprite = this.sprites[2];
    if (num == 4)
      this.background.GetComponent<SpriteRenderer>().sprite = this.sprites[3];
    if (num != 5)
      return;
    this.background.GetComponent<SpriteRenderer>().sprite = this.sprites[4];
  }
}
