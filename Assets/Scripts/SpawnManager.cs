using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objectPrefabs;

    private float spawnLimitXLeft = -15.5f;
    private float spawnLimitXRight = 15.5f;
    private float spawnPosY = 22;

    private float startDelay = 5.5f;
    private float spawnInterval = 5.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObject", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void SpawnRandomObject()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int objectIndex = Random.Range(0, objectPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(objectPrefabs[objectIndex], spawnPos, objectPrefabs[objectIndex].transform.rotation);
    }
}
