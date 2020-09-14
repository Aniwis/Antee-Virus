using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{

    [SerializeField] public static ArrayList Enemies = new ArrayList();


    void Start()
    {

        GameObject singleEnemy = GameObject.Find("Malware_01");
        GameObject temp;
        Vector3 increase = new Vector3(0, 1);
        Vector3 actualPosition = singleEnemy.transform.position;

        for (int i = 0; i < 5; i++)
        {
            temp = Instantiate(singleEnemy, actualPosition, Quaternion.identity);
            actualPosition = temp.transform.position;
            Enemies.Add(temp);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
