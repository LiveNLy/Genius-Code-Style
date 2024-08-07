using System;
using System.Linq;
using UnityEngine;

public class TargetMover : MonoBehaviour
{
    [SerializeField] private Transform[] _targetMovePoints;
    [SerializeField] private float _targetSpeed;

    private int _numberOfMovePoint = 0;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetMovePoints[_numberOfMovePoint].position, _targetSpeed * Time.deltaTime);

        if(transform.position == _targetMovePoints[_numberOfMovePoint].position)
            _numberOfMovePoint = (_numberOfMovePoint + 1) % _targetMovePoints.Length;
    }
}