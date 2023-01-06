using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderShooter : MonoBehaviour
{

    [SerializeField]
    private GameObject bullet;

    private Transform bulletSpawnPoint;

    [SerializeField]
    private float minShootTime = 2f, maxShootTime = 5f;

    private float shootTimer;

    private void Awake()
    {
        bulletSpawnPoint = transform.GetChild(0).transform;
    }

    private void Start()
    {
        //Invoke("ShootBullet", Random.Range(minShootTime, maxShootTime));
        //shootTimer = Time.time + Random.Range(minShootTime, maxShootTime);
        StartCoroutine(StartShoting());
    }

    private void Update()
    {
        //if (Time.time > shootTimer)
        //{
            //ShootBullet();
            //shootTimer = Time.time + Random.Range(minShootTime, maxShootTime);
        //}
    }

    void ShootBullet()
    {
        Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
        //Invoke("ShootBullet", Random.Range(minShootTime, maxShootTime));
    }

    IEnumerator StartShoting()
    {
        yield return new WaitForSeconds(Random.Range(minShootTime, maxShootTime));
        ShootBullet();

        StartCoroutine(StartShoting());

    }

} // class





































