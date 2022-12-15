// Decompiled with JetBrains decompiler
// Type: BlockMoveTouch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class BlockMoveTouch : MonoBehaviour
{
  public void blockMovement()
  {
    playerWalk.allowMovement = false;
    this.StartCoroutine(this.enableMovement());
  }

  private void Start() => playerWalk.allowMovement = true;
}
