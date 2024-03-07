using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : MonoBehaviour
{
    protected int speed;
    public float xPos;
    public float yPos;
    private void Update()
    {

    }

    public void move(float inputX, float inputY)
    {
        Vector3 movement = new Vector3(inputX * Time.deltaTime * 10, inputY * Time.deltaTime * speed, 0);

        transform.position += movement;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    public abstract void attack();
}
