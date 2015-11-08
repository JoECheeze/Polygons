using UnityEngine;
using System.Collections;

public class SquareSpawnerManager : MonoBehaviour {

    public GameObject square;
    public int squaresToSpawn;

	// Use this for initialization
	void Start ()
    {
        SpawnSquares();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SpawnSquares()
    {
        for (int i = 0; i < squaresToSpawn; i++)
        {
            GameObject newSquare = Instantiate(square, transform.position, transform.rotation) as GameObject;
            SquareBehaviour squareScript = newSquare.GetComponent<SquareBehaviour>();

            for (int j = 0; j < 4; j++)
            {
                squareScript.sideValues[j] = SideValue();
                squareScript.AssignValue(squareScript.sideValues[j], j);
            }
        }
    }

    int SideValue()
    {
        int _value = Random.Range(0, 3);
        return _value;
    }

}
