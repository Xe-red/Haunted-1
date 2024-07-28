using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PatrolEnemy : MonoBehaviour
{

     public Transform[] pointsToMove;
     public int index = 0;
    public float duration;

    private void Start()
    {
        LoopMove();
    }

    private void LoopMove()
    {
        if (index >= pointsToMove.Length)
        {
            index = 0;
        }
       
        transform.DOMove(pointsToMove[index].position, duration).OnComplete(() =>
        {
            index++;
            LoopMove();
        });
    }
    private void FixedUpdate() 
    {
        transform.LookAt(pointsToMove[index]);
    }
}