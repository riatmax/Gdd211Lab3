using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : Player
{
    
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        xPos = transform.position.x;
        yPos = transform.position.y;

        float X = Input.GetAxis("Horizontal");
        float Y = Input.GetAxis("Vertical");

        move(X, Y);

        if (X != 0 || Y != 0)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
        Enemy[] enemies = FindObjectsOfType<Enemy>();
        if (Input.GetMouseButtonDown(0))
        {
            
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].speed = .25f;
            }
        }
    }
    public override void attack()
    {
        anim.SetBool("isAttacking", true);
    }
}
