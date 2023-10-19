using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Battle : MonoBehaviour
{
    [SerializeField] GameObject player;
    CharStats charStats;
    [SerializeField] GameObject enemy;
    EnemyStats enemystats;

    [SerializeField] GameObject battleScene;


    // text for lvl up
    // text for kill

    // gameover shit

    public bool isBattle;

    void Start()
    {
        isBattle = false;
        charStats = player.GetComponent<CharStats>();
        enemystats = enemy.GetComponent<EnemyStats>();
    }

    void Update()
    {

        

    }






    public void Encounter()
    {
        player.SetActive(false);
        battleScene.SetActive(true);

        enemystats.SpawnEnemy();

    }

    public void EncounterEnd()
    {
        player.SetActive(true);
        battleScene.SetActive(false);
    }



}
