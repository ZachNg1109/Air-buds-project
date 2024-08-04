using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    public GameObject building1;
    public GameObject building2;
    public GameObject building3;
    public GameObject building4;
    public GameObject building5;
    public GameObject building6;
    public GameObject building7;
    public GameObject KLTower;
    public GameObject petronasTower;
    public GameObject TMTower;

    private GameObject spawnedBuilding;
    private GameObject spawnedBuilding2;

    private GameObject newBuilding;
    private GameObject newBuilding2;

    private bool canBuild = true;
    private float buildCD;

    private void Update()
    {
        if (canBuild == false)
        {
            buildCD += Time.deltaTime;


            if (buildCD > 0.7f)
            {
                buildCD = 0;
                canBuild = true;
            }
        }
        if(canBuild == true)
            StartCoroutine(BuildingFrequency());
    }

    private void SpawnBuildings()
    {
       
        newBuilding = Instantiate(spawnedBuilding, new Vector3(73.22f, -0.31f, 92.03f), Quaternion.Euler(8.157f, 20.737f, -27.122f));
        newBuilding.transform.SetParent(gameObject.transform, true);


        if (this.transform.localRotation.x > 160)
        {
            Destroy(newBuilding);
        }
    }


    private void SpawnBuildingsOpposite()
    {

        newBuilding2 = Instantiate(spawnedBuilding2, new Vector3(62.83f, -2.36f, 98.87f), Quaternion.Euler(-19.873f, 64.948f, 46.673f));
        newBuilding2.transform.SetParent(gameObject.transform, true);


        if (this.transform.localRotation.x > 160)
        {
            Destroy(newBuilding2);
        }
    }

    private IEnumerator BuildingFrequency()
    {
        canBuild = false;
        int randomObs = Random.Range(1, 7);
        float rand = Random.Range(0f, 2.3f);
        yield return new WaitForSeconds(rand);
        switch (randomObs)
        {
            case 1:
                spawnedBuilding = building1;
                spawnedBuilding2 = building5;

                SpawnBuildings();
                SpawnBuildingsOpposite();

                break;

            case 2:
                spawnedBuilding = building2;
                spawnedBuilding2 = building6;

                SpawnBuildings();
                SpawnBuildingsOpposite();

                break;
            case 3:
                spawnedBuilding = building3;
                spawnedBuilding2 = building7;

                SpawnBuildings();
                SpawnBuildingsOpposite();


                break;
            case 4:
                spawnedBuilding = building4;
                spawnedBuilding2 = building1;

                SpawnBuildings();
                SpawnBuildingsOpposite();


                break;
            case 5:
                spawnedBuilding = building5;
                spawnedBuilding2 = building2;

                SpawnBuildings();
                SpawnBuildingsOpposite();


                break;
            case 6:
                spawnedBuilding = building6;
                spawnedBuilding2 = building3;

                SpawnBuildings();
                SpawnBuildingsOpposite();


                break;
            case 7:
                spawnedBuilding = building7;
                spawnedBuilding2 = building4;

                SpawnBuildings();
                SpawnBuildingsOpposite();


                break;

        }



    }
}
