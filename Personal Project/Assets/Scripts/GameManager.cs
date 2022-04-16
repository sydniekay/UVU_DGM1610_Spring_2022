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

    public List<GameObject> enemyPrefabs;
    public GameObject healthPrefab;
    public GameObject projectile;

    private float xStart = 11;
    private float yRangeTop = 5;
    private float yRangeBottom = 1;
    private float zPath = 5;

    private float lastSpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomEnemy());
        StartCoroutine(SpawnRandomHealth());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private float PickASign()
    {
        // this is generating either a 1 or -1 to tell whether enemies spawn on the left or right side of screen
        int sign = Random.Range(0, 2) * 2 - 1;
        return sign;
 
    }
    IEnumerator SpawnRandomEnemy()
    {
        while (true)
        {
            float sign = PickASign();
            float xSide = sign * xStart;

            int enemyIndex = Random.Range(0, enemyPrefabs.Count);
            Vector3 spawnPos = new Vector3(xSide, Random.Range(yRangeBottom, yRangeTop), zPath);

            Instantiate(enemyPrefabs[enemyIndex].transform, spawnPos, enemyPrefabs[enemyIndex].transform.rotation);

            yield return new WaitForSeconds(1);

        }
    }

    IEnumerator SpawnRandomHealth()
    {
        while (true)
        {
            float sign = PickASign();
            float xSide = sign * xStart;

            Vector3 spawnPos = new Vector3(xSide, Random.Range(yRangeBottom, yRangeTop), zPath);

            Instantiate(healthPrefab.transform, spawnPos, healthPrefab.transform.rotation);



            yield return new WaitForSeconds(3);
        }
    }
}
