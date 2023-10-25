using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyStats : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    public int atk;

    public int level;

    // random numbers
    private int randomTemp;
    private int randomGuy;

    // reference to PS
    public ParticleSystem attackPS;

    // reference to sprites
    public Sprite fireSprite;
    public Sprite waterSprite;
    public Sprite grassSprite;
    public Sprite rockSprite;
    public Sprite iceSprite;
    public Sprite lightningSprite;

    // Particle systems
    public ParticleSystem fire;
    public ParticleSystem water;
    public ParticleSystem grass;
    public ParticleSystem rock;
    public ParticleSystem ice;
    public ParticleSystem lightning;

    public Slider enemyHealth;

    [SerializeField] GameObject enemyBun;
    public SpriteRenderer enemySprite;

    [SerializeField] GameObject player;
    CharStats playerStats;

    public bool isMoved;

    public TextMeshProUGUI enemyName;

    void Start()
    {
        enemySprite = enemyBun.GetComponent<SpriteRenderer>();
        playerStats = player.GetComponent<CharStats>();

        currentHealth = maxHealth;

        enemyHealth.maxValue = maxHealth;
        enemyHealth.value = currentHealth;
        isMoved = false;
    }

    void Update()
    {
        enemyHealth.value = currentHealth;

        if (isMoved == true)
        {
            Debug.Log("Enemy Attack");
            StartCoroutine(EnemyAttack());
            isMoved = false;
        }

    }


    public void SpawnEnemy()
    {
        randomGuy = Random.Range(1, 7);
        if (randomGuy == 1)
        {
            level = 2;
        }
        if (randomGuy == 2)
        {
            level = 2;
        }
        if (randomGuy == 3)
        {
            level = 3;
        }
        if (randomGuy == 4)
        {
            level = 4;
        }
        if (randomGuy == 5)
        {
            level = 5;
        }
        if (randomGuy == 6)
        {
            level = 6;
        }

        randomTemp = Random.Range(1, 7);
        if (randomTemp == 1)
        {
            FireEnemy();
        }
        if (randomTemp == 2)
        {
            WaterEnemy();
        }    
        if (randomTemp == 3)
        {
            GrassEnemy();
        }
        if (randomTemp == 4)
        {
            RockEnemy();
        }
        if (randomTemp == 5)
        {
            IceEnemy();
        }
        if (randomTemp == 6)
        {
            LightningEnemy();
        }

    }

    public void FireEnemy()
    {
        attackPS = fire;
        enemySprite.sprite = fireSprite;
        atk = level * 3;
        maxHealth = level;
        currentHealth = maxHealth;
        enemyName.text = "FIREBUN  LVL: " + level.ToString();
        enemyHealth.maxValue = maxHealth;
        enemyHealth.value = currentHealth;
    }

    public void WaterEnemy()
    {
        attackPS = water;
        enemySprite.sprite = waterSprite;
        atk = level * 2;
        maxHealth = level * 2;
        currentHealth = maxHealth;
        enemyName.text = "WATERBUN  LVL: " + level.ToString();
        enemyHealth.maxValue = maxHealth;
        enemyHealth.value = currentHealth;
    }

    public void GrassEnemy()
    {
        attackPS = grass;
        enemySprite.sprite = grassSprite;
        atk = level; 
        maxHealth = level * 3;
        currentHealth = maxHealth;
        enemyName.text = "GRASSBUN  LVL: " + level.ToString();
        enemyHealth.maxValue = maxHealth;
        enemyHealth.value = currentHealth;
    }

    public void RockEnemy()
    {
        attackPS = rock;
        enemySprite.sprite = rockSprite;
        atk = level;
        maxHealth = level * 3;
        currentHealth = maxHealth;
        enemyName.text = "ROCKBUN  LVL: " + level.ToString();
        enemyHealth.maxValue = maxHealth;
        enemyHealth.value = currentHealth;
    }

    public void IceEnemy()
    {
        attackPS = ice;
        enemySprite.sprite = iceSprite;
        atk = level * 2;
        maxHealth = level * 2;
        currentHealth = maxHealth;
        enemyName.text = "ICEBUN  LVL: " + level.ToString();
        enemyHealth.maxValue = maxHealth;
        enemyHealth.value = currentHealth;
    }

    public void LightningEnemy()
    {
        attackPS = lightning;
        enemySprite.sprite = lightningSprite;
        atk = level * 3;
        maxHealth = level;
        currentHealth = maxHealth;
        enemyName.text = "LIGHTNINGBUN  LVL: " + level.ToString();
        enemyHealth.maxValue = maxHealth;
        enemyHealth.value = currentHealth;
    }

    IEnumerator EnemyAttack()
    {
        Debug.Log("Player Hit!");
        // audio clip
        attackPS.Play();
        yield return new WaitForSeconds(4);
        playerStats.currentHealth -= atk;
        
    }


}
