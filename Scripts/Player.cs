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

    protected override void AttempMove <T> (int xDir, int yDir)
    {
        food --;
        
        base.AttempMove <T> (xDir, yDir);

        RaycastHit2D hit;

        CheckIfGameOver();

        GameManager.instance.playersTurn = false;
    }
    private void CheckIfGameOver()
    {
        if (food <= 0)
            GameManager.instance.GameOver();
    }

}
