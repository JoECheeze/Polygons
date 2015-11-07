using UnityEngine;
using System.Collections;

public class SquareBehaviour : MonoBehaviour {

    public bool isEnabled;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (isEnabled)
        {
            PositionUpdate();
        }
	}

    void PositionUpdate()
    {
        Vector3 _newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.localPosition = new Vector3(_newPosition.x, _newPosition.y, 0);
    }
}
