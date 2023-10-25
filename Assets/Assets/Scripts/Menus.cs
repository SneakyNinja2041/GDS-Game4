using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menus : MonoBehaviour
{
    [SerializeField] GameObject menuMenu;
    [SerializeField] GameObject fightMenu;

    public bool isAttack;
    public bool isMenus;

    // ref to battle script
    [SerializeField] GameObject battleGO;
    Battle battle;

    private void Start()
    {
        isAttack = false;
        isMenus = true;
        battle = battleGO.GetComponent<Battle>();
    }

    private void Update()
    {
        if (isAttack == true) 
        {
            menuMenu.SetActive(false);
            fightMenu.SetActive(true);
        }

        if (isMenus == true)
        {
            menuMenu.SetActive(true);
            fightMenu.SetActive(false);
        }


    }

    public void AttackMenu()
    {
        // audio clip of select
        isAttack = true;
        isMenus = false;
    }

    public void MenusOpen()
    {
        // audio clip of select
        isMenus = true;
        isAttack = false;
    }

    public void Run()
    {
        // player attempts to run away. 
        // if they runaway, play run audio
        battle.EncounterEnd();
    }



}
