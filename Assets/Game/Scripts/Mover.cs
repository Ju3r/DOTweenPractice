using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration = 5f;
    [SerializeField] private float _distance = 0.2f;

    private void Start()
    {
        Move();
    }

    private void Move()
    {
        transform.DOMoveZ(transform.position.z - _distance, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(ConstantData.InfinityLoopValue, LoopType.Incremental);
    }
}