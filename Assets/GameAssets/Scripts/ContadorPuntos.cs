using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ContadorPuntos : MonoBehaviour {
    	
	void Update () {
		this.GetComponent<Text>().text = GameManager.puntos.ToString();
	}
}
