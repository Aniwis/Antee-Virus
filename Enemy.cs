using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject Route;
    int index = 0;
    Vector3 startPosition;
    Vector3 nextPosition;
    [SerializeField] float Velocity = 1f;
    float distanceBetween = 0.5f;
    [SerializeField]public int State = 1;

    void Start()
    {
        startPosition = this.transform.position;
        nextPosition = Route.transform.GetChild(0).position;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = nextPosition - this.transform.position;
        this.transform.position += direction * Velocity * Time.deltaTime;

        if (State == 1)
        {
            if (direction.magnitude <= distanceBetween)
            {

                if (index + 1 < Route.transform.childCount)
                {

                    index++;
                    nextPosition = Route.transform.GetChild(index).position;

                }

                else
                {

                    index = 0;
                    this.transform.position = startPosition;
                    nextPosition = Route.transform.GetChild(0).position;

                }

            }

        }
        else if (State == 0)
        {
            Destroy(gameObject);
        }
    }
}
