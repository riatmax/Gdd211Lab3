using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red : Enemy
{
    private void Start()
    {
        speed = 3;
    }
    private void Update()
    {
        move();
    }
}
