using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPiece : MonoBehaviour
{
    void OnMouseDown()
    {
        PlayerPrefs.SetString("SelectedPiece", gameObject.name);
    }
}
