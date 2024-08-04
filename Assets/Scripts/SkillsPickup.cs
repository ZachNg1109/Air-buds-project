using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsPickup : MonoBehaviour
{
    //public Special moves;

    [SerializeField]private bool Move1;
    [SerializeField]private bool Move2;

    public GameObject skillButton1;
    public GameObject skillButton2;
    public CharactersObjects charlist;

    private void Awake()
    {
        Move1 = false;
        Move2 = false;
    }

    private void Update()
    {
        


        if (Move1 == true)
        {
            Move2 = false;
            skillButton1.SetActive(true);

        }
        else if (Move2 == true)
        {
            Move1 = false;
            skillButton2.SetActive(true);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<SkillBoolSelect>().skillMove1 == true)
        {
            Move1 = true;

        }

        if (other.gameObject.GetComponent<SkillBoolSelect>().skillMove2 == true)
        {
            Move2 = true;

        }

        if (other.gameObject.CompareTag("Star"))
        {
            charlist.StarsCollected += 1;
        }

    }
}
