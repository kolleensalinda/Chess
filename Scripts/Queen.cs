using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : Piece
{
    public override bool IsLegalMove(char spaceToMoveTo)
    {
        return true;
    }

    public override void Move(char spaceToMoveTo)
    {
        // will need to call IsLegalMove() here...

        // Need to finish writing this move...
        // Place code here :)
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
