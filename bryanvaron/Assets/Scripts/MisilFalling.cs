using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisilFalling : MonoBehaviour {


    public GameObject MarsExplosion;
     public GameObject JupiterExplosion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision collision) {
        Destroy(gameObject);
        Destroy(collision.gameObject);

        if (collision.gameObject.tag == "MarsAlien");
        {
             GameObject MarsExplosion  = GameObject.Instantiate(Resources.Load("Prefabs/MarsExplosion") as GameObject);
             MarsExplosion.transform.SetParent(this.transform);
             MarsExplosion.transform.localPosition = new Vector3 (-6.85f,-2.65f,1.64f);
             MarsExplosion.transform.SetParent(null);
             Destroy(MarsExplosion,3);
        }
         if (collision.gameObject.tag == "JupiterAlien");
          {
                GameObject JupiterExplosion  = GameObject.Instantiate(Resources.Load("Prefabs/JupiterExplosion") as GameObject);
                JupiterExplosion.transform.SetParent(this.transform);
                JupiterExplosion.transform.localPosition = new Vector3 (-6.85f,-2.65f,1.64f);
                JupiterExplosion.transform.SetParent(null);
                Destroy(JupiterExplosion,3);
           }



    }
}
