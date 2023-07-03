using UnityEngine;
using System;
using GoogleMobileAds.Api;
using System.Collections.Generic;

public class AdaptiveBanner : MonoBehaviour
{
    private BannerView _bannerView;
    // Create a 320x50 banner ad at coordinate (0,50) on screen.
    

    // Use this for initialization
    void Start()
    {
        // Set your test devices.
        // https://developers.google.com/admob/unity/test-ads
        RequestConfiguration requestConfiguration = new RequestConfiguration
        {
            TestDeviceIds = new List<string>
            {
                AdRequest.TestDeviceSimulator,
                // Add your test device IDs (replace with your own device IDs).
                #if UNITY_IPHONE
                "96e23e80653bb28980d3f40beb58915c"
                #elif UNITY_ANDROID
                "ca-app-pub-8255863298013904~2981599283"
                #endif
            }
        };
        MobileAds.SetRequestConfiguration(requestConfiguration);

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize((InitializationStatus status) =>
        {
            RequestBanner();
        });
    }

    public void OnGUI()
    {
        
    }

    private void RequestBanner()
    {
        // These ad units are configured to always serve test ads.
#if UNITY_EDITOR
        string adUnitId = "unused";
#elif UNITY_ANDROID
            string adUnitId = "ca-app-pub-8255863298013904/2686590398";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3212738706492790/5381898163";
#else
            string adUnitId = "unexpected_platform";
#endif

        // Clean up banner ad before creating a new one.
        if (_bannerView != null)
        {
            _bannerView.Destroy();
        }

        AdSize adaptiveSize =
                AdSize.GetCurrentOrientationAnchoredAdaptiveBannerAdSizeWithWidth(AdSize.FullWidth);

        _bannerView = new BannerView(adUnitId, adaptiveSize, AdPosition.Bottom);

        // Register for ad events.
       // _bannerView.OnBannerAdLoaded += OnBannerAdLoaded;
        _bannerView.OnBannerAdLoadFailed += OnBannerAdLoadFailed;

        AdRequest adRequest = new AdRequest();

        // Load a banner ad.
        _bannerView.LoadAd(adRequest);
    }

    #region Banner callback handlers

    private void OnBannerAdLoaded(object sender, EventArgs args)
    {
       // Debug.Log("Banner view loaded an ad with response : "
         //        + _bannerView.GetResponseInfo());
       // Debug.Log("Ad Height: {0}, width: {1}",
         //       _bannerView.GetHeightInPixels(),
           //     _bannerView.GetWidthInPixels());
    }

    private void OnBannerAdLoadFailed(LoadAdError error)
    {
      //  Debug.LogError("Banner view failed to load an ad with error : "
        //        + error);
    }

    #endregion
}
