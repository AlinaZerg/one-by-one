﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeriodicEnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyToSpawn = null;
    [SerializeField]
    private Vector2 timeToEachEnemyFromTo = new Vector2(5f, 15f);

    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nextEnemyTL = GenerateRandomTime();
    }

    private void Update()
    {
        nextEnemyTL = Mathf.Max(0, nextEnemyTL - Time.deltaTime);
        if (nextEnemyTL <= 0 && spawnedEnemy == null)
        {
            spawnedEnemy = Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
            nextEnemyTL = GenerateRandomTime();
        }
    }

    private float GenerateRandomTime()
    {
        return Random.Range(timeToEachEnemyFromTo.x, timeToEachEnemyFromTo.y);
    }
 
    private float nextEnemyTL = 100f;
    private Transform player;
    private GameObject spawnedEnemy = null;
}
