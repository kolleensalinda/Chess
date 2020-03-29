using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : Piece
{
    Board board;
    GameController gameController;

    public override void Move(char spaceToMoveTo)
    {
        if (IsLegalMove(spaceToMoveTo) == true)
        {
           gameObject.transform.position += new Vector3(0, (float)1.5, 0);
            gameController.hasMovedBefore = true;
        }
    }

    public override bool IsLegalMove(char spaceToMoveTo)
    {     
        if (spaceToMoveTo == 'e')
            return true;
        return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        //   Debug.Log("Test");
        board = gameObject.GetComponent<Board>();
        gameController = gameObject.GetComponent<GameController>();
    }

    /*   // Update is called once per frame
       void Update()
       {
           if (Input.GetMouseButtonDown(0))
           {
               board.squares[8, 1].GetComponent<MeshRenderer>().material.color = Color.red;
               transform.position += new Vector3(0, (float)1.5, 0);
           }
       }*/
}
