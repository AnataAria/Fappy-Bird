using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D bird_RB;
    private BoxCollider2D bird_BC;
    [SerializeField] int force = 10;
    // Start is called before the first frame update
    void Start()
    {
        bird_BC= GetComponent<BoxCollider2D>();
        bird_RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        BirdMovement();
    }

    void BirdMovement()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            bird_RB.velocity = Vector2.up* force;
        }
    }
}
