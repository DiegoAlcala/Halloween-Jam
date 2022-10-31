using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ManagerGame : MonoBehaviour
{
    public SceneController managerScenes;
    public ItemController itemsController;
    public TimerController timerController;
    public UIController ControllerUI;
    public PlayerControl playerController;
    

    public bool Gane = false;
    public bool perdi = false;
    bool isActivate;

    void Start()
    {
        StartGame();
    }

    void Update()
    {
        if (isActivate)
        {
            if (itemsController.CountItems() <= 0)
            {
                Winner();
            }
            if (timerController.timeOut || playerController.ImDead) 
            {
                Loser();
            }
        }
    }

    public void StartGame()
    {

        isActivate = true;
    }
    public void Winner()
    {


        ControllerUI.PanelWinner();
        Debug.Log("Reiniciar porque Gane");
        Invoke("ResetScene", 3);
        Gane = true;
        isActivate = false;
    }

    public void Loser()
    {

        ControllerUI.PanelLose();
        perdi = true;
        Debug.Log("Cargando Interfaz.");
        Invoke("ResetScene", 3);
        isActivate = false;
    }

    public void GetItemAction()
    {
        timerController.sumarSegundos(7f);
    }
    public void ResetScene()
    {
        managerScenes.ReiniciarJuego();
    }
}
