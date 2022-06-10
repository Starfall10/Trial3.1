using UnityEngine;
using System.Collections;

public abstract class MovingObject : MonoBehavious {

    public float moveTime = 0.1f;
    public LayerMask blockingLayer;

    private BoxCollider2D boxCollider;
    private Ridgidbody2D rb2D;
    private float inverseMoveTime;
    

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }
}