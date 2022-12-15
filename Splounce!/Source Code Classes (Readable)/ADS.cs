// Decompiled with JetBrains decompiler
// Type: ADS
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Advertisements;

public class ADS : MonoBehaviour, IUnityAdsListener
{
  private string GooglePlay_ID = "3538536";
  private bool testMode = true;
  private string interstitalAd = "video";
  private string rewardedVideoAd = "rewardedVideo";
  public bool isTargetPlayStore;
  public bool isTestAd;
  public GameObject continueCanvas;
  public GameObject playerTrigger;
  public GameObject player;
  public static int adCounter = 1;

  private void Start()
  {
    this.IntializeAdvertismenet();
    Advertisement.AddListener((IUnityAdsListener) this);
  }

  private void IntializeAdvertismenet() => Advertisement.Initialize(this.GooglePlay_ID, this.isTestAd);

  public void PlayInterstialAd()
  {
    if (ADS.adCounter != 2 || !(PlayerPrefs.GetString("Show Ads") != "No") || !Advertisement.IsReady(this.interstitalAd))
      return;
    Time.timeScale = 0.0f;
    Advertisement.Show(this.interstitalAd);
  }

  public void PlayRewardedVideoAd()
  {
    if (!Advertisement.IsReady(this.rewardedVideoAd))
      return;
    Advertisement.Show(this.rewardedVideoAd);
  }

  public void OnUnityAdsReady(string placementId)
  {
  }

  public void OnUnityAdsDidError(string message)
  {
  }

  public void OnUnityAdsDidStart(string placementId)
  {
  }

  public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
  {
    switch (showResult)
    {
      case ShowResult.Skipped:
        if (!(placementId == this.interstitalAd))
          break;
        Time.timeScale = 1f;
        ADS.adCounter = 1;
        break;
      case ShowResult.Finished:
        if (placementId == this.rewardedVideoAd)
        {
          --Ball.ballCount;
          deleteBallCode.active = false;
          deleteBallCode.deleteBall = true;
          Time.timeScale = 1f;
          deleteBallCode.playerColorActive = true;
          ADS.adCounter = 0;
          deleteBallCode.finishRoutineActive = true;
        }
        if (!(placementId == this.interstitalAd))
          break;
        Time.timeScale = 1f;
        ADS.adCounter = 1;
        break;
    }
  }
}
