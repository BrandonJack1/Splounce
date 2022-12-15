// Decompiled with JetBrains decompiler
// Type: TimedBall
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class TimedBall : MonoBehaviour
{
  public Vector2 startForce;
  public Rigidbody2D rb;
  public GameObject nextBall;
  public static int timedBallCount = 1;
  public GameObject ballCountText;
  public static bool split;
  public AudioSource plop;
  public GameObject plusText;
  public bool plusTextActive;
  private Random rnd = new Random();
  public GameObject powerUp;
  private int powerRnd;
  public GameObject explosion;

  private void Start() => this.rb.AddForce(this.startForce, ForceMode2D.Impulse);

  private void Update() => this.ballCountText.GetComponent<Text>().text = "BALL COUNT: " + (object) TimedBall.timedBallCount;

  private void explode() => Object.Instantiate<GameObject>(this.explosion, (Vector3) this.rb.position, Quaternion.identity).GetComponent<ParticleSystem>().Play();
}
