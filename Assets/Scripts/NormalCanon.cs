using UnityEngine;

public class NormalCanon : MonoBehaviour, IShootable
{
    private InputController inputController;

    [SerializeField]
    private float shootingPeriod = 1f;

    private float lastShoot;

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private Transform spawnPoint;

    private Transform _spawnPoint;

    private void Awake()
    {
        inputController = transform.parent.GetComponent<InputController>();
        inputController.OnFire += Shoot;
        lastShoot = Time.time;
    }

    public void Shoot()
    {
        _spawnPoint = spawnPoint == null ? transform : spawnPoint;
        if (lastShoot + shootingPeriod < Time.time)
        {
            PerformShoot();
            lastShoot = Time.time;
        }
    }

    private void PerformShoot()
    {
        GameObject dummyBullet = Instantiate(bullet, _spawnPoint.position, _spawnPoint.rotation, null);
    }
}