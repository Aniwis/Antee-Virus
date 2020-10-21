using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{

    public int state = 0;

    public float money = 30f;

    public Text moneyText;

    public void BuyTorret()
    {
        state = 1;
    }

    private void Update()
    {

        money += Time.deltaTime / 3;

        moneyText.text = Mathf.Floor(money).ToString();
    }

}
