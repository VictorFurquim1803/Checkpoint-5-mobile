using UnityEngine;

public class FleeStrategy : EnemyMovementStrategy
{
    public override Vector3 Move(Transform enemy, Transform player, float speed)
    {
        Vector3 direction = enemy.position - player.position;

        direction.y = 0;

        direction.Normalize();

        Vector3 newPosition = enemy.position + direction * speed * Time.deltaTime;

        float minX = -23f;
        float maxX = 23f;

        float minZ = -23f;
        float maxZ = 23f;

        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.z = Mathf.Clamp(newPosition.z, minZ, maxZ);

        newPosition.y = enemy.position.y;

        return newPosition;
    }
}
