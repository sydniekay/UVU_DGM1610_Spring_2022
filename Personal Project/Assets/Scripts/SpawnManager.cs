using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject butterflyPrefab;
    public GameObject beePrefab;
    public GameObject ladybugPrefab;
    public GameObject beetlePrefab;
    public GameObject healthPrefab;

    private float spawnRangeX = 6.5f;
    private float spawnRangeY = 9;

    public int waveNumber = 1;
    public int insectCount;

    // Start is called before the first frame update
    void Start()
    {
        SpawnInsectWave(waveNumber);
        SpawnHealth();
    }

    // Update is called once per frame
    void Update()
    {
        // Increases the number of insects and powerups per wave
        insectCount = FindObjectsOfType<Insects>().Length;
        
        if (insectCount == 0)
        {
            waveNumber++;
            SpawnInsectWave(waveNumber);

            SpawnHealth();
        }



    }

    // Random position within the range of the screen (going from bottom to top)
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPositionX = Random.Range(-spawnRangeX, spawnRangeX);
        float spawnPositionY = Random.Range(- spawnRangeY, spawnRangeY);

        Vector3 randomPosition = new Vector3(spawnPositionX, spawnPositionY, 0);

        return randomPosition;
    }

    // Spawn insects in a wave
    void SpawnInsectWave(int insectsToSpawn)
    {
        for (int i = 0; i < insectsToSpawn; i++)
        {
            Instantiate(beetlePrefab, GenerateSpawnPosition(), beetlePrefab.transform.rotation);
        }
    }

    // Spawn health powerup
    void SpawnHealth()
    {
        if (insectCount == 0)
        {
            Instantiate(healthPrefab, GenerateSpawnPosition(), healthPrefab.transform.rotation);
        }
    }
}
