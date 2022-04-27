using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /* This script will contain the following functionalities:
     * Spawning enemies (coroutine)
     * Game over 
     * UI stuff
     * 
     * Reference Prototypes 4 and 5
     */

    public TextMeshProUGUI titleText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public Button restartButton;
    public Button startButton;

    private AudioSource managerAudio;
    public AudioClip shootSound;
    public AudioClip gameOverAudio;

    public List<GameObject> enemyPrefabs;
    public GameObject healthPrefab;
    public GameObject projectile;
    public ParticleSystem cannonParticle;

    private float xStart = 11;
    private float yRangeTop = 5;
    private float yRangeBottom = 1;
    private float zPath = 5;
    private int score;
    private int gameTimer;
    public bool isGameActive;

    private const int leftMouseButton = 0;
    public int beginningTime;


    // Start is called before the first frame update
    void Start()
    {
        managerAudio = GetComponent<AudioSource>();

        scoreText.text = " ";
        timerText.text = " ";
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
        while (isGameActive)
        {
            SpawnToRandomPosition(healthPrefab);

            yield return new WaitForSeconds(10);
        }
    }

    IEnumerator SpawnRandomEnemy()
    {
        while (isGameActive)
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
        if (Input.GetMouseButtonDown(leftMouseButton) && isGameActive)
        {
            GameObject bulletPosition = GameObject.Find("BulletPosition");
            Instantiate(projectile, bulletPosition.transform.position, bulletPosition.transform.rotation);

            cannonParticle.Play();

            managerAudio.PlayOneShot(shootSound, 1.0f);

        }
    }

    IEnumerator StartTimer(int timerTotal)
    {
        gameTimer = timerTotal;

        while (isGameActive)
        {
            PrintTimer();

            yield return new WaitForSeconds(1);
            gameTimer -= 1;

            if(gameTimer == 0)
            {
                GameOver();
            }
        }
    }

    public void AddToTimer(int timeToAdd)
    {
        gameTimer += timeToAdd;
        PrintTimer();
    }

    private void PrintTimer()
    {
        timerText.text = "Timer: " + gameTimer;
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame()
    {
        isGameActive = true;
        score = 0;
        UpdateScore(score);

        StartCoroutine(SpawnRandomEnemy());
        StartCoroutine(SpawnRandomHealth());

        StartCoroutine(StartTimer(beginningTime));

        titleText.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);

    }

}
