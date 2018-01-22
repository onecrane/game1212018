﻿using Assets.Scripts.GameClasses;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisGrid : MonoBehaviour {

    private int gridWidth = 10;
    private int gridHeight = 20;

    private TetrisGameGrid myGrid;      // null by default


    public GameObject greenBlock;


	// Use this for initialization
	void Start () {

        myGrid = new TetrisGameGrid(gridWidth, gridHeight);

        myGrid.gridSpaces[0, 0] = new Block(0, 0, BlockColor.Green);
	}
	
	// Update is called once per frame
	void Update () {
		
        // Draw a square in the appropriate location
        // for all occupied blocks in myGrid.

        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                // TODO: Determine if there is a block present
                // at grid space [x, y], and if there is,
                // draw it in the correct color.


                // Prefab instantiation example
                //
                //if (myGrid.gridSpaces[x, y] != null)
                //{
                //    if (myGrid.gridSpaces[x, y].color == BlockColor.Green)
                //    {
                //        GameObject newGreenBlock = GameObject.Instantiate(greenBlock);
                //    }
                //}

            }
        }

	}

}

