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

    protected override void AttemptMove <T> (int xDir, int yDir)
    {
        if (skipMove)
        {
            skipMove = false;
            return;
        }

        base.AttemptMove <T> (xDir,yDir);

        skipMove = true;
    }

    public void MoveEnemy()
    {
        int xDir = 0;
        int yDir = 0;

        if (Mathf.Abs (targer.position.x - transform.position.x) < float.Epsilon)
            yDir = target.postion.y > transform.position.y ? 1 : -1;
        else
            xDir = targer.position.x > transform.position.x ? 1 : -1;
        
        AttemptMove <Player> (xDir, yDir);
    }

}
