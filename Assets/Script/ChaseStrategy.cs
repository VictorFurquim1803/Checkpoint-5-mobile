using UnityEngine;

public class ChaseStrategy : EnemyMovementStrategy
{
    public override Vector3 Move(Transform enemy, Transform player, float speed)
    {
        Vector3 direction = (player.position - enemy.position).normalized;

        return enemy.position + direction * speed * Time.deltaTime;
    }
}
