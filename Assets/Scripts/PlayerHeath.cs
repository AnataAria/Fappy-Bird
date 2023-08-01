using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeath : MonoBehaviour
{
    // Start is called before the first frame update
    private int health = 5;
    void Start()
    {
        ResetHealth();
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            PlayerDeath.Instance.Death();
        }
    }

    public void AddHealth() {
        this.health++;
    }
    public void ResetHealth()
    {
        this.health = 5;
    }
    public void MinusHealth()
    {
        this.health--;
    }
}
