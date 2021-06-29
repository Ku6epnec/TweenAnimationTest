using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CustomButton : Button
{
    [SerializeField] private AnimationType _animationType = AnimationType.ChangePosition;

    [SerializeField] Ease _ease = Ease.Linear;

    [SerializeField] private float _duration;

    private float _strenght = 60.0f;
    private RectTransform _rectTransform;

    protected override void Awake()
    {
        base.Awake();
        _rectTransform = GetComponent<RectTransform>();
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
        ActivateAnimation();
    }

    private void ActivateAnimation()
    {
        switch (_animationType)
        {
            case AnimationType.ChangePosition:
                _rectTransform.DOShakeAnchorPos(_duration, _strenght).SetEase(_ease);
                break;

            case AnimationType.ChangeRotation:
                _rectTransform.DOShakeRotation(_duration, _strenght).SetEase(_ease);
                break;
        }
    }
}


