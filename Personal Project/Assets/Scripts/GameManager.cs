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

    private const int leftMouseButton = 0;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomEnemy());
        StartCoroutine(SpawnRandomHealth());
    }

    // Update is called once per frame
    void Update()
    {
        SpawnProjectile();
    }

    private float PickASign()
    {
        // this is generating either a 1 or -1 to tell whether enemies spawn on the left or right side of screen
        int sign = Random.Range(0, 2) * 2 - 1;
        return sign;
 
    }

    IEnumerator SpawnRandomHealth()
    {
        while (true)
        {
            SpawnToRandomPosition(healthPrefab);

            yield return new WaitForSeconds(7);
        }
    }

    IEnumerator SpawnRandomEnemy()
    {
        while (true)
        {
            int enemyIndex = Random.Range(0, enemyPrefabs.Count);

            SpawnToRandomPosition(enemyPrefabs[enemyIndex]);

            yield return new WaitForSeconds(1);
        }
    }

    private void SpawnToRandomPosition(GameObject prefab)
    {
        float sign = PickASign();
        float xSide = sign * xStart;

        Vector3 spawnPos = new Vector3(xSide, Random.Range(yRangeBottom, yRangeTop), zPath);

        Transform objectTransform = Instantiate(prefab.transform, spawnPos, prefab.transform.rotation);
        objectTransform.transform.localScale = 
            new Vector3(
                objectTransform.transform.localScale.x, 
                objectTransform.transform.localScale.y, 
                objectTransform.transform.localScale.z * sign
            );
    }

    private void SpawnProjectile()
    {
        if (Input.GetMouseButtonDown(leftMouseButton))
        {
            GameObject bulletPosition = GameObject.Find("BulletPosition");
            Instantiate(projectile, bulletPosition.transform.position, bulletPosition.transform.rotation);
        }
    }
}
