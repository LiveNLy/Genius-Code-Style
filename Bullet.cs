using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public void BulletShot(Vector3 direction)
    {
        if (TryGetComponent<Rigidbody>(out _rigidbody))
            _rigidbody.velocity = direction;
    }
}
