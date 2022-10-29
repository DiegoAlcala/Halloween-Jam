using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject WinPanel;
    public GameObject LosePanel;
    public GameObject MenuPanel;

    public void PanelWinner()
    {
        WinPanel.SetActive(true);
        Debug.Log("Active El Panel de ganar");
    }
    public void PanelLose()
    {
        LosePanel.SetActive(true);
        Debug.Log("Panel Perdi");
    }
    public void PanelMenu()
    {
        MenuPanel.SetActive(true);
        Debug.Log("Menu");
    }

}

