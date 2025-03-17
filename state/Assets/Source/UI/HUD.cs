    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUD : MonoBehaviour
{
    [SerializeField] private BootStrapper playerState;
    [SerializeField] private TMP_Text uiText; 

    void Update()
    {
        if (playerState.StateMachine.CurrentState != null)
        {
            uiText.text = playerState 
        }
    }
}
