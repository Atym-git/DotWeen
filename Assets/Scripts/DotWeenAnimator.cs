using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DotWeenAnimator : MonoBehaviour
{
    [SerializeField] private float duration;
    [SerializeField] private AnimationCurve curve;

    //1. Movement
    [SerializeField] private Transform movable;
    [SerializeField] private Transform targetPosition;

    //2. Transparency
    [SerializeField] private Image _timer;

    private Tween tween;

    private void Start()
    {
        //1. Movement
        //movable.DOLocalMove(targetPosition.position, duration);

        //fadePanel.DOFade(0, duration)
        //    .OnComplete(OnFadeComplete);

        //tween = movable.DOMove(targetPosition.position, duration)
        //.SetEase(curve);

        //fadePanel.DOFade(0, duration)
        //    .OnComplete(() =>
        //    {
        //        Debug.Log("Fade Completed!");
        //    });

        //if (tween.IsPlaying())
        //{ 

        //}

        //tween.Play();
        //tween.Restart();
        //tween.Kill();
        //tween.Pause();
        //tween.Rewind();

        //float somefloat = 10;
        //DOTween.To(() => somefloat, x => somefloat = x,
        //    1, duration)
        //    .OnUpdate(() =>
        //    {
        //        Debug.Log(somefloat);
        //    });
    }

    private void FixedUpdate()
    {
        if (_timer.fillAmount >= 1)
        {
            _timer.fillAmount = 0;
        }
        if (_timer.fillAmount <= 0)
        {
            DoFillAmount();
        }
    }

    private void DoFillAmount()
    {
        _timer.fillAmount = 0;
        _timer.DOFillAmount(1, duration);
        Debug.Log("Start");
    }
    //private void OnFadeComplete()
    //{
    //    Debug.Log("Fade Completed!");
    //}


}
