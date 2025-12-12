using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    private bool isDead = false; 
    private Rigidbody2D rb2d;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        // Initialize the rb2d field using GetComponent<Rigidbody2D>()
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0))  // Add your logic here for when the bird is not dead
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, 200));
                anim.SetTrigger ("Flap");
            }
        }
    }

    // Correct Unity collision event method
    void OnCollisionEnter2D ()
    {
        isDead = true;
        anim.SetTrigger ("Die");
        GameControl.instance.BirdDied();
    }
}
