// Decompiled with JetBrains decompiler
// Type: TimedPlayerWalk
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class TimedPlayerWalk : MonoBehaviour
{
  public static int moveSpeed = 900;
  public GameObject character;
  private Rigidbody2D characterBody;
  private float ScreenWidth;
  private float ScreenHeight;
  public static bool allowMovement = true;

  private void Start()
  {
    this.ScreenWidth = (float) Screen.width;
    this.ScreenHeight = (float) Screen.width;
    this.characterBody = this.character.GetComponent<Rigidbody2D>();
  }

  private void Update()
  {
    for (int index = 0; index < Input.touchCount; ++index)
    {
      if ((double) Input.GetTouch(index).position.x > (double) this.ScreenWidth / 2.0)
        this.RunCharacter(1f);
      if ((double) Input.GetTouch(index).position.x < (double) this.ScreenWidth / 2.0)
        this.RunCharacter(-1f);
      else
        this.RunCharacter(0.0f);
    }
  }

  private void FixedUpdate()
  {
  }

  private void RunCharacter(float horizontalInput)
  {
    if (!TimedPlayerWalk.allowMovement)
      return;
    if ((double) horizontalInput != 0.0)
      this.characterBody.velocity = new Vector2(8f * horizontalInput, 0.0f);
    else if ((double) horizontalInput != 0.0)
      ;
  }
}
