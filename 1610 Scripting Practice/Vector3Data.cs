using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


// Taking notes on scriptable objects based on Anthony's provided practice code

[CreateAssetMenu]

// We need to replace MonoBehavior with ScriptableObject in order for this to work
public class Vector3Data : ScriptableObject
{
    public Vector3[] spawnPoint;

    private void Start()
    {
        SpawnEntities();
    }

    private void SpawnEntities()
    {
        if (spawnPoints.transform.position.z = 0)
        {
            spawnPoint = new Vector3(0, 0, 6);
        }
    }

    // Again, I'm doing this on my own in my IDE outside of Unity, so some of this is pseudo code...
}