using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DetectCollisions : MonoBehaviour
{
    public ParticleSystem explosionParticle;
    private GameManager gameManager;

    public AudioClip destroySound;

    [SerializeField] int pointValue;
    [SerializeField] int timeValue;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameManager.isGameActive)
        {
            Destroy(gameObject);

            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);

            AudioSource.PlayClipAtPoint(destroySound, new Vector3(0f, 2.3f, -10f));

            gameManager.UpdateScore(pointValue);
            gameManager.AddToTimer(timeValue);
        }
    }
}
