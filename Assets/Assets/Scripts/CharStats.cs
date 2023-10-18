using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharStats : MonoBehaviour
{

    public int currentHealth;
    public int maxHealth;
    public int healthMultiplier;

    public int atk;
    public int atkMultiplier;

    public int level;

    public int startExp = 0;
    public int exp;
    public int maxExp;

    public ParticleSystem attackPS;

    void Start()
    {
        level = 1;

        maxHealth = level * healthMultiplier;
        currentHealth = maxHealth;

        atk = level * atkMultiplier;

        exp = startExp;
        maxExp = level * 3;
    }

    public void Attack()
    {
        attackPS.Play();
    }
 

    // :>
}
