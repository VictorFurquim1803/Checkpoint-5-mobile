using UnityEngine;

public abstract class EnemyMovementStrategy
{
    public abstract Vector3 Move(Transform enemy, Transform player, float speed);
}
