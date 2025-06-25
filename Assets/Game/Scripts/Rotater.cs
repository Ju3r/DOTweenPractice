using DG.Tweening;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] private float _duration = 5f;

    private int _outOfTurn = 0;
    private float _fullTurn = 360;

    private void Start()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.DORotate(new Vector3(_outOfTurn, _fullTurn, _outOfTurn), _duration, RotateMode.FastBeyond360)
            .SetEase(Ease.Linear)
            .SetLoops(ConstantData.InfinityLoopValue, LoopType.Restart);
    }
}