using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour {

	public float velocidad = 10;	
	public GameObject sonidoAleteo;
		

	void Start () {
        GameManager.gameOver = false;
		GameManager.puntos = 0;        
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
		
		if(!GameManager.gameOver)
        {
			if(Input.GetKeyDown(KeyCode.Space) ){
				this.GetComponent<Rigidbody>().velocity = Vector3.up * velocidad;
				sonidoAleteo.GetComponent<AudioSource>().Play();				
			}
		}		
	}
	
	void OnCollisionEnter(Collision coll){
		Debug.Log("He muerto");

        GameManager.gameOver = true;

        this.GetComponent<Rigidbody>().velocity = Vector3.up * 5 + Vector3.left * 5;
		this.GetComponent<Collider>().enabled = false;		
		
		Invoke("ReiniciarPartida",3);		
	}
	
	void OnTriggerEnter(Collider collider){
        GameManager.puntos += 1;	
	}
	
	
	void ReiniciarPartida(){
		SceneManager.LoadScene("CrazyBird");
	}
	
	
	
}
