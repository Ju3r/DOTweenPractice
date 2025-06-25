using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    private Text _text;

    private string _targetText = "! IJunior !";
    private float _duration = 2f;

    private void Awake()
    {
        _text = GetComponent<Text>();   
    }

    private void Start()
    {
        ChangeText();
    }

    private void ChangeText()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(Replace());
        sequence.Append(Add());
        sequence.Append(Hack());
        sequence.SetLoops(ConstantData.InfinityLoopValue, LoopType.Yoyo);
    }

    private Tween Replace()
    {
        return _text.DOText(_targetText, _duration);
    }

    private Tween Add()
    {
        return _text.DOText(_targetText, _duration).SetRelative();
    }

    private Tween Hack()
    {
        return _text.DOText(_targetText, _duration, true, ScrambleMode.All); 
    }
}
