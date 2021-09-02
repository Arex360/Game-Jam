using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] Transform tip;
    [SerializeField] GameObject bullet;
    public void Shoot()
    {
        GameObject newBullet = (GameObject)Instantiate(bullet, tip.transform.position, tip.transform.rotation);
        Destroy(newBullet, 5f);
    }
}
