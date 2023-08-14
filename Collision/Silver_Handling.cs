using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silver_Handling : MonoBehaviour
{
    public AudioSource sound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
            playerInventory.SilverCollected();
            sound.Play();
            this.gameObject.SetActive(false);
        }

        if(other.gameObject.tag == "Kingdom_Sphere")
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 2, ForceMode.Impulse);
        }
    }
}
