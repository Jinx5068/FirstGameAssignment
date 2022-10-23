using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//SceneManagement is where all the assets of the game is stored, by adding this I am forcing the player to restart if it dies in the scene or start all the way back from the start
public class Lava : MonoBehaviour
{
    void OnTriggerEnter(Collider other)//if I object colliders with anything it will activate the script and restart the player.
    {//Sample scene is the first scene which is created for the player, "loadscene" means that everytime the player dies in the floor is lava part they will be teleported back to the start 
        //until they manage to complete the task in hand.
        SceneManager.LoadScene("SampleScene");
    }
}
