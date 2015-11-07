using UnityEngine;
using System.Collections;

public class GridManager : MonoBehaviour {

    [Header("Grid Set Up")]
    public GameObject[,] grid;
    [SerializeField] private int gridWidth;
    [SerializeField] private int gridHeight;
    [SerializeField] private GameObject gridPlaceHolder;
    [SerializeField] private Transform gridTidy;




	// Use this for initialization
	void Start ()
    {
        grid = new GameObject[gridWidth, gridHeight];
        
        for(int i=0; i < gridWidth; i++)
        {
            for (int j=0; j < gridHeight; j++)
            {
                GameObject _gridPiece = Instantiate(gridPlaceHolder, new Vector3 (i, j, 0), transform.rotation) as GameObject;
                _gridPiece.transform.parent = gridTidy;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
