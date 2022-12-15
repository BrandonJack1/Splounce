// Decompiled with JetBrains decompiler
// Type: IAPManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1DDC9A9A-03CC-490E-A42C-44DD0D77CF7B
// Assembly location: C:\Users\Brandon\Downloads\BOUNCE-MAY-25th-WIN_Data\BOUNCE-MAY-25th-WIN_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

public class IAPManager : MonoBehaviour, IStoreListener
{
  public static IAPManager instance;
  private static IStoreController m_StoreController;
  private static IExtensionProvider m_StoreExtensionProvider;
  private string removeAds = "remove_ads";

  public void InitializePurchasing()
  {
    if (this.IsInitialized())
      return;
    ConfigurationBuilder builder = ConfigurationBuilder.Instance((IPurchasingModule) StandardPurchasingModule.Instance());
    builder.AddProduct(this.removeAds, ProductType.NonConsumable);
    UnityPurchasing.Initialize((IStoreListener) this, builder);
  }

  private bool IsInitialized() => IAPManager.m_StoreController != null && IAPManager.m_StoreExtensionProvider != null;

  public void BuyRemoveAds() => this.BuyProductID(this.removeAds);

  public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
  {
    if (string.Equals(args.purchasedProduct.definition.id, this.removeAds, StringComparison.Ordinal))
    {
      Debug.Log((object) "Ads removed Succsefully");
      PlayerPrefs.SetString("Show Ads", "No");
    }
    else
      Debug.Log((object) "Purchase Failed");
    return PurchaseProcessingResult.Complete;
  }

  private void Awake() => this.TestSingleton();

  private void Start()
  {
    if (IAPManager.m_StoreController != null)
      return;
    this.InitializePurchasing();
  }

  private void TestSingleton()
  {
    if ((UnityEngine.Object) IAPManager.instance != (UnityEngine.Object) null)
    {
      UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
    }
    else
    {
      IAPManager.instance = this;
      UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object) this.gameObject);
    }
  }

  private void BuyProductID(string productId)
  {
    if (this.IsInitialized())
    {
      Product product = IAPManager.m_StoreController.products.WithID(productId);
      if (product != null && product.availableToPurchase)
      {
        Debug.Log((object) string.Format("Purchasing product asychronously: '{0}'", (object) product.definition.id));
        IAPManager.m_StoreController.InitiatePurchase(product);
      }
      else
        Debug.Log((object) "BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
    }
    else
      Debug.Log((object) "BuyProductID FAIL. Not initialized.");
  }

  public void RestorePurchases()
  {
    if (!this.IsInitialized())
      Debug.Log((object) "RestorePurchases FAIL. Not initialized.");
    else if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.OSXPlayer)
    {
      Debug.Log((object) "RestorePurchases started ...");
      IAPManager.m_StoreExtensionProvider.GetExtension<IAppleExtensions>().RestoreTransactions((Action<bool>) (result => Debug.Log((object) ("RestorePurchases continuing: " + (object) result + ". If no further messages, no purchases available to restore."))));
    }
    else
      Debug.Log((object) ("RestorePurchases FAIL. Not supported on this platform. Current = " + (object) Application.platform));
  }

  public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
  {
    Debug.Log((object) "OnInitialized: PASS");
    IAPManager.m_StoreController = controller;
    IAPManager.m_StoreExtensionProvider = extensions;
  }

  public void OnInitializeFailed(InitializationFailureReason error) => Debug.Log((object) ("OnInitializeFailed InitializationFailureReason:" + (object) error));

  public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason) => Debug.Log((object) string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", (object) product.definition.storeSpecificId, (object) failureReason));
}
