using UnityEngine;
using System.Collections;

public class CubeGod : MonoBehaviour {

	public Transform blueprint; //assign in inspector
	 float cubeSpawnRadius = 10f;
	 float cubeCountMax = 100;
	// Use this for initialization
	void Start () {
		//ITERATION
		//starting from really small, building it up, testing, repeat

		cubeCountMax = Random.Range (100, 1000f);
		cubeSpawnRadius = Random.Range (5f, 100f);
		//how to instantiate multiple cubes
		int cubeCount = 0;
		while ( cubeCount < cubeCountMax ) {
		Instantiate ( blueprint,
			           //  Random.insideUnitSphere * 10f,
			             Random.onUnitSphere * cubeSpawnRadius,
		             // new Vector3( 3.14f, 0.62f, 1f ), 
			             Random.rotation
		            //  Quaternion.Euler (0f, 180f, 0f)
		             );
			cubeCount = cubeCount + 1; // or "cubeCount++;" or "cubeCount += 1;"
		}
	}
	void MakeRandomCube (){
		Instantiate ( blueprint, 
		             Random.onUnitSphere * cubeSpawnRadius,
		             Random.rotation
		             );
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown (KeyCode.R) ) {
			Application.LoadLevel (Application.loadedLevel);
		}

		if ( Input.GetKeyDown (KeyCode.Space) ){
			MakeRandomCube ();
		}

	}
}
