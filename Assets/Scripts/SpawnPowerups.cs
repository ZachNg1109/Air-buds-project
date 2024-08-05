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
   

    public CharactersObjects charList;

    public GameObject skillrefMiddle;

    private GameObject spawnedSkill;
    private int rand2;
    private bool canSpawn = true;
    private float spawnCD = 0f;

    private void Start()
    {
        //rand2 = Random.Range(0, 3);
    }

    private void Update()
    {

        if (charList.Tappy == true && charList.distance >= 15 && canSpawn == true)
        {
            GameObject[] skills = new GameObject[2];
            skills[0] = tappy1;
            skills[1] = tappy2;

            int n = Random.Range(0, 2);

            canSpawn = false;        

            spawnedSkill = Instantiate(skills[n], skillrefMiddle.transform.position, skillrefMiddle.transform.rotation);
            spawnedSkill.transform.SetParent(gameObject.transform, true);
            
        }

        else if (charList.Bam == true && charList.distance >= 15 && canSpawn == true)
        {
            GameObject[] skills = new GameObject[2];
            skills[0] = bam1;
            skills[1] = bam2;

            int n = Random.Range(0, 2);

            canSpawn = false;

            spawnedSkill = Instantiate(skills[n], skillrefMiddle.transform.position, skillrefMiddle.transform.rotation);
            spawnedSkill.transform.SetParent(gameObject.transform, true);

        }

        else if (charList.Biggie == true && charList.distance >= 15 && canSpawn == true)
        {
            GameObject[] skills = new GameObject[2];
            skills[0] = biggie1;
            skills[1] = biggie2;

            int n = Random.Range(0, 2);

            canSpawn = false;

            spawnedSkill = Instantiate(skills[n], skillrefMiddle.transform.position, skillrefMiddle.transform.rotation);
            spawnedSkill.transform.SetParent(gameObject.transform, true);

        }

        else if (charList.Ogu == true && charList.distance >= 15 && canSpawn == true)
        {
            GameObject[] skills = new GameObject[2];
            skills[0] = ogu1;
            skills[1] = ogu2;

            int n = Random.Range(0, 2);

            canSpawn = false;

            spawnedSkill = Instantiate(skills[n], skillrefMiddle.transform.position, skillrefMiddle.transform.rotation);
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
