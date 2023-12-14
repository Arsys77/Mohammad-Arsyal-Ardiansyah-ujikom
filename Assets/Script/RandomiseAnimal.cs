using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomiseAnimal : MonoBehaviour
{
    public GameObject AnimalPrefab;
    public int numberOfAnimal = 10;
    public float spawnRadius = 10f;
    public float yOffset = 1f;
    public float rotation = 110f;
    public float respawnDelay = 2f;

    private int score = 0;
    public TMP_Text scoreText;

    void Start()
    {
        SpawnAnimal();
        UpdateScoreText();
    }

    void SpawnAnimal()
    {
        for (int i = 0; i < numberOfAnimal; i++)
        {
            float randomAngle = Random.Range(0f, Mathf.PI * 2f);
            float randomX = Mathf.Cos(randomAngle) * spawnRadius;
            float randomZ = Mathf.Sin(randomAngle) * spawnRadius;

            Vector3 spawnPosition = new Vector3(randomX, yOffset, randomZ) + transform.position;

            GameObject animal = Instantiate(AnimalPrefab, spawnPosition, Quaternion.identity);
        }
    }

    public void IncreaseScore()
    {
        score+=5;
        UpdateScoreText();

        Invoke("RespawnAnimal", respawnDelay);
    }

    void RespawnAnimal()
    {

        float randomAngle = Random.Range(0f, Mathf.PI * 2f);
        float randomX = Mathf.Cos(randomAngle) * spawnRadius;
        float randomZ = Mathf.Sin(randomAngle) * spawnRadius;

        Vector3 spawnPosition = new Vector3(randomX, yOffset, randomZ) + transform.position;

        GameObject animal = Instantiate(AnimalPrefab, spawnPosition, Quaternion.identity);
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
            Debug.Log(scoreText);
        }
    }
}


