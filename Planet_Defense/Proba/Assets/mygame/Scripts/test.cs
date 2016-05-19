using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    private ScreenOrientation screenOrientation;
    private float screenWidth;
    private float screenHeight;
    private float wrongWidth;
    private float wrongHeight;

    public void Update()
    {
        //These values are right
        this.screenWidth = Screen.width;
        this.screenHeight = Screen.height;

        if (this.screenOrientation != Screen.orientation)
        {
            this.DoWhatever();
            this.screenOrientation = Screen.orientation;
        }
    }

    public void DoWhatever()
    {
        //These values are wrong
        this.wrongWidth = this.screenWidth;
        this.wrongHeight = this.screenHeight;
    }
}
