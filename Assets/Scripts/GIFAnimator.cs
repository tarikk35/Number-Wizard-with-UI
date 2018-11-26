using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GIFAnimator : MonoBehaviour {

    public Sprite[] animatedImages;
    public Image animateImageObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        animateImageObject.sprite = animatedImages[(int)(Time.time*30)%animatedImages.Length];
	}
}
