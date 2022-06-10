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

    protected IEnumerator SmoothMovement (Vector3 end)
    {
        float sqrRemainingDistance = (transform.position - end).sqrMagnitude;

        while (sqrRemainingDistance > float.Epsilon)
        {
            Vector3 newPosition = Vector3.MoveTowards (rb2D.position, end , inverseMoveTime * moveTime.deltaTime);
            rb2D.MovePosition(newPosition);
            sqrRemainingDistance = (transform.position - end).sqrMagnitude;
            yield return null;
        }
    }
    // Update is called once per frame
    void Update () {

    }
}