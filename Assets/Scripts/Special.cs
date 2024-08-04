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
        Skill();

    }

    public void FlightTicket()
    {
        Skill();
        if (!isCooldown)
        {
            globe.speed = 200f;
        }
    }
    public void Headphone()
    {
        Skill();
        if (!isCooldown)
        {
            globe.speed = 8f;
        }
    }
    public void Whistle()
    {
        Skill();
        if (!isCooldown)
        {
            List<GameObject> list = new List<GameObject> ();
            GameObject birdos = GameObject.FindGameObjectWithTag("Bird");
            Destroy(birdos);
                
        }

    }
    public void MoneyGun()
    {
        Skill();
        if (!isCooldown)
        {
            decorationEffect.Play();
        }
    }
    public void Coins()
    {
        Skill();
        if (!isCooldown)
        {
            globe.CoinChallenge();
        }
    }
    public void Combs()
    {
        Skill();
        if (!isCooldown)
        {
            StartCoroutine(SetCombedForSeconds(2f));
        }
    }
    public void Sunglasses()
    {
        Skill();
        if (!isCooldown)
        {
            playerConditions.isSunGlasses = true;
        }
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
