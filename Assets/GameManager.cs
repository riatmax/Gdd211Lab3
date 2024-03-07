using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static int charSelect = -1;

    private float delay = 5;
    private float interval = 5;

    [SerializeField] private int spawnRate;
    [SerializeField] private GameObject greg;
    [SerializeField] private GameObject bob;

    [SerializeField] private GameObject greenEnemy;
    [SerializeField] private GameObject blueEnemy;
    [SerializeField] private GameObject redEnemy;

    [SerializeField] private TMP_Text myText;
    float timer;
    void Awake()
    {
        switch (charSelect)
        {
            case 0:
                Instantiate(greg, gameObject.transform.position, Quaternion.identity);
                break;
            case 1:
                Instantiate(bob, gameObject.transform.position, Quaternion.identity);
                break;
        }
    }

    void Update()
    {
        if (charSelect != -1)
        {
            

            if (FindObjectOfType<Player>() != null)
            {
                timer = Time.time;
                
                myText.text = $"Time Survived: {timer}";
            }
            else
            {
                float finalTime = timer;
                myText.text = $"Timer Survived: {finalTime}";
            }
            if (delay > 0)
            {
                delay -= Time.deltaTime;
            }
            else 
            {
                delay = interval;
                spawnEnemies();
            }
        }

    }
    public void gregSelect()
    {
        charSelect = 0;
        SceneManager.LoadScene(0);
    }
    public void bobSelect()
    {
        charSelect = 1;
        SceneManager.LoadScene(0);
    }
    public void spawnEnemies()
    {
        for (int i = 0; i < 5; i++)
        {

            int randEnemy = Random.Range(0, 3);

            switch (randEnemy)
            {
                case 0:
                    Instantiate(greenEnemy, Random.onUnitSphere * 10 + transform.position, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(redEnemy, Random.onUnitSphere * 10 + transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(blueEnemy, Random.onUnitSphere * 10 + transform.position, Quaternion.identity);
                    break;
            }
            
        }
    }
}
