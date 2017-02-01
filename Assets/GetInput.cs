using UnityEngine;
using System.Collections;

public class GetInput : MonoBehaviour {
    public GameObject projectile;
    public float speed = 200;
	// Use this for initialization
	void Start () {
	
	}

    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("shot");
            // Instantiate the projectile at the position and rotation of this transform
            GameObject clone;
            clone = (GameObject)Instantiate(projectile, transform.position, transform.rotation);

            // Add force to the cloned object in the object's forward direction
            clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward * speed);
        }
    }
}
