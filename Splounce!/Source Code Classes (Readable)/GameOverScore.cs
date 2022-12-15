// Decompiled with JetBrains decompiler
// Type: GameOverScore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
  public GameObject Score;
  public int numCoins;
  public GameObject coinAmt;
  public GameObject plusCoin;

  private void Start()
  {
    this.numCoins = GlobalScore.Score / 100;
    coins.addCoins(this.numCoins);
  }

  private void Update()
  {
    this.Score.GetComponent<Text>().text = "SCORE: " + (object) GlobalScore.Score;
    this.coinAmt.GetComponent<Text>().text = "COINS: " + (object) PlayerPrefs.GetInt("Num Coins");
    this.plusCoin.GetComponent<Text>().text = "+ " + (object) this.numCoins;
  }
}
