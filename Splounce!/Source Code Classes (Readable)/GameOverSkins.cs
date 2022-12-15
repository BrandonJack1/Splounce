// Decompiled with JetBrains decompiler
// Type: GameOverSkins
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class GameOverSkins : MonoBehaviour
{
  public GameObject ball;
  public GameObject nextBall;
  public Sprite soccerBall;
  public Sprite basketBall;
  public Sprite beachBall;
  public Sprite eightBall;

  private void Start()
  {
    Debug.Log((object) PlayerPrefs.GetString("Active Player Skin"));
    if (PlayerPrefs.GetString("Active Ball Skin") == "Soccer Ball")
    {
      this.ball.GetComponent<SpriteRenderer>().sprite = this.soccerBall;
      this.ball.GetComponent<SpriteRenderer>().drawMode = SpriteDrawMode.Sliced;
      this.ball.GetComponent<Transform>().localScale = new Vector3(0.7f, 0.7f, 0.0f);
      this.ball.GetComponent<SpriteRenderer>().color = Color.white;
      this.nextBall.GetComponent<SpriteRenderer>().sprite = this.soccerBall;
      this.nextBall.GetComponent<SpriteRenderer>().drawMode = SpriteDrawMode.Sliced;
      this.nextBall.GetComponent<Transform>().localScale = new Vector3(0.7f, 0.7f, 0.0f);
      this.nextBall.GetComponent<SpriteRenderer>().color = Color.white;
    }
    else if (PlayerPrefs.GetString("Active Ball Skin") == "Basket Ball")
    {
      this.ball.GetComponent<SpriteRenderer>().sprite = this.basketBall;
      this.ball.GetComponent<SpriteRenderer>().drawMode = SpriteDrawMode.Sliced;
      this.ball.GetComponent<Transform>().localScale = new Vector3(0.7f, 0.7f, 0.0f);
      this.ball.GetComponent<SpriteRenderer>().color = Color.white;
      this.nextBall.GetComponent<SpriteRenderer>().sprite = this.basketBall;
      this.nextBall.GetComponent<SpriteRenderer>().drawMode = SpriteDrawMode.Sliced;
      this.nextBall.GetComponent<Transform>().localScale = new Vector3(0.7f, 0.7f, 0.0f);
    }
    else if (PlayerPrefs.GetString("Active Ball Skin") == "Beach Ball")
    {
      this.ball.GetComponent<SpriteRenderer>().sprite = this.beachBall;
      this.ball.GetComponent<SpriteRenderer>().drawMode = SpriteDrawMode.Sliced;
      this.ball.GetComponent<Transform>().localScale = new Vector3(0.6f, 0.6f, 0.0f);
      this.ball.GetComponent<SpriteRenderer>().color = Color.white;
      this.nextBall.GetComponent<SpriteRenderer>().sprite = this.beachBall;
      this.nextBall.GetComponent<SpriteRenderer>().drawMode = SpriteDrawMode.Sliced;
      this.nextBall.GetComponent<Transform>().localScale = new Vector3(0.6f, 0.6f, 0.0f);
      this.nextBall.GetComponent<SpriteRenderer>().color = Color.white;
    }
    else
    {
      if (!(PlayerPrefs.GetString("Active Ball Skin") == "Eight Ball"))
        return;
      this.ball.GetComponent<SpriteRenderer>().sprite = this.eightBall;
      this.ball.GetComponent<SpriteRenderer>().drawMode = SpriteDrawMode.Sliced;
      this.ball.GetComponent<Transform>().localScale = new Vector3(0.6f, 0.6f, 0.0f);
      this.ball.GetComponent<SpriteRenderer>().color = Color.white;
      this.nextBall.GetComponent<SpriteRenderer>().sprite = this.eightBall;
      this.nextBall.GetComponent<SpriteRenderer>().drawMode = SpriteDrawMode.Sliced;
      this.nextBall.GetComponent<Transform>().localScale = new Vector3(0.6f, 0.6f, 0.0f);
      this.nextBall.GetComponent<SpriteRenderer>().color = Color.white;
    }
  }

  private void Update()
  {
  }
}
