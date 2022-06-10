using UnityEngine;
using System.Collections;

public abstract class MovingObject : MonoBehavious {

    public float moveTime = 0.1f;
    public LayerMask blockingLayer;

    private BoxCollider2D boxCollider;
    private Ridgidbody2D rb2D;
    private float inverseMoveTime;


    // Use this for initialization
    protected virtual void Start () {
        boxCollider = GetComponent<BoxCollider2D> ();
        rd2D = GetComponent<Ridgidbody2D>();
        inverseMoveTime = 1f / moveTime;
    }

    // Update is called once per frame
    void Update () {

    }
}