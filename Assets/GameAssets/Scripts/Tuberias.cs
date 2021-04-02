using UnityEngine;
using System.Collections;

public class Tuberias : MonoBehaviour
{
	public float velocidad = 5;		
	public float limiteIzquierdo = -10;
    		
	void Update ()
	{
		if(this.transform.position.x < limiteIzquierdo){
			Destroy(this.gameObject);
		} 
	
		if (!GameManager.gameOver) {
			this.transform.Translate (Vector3.left * Time.deltaTime * velocidad);
		}
	}
}
