using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] alienPrefabs;
    private float spawnRangeX = 11.0f;
    int[] spawnRangeY = {0, 2, 4};

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAlien()
    {
        //Vector2 spawnPos = new Vector2(spawnRangeX, spawnRangeY);
        int alienIndex = (Random.Range(0, alienPrefabs.Length));
        //Instatiate(alienPrefabs[alienIndex], spawnPos, alienPrefabs[animalIndex].transform.rotation);
    }
}
