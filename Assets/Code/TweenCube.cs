using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;

public class TweenCube : MonoBehaviour
{
    [SerializeField]
    private float _duration;

    [SerializeField]
    private PathType _pathType = PathType.Linear;

    [SerializeField]
    private Transform[] _points;

    private List<Vector3> _pointPosition = new List<Vector3>();

    [SerializeField] private Color _color;

    private Material _material;

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
    }

    private void Start()
    {
        foreach (var point in _points)
            _pointPosition.Add(point.position);

        transform.DOPath(_pointPosition.ToArray(), _duration, _pathType);

        _material.DOColor(_color, _duration);
    }
}

