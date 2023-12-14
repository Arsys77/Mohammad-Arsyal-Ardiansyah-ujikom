using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject MunculPause;

    public void PauseMuncul()
    {
        MunculPause.SetActive(true);
    }


    public void PauseIlang()
    {
        MunculPause.SetActive(false);
    }
}
