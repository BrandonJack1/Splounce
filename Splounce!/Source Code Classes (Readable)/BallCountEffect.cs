// Decompiled with JetBrains decompiler
// Type: BallCountEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class BallCountEffect : MonoBehaviour
{
  public GameObject ball;
  public GameObject ballCountNum;
  public Rigidbody2D ballRespawnArea;
  public bool spawnActive;
  public GameObject nextBall;
  public float nextSpawn;
  public float spawnTimer = 0.25f;
  public int maxBall;
  public int totalBall;
  public float fnextSpawn;
  public bool addExtra;
  public int subtractAmt;

  private void Start()
  {
    this.maxBall = Ball.ballCount;
    this.totalBall = 0;
    this.fnextSpawn = Time.time + this.spawnTimer;
  }

  private void Update()
  {
    this.ballCountNum.GetComponent<Text>().text = string.Empty + (object) this.totalBall;
    this.spawnTimer -= Time.deltaTime;
    if (!this.addExtra && Ball.ballCount > 1)
      this.addExtra = true;
    if ((double) this.spawnTimer > 0.0 || this.totalBall >= this.maxBall)
      return;
    this.spawn();
    this.spawnTimer = 0.25f;
    ++this.totalBall;
  }

  private void spawn()
  {
    GameObject gameObject = Object.Instantiate<GameObject>(this.nextBall, (Vector3) this.ballRespawnArea.position, Quaternion.identity);
    int num = Random.Range(1, 7);
    if (num == 1)
      gameObject.GetComponent<Ball>().startForce = new Vector2(3f, 7f);
    if (num == 2)
      gameObject.GetComponent<Ball>().startForce = new Vector2(-3f, 7f);
    if (num == 3)
      gameObject.GetComponent<Ball>().startForce = new Vector2(-4f, -7f);
    if (num == 4)
      gameObject.GetComponent<Ball>().startForce = new Vector2(5f, -2f);
    if (num == 5)
      gameObject.GetComponent<Ball>().startForce = new Vector2(5f, 5f);
    if (num != 6)
      return;
    gameObject.GetComponent<Ball>().startForce = new Vector2(-7f, 5f);
  }
}
