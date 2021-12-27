using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballsPrefabs;
    private float spawnRangeX = 8;
    private float spawnPosY = 6;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;



    void SpawnRandomBall()
    {
        int ballIndex = Random.Range(0, ballsPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, 0);
        Instantiate(ballsPrefabs[ballIndex], spawnPos, ballsPrefabs[ballIndex].transform.rotation);
    }


    private void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

}
