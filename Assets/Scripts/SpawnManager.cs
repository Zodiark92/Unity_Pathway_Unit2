using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField]
    private GameObject[] animals;

    private float rangeSpawnX = 12f;
    private float spawnPosZ = 30f;

    private float startDelay = 2f;
    private float timeInterval = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnAnimal", startDelay, timeInterval);
    }

  private void spawnAnimal()
    {
        int index = Random.Range(0,animals.Length);
        GameObject animal = animals[index];
        Vector3 spawnPos = new Vector3(Random.Range(-rangeSpawnX, rangeSpawnX), animal.transform.position.y, spawnPosZ);

        Instantiate(animal, spawnPos, animal.transform.rotation);
    }
}
