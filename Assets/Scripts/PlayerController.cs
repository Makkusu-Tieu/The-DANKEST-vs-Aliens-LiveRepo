using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verticalInput;
    public float speed;
    private float yRange = 4;

    public GameObject projectilePrefab;

    public GameObject gameOverText;
    public GameObject wallBreachText;
    public GameObject tryAgainButton;

    public GameObject wall;

    //public GameObject spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); 
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y +2);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y -2);
        }
    }

    void LateUpdate()
    {
        if (transform.position.y > yRange)
        {
            transform.position = new Vector2(transform.position.x, yRange);
        }

        if (transform.position.y < -yRange)
        {
            transform.position = new Vector2(transform.position.x, -yRange);
        }
    }

    public void NewGame()
    {
        Time.timeScale = 1;

        GameObject[] allAliens = GameObject.FindGameObjectsWithTag("Alien");
        foreach (GameObject alien in allAliens)
            GameObject.Destroy(alien);

        GameObject[] allProjectiles = GameObject.FindGameObjectsWithTag("Bullet");
        foreach (GameObject bullet in allProjectiles)
            GameObject.Destroy(bullet);

        wall.SetActive(true);
        gameOverText.SetActive(false);
        wallBreachText.SetActive(false);
        tryAgainButton.SetActive(false);

        //SpawnManager.GetComponent < WaveSpawnerScript().waveCount = 1;
    }
}
