using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject torre;

    public GameObject shop;

    public Shop _shop;

    public void Start()
    {
        shop = GameObject.FindGameObjectWithTag("shop");
        _shop = shop.GetComponent<Shop>();
    }

    private void OnMouseDown()
    {
        if (_shop.state == 1 && _shop.money >= 10f)
        {
            
            GameObject temp;
            Vector3 posicion = this.transform.position;
            temp = Instantiate(torre);
            temp.transform.position = posicion;
            Destroy(this.gameObject);
            _shop.state = 0;
            _shop.money -= 10f;

        }
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
