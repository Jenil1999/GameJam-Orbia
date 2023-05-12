using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    [SerializeField] Button backButton;
    [SerializeField] Button Lvl1Button;

    private void Start()
    {
        backButton.onClick.AddListener(BacktoMenu);
        Lvl1Button.onClick.AddListener(LoadLvl1);
    }

    void BacktoMenu()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.MainMenu);
    }

    void LoadLvl1()
    {
        ScreenManager.instance.ShowNextScreen(ScreenType.GamePlayCanvas);
        Time.timeScale = 1f;

    }
}
