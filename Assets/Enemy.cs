using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public float speed { get; set; }
    private Player player;
    public bool frozen { get; set; }
  
    private void Awake()
    {
        player = FindObjectOfType<Player>();
    }
    public void move()
    {
        transform.position = Vector2.Lerp(transform.position, new Vector2(player.xPos, player.yPos), Time.deltaTime * speed); 
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Player>() != null)
        {
            Destroy(gameObject);
        }
    }
}
