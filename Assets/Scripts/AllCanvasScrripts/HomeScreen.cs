using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScreen : MonoBehaviour
{
    [SerializeField] Button PlayNowButton;
    [SerializeField] Button SettingButton;

    void Start()
    {
        PlayNowButton.onClick.AddListener(PlayNow);
        SettingButton.onClick.AddListener(SettingPop);
    }
    void PlayNow()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.MainMenu);
    }
    void SettingPop()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.SettingPage);
    }


}
