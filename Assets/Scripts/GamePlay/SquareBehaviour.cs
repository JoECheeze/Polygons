using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SquareBehaviour : MonoBehaviour {

    public bool isEnabled;

    [Header("Side Values")]
    public int[] sideValues = new int[4];
    public Text[] sideValueText = new Text[4];

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

    public void AssignValue(int value, int textID)
    {
        switch (value)
        {
            case (0):
                sideValueText[textID].text = "N";
                break;

            case (1):
                sideValueText[textID].text = "-";
                break;

            case (2):
                sideValueText[textID].text = "+";
                break;
        }
    }
}
