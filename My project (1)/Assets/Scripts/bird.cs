using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    private bool isDead = false; 
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the rb2d field using GetComponent<Rigidbody2D>()
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0))  // Add your logic here for when the bird is not dead
            {
                // Your logic here
            }
        }
    }
}
