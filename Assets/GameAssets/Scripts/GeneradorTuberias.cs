using UnityEngine;
using System.Collections;

public class GeneradorTuberias : MonoBehaviour {

	public GameObject prefabTuberias;
	public float tiempoEntreTuberias = 3.5f;
    	
	void Start () {
		InvokeRepeating("CrearTuberia",0,tiempoEntreTuberias);		
	}
	
	void Update () {
		if(GameManager.gameOver){
			CancelInvoke("CrearTuberia");			
		}
	}
	
	void CrearTuberia(){		
		GameObject nuevaTuberia = Instantiate<GameObject>(prefabTuberias);
		nuevaTuberia.transform.position = this.transform.position;
		nuevaTuberia.transform.position += Vector3.up * Random.Range(-2,3);		
	}
	
	
}
