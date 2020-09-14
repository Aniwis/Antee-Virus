using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour
{

    public GameObject enemy;
    [SerializeField] GameObject bullet;
    [SerializeField] float Distance = 1.5f;
    [SerializeField] float TimeBtwShoots = 0f;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        TimeBtwShoots += Time.deltaTime;
        enemy = SearchNearestEnemy();
        if (enemy != null)
        {
            Debug.DrawLine(this.transform.position, enemy.transform.position, Color.red);
        }
        if (enemy != null && TimeBtwShoots >= 1.2f)
        {
            Shoot();
        }

    }

    void Shoot()
    {
        GameObject obj = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);
        Projectile Bullett = obj.GetComponent<Projectile>();
        Bullett.ActivateBullet(this);
        TimeBtwShoots = 0f;
    }

    GameObject SearchNearestEnemy()
    {

        ArrayList EnemiesTower = EnemyPool.Enemies;
        GameObject temp;
        foreach (object item in EnemiesTower)
        {
            temp = (GameObject)item;

            if (Vector3.Distance(temp.transform.position, this.transform.position) < Distance)
            {
                return temp;
            }
        }
        return null;

    }

}
