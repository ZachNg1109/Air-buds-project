using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject bomb;
    public GameObject cloud;
    public GameObject bird;
    public GameObject star;

    [SerializeField] private float obstacleTimer = 3.5f;

    private GameObject spawnedBomb;
    private GameObject spawnedBird;
    private GameObject spawnedStar;
    private GameObject spawnedCloud;

    private int powerNegativeValueHolder;
    private bool canObst = true;
    private float obstCD;

    private void FixedUpdate()
    {
        if (canObst == false)
        {
            obstCD += Time.deltaTime;


            if (obstCD > 2.5f)
            {
                obstCD = 0;
                canObst = true;
            }
        }

        if(canObst == true)
        {
            StartCoroutine(ObstacleFrequency());

        }
        powerNegativeValueHolder = Random.Range(0, 3);
    }

    private void SpawnBomb()
    {
        int rand = Random.Range(0, 3);
        int n = 0;
        while(n<rand)
        {
            int rand2 = Random.Range(0, 3);
            spawnedBomb = Instantiate(bomb, new Vector3(68.1699982f+((-rand2)^powerNegativeValueHolder), 1.98000002f, 90.6200027f), Quaternion.Euler(-15f, 0, 0));
            spawnedBomb.transform.SetParent(gameObject.transform, true);

            n++;
        }


        if (this.transform.localRotation.x > 160)
        {
            Destroy(spawnedBomb);
        }
    }

    private IEnumerator ObstacleFrequency()
    {
        canObst = false;
        int randomObs = Random.Range(1, 4);
        float rand = Random.Range(0f, obstacleTimer);
        yield return new WaitForSeconds(rand);
        switch (randomObs)
        {
            case 1:
                SpawnBomb();
                
                break;

            case 2:
                SpawnClouds();
                break;
            case 3:
                SpawnBirds(); 
                break;
               
        }


        

    }

    private void SpawnClouds()
    {
        int negativeValuer = Random.Range(-1, 1);
        if(negativeValuer == 0)
        {
            negativeValuer = 1;
        }
        float rand = Random.Range(0f, 4f);
        int n = 0;
        while (n < rand)
        {
            int rand2 = Random.Range(0, 3);

            spawnedCloud = Instantiate(cloud, new Vector3(68f+((-rand2) * negativeValuer), 1.98000002f, 96.7200027f), Quaternion.Euler(-90f, 0, -90));
            spawnedCloud.transform.SetParent(gameObject.transform, true);

            n++;
        }


        if (this.transform.localRotation.x > 160)
        {
            Destroy(spawnedCloud);
        }
    }

    private void SpawnBirds()
    {
        int rand = Random.Range(0, 1);
        int n = 0;
        while (n < rand)
        {
            spawnedBird = Instantiate(bird, new Vector3(68.1699982f+((-rand) ^ powerNegativeValueHolder), 1.98000002f, 90.6200027f), Quaternion.Euler(-15f, 0, 0));
            spawnedBird.transform.SetParent(gameObject.transform, true);

            n++;
        }


        if (this.transform.localRotation.x > 160)
        {
            Destroy(spawnedBird);
        }
    }

}
