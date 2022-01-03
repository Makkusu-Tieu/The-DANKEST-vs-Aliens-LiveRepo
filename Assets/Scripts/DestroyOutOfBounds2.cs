using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds2 : MonoBehaviour
{
    private float leftbound = -10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftbound)
        {
            Destroy(gameObject);
        }
    }
}