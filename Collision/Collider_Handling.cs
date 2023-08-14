using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Handling : MonoBehaviour
{
    public AudioSource sound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            sound.Play();
            this.gameObject.SetActive(false);
        }
    }
}
