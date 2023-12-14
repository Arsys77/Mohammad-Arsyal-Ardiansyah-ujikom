using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfekButton : MonoBehaviour
{
    public void Button()
    {
        AudioManager.instance.PlayEfek("Efek");
    }

    public void Mulai_BGM_Main_dari_Gampelay()
    {
        AudioManager.instance.StopBG("Gameplay_BGM");
        AudioManager.instance.PlayBG("MainScreen_BGM");
    }

    public void Mulai_BGM_Gampelay_dari_MainScreen()
    {
        AudioManager.instance.StopBG("MainScreen_BGM");
        AudioManager.instance.PlayBG("Gameplay_BGM");
    }

}
