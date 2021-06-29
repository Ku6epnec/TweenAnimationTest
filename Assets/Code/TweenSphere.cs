using UnityEngine;
using DG.Tweening;

public class TweenSphere : MonoBehaviour
{
    [SerializeField] private float _duration;

    [SerializeField] private Vector3 _endPosition;

    [SerializeField] private Color _color;

    private Material _material;

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
    }

    private void Start()
    {
        transform.DOMove(_endPosition, _duration);
        _material.DOColor(_color, _duration);
    }
}
