using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs; // array to store balloon game object
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;
    public float xRange = 10.0f;
    public float yRange = 10.0f;
    public float zRange = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval); //constantly spawns balloons with a start delay
    }

    // Update is called once per frame
    void SpawnRandomBalloon()
    {
        //Get a random position on the x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-xRange,xRange),Random.Range(-yRange,yRange),Random.Range(0,zRange));

        //pick a random Balloon from the balloon array
        int balloonIndex = Random.Range(0,balloonPrefabs.Length);
        
        //Spawn random balloon at spawn position
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation);
    }
}
