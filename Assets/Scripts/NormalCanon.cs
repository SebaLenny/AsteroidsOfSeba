using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalCanon : MonoBehaviour , IShootable
{
    private InputController inputController;
    [SerializeField]
    private float shootingPeriod = 1f;
    private float lastShoot;
    [SerializeField]
    private GameObject bullet;

    private void Awake()
    {
        inputController = transform.parent.GetComponent<InputController>();
        inputController.OnFire += Shoot;
        lastShoot = Time.time;
    }

    public void Shoot()
    {
        if (lastShoot + shootingPeriod < Time.time)
        {
            PerformShoot();
            lastShoot = Time.time;
        }
    }

    private void PerformShoot()
    {
        GameObject dummyBullet = Instantiate(bullet, transform.position, transform.rotation, null);
    }

}
