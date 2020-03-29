using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Board board;
    public bool hasMovedBefore;

    // Start is called before the first frame update
    void Start()
    {
        board = gameObject.GetComponent<Board>();
        board.CreateBoard();
        board.SetUpPieces();
        hasMovedBefore = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && gameObject.transform.tag == "Rook")
        {
            Debug.Log("Got here");
        }
    }
}
