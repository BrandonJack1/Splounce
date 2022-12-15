// Decompiled with JetBrains decompiler
// Type: timer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
  public Text timerText;
  public static float secondsCount;
  public static int minuteCount;
  private int hourCount;
  public static float privateTimer;
  public GameObject bigBall;
  public GameObject smallBall;
  public Rigidbody2D spawn;
  public float spawnTime;
  public AudioSource pop;
  public bool invokeActive;
  public bool invokeTwoActive;

  private void Start()
  {
    this.InvokeRepeating("SpawnBall", this.spawnTime, this.spawnTime);
    timer.privateTimer = 0.0f;
    timer.secondsCount = 0.0f;
    timer.minuteCount = 0;
    TimedBall.timedBallCount = 1;
  }

  private void Update()
  {
    this.UpdateTimerUI();
    timer.privateTimer += Time.deltaTime;
    if (roundWipe.roundCount > 2 && roundWipe.roundCount < 6)
    {
      if (this.invokeActive)
        return;
      this.invokeSeconds(3, roundWipe.roundCount);
      Debug.Log((object) this.spawnTime);
    }
    else if (roundWipe.roundCount >= 6)
    {
      if (this.invokeTwoActive)
        return;
      Debug.Log((object) "2 Second Method");
      this.invokeSeconds2(2, roundWipe.roundCount);
      Debug.Log((object) this.spawnTime);
    }
    else
      this.spawnTime = 5f;
  }

  public void UpdateTimerUI()
  {
    timer.secondsCount += Time.deltaTime;
    this.timerText.text = timer.minuteCount.ToString() + "m:" + (object) (int) timer.secondsCount + "s";
    if ((double) timer.secondsCount >= 60.0)
    {
      ++timer.minuteCount;
      timer.secondsCount = 0.0f;
    }
    else
    {
      if (timer.minuteCount < 60)
        return;
      ++this.hourCount;
      timer.minuteCount = 0;
    }
  }

  private void SpawnBall()
  {
    GameObject gameObject1 = Object.Instantiate<GameObject>(this.bigBall, (Vector3) this.spawn.position, Quaternion.identity);
    gameObject1.GetComponent<Rigidbody2D>().AddTorque(-0.3f, ForceMode2D.Impulse);
    ++TimedBall.timedBallCount;
    int num1 = Random.Range(1, 7);
    if (PlayerPrefs.GetString("sound") != "off")
      this.pop.Play();
    if (num1 == 1)
      gameObject1.GetComponent<TimedBall>().startForce = new Vector2(5f, 7f);
    if (num1 == 2)
      gameObject1.GetComponent<TimedBall>().startForce = new Vector2(-5f, 7f);
    if (num1 == 3)
      gameObject1.GetComponent<TimedBall>().startForce = new Vector2(-3f, 10f);
    if (num1 == 4)
      gameObject1.GetComponent<TimedBall>().startForce = new Vector2(3f, 10f);
    if (num1 == 5)
      gameObject1.GetComponent<TimedBall>().startForce = new Vector2(3f, 8f);
    if (num1 == 6)
      gameObject1.GetComponent<TimedBall>().startForce = new Vector2(-3f, 8f);
    if (TimedBall.timedBallCount > 5)
      return;
    GameObject gameObject2 = Object.Instantiate<GameObject>(this.bigBall, (Vector3) this.spawn.position, Quaternion.identity);
    gameObject2.GetComponent<Rigidbody2D>().AddTorque(-0.3f, ForceMode2D.Impulse);
    ++TimedBall.timedBallCount;
    int num2 = Random.Range(1, 7);
    if (num2 == 1)
      gameObject2.GetComponent<TimedBall>().startForce = new Vector2(2f, 6f);
    if (num2 == 2)
      gameObject2.GetComponent<TimedBall>().startForce = new Vector2(-2f, 6f);
    if (num2 == 3)
      gameObject2.GetComponent<TimedBall>().startForce = new Vector2(-2f, 11f);
    if (num2 == 4)
      gameObject2.GetComponent<TimedBall>().startForce = new Vector2(2f, 11f);
    if (num2 == 5)
      gameObject2.GetComponent<TimedBall>().startForce = new Vector2(1f, 9f);
    if (num2 != 6)
      return;
    gameObject2.GetComponent<TimedBall>().startForce = new Vector2(-1f, 9f);
  }

  public void invokeSeconds(int sec, int roundCount)
  {
    this.CancelInvoke("SpawnBall");
    this.invokeActive = true;
    this.spawnTime = (float) sec;
    this.InvokeRepeating("SpawnBall", this.spawnTime, this.spawnTime);
  }

  public void invokeSeconds2(int sec, int roundCount)
  {
    this.CancelInvoke("SpawnBall");
    this.invokeTwoActive = true;
    this.spawnTime = (float) sec;
    this.InvokeRepeating("SpawnBall", this.spawnTime, this.spawnTime);
  }
}
