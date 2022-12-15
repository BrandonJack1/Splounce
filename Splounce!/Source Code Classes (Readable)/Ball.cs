// Decompiled with JetBrains decompiler
// Type: Ball
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
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
  private Random rnd = new Random();
  public GameObject powerUp;
  private int powerRnd;
  public GameObject explosion;
  public Text txtScore;
  public int rotateSpeed = 10;

  private void Start()
  {
    this.rb.AddForce(this.startForce, ForceMode2D.Impulse);
    this.StartCoroutine(this.splitTime());
  }

  private void Update() => this.ballCountText.GetComponent<Text>().text = "BALL COUNT: " + (object) Ball.ballCount;

  public void Split()
  {
    if (!Ball.split)
      return;
    this.explode();
    if (PlayerPrefs.GetString("sound") != "off")
      this.plop.Play();
    Ball.split = false;
    GlobalScore.plusScoreOn = true;
    GlobalScore.flashNow = true;
    GameObject gameObject1 = Object.Instantiate<GameObject>(this.nextBall, (Vector3) (this.rb.position + Vector2.right / 2f), Quaternion.identity);
    GameObject gameObject2 = Object.Instantiate<GameObject>(this.nextBall, (Vector3) (this.rb.position + Vector2.left / 2f), Quaternion.identity);
    if (Ball.ballCount < 9)
      this.powerRnd = Random.Range(1, 12);
    if (Ball.ballCount >= 10)
      this.powerRnd = Random.Range(1, 6);
    if (this.powerRnd == 2)
      Object.Instantiate<GameObject>(this.powerUp, (Vector3) this.rb.position, Quaternion.identity);
    this.gameObject.SetActive(false);
    gameObject1.GetComponent<Ball>().startForce = new Vector2(2f, 7f);
    gameObject1.GetComponent<Rigidbody2D>().AddTorque(-0.3f, ForceMode2D.Impulse);
    gameObject2.GetComponent<Ball>().startForce = new Vector2(-2f, 7f);
    gameObject2.GetComponent<Rigidbody2D>().AddTorque(0.3f, ForceMode2D.Impulse);
    GlobalScore.Score += 250;
    this.txtScore.GetComponent<Animation>().Play("scoreAnim");
    ++Ball.ballCount;
  }

  private void explode() => Object.Instantiate<GameObject>(this.explosion, (Vector3) this.rb.position, Quaternion.identity).GetComponent<ParticleSystem>().Play();


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
