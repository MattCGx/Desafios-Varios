using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    [SerializeField] float fireRate = 10f;
    [SerializeField] float loadTime = 0f;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject shootPoint1;

    // Start is called before the first frame update
    void Start()
    {
      InvokeRepeating("BulletSpawn", loadTime, 1 / fireRate);  
    }

    // Update is called once per frame
    void Update()
    {

    }

private void BulletSpawn()
{
    Instantiate(bulletPrefab, shootPoint1.transform.position, shootPoint1.transform.rotation);
}
}
