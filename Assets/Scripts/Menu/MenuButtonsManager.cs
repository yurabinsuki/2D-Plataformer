using UnityEngine;
using DG.Tweening;
using System.Collections.Generic;
using Unity.VisualScripting;
using System.Collections;

public class MenuButtonsManager : MonoBehaviour
{
    
    public List<GameObject> buttons;

 [Header("Animation")]   
    public float duration = 0.5f;
    public float delay = 0.15f;
    public Ease ease = Ease.OutBack;


    void Awake()
    {
        HideAllButtons();
        ShowButtons();
    }


    private void HideAllButtons()
    {
        foreach (var b in buttons)
        {
            b.transform.localScale = Vector3.zero;
            b.SetActive(false);
        }
    }


    private void ShowButtons()
    {
        for(int i = 0; i < buttons.Count; i++)
        {
            var b = buttons[i];
            b.SetActive(true);
            b.transform.DOScale(1, duration).SetDelay(i*delay).SetEase(ease);
        }
    }


}
