using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float speed = 10f;

    private Transform target;
    private int waypointIndex = 0;

    public Stats Core;
    

    private void Start()
    {

        target = Waypoints.points[0];
        Core = GameObject.FindGameObjectWithTag("life").GetComponent<Stats>();

    }

    private void Update()
    {

        Vector2 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector2.Distance(target.position, transform.position) <= 0.2f)
        {
            GetNextWaypoint();
        }

    }

    void GetNextWaypoint()
    {

        if (waypointIndex >= Waypoints.points.Length - 1)
        {

            Core.initialLife--;
            Destroy(gameObject);
            return;

        }

        waypointIndex++;
        target = Waypoints.points[waypointIndex];
    }

}
