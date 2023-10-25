using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    public Slider expBar;
    public Slider hpBar;

    public ParticleSystem attackPS;

    [SerializeField] GameObject enemy;
    EnemyStats enemystats;

    [SerializeField] GameObject battleGO;
    Battle battle;

    [SerializeField] GameObject battleWinText;

    public TextMeshProUGUI playerStats;

    void Start()
    {
        level = 5;

        maxHealth = level * healthMultiplier * 2;
        currentHealth = maxHealth;

        atk = level + atkMultiplier;

        exp = startExp;
        maxExp = level * 3;

        enemystats = enemy.GetComponent<EnemyStats>();
        battle = battleGO.GetComponent<Battle>();

        hpBar.maxValue = maxHealth;
        hpBar.value = currentHealth;

        expBar.maxValue = level;
        expBar.value = exp;
    }

    void Update()
    {
        if (exp >= maxExp)
        {
            exp = 0;
            level++;
        }

        hpBar.value = currentHealth;
        expBar.value = exp;
        expBar.maxValue = level * 3;

        if (enemystats.currentHealth <= 0)
        {
            battleWinText.SetActive(true);
            StartCoroutine(WaitA());
        }

        if (currentHealth <= 0)
        {
            currentHealth = maxHealth;
            battle.EncounterEnd();
        }

        playerStats.text = "BUNBUN  LVL: " + level;
    }

    public void Attack()
    {
        attackPS.Play();
        StartCoroutine(HitEnemy());
    }
 
    public IEnumerator HitEnemy()
    {

        yield return new WaitForSeconds(4);
        Debug.Log("Enemy Hurt!");
        // audio clip
        enemystats.currentHealth -= atk; 

        if (enemystats.currentHealth >=1)
        {
            Debug.Log("Enemy Turn!");
            enemystats.isMoved = true;
        }

    }

    public IEnumerator WaitA()
    {
        yield return new WaitForSeconds(1);
        exp += enemystats.level;
        battleWinText.SetActive(false);
        battle.EncounterEnd();
    }

    
}
