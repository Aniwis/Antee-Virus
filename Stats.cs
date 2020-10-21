using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{

    public float initialLife = 20f;

    public Text lifeText;

    public Text gameOver;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        lifeText.text = Mathf.Floor(initialLife).ToString();

        if (initialLife<=0f)
        {
            gameOver.gameObject.SetActive(true);
            initialLife = 0f;
        }

    }
}
