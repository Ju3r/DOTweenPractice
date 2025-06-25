using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration = 1f;

    private Renderer _renderer;
    private float _hueMin = 0f;
    private float _hueMax = 1f;
    private float _saturationMin = 1f;
    private float _saturationMax = 1f;
    private float _valueMin = 1f;
    private float _valueMax = 1f;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        Color randomColor = Random.ColorHSV(
            _hueMin, 
            _hueMax,
            _saturationMin,
            _saturationMax,
            _valueMin,
            _valueMax);

        _renderer.material.DOColor(randomColor, _duration)
            .SetEase(Ease.Linear)
            .OnComplete(ChangeColor);
    }
}
