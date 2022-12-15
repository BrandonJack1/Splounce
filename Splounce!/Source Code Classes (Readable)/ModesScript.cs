// Decompiled with JetBrains decompiler
// Type: ModesScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.SceneManagement;

public class ModesScript : MonoBehaviour
{
  private void Start()
  {
  }

  private void Update()
  {
  }

  public void startBlitz() => SceneManager.LoadScene(2);

  public void startTimed() => SceneManager.LoadScene(4);

  public void goToModes() => SceneManager.LoadScene(6);

  public void goToStore() => SceneManager.LoadScene(7);
}
