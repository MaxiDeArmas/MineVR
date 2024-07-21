using System.Collections; //Access to collection classes and interfaces
using System.Collections.Generic; //Access to generic collection classes and interfaces
using UnityEngine; //Access to Unity-specific classes and functionality

public class RockInteraction : MonoBehaviour //Template definition of the methods and variables in a particular kind of object
{
    public GameObject rock; // Reference to the rock GameObject
    public AudioSource audioSource; // Reference to the AudioSource component

    // Function to handle the interaction between pickaxe and rock
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the pickaxe
        if (other.CompareTag("Pickaxe"))
        {
            // Make the rock disappear
            Destroy(rock);

            // Play the sound effect
            audioSource.Play();
        }
    }
}
