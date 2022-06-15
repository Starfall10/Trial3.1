using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MovingObject
{
    public int playerDamage;

    private Animator animator;
    private Transform targer;
    private bool skipMove;


    protected override void Start()
    {
        animator = GetComponent<animator>();
        target = GameObject.FindGameObjectWithTag ("Player").transform;
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}