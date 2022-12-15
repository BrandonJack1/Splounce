// Decompiled with JetBrains decompiler
// Type: roundWipe
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class roundWipe : MonoBehaviour
{
  public int ballWipeCount = 4;
  public static int roundCount = 1;
  public GameObject wipeWall;
  public GameObject roundCountText;
  public GameObject ballWipeCountText;
  public Text roundCountNum;
  public AudioSource pop;
  public AudioSource lvlUp;

  private void Start()
  {
    this.ballWipeCount = 6;
    roundWipe.roundCount = 1;
  }

  private void Update()
  {
    if (TimedBall.timedBallCount == this.ballWipeCount)
    {
      this.wipeWall.GetComponent<Animation>().Play("wipeWallMoveAnim");
      this.roundCountNum.GetComponent<Animation>().Play("roundNumAnim");
      ++roundWipe.roundCount;
      this.ballWipeCount += 2;
      if (PlayerPrefs.GetString("sound") != "off")
        this.lvlUp.Play();
    }
    this.roundCountNum.GetComponent<Text>().text = roundWipe.roundCount.ToString();
    this.roundCountText.GetComponent<Text>().text = "Round: ";
    this.ballWipeCountText.GetComponent<Text>().text = "Arena will wipe at: " + (object) this.ballWipeCount + " balls";
  }

  private void OnTriggerEnter2D(Collider2D col)
  {
    if (!(col.tag == "Ball"))
      return;
    if (PlayerPrefs.GetString("sound") != "off")
      this.pop.Play();
    col.gameObject.SetActive(false);
    --TimedBall.timedBallCount;
  }
}
