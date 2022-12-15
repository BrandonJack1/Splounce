// Decompiled with JetBrains decompiler
// Type: Chain
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class Chain : MonoBehaviour
{
  public Rigidbody2D laser;
  public static bool isFired;
  public Transform player;
  public AudioSource laserSound;
  public static bool laserSoundEnabled = true;
  public GameObject laserParticles;
  public ParticleSystem laserParticleSystem;
  public float laserSpeed = 15f;

  private void Start() => Chain.isFired = false;

  private void Update()
  {
    if (Input.GetKeyDown("space"))
      Chain.isFired = true;
    if (!Chain.isFired)
    {
      this.laser.transform.position = this.player.position;
      this.laser.velocity = (Vector2) (this.transform.up * 0.0f);
      this.laserParticleSystem.Stop();
    }
    else
    {
      this.laserParticles.GetComponent<ParticleSystem>().Play();
      this.laser.velocity = (Vector2) (this.transform.up * this.laserSpeed);
      this.laserParticleSystem.time = 0.0f;
      this.laserParticleSystem.Play();
    }
  }

  public void fired()
  {
    Chain.isFired = true;
    if (!(PlayerPrefs.GetString("sound") != "off"))
      return;
    this.laserSound.Play();
  }
}
