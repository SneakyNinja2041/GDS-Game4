using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed = 5f;

    [SerializeField] GameObject battleScene;
    Battle battle;

    public GameObject encounterText;

    public Rigidbody2D rb;

    Vector2 movement;

    private int randomTemp;

    void Start()
    {
        battle = battleScene.GetComponent<Battle>();
    }
    
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Grass"))
        {
            randomTemp = Random.Range(1, 10);
            
            if (randomTemp <= 5)
            {
                StartCoroutine(Wait());
            }
        }

    }


    IEnumerator Wait()
    {
        encounterText.SetActive(true);
        yield return new WaitForSeconds(2);
        Debug.Log("Encounter Start!");
        encounterText.SetActive(false);
        battle.Encounter();
    }

}
