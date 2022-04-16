using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /* This script will contain the following functionalities:
     * Spawning enemies (coroutine)
     * Game over 
     * UI stuff
     * 
     * Reference Prototypes 4 and 5
     */

    public List<GameObject> targets;

    private float xRange = 5;
    private float yRangeTop = 6;
    private float yRangeBottom = 1;



    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomEnemy();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomEnemy()
    {
        int enemyIndex = Random.Range(0, targets.Count);
        Vector3 spawnPos = new Vector3(-xRange, Random.Range(yRangeBottom, yRangeTop), 0);

        Instantiate(targets[enemyIndex].transform, spawnPos, targets[enemyIndex].transform.rotation);

    }
}
