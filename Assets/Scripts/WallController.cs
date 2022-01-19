using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public HealthBar healthBar;
    public GameObject gameOverText;
    public GameObject wallBreachText;
    public GameObject tryAgainButton;
    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth < 1)
        {
            currentHealth = maxHealth;
        }

        if (currentHealth > 4)
        {
            healthBar.SetMaxHealth(maxHealth);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Alien"))
        {
            TakeDamage(1);
            Destroy(other.gameObject);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        if (currentHealth < 1)
        {
            //Destroy(gameObject);
            wall.SetActive(false);
            Time.timeScale = 0;
            gameOverText.SetActive(true);
            wallBreachText.SetActive(true);
            tryAgainButton.SetActive(true);
        }
    }
}
