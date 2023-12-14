using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColiision : MonoBehaviour
{
    public AudioSource efek;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animal"))
        {
            RandomiseAnimal AnimalSpawner = FindObjectOfType<RandomiseAnimal>();

            if (AnimalSpawner != null)
            {
                AnimalSpawner.IncreaseScore();
                Destroy(other.gameObject);
                efek.Play();
            }
        }
    }
}