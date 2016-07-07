using UnityEngine;
using System.Collections;

public class StarWipe : MonoBehaviour {

	public GameObject starWipePlaneGO; 	//the plane we're going to animate
	public GameObject starWipeCameraGO; 	//we want to turn it off when not in use
    
    public float smallStarWipeScale = 0.05f;
    public float largeStarWipeScale = 0.5f;
    
    private bool starWipeIsAnimating = false;
    private float starWipeScaleTarget = 0.05f;
    private float scaleV = 0.05f;


    //input
    private float lastVertical = 0f;

    void Start () 
	{
	
	}
	
	void Update () 
	{
		//listen for up/down to starwipe in or out
		float vertical = Input.GetAxis("Vertical");
		if(vertical == 0f && lastVertical > 0)
		{
			//pressed UP
			starWipeIn();
		}
		if(vertical == 0f && lastVertical < 0)
		{
			//pressed DOWN
			starWipeOut();
		}

		lastVertical = Input.GetAxis("Vertical");








		//could easily replace this with a Tween
		if(starWipeIsAnimating)
        {
            float current = starWipePlaneGO.transform.localScale.x;
            float next_scale = current + scaleV;

            if(Mathf.Abs(starWipeScaleTarget - next_scale) < 0.05f)
            {
                next_scale = starWipeScaleTarget;
                starWipeIsAnimating = false;
            }

            
            if(!starWipeIsAnimating && next_scale == smallStarWipeScale)
            {
                starWipeCameraGO.SetActive(false);
                starWipePlaneGO.SetActive(false);
            }else{
                starWipePlaneGO.transform.localScale = new Vector3(next_scale, next_scale, next_scale);
            }

        }
	}


    void starWipeIn()
    {
        Debug.Log("------------------------------ STAR WIPE IN");
        starWipeCameraGO.SetActive(true);
        starWipePlaneGO.transform.localScale = new Vector3(smallStarWipeScale, smallStarWipeScale, smallStarWipeScale);
        starWipeScaleTarget = largeStarWipeScale;
        starWipeIsAnimating = true;
        starWipePlaneGO.SetActive(true);

        scaleV = 0.05f;
    }
    void starWipeOut()
    {
        Debug.Log("------------------------------ STAR WIPE OUT");
        starWipeScaleTarget = smallStarWipeScale;
        starWipeIsAnimating = true;

        scaleV = -0.05f;
	}
       





	
}
