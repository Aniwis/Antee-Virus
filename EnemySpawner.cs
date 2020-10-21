using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{

    public Transform enemyPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    private int wavenumber = 0;

    public Text WaveCountDownText;



    private void Update()
    {

        if (countdown <= 0f)
        {

            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;

        }

        countdown -= Time.deltaTime;

        WaveCountDownText.text = Mathf.Floor(countdown).ToString();

    }

    IEnumerator SpawnWave()
    {

        wavenumber++;

        for (int i = 0; i < wavenumber; i++)
        {

            SpawnEnemy();
            yield return new WaitForSeconds(0.2f);

        }
        
    }

    void SpawnEnemy()
    {

        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

    }

}
