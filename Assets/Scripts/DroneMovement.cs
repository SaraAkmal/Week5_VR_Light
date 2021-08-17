using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DroneMovement : MonoBehaviour
{
    [SerializeField] private Transform[] targetPositions;
    private int index = 0;
    void Start()
    {
        MoveOnPath();
    }

    void MoveOnPath()
    {
        if (index == 4)
        {
            index = 0;
        }
        transform.DOLookAt(targetPositions[index].position, 0.3f, AxisConstraint.None,
            Vector3.up).SetEase(Ease.InOutSine);
        transform.DOMove(targetPositions[index++].position , 2)
                .OnComplete(MoveOnPath).SetEase(Ease.InOutSine);
          
        

    }
    
}
