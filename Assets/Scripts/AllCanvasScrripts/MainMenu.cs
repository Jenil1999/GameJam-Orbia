using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button LoadGameNowButton;
    [SerializeField] Button OptionsButton;
    [SerializeField] Button LevelsButton;
    [SerializeField] Button MainMenuButton;

    void Start()
    {
        LoadGameNowButton.onClick.AddListener(LoadCurrentLevel);
        OptionsButton.onClick.AddListener(OptionPop);
        LevelsButton.onClick.AddListener(LevelPop);
        MainMenuButton.onClick.AddListener(BackMainMenu);
    }

     void LoadCurrentLevel()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.GamePlayCanvas);
        Time.timeScale = 1f;
    }

    void OptionPop()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.SettingPage);

    }

    void LevelPop()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.LevelSelectionPage);

    }

    void BackMainMenu()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.HomeScreen);

    }
}
