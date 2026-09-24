using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyFactory factory;
    public Transform player;

    public float spawnTime = 2f;

    public int maxEnemies = 10;

    private int currentEnemies = 0;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnTime);
    }

    
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        if (currentEnemies >= maxEnemies)
        {
            return;
        }

        Vector3 position = new Vector3(Random.Range(-8f, 8f), 1f, Random.Range(5f, 10f));

        factory.CreateEnemy(position, player, this);

        currentEnemies++;
    }

    public void EnemyDied()
    {
        currentEnemies--;
    }
}
