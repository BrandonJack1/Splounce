// Decompiled with JetBrains decompiler
// Type: reset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class reset : MonoBehaviour
{
  private void Start()
  {
  }

  private void Update()
  {
  }

  public void resetPrefs() => PlayerPrefs.DeleteAll();
}
