// Decompiled with JetBrains decompiler
// Type: HighScoreBall
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class HighScoreBall : MonoBehaviour
{
  public Vector2 highScoreMovement;
  public Rigidbody2D rb;

  private void Start()
  {
  }

  private void OnEnable()
  {
    this.highScoreMovement = new Vector2(0.0f, 12f);
    this.rb.AddForce(this.highScoreMovement, ForceMode2D.Impulse);
  }

  private void Update()
  {
  }

  public void startMovement()
  {
  }

  private void Awake()
  {
  }
}
