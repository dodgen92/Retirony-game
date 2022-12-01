using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject objectToSpawn;



    public float timeToSpawn;
    private float currentTimeToSpawn;


    void Start()
    {
        currentTimeToSpawn = timeToSpawn;
    }

     void Update()
    {
        if(currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }
    }




    public void SpawnObject()
    {
        Instantiate(objectToSpawn,transform.position, transform.rotation);
    }

}
