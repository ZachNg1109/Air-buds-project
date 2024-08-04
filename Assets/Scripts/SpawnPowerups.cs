using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnPowerups : MonoBehaviour
{
    public GameObject tappy1;
    public GameObject tappy2;

    public GameObject bam1;
    public GameObject bam2;

    public GameObject biggie1;
    public GameObject biggie2;

    public GameObject ogu1;
    public GameObject ogu2;
    public GameObject starPrefab;

    public CharactersObjects charList;

    private GameObject spawnedSkill;
    private int rand2 = Random.Range(0, 3);
    private bool canSpawn;
    private float spawnCD = 0f;
    private bool canBuild = true;
    private float buildCD = 0f;

    private void Update()
    {

        if (charList.Tappy == true && charList.distance >= 15)
        {
            GameObject[] skills = new GameObject[2];
            skills[0] = tappy1;
            skills[1] = tappy2;

            int n = Random.Range(0, 2);

            canSpawn = false;        

            spawnedSkill = Instantiate(skills[n], new Vector3(68f + 2*((-1) ^ rand2), 1.98000002f, 96.7200027f), Quaternion.Euler(-90f, 0, -90));
            spawnedSkill.transform.SetParent(gameObject.transform, true);
            
        }

        else if (charList.Bam == true && charList.distance >= 15)
        {
            GameObject[] skills = new GameObject[2];
            skills[0] = bam1;
            skills[1] = bam2;

            int n = Random.Range(0, 2);

            canSpawn = false;

            spawnedSkill = Instantiate(skills[n], new Vector3(68f + 2 * ((-1) ^ rand2), 1.98000002f, 96.7200027f), Quaternion.Euler(-90f, 0, -90));
            spawnedSkill.transform.SetParent(gameObject.transform, true);

        }

        else if (charList.Biggie == true && charList.distance >= 15)
        {
            GameObject[] skills = new GameObject[2];
            skills[0] = biggie1;
            skills[1] = biggie2;

            int n = Random.Range(0, 2);

            canSpawn = false;

            spawnedSkill = Instantiate(skills[n], new Vector3(68f + 2 * ((-1) ^ rand2), 1.98000002f, 96.7200027f), Quaternion.Euler(-90f, 0, -90));
            spawnedSkill.transform.SetParent(gameObject.transform, true);

        }

        else if (charList.Ogu == true && charList.distance >= 15)
        {
            GameObject[] skills = new GameObject[2];
            skills[0] = ogu1;
            skills[1] = ogu2;

            int n = Random.Range(0, 2);

            canSpawn = false;

            spawnedSkill = Instantiate(skills[n], new Vector3(68f + 2 * ((-1) ^ rand2), 1.98000002f, 96.7200027f), Quaternion.Euler(-90f, 0, -90));
            spawnedSkill.transform.SetParent(gameObject.transform, true);

        }

        if (canSpawn == false)
        {
            spawnCD += Time.deltaTime;
            if(spawnCD > 25)
            {
                canSpawn = true;
                spawnCD = 0;
            }
        }

        



    }
}
