using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Special : MonoBehaviour
{
    public Image abilityCooldownUI;
    public float cooldown = 5f;
    private float cooldownTime;
    public bool isCooldown;
    public MovingGlobe globe;
    public ParticleSystem decorationEffect;
    public GameObject deco;

    public PlayerConditions playerConditions;

    private void Start()
    {
        abilityCooldownUI.fillAmount = 0;
        playerConditions = FindAnyObjectByType<PlayerConditions>();
    }
    private void Update()
    {
        if (isCooldown)
        {
            cooldownTime -= Time.deltaTime;
            abilityCooldownUI.fillAmount = cooldownTime / cooldown;

            if (cooldownTime <= 0)
            {
                isCooldown = false;
                abilityCooldownUI.fillAmount = 0;
            }
        }
    }

    public void MagicCarpet()
    {
        if (!isCooldown)
        {
            
            StartCoroutine(SetCombedForSeconds(5f));
        }
        Skill();

    }

    public void FlightTicket()
    {
        
        
        if (!isCooldown)
        {
            globe.speed = 200f;
            StartCoroutine(SetCombedForSeconds(2.7f));
        }
        Skill();
    }
    public void Headphone()
    {
        if (!isCooldown)
        {
            globe.speed = 8f;
        }
        Skill();
        
    }
    public void Whistle()
    {
        
        if (!isCooldown)
        {
            List<GameObject> list = new List<GameObject> ();
            GameObject birdos = GameObject.FindGameObjectWithTag("Bird");
            Destroy(birdos);
                
        }
        Skill();
    }
    public void MoneyGun()
    {
        
        if (!isCooldown)
        {
            decorationEffect.Play();
        }
        Skill();
    }
    public void Coins()
    {
        if (!isCooldown)
        {
            globe.CoinChallenge();
        }
        Skill();
    }
    public void Combs()
    {
        
        if (!isCooldown)
        {
            StartCoroutine(SetCombedForSeconds(8f));

        }
        Skill();
    }
    public void Sunglasses()
    {
        if (!isCooldown)
        {
            playerConditions.isSunGlasses = true;
        }
        Skill();
        
    }
    public void Gadgets()
    {
        Skill();
        if (!isCooldown)
        {
        }
    }

    public void Skill()
    {
        if (!isCooldown)
        {
            abilityCooldownUI.fillAmount = 1;
            isCooldown = true;
            cooldownTime = cooldown;
        }
    }

    private IEnumerator SetCombedForSeconds(float seconds)
    {
        playerConditions.isCombed = true;
        yield return new WaitForSeconds(seconds);
        playerConditions.isCombed = false;
    }
}
