using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PausarJuego();
        }
    }

    public void PausarJuego()
    {
             if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }

        else
        {
            Time.timeScale = 1;
        }
    }
}
