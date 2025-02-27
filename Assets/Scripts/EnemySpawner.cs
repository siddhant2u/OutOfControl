﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform spawnpoint1;
    public Transform spawnpoint2;
    public Transform spawnpoint3;
    public Transform spawnpoint4;

    public GameObject enemyPrefab;

    int counter = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Enemy").Length == 0 && counter <= 20){
            StartCoroutine(spawner());
        }else{
            StopCoroutine(spawner());
        }
    }
    IEnumerator spawner(){
        Instantiate(enemyPrefab,spawnpoint1.position,Quaternion.identity);
        Instantiate(enemyPrefab,spawnpoint2.position,Quaternion.identity);
        Instantiate(enemyPrefab,spawnpoint3.position,Quaternion.identity);
        Instantiate(enemyPrefab,spawnpoint4.position,Quaternion.identity);
        yield return new WaitForSeconds(15f);
        counter++;
    }

}
