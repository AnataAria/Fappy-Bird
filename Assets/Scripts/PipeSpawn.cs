using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    [SerializeField] GameObject pipes;
    [SerializeField] float spawnRate = 1;
    private float timeDelay = 0;
    private float hight = 3;
    void Update()
    {
        checkSpawn();
    }

    void checkSpawn()
    {
        if (timeDelay < spawnRate) {
            timeDelay += Time.deltaTime;
        }
        else
        {
            spawn();
            timeDelay= 0;
        }
    }

    void spawn()
    {
        float lowPoint = transform.position.x - hight;
        float highPoint = transform.position.y + hight;
        Instantiate(pipes, new Vector3(transform.position.x,Random.Range(lowPoint,highPoint),0), transform.rotation);
    }
}
