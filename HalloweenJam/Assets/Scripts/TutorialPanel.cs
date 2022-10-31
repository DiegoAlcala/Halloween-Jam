using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPanel : MonoBehaviour
{
  public GameObject tutorialPanel;
    // Start is called before the first frame update
    void Start()
    {
        tutorialPanel.SetActive(true);
        Invoke("eliminarObjeto",5);
    }

    // Update is called once per frame
    public void eliminarObjeto()

    {
        Destroy(tutorialPanel.gameObject);
    }
}

