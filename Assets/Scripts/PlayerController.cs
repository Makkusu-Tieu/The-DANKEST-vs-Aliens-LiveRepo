using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verticalInput;
    public float speed;
    private float yRange = 4;

    public GameObject projectilePrefab;

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

        if (transform.position.y > yRange)
        {
            transform.position = new Vector2(transform.position.x, yRange);
        }

        if (transform.position.y < -yRange)
        {
            transform.position = new Vector2(transform.position.x, -yRange);
        }

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * verticalInput * Time.deltaTime * speed);
    }
}
