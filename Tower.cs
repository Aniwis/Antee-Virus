using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject torre;
    private void OnMouseDown()
    {
        GameObject temp;
        Vector3 posicion = this.transform.position;
        temp = Instantiate(torre);
        temp.transform.position = posicion;
        Destroy(this.gameObject);
        
    }
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    } */
}
