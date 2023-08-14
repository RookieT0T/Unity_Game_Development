using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    // Variables for movement
    public CharacterController characterController;
    public float initialSpeed = 10f;
    public float miniSpeed = 0f;
    Vector3 velocity;

    // Variables for ground checking
    public Transform groundCheck;
    public float groundDistance = 0.3f;
    public LayerMask groundMask;
    bool isGrounded;

    // Health bar in the UI
    public Health_Bar health_Bar;

    // Gameover menu
    public GameOver_Menu gameOver;

    // Gamewin menu
    public GameWin_Menu gameWin;

    // PlayerInventory instance
    public PlayerInventory inventory;

    // Start is called in the beginning of the program
    void Start()
    {
        Time.timeScale = 1f;
        health_Bar.SetMax(initialSpeed); // full speed in the beginning
    }

    // Update is called once per frame
    void Update()
    {
        // Check whether the character is on the terrain
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -1f;
        }

        // Handle the movement in the horizontal direction
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        
        // decrease the speed all the time or mimic the characater's tiredness
        if(initialSpeed > miniSpeed)
        {
            /*
            initialSpeed -= 2f * Time.deltaTime;
            health_Bar.SetSpeed(initialSpeed);
            */
            
            int number = inventory.totalNumber();
            if(number == 9)
            {
                gameWin.setUp(); // call the gamewin menu to appear
            }
            
            
            if (initialSpeed >= 5)
            {
                initialSpeed -= 0.06f * Time.deltaTime;
                health_Bar.SetSpeed(initialSpeed); // update the UI value
            }
            else
            {
                initialSpeed -= 0.04f * Time.deltaTime;
                health_Bar.SetSpeed(initialSpeed); // update the UI value
            }
            
        }
        else
        {
            gameOver.setUp(); // call the gameover menu to appear
        }
        
     
        characterController.Move(move * initialSpeed * Time.deltaTime);

        // Handle the free dropping of the character
        velocity.y -= 0.2f * 9.8f * Time.deltaTime * Time.deltaTime;
        characterController.Move(velocity);
    }

    // Recover the speed after hitting the first aid package
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FirstAid")
        {
            initialSpeed = 10f;
        }
    }
}
