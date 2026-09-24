using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 1;

    private EnemyMovementStrategy strategy;
    private Transform player;

    public EnemySpawner spawner;

    public void Initialize(EnemyMovementStrategy newStrategy, Transform target)
    {
        strategy = newStrategy;
        player = target;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        if (strategy != null && player != null)
        {
            transform.position = strategy.Move(transform, player, 2f);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            if (spawner != null)
            {
                spawner.EnemyDied();
            }

            Destroy(gameObject);
        }
    }
}
