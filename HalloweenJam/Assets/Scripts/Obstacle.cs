using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    public PlayerControl player;
    
   private void OnCollisionEnter(Collision collision) 
   {
    if(collision.transform.CompareTag("Player"))
    {
      player.ImDead =true;

    }
   }
}
