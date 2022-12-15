// Decompiled with JetBrains decompiler
// Type: BlitzBall
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class BlitzBall : MonoBehaviour
{
  public Vector2 startForce;
  public Rigidbody2D rb;
  public GameObject nextBall;
  public static int ballCount = 1;
  public GameObject ballCountText;
  public static bool split;
  public AudioSource plop;
  public GameObject plusText;
  public bool plusTextActive;

  private void Start()
  {
    this.rb.AddForce(this.startForce, ForceMode2D.Impulse);
    this.StartCoroutine(this.splitTime());
  }

  private void Update() => this.ballCountText.GetComponent<Text>().text = "BALL COUNT: " + (object) BlitzBall.ballCount;

  public void Split()
  {
    if (!BlitzBall.split)
      return;
    BlitzBall.split = false;
    GlobalScore.plusScoreOn = true;
    GlobalScore.flashNow = true;
    GameObject gameObject1 = Object.Instantiate<GameObject>(this.nextBall, (Vector3) (this.rb.position + Vector2.right / 2f), Quaternion.identity);
    GameObject gameObject2 = Object.Instantiate<GameObject>(this.nextBall, (Vector3) (this.rb.position + Vector2.left / 2f), Quaternion.identity);
    this.gameObject.SetActive(false);
    gameObject1.GetComponent<Ball>().startForce = new Vector2(2f, 7f);
    gameObject2.GetComponent<Ball>().startForce = new Vector2(-2f, 7f);
    if (PlayerPrefs.GetString("sound") != "off")
      this.plop.Play();
    GlobalScore.Score += 100;
    ++BlitzBall.ballCount;
  }

  private void pickColor(GameObject ball)
  {
    int num = Random.Range(1, 6);
    if (num == 1)
      ball.GetComponent<Renderer>().material.color = new Color(0.0f, (float) byte.MaxValue, 0.0f);
    if (num == 2)
      ball.GetComponent<Renderer>().material.color = new Color((float) byte.MaxValue, 0.0f, 0.0f);
    if (num == 3)
      ball.GetComponent<Renderer>().material.color = new Color(0.0f, 0.0f, (float) byte.MaxValue);
    if (num == 4)
      ball.GetComponent<Renderer>().material.color = Color.magenta;
    if (num != 5)
      return;
    ball.GetComponent<Renderer>().material.color = Color.white;
  }
}
