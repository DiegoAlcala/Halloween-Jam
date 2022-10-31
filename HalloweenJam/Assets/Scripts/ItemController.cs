using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    public Text itemText;
    // almacenar el valor total de todos los items que toca obtener
    [SerializeField] int  items;

    //public PlayerColliders Variable que se aumenta. 

    public bool IsWinner;

    // Update is called once per frame
    void Update()
    {
        itemText.text = "Items:" + items + ("/26");
        if (items == 0)
        {
            NoItems();
        }
    }


    public float CountItems()
    {
        return items;
    }
    public void ActualizarMarcador()
    {
        items --;
    }
    public void NoItems()
    {
        IsWinner = true;
    }
}

