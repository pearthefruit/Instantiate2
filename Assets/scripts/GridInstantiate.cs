using UnityEngine;
using System.Collections;

public class GridInstantiate : MonoBehaviour {

	public GameObject wall;
	public GameObject floor;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		for (int x = 0; x < 5; x++){
			for (int z = 0; z < 5; z++) {
				float range = Random.Range (0f, 1f);
				Vector3 pos = (new Vector3(x * 5, 0, z * 5) + transform.position);

				if (range < .7f) {
					Instantiate ( floor, pos, floor.transform.rotation);
				}
				else if (range < .95f) {
					Instantiate (wall, pos, wall.transform.rotation);
				}
				else if (range < .05f) {

				}

			}
			Destroy (this.gameObject);
		}
	}
}
