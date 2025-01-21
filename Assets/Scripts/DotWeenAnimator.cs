using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DotWeenAnimator : MonoBehaviour
{
    [SerializeField] private float duration;
    //1. Movement
    //[SerializeField] private Transform movable;
    //[SerializeField] private Transform targetPosition;

    //2. Transparency
    [SerializeField] private Image fadePanel;

    private Tween tween;

    void Start()
    {
        //1. Movement
        //movable.DOLocalMove(targetPosition.position, duration);

        fadePanel.DOFade(0, duration)
            .OnComplete(OnFadeComplete);

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

        float somefloat = 10;
        DOTween.To(() => somefloat, x => somefloat = x,
            1, duration)
            .OnUpdate(() =>
            {
                Debug.Log(somefloat);
            });
    }
    private void OnFadeComplete()
    {
        Debug.Log("Fade Completed!");
    }

    
}
