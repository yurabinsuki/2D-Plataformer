using Ebac.Core.Singleton;
using TMPro;
using UnityEngine;

public class UiInGameManager : Singleton<UiInGameManager>
{
    public TextMeshProUGUI uiTextScore;

    
    public void UpdateTextCoins(string s)
    {
        uiTextScore.text = s;
    }
}
