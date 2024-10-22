using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float yPosition = 4f;
    public float xPositionFrom = -8f;
    public float xPositionTo = 8f;
    public float spawnInterval = 1f;
    float timeSinceLastSpawn = 0f;

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        {
            float randomXPosition = Random.Range(xPositionFrom, xPositionTo);
            Vector3 randomPosition = new Vector3(randomXPosition, yPosition, 0);
            Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
            timeSinceLastSpawn = 0f;
        }
    }
}
