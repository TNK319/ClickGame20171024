using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public GameObject SpherePrefab;
	
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Sphere=
                Instantiate(SpherePrefab)
                as GameObject;
            Sphere.GetComponent<get>().Shoot(
                new Vector3( -500, 0, 0));
        }
	}
}
