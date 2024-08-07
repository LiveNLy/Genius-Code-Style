using System.Collections;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private float _shootingDelay;
    [SerializeField] private Transform _objectToShoot;
    [SerializeField] private Transform _bulletPointOfDeparture;

    private void Start()
    {
        StartCoroutine(Shoot());
    }

    private IEnumerator Shoot()
    {
        var time = new WaitForSeconds(_shootingDelay);
        bool isWork = enabled;

        while (isWork)
        {
            Vector3 targetDirection = (_objectToShoot.position - transform.position).normalized;
            Bullet newBullet = Instantiate(_bulletPrefab, _bulletPointOfDeparture.position, Quaternion.identity);

            newBullet.BulletShot(targetDirection * _bulletSpeed);

            yield return time;
        }
    }
}
