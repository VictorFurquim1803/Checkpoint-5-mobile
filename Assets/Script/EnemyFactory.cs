using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public GameObject enemyPrefab;

    public Enemy CreateEnemy(Vector3 position, Transform player, EnemySpawner spawner)
    {
        GameObject enemyObject = Instantiate(enemyPrefab, position, Quaternion.identity);

        Enemy enemy = enemyObject.GetComponent<Enemy>();

        enemy.spawner = spawner;

        int type = Random.Range(0, 3);

        if (type == 0)
        {
            enemy.health = 1;
            enemy.Initialize(new ChaseStrategy(), player);
        }
        else if (type == 1)
        {
            enemy.health = 1;
            enemy.Initialize(new FastChaseStrategy(), player);
        }
        else
        {
            enemy.health = 2;
            enemy.Initialize(new FleeStrategy(), player);
        }

        return enemy;
    }
}
