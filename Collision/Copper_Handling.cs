using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copper_Handling : MonoBehaviour
{
    public AudioSource sound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
            playerInventory.CopperCollected();
            sound.Play();
            this.gameObject.SetActive(false);
        }
    }
}
