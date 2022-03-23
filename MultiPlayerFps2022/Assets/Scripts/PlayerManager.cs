using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public float health = 100;
    public Text healthAmount;

    public GameManager gameManager;

    public void Hit(float damage)
    {
        health -= damage;
        healthAmount.text = health.ToString()+ ": HEALTH"  ;
        if(health <= 0)
        {
            //SceneManager.LoadScene(0);
            gameManager.EndGame();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
