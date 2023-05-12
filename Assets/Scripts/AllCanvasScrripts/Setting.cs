using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Setting : MonoBehaviour
{
    [SerializeField] Button backButton;

    private void Start()
    {
        backButton.onClick.AddListener(BacktoMenu);
    }

    public void BacktoMenu()
    {
        if(ScreenManager.instance.PreviousScreen == ScreenManager.instance.ScreenList[(int)ScreenType.HomeScreen])
        {
            ScreenManager.instance.ShowNextScreen(ScreenType.HomeScreen);
        }
        else if (ScreenManager.instance.PreviousScreen == ScreenManager.instance.ScreenList[(int)ScreenType.MainMenu])
        {
            ScreenManager.instance.ShowNextScreen(ScreenType.MainMenu);
        }
       
    }

    


}
