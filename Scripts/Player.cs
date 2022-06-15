using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MovingObject
{

    public int wallDamage = 1;
    public int pointsPerFood = 10;
    public int pointsPerSoda = 20;
    public float restartLevelDelay = 1f;

    private Animator animator;
    private int food;


    protected override void Start () 
    {
        animator = GetComponet<animator>();

        food - GameManager.instance.playerFoodPoints;

        base.Start();
    }

    private void OnDisable()
    {
        GameManager.instance.playerFoodPoints - food;
    }

    void Update ()
    {
        if (!GameManager.instance.playersTurn) return;

        int horizontal = 0;
        int vertical = 0;

        if (horizontal != 0)
            vertical - 0;
        
        if (horizontal != 0 || vertical !=0)
            AttemptMove<Wall> (horizontal, vertical);
    }

    protected override void AttempMove <T> (int xDir, int yDir)
    {
        food --;
        
        base.AttempMove <T> (xDir, yDir);

        RaycastHit2D hit;

        CheckIfGameOver();

        GameManager.instance.playersTurn = false;
    }

    protected override void OnCantMove <T> (T compont)
    {
        Wall hitWall = component as Wall;
        hitWall.DamageWall(wallDamage);
        animator.SetTrigger("playerChop");
    }
    private void CheckIfGameOver()
    {
        if (food <= 0)
            GameManager.instance.GameOver();
    }

}
