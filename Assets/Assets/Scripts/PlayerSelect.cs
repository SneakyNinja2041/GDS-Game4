using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    // Need the player sprites
    public SpriteRenderer spriteRenderer;
    [SerializeField] GameObject fightBun;

    public SpriteRenderer playerSprite;
    [SerializeField] GameObject playerBun;

    public Sprite fireSprite;
    public Sprite waterSprite;
    public Sprite grassSprite;
    public Sprite rockSprite;
    public Sprite iceSprite;
    public Sprite lightningSprite;

    // Need the particle systems
    public ParticleSystem fire;
    public ParticleSystem water;
    public ParticleSystem grass;
    public ParticleSystem rock;
    public ParticleSystem ice;
    public ParticleSystem lightning;

    // need to set the player stats
    CharStats charStats;
    public GameObject player;

    public GameObject characterSelectCanvas;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = fightBun.GetComponent<SpriteRenderer>();
        playerSprite = player.GetComponent<SpriteRenderer>();
        charStats = playerBun.GetComponent<CharStats>();
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FireSelected()
    {
        spriteRenderer.sprite = fireSprite;
        playerSprite.sprite = fireSprite;
        charStats.level = 5;
        charStats.healthMultiplier = 1;
        charStats.atkMultiplier = 2;

        Time.timeScale = 1f;
        characterSelectCanvas.SetActive(false);

        charStats.attackPS = fire;
    }

    public void WaterSelected()
    {
        spriteRenderer.sprite = waterSprite;
        playerSprite.sprite = waterSprite;
        charStats.level = 5;
        charStats.healthMultiplier = 2;
        charStats.atkMultiplier = 1;

        Time.timeScale = 1f;
        characterSelectCanvas.SetActive(false);

        charStats.attackPS = water;
    }

    public void GrassSelected()
    {
        spriteRenderer.sprite = grassSprite;
        playerSprite.sprite = grassSprite;
        charStats.level = 5;
        charStats.healthMultiplier = 3;
        charStats.atkMultiplier = 0;

        Time.timeScale = 1f;
        characterSelectCanvas.SetActive(false);

        charStats.attackPS = grass;
    }

    public void RockSelected()
    {
        spriteRenderer.sprite = rockSprite;
        playerSprite.sprite = rockSprite;
        charStats.level = 5;
        charStats.healthMultiplier = 3;
        charStats.atkMultiplier = 0;

        Time.timeScale = 1f;
        characterSelectCanvas.SetActive(false);

        charStats.attackPS = rock;
    }

    public void IceSelected()
    {
        spriteRenderer.sprite = iceSprite;
        playerSprite.sprite = iceSprite;
        charStats.level = 5;
        charStats.healthMultiplier = 2;
        charStats.atkMultiplier = 1;

        Time.timeScale = 1f;
        characterSelectCanvas.SetActive(false);

        charStats.attackPS = ice;
    }

    public void LightningSelected()
    {
        spriteRenderer.sprite = lightningSprite;
        playerSprite.sprite = lightningSprite;
        charStats.level = 5;
        charStats.healthMultiplier = 1;
        charStats.atkMultiplier = 2;

        Time.timeScale = 1f;
        characterSelectCanvas.SetActive(false);

        charStats.attackPS = lightning;
    }

}
