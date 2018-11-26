using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NumberChecker : MonoBehaviour {

    SceneLoader sceneLoader=new SceneLoader();

	public void CheckMinAndMax(int min,int max,TextMeshProUGUI infoText)
    {
        if (max <= min)
        {
            infoText.text = "Sectigin maksimum sayi minimum sayindan kucuk. Klavyenden BACKSPACE tusuna basarak duzeltme yapabilirsin.\nHazir oldugunda Devam Et .";
        }
           
        else
        {
            sceneLoader = new SceneLoader();
            sceneLoader.LoadNextScene();
            Destroy(DontDestroyMusic.instance.gameObject);
        }
        
    }
}
