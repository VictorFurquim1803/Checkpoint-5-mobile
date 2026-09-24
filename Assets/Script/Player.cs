using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    public GameObject bulletPrefab;
    public Transform firePoint;

    public Transform cameraTransform;

    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
        Shoot();
        RotatePlayer();
    }

    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        Vector3 movement = forward * vertical + right * horizontal;

        if (movement.magnitude > 1)
        {
            movement.Normalize();
        }

        transform.position += movement * speed * Time.deltaTime;
    }

    void RotatePlayer()
    {
        Vector3 direction = cameraTransform.forward;

        direction.y = 0;

        if (direction.magnitude > 0.1f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10f * Time.deltaTime);
        }
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
