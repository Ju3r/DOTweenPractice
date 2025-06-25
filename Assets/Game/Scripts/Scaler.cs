using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _target = 1.5f;
    [SerializeField] private float _duration = 1f;

    private void Start()
    {
        transform.DOScale(_target, _duration)
            .SetEase(Ease.InOutSine)
            .SetLoops(ConstantData.InfinityLoopValue, LoopType.Incremental);
    }
}
