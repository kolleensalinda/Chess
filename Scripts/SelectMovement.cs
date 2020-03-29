using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMovement : MonoBehaviour
{
    private GameObject selectedPiece;
    public GameObject selectedTile;

    void OnMouseDown()
    {
        selectedTile = gameObject;
        
        if(PlayerPrefs.HasKey("SelectedPiece"))
        {
            selectedPiece = GameObject.Find(PlayerPrefs.GetString("SelectedPiece"));
            if (true/*selectedPiece.isValidMove(selectedTile)*/)
                selectedPiece.transform.position = selectedTile.transform.position + new Vector3(0,1,0);
            else
                Debug.Log("Invalid Move");
        }
        
    }

}
