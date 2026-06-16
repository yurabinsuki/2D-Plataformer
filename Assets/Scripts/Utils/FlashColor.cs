using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlashColor : MonoBehaviour
{
    public List<SpriteRenderer> spriteRenderers;
    public Color flashColor = Color.red;
    public float flashDuration = 0.3f;
    private Tween _currentTween;

    private void OnValidate()
    {
        if (spriteRenderers == null || spriteRenderers.Count == 0)
        {
            spriteRenderers = new List<SpriteRenderer>();
            foreach (var sprite in transform.GetComponentsInChildren<SpriteRenderer>())
            {
                spriteRenderers.Add(sprite);
            }
        }
    }

    public void Flash()
        {
            if (_currentTween != null)
            {
                _currentTween.Kill();
                spriteRenderers.ForEach(s => s.color = Color.white);
            }

            foreach (var s in spriteRenderers)
            {
                _currentTween = s.DOColor(flashColor, flashDuration).SetLoops(2, LoopType.Yoyo).SetEase(Ease.Flash);
            }
        }

}
