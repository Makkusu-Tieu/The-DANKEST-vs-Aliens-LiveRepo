using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
    public float spawnRate = 1.0f;
    public float timeBetweenWaves = 3.0f;

    public int enemyCount;

    public GameObject alien;

    bool waveIsDone = true;

    private float spawnRangeX = 11.0f;
    private int[] spawnRangeY = { -4, -2, 0, 2, 4 };
    private int alienSpawnPosY;

    public TextMeshProUGUI waveCountText;
    int waveCount = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        waveCountText.text = "Wave: " + waveCount.ToString();

        if (waveIsDone == true)
        {
            StartCoroutine(waveSpawner());
        }
    }

    IEnumerator waveSpawner()
    {
        waveIsDone = false;

        for (int i = 0; i < enemyCount; i++)
        {
            //GameObject enemyClone = Instantiate(alien);
            alienSpawnPosY = spawnRangeY[Random.Range(0, 5)];
            Vector2 spawnPos = new Vector2(spawnRangeX, alienSpawnPosY);
            Instantiate(alien, spawnPos, alien.transform.rotation);

            yield return new WaitForSeconds(spawnRate);
        }

        spawnRate -= 0.1f;
        enemyCount += 3;
        waveCount += 1;

        yield return new WaitForSeconds(timeBetweenWaves);

        waveIsDone = true;
    }
}
