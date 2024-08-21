using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Script : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnerDelay;
    public float positionMedium;
    public float spawnerSize;
    float positionInitial;
    float positionFinal;

    float spawnArea;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3f, spawnerDelay);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnerArea()
    {
        positionInitial = positionMedium - (spawnerSize / 2);
        positionFinal = positionMedium + (spawnerSize / 2);
        spawnArea = Random.Range(positionInitial, positionFinal);
    }

    void Spawn()
    {
        SpawnerArea();
        Instantiate(enemyPrefab, new Vector3(spawnArea, 12, 0), Quaternion.identity);
    }
}