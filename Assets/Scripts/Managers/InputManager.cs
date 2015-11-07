using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    private bool hasSquare;
    private SquareBehaviour currentSquare;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetButtonDown("Fire1"))
        {
            if (currentSquare)
            {
                currentSquare.isEnabled = false;
                currentSquare = null;
            }
            else
            {
                SquareDetection();
            }
        }
 // if (currentSquare && Input.GetButtonDown("Fire1"))
 //       {
 //           currentSquare.isEnabled = false;
 //       }
    }

    void SquareDetection ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if (hit.collider.tag == "Square")
            {
                hasSquare = true;
                currentSquare = hit.collider.gameObject.GetComponent<SquareBehaviour>();
                currentSquare.isEnabled = true;
                
            }
        }
    }
}
