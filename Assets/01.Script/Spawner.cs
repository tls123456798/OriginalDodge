using UnityEngine;

public class Spawner : MonoBehaviour 
{
    public GameObject bulletspawnerPrefab;
    public Transform[] spawnPoints;
    public int spawnInterval = 1;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1.0f, spawnInterval);
    }

    
    void SpawnEnemy()
    {
        if (bulletspawnerPrefab != null && spawnPoints.Length > 0)
        {
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];

            Instantiate(bulletspawnerPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
