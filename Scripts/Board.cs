using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] GameObject tile;
    [SerializeField] GameObject pawn;
    [SerializeField] GameObject bishop;
    [SerializeField] GameObject knight;
    [SerializeField] GameObject rook;
    [SerializeField] GameObject queen;
    [SerializeField] GameObject king;

    public GameObject[] pawnWhiteArray = new GameObject[8];
    public GameObject[] pawnBlackArray = new GameObject[8];
    public GameObject[] bishopWhiteArray = new GameObject[2];
    public GameObject[] bishopBlackArray = new GameObject[2];
    public GameObject[] rookWhiteArray = new GameObject[2];
    public GameObject[] rookBlackArray = new GameObject[2];
    public GameObject[] knightWhiteArray = new GameObject[2];
    public GameObject[] knightBlackArray = new GameObject[2];
    public GameObject[] queenWhiteArray = new GameObject[1];
    public GameObject[] queenBlackArray = new GameObject[1];
    public GameObject[] kingWhiteArray = new GameObject[1];
    public GameObject[] kingBlackArray = new GameObject[1];
    public GameObject[] piecePlacement;
    //GameObject player1;
    

    public GameObject[,] squares = new GameObject[8, 8];
    public char[,] spacesOccupied = new char[8, 8]; // Char array to put which spaces are occupied. 
        // 'e' for empty, 'w' for white space occupying space, 'b' for black space occupying space

    public void CreateBoard()
    {
        for (int i=0; i<8; i++)
        {
            for (int j=0; j<8; j++)
            {
                squares[i, j] = Instantiate(tile, new Vector3 (i, j, 0), Quaternion.identity);
                if (i % 2 != 0 && j % 2 != 0 || i % 2 == 0 && j % 2 == 0)
                    squares[i, j].GetComponent<MeshRenderer>().material.color = Color.black;
                else
                    squares[i, j].GetComponent<MeshRenderer>().material.color = Color.white;
            }
        }
    }
    public void SetUpPieces()
    {
        // Initialize spacesOccupied array.
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                spacesOccupied[i, j] = 'e';
            }
        }

        GameObject[] pieces = new GameObject[8] { rook, knight, bishop, queen, king, bishop, knight, rook };
        
        // Sets up white pieces
        for (int i=0; i<8; i++)
        {
            pawnWhiteArray[i] = Instantiate(pawn, new Vector3(i, 1, (float)-0.62), Quaternion.identity);
            pawnWhiteArray[i].tag = "Pawn";
            spacesOccupied[i, 1] = 'w';
            //pawnWhiteArray[i].gameObject.GetComponent<Pawn>();

            if(i == 0)
            {
                rookWhiteArray[0] = Instantiate(rook, new Vector3(i, 0, (float)-0.62), Quaternion.identity);
                rookWhiteArray[0].tag = "Rook";
                spacesOccupied[i, 0] = 'w';
            }
                
            if(i == 1)
            {
                knightWhiteArray[0] = Instantiate(knight, new Vector3(i, 0, (float)-0.62), Quaternion.identity);
                knightWhiteArray[0].tag = "Knight";
                spacesOccupied[i, 0] = 'w';
            }
                
            if(i == 2)
            {
                bishopWhiteArray[0] = Instantiate(bishop, new Vector3(i, 0, (float)-0.62), Quaternion.identity);
                bishopWhiteArray[0].tag = "Bishop";
                spacesOccupied[i, 0] = 'w';
            }
             
            if (i == 3)
            {
                queenWhiteArray[0] = Instantiate(queen, new Vector3(i, 0, (float)-0.62), Quaternion.identity);
                queenWhiteArray[0].tag = "Queen";
                spacesOccupied[i, 0] = 'w';
            }
                
            if (i == 4)
            {
                kingWhiteArray[0] = Instantiate(king, new Vector3(i, 0, (float)-0.62), Quaternion.identity);
                kingWhiteArray[0].tag = "King";
                spacesOccupied[i, 0] = 'w';
            }

            if (i == 5)
            {
                bishopWhiteArray[1] = Instantiate(bishop, new Vector3(i, 0, (float)-0.62), Quaternion.identity);
                bishopWhiteArray[1].tag = "Bishop";
                spacesOccupied[i, 0] = 'w';
            }

            if (i == 6)
            {
                knightWhiteArray[1] = Instantiate(knight, new Vector3(i, 0, (float)-0.62), Quaternion.identity);
                knightWhiteArray[1].tag = "Knight";
                spacesOccupied[i, 0] = 'w';
            }

            if (i == 7)
            {
                rookWhiteArray[1] = Instantiate(rook, new Vector3(i, 0, (float)-0.62), Quaternion.identity);
                rookWhiteArray[1].tag = "Rook";
                spacesOccupied[i, 0] = 'w';
            }
                
        }

        // Sets up black pieces
        for (int i = 0; i < 8; i++)
        {
            pawnBlackArray[i] = Instantiate(pawn, new Vector3(i, 6, (float)-0.62), Quaternion.identity);
            pawnBlackArray[i].tag = "Pawn";
            spacesOccupied[i, 6] = 'b';
            //pawnBlackArray[i].gameObject.GetComponent<Pawn>();

            if (i == 0)
            {
                rookBlackArray[0] = Instantiate(rook, new Vector3(i, 7, (float)-0.62), Quaternion.identity);
                rookBlackArray[0].tag = "Rook";
                spacesOccupied[i, 7] = 'b';
            }

            if (i == 1)
            {
                knightBlackArray[0] = Instantiate(knight, new Vector3(i, 7, (float)-0.62), Quaternion.identity);
                knightBlackArray[0].tag = "Knight";
                spacesOccupied[i, 7] = 'b';
            }

            if (i == 2)
            {
                bishopBlackArray[0] = Instantiate(bishop, new Vector3(i, 7, (float)-0.62), Quaternion.identity);
                bishopBlackArray[0].tag = "Bishop";
                spacesOccupied[i, 7] = 'b';
            }

            if (i == 3)
            {
                queenBlackArray[0] = Instantiate(queen, new Vector3(i, 7, (float)-0.62), Quaternion.identity);
                queenBlackArray[0].tag = "Queen";
                spacesOccupied[i, 7] = 'b';
            }

            if (i == 4)
            {
                kingBlackArray[0] = Instantiate(king, new Vector3(i, 7, (float)-0.62), Quaternion.identity);
                kingBlackArray[0].tag = "King";
                spacesOccupied[i, 7] = 'b';
            }

            if (i == 5)
            {
                bishopBlackArray[1] = Instantiate(bishop, new Vector3(i, 7, (float)-0.62), Quaternion.identity);
                bishopBlackArray[1].tag = "Bishop";
                spacesOccupied[i, 7] = 'b';
            }

            if (i == 6)
            {
                knightBlackArray[1] = Instantiate(knight, new Vector3(i, 7, (float)-0.62), Quaternion.identity);
                knightBlackArray[1].tag = "Knight";
                spacesOccupied[i, 7] = 'b';
            }

            if (i == 7)
            {
                rookBlackArray[1] = Instantiate(rook, new Vector3(i, 7, (float)-0.62), Quaternion.identity);
                rookBlackArray[1].tag = "Rook";
                spacesOccupied[i, 7] = 'b';
            }

        }
    }
}
