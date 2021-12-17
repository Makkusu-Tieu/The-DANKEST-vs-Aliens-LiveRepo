using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] alienPrefabs;
    private float spawnRangeX = 11.0f;
    private float startDelay = 1.0f;
    private float spawnInterval = 1.0f;
    //private int[] spawnRangeY = { -4, -2, 0, 2, 4 };

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAlien", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAlien()
    {
        Vector2 spawnPos = new Vector2(spawnRangeX, Random.Range(-4, 4));
        //Vector2 spawnPos = new Vector2(spawnRangeX, spawnRangeY(0, 4));
        int alienIndex = (Random.Range(0, alienPrefabs.Length));
        Instantiate(alienPrefabs[alienIndex], spawnPos, alienPrefabs[alienIndex].transform.rotation);
    }
}
