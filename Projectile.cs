using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    GameObject Objective;
    [SerializeField] float velocity = 5f;
    float timeLimit = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timeLimit += Time.deltaTime;

        if (Objective != null)
        {
            Vector3 direction = Objective.transform.position - this.transform.position;
            this.transform.position += velocity * direction * Time.deltaTime;
        }

        if (timeLimit >= 5f)
        {
            Destroy(gameObject);
        }

    }


    public void ActivateBullet(DetectEnemy tower)
    {
        Objective = tower.enemy;
    }

}
