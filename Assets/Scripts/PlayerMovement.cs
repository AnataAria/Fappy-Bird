using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D bird_RB;
    [SerializeField] float force = 100;
    private PlayerHeath playerHealth; 
    // Start is called before the first frame update


    void Start()
    {
        bird_RB = GetComponent<Rigidbody2D>();
        playerHealth = GetComponent<PlayerHeath>();
    }

    // Update is called once per frame
    void Update()
    {
        BirdMovement();
    }

    void BirdMovement()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            bird_RB.AddForce(new Vector2(0,50 * force));
            Debug.Log("Space");
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.tag.Equals("Enemy"))
        {
            playerHealth.MinusHealth();
        }
        if (collision.gameObject.transform.tag.Equals("ScreemLimit")) { 
            if(!collision.gameObject.name.Equals("Limit Top")){
                PlayerDeath.Instance.Death();
            }

        }
    }
}
