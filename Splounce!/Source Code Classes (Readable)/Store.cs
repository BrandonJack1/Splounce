// Decompiled with JetBrains decompiler
// Type: Store
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
  public GameObject coinAmt;
  public GameObject playerPurple;
  public GameObject playerYellow;
  public GameObject playerRed;
  public GameObject playerGreen;
  public GameObject soccerBall;
  public GameObject basketBall;
  public GameObject beachBall;
  public GameObject eightBall;
  public static string playerSkinActive = string.Empty;
  public GameObject activeSkin;
  public GameObject ballActiveSkin;

  private void Start() => this.coinAmt.GetComponent<Text>().text = "COINS " + (object) PlayerPrefs.GetInt("Num Coins");

  private void Update()
  {
    this.coinAmt.GetComponent<Text>().text = "COINS: " + (object) PlayerPrefs.GetInt("Num Coins");
    if (PlayerPrefs.GetString("Player Purple") == "Not Equipped")
      this.playerPurple.GetComponentInChildren<Text>().text = "Equip";
    if (PlayerPrefs.GetString("Player Dark Yellow") == "Not Equipped")
      this.playerYellow.GetComponentInChildren<Text>().text = "Equip";
    if (PlayerPrefs.GetString("Player Green") == "Not Equipped")
      this.playerGreen.GetComponentInChildren<Text>().text = "Equip";
    if (PlayerPrefs.GetString("Player Red") == "Not Equipped")
      this.playerRed.GetComponentInChildren<Text>().text = "Equip";
    if (PlayerPrefs.GetString("Ball Soccer Ball") == "Not Equipped")
      this.soccerBall.GetComponentInChildren<Text>().text = "Equip";
    if (PlayerPrefs.GetString("Ball Basket Ball") == "Not Equipped")
      this.basketBall.GetComponentInChildren<Text>().text = "Equip";
    if (PlayerPrefs.GetString("Ball Beach Ball") == "Not Equipped")
      this.beachBall.GetComponentInChildren<Text>().text = "Equip";
    if (PlayerPrefs.GetString("Ball Eight Ball") == "Not Equipped")
      this.eightBall.GetComponentInChildren<Text>().text = "Equip";
    this.activeSkin.GetComponent<Text>().text = "Current Skin: " + PlayerPrefs.GetString("Active Player Skin");
    this.ballActiveSkin.GetComponent<Text>().text = "Current Skin: " + PlayerPrefs.GetString("Active Ball Skin");
  }

  public void Buy(Button btn)
  {
    if (PlayerPrefs.GetString("Player " + btn.name) != "Equipped" && PlayerPrefs.GetString("Player " + btn.name) != "Not Equipped")
    {
      if (PlayerPrefs.GetInt("Num Coins") < 500)
        return;
      coins.subtractCoins(500);
      PlayerPrefs.SetString("Player " + btn.name, "Not Equipped");
      Debug.Log((object) PlayerPrefs.GetString("Player " + btn.name));
    }
    else
      PlayerPrefs.SetString("Active Player Skin", btn.name);
  }

  public void BuyBall(Button btn)
  {
    if (PlayerPrefs.GetString("Ball " + btn.name) != "Equipped" && PlayerPrefs.GetString("Ball " + btn.name) != "Not Equipped")
    {
      if (PlayerPrefs.GetInt("Num Coins") < 750)
        return;
      coins.subtractCoins(750);
      PlayerPrefs.SetString("Ball " + btn.name, "Not Equipped");
      Debug.Log((object) PlayerPrefs.GetString("Ball " + btn.name));
    }
    else
      PlayerPrefs.SetString("Active Ball Skin", btn.name);
  }

  public void devAddCoins() => coins.addCoins(500);
}
