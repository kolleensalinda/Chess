using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Piece : MonoBehaviour
{
    public abstract bool IsLegalMove(char spaceToMoveTo);

    public abstract void Move(char spaceToMoveTo);
}
