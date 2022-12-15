// Decompiled with JetBrains decompiler
// Type: easterEgg
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class easterEgg : MonoBehaviour
{
  public Rigidbody2D bounceText;

  private void Start() => this.bounceText.GetComponent<Rigidbody2D>().gravityScale = 0.0f;

  private void Update()
  {
  }

  public void btnPressed()
  {
    this.bounceText.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    this.bounceText.GetComponent<Rigidbody2D>().gravityScale = 1f;
    this.bounceText.AddForce((Vector2) (this.transform.right * 150f));
  }
}
