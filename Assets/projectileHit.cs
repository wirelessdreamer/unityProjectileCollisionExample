using UnityEngine;
using System.Collections;

public class projectileHit : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "target") {
            Debug.Log("hit " + other.gameObject.name);
        }
        
        //Destroy(other.gameObject);
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
