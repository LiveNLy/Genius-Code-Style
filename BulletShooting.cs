using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletShooting : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
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
        bool isWork = enabled;

        while (isWork)
        {
            var TargetDirection = (_objectToShoot.position - transform.position).normalized;
            var NewBullet = Instantiate(_bulletPrefab, _bulletPointOfDeparture.position, Quaternion.identity);

            NewBullet.GetComponent<Rigidbody>().velocity = TargetDirection * _bulletSpeed;

            yield return new WaitForSeconds(_shootingDelay);
        }
    }
}
