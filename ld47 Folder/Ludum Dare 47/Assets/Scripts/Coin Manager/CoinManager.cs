using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public TextMeshProUGUI textPro;

    private void Start() {
        SetCoin();
    }

    public void SetCoin()
    {
        textPro.text = PlayerPrefs.GetInt("Gold").ToString(); 
    }
}
