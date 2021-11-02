using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject[] ObstaclePrefab;
    public float spawnTime = 1;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        if (timer > spawnTime)
        {
            int rand = Random.Range(0, ObstaclePrefab.Length);
            GameObject obs = Instantiate(ObstaclePrefab[rand]);
            Destroy(obs, 30);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
