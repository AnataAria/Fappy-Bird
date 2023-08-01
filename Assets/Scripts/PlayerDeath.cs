using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : Singleton<PlayerDeath>
{
    private GameObject player;
    private GameObject scoreUI;
    private GameObject GO;

    private bool isAlive = false;
    // Start is called before the first frame update
    void Start()
    {
        ResetLive();
        this.player = GameObject.FindGameObjectWithTag("Player");
        GO = GameObject.FindGameObjectWithTag("Finish");
        scoreUI = GameObject.FindGameObjectWithTag("ScoreUI");
    }

    // Update is called once per frame
    void Update()
    {
        if (!isAlive)
        {
            Death();
        }
    }

    public void Death()
    {
        this.player.SetActive(false);
        this.scoreUI.SetActive(false);
        this.GO.SetActive(true);
    }

    public void ResetLive()
    {
        this.isAlive = true;
    }
}
