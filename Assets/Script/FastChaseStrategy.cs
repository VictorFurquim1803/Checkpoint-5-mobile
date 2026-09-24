using UnityEngine;

public class FastChaseStrategy : EnemyMovementStrategy
{
    public override Vector3 Move(Transform enemy, Transform player, float speed)
    {
        Vector3 direction = player.position - enemy.position;

        direction.y = 0;

        direction.Normalize();

        Vector3 newPosition = enemy.position + direction * speed * 2f * Time.deltaTime;

        newPosition.y = enemy.position.y;

        return newPosition;
    }
}
