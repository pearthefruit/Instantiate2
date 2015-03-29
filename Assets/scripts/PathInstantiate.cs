using UnityEngine;
using System.Collections;

public class PathInstantiate : MonoBehaviour {
	public GameObject Cube;
	// Use this for initialization
	void Start () {

//		




	}
	
	// Update is called once per frame
	void Update () {
		int counter = 0;
		if ( counter < 50){
			float random = Random.Range (0f, 1f);
			if(random < 0.25f) {
				transform.Rotate ( 0f, 90f, 0f );
				
			}
			else if (random < 0.5f ) {
				transform.Rotate (0f, -90f, 0f);
			}
			Instantiate ( Cube, transform.position, Quaternion.identity );
			transform.position += transform.forward * 5f;
			counter++;
		}else if (counter > 50){
			Destroy (gameObject);
		}
	}
}
