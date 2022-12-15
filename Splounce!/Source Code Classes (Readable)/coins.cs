// Decompiled with JetBrains decompiler
// Type: coins
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class coins : MonoBehaviour
{
  public static int coinsAmt;

  private void Start()
  {
  }

  private void Update() => coins.coinsAmt = PlayerPrefs.GetInt("Num Coins", coins.coinsAmt);

  public static void addCoins(int coins) => PlayerPrefs.SetInt("Num Coins", PlayerPrefs.GetInt("Num Coins") + coins);

  public static void subtractCoins(int numCoins) => PlayerPrefs.SetInt("Num Coins", PlayerPrefs.GetInt("Num Coins") - numCoins);
}
