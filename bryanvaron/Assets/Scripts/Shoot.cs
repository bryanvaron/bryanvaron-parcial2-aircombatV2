using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    //public Transform  avion;
    //public GameObject Misil;


	public GameObject Misil;
    public AudioClip launch;
    AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


	
	// Update is called once per frame
	void Update () {


        // si el usuario presiona la tecla espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Creo un game object a partir de la informacion guardada
            // en un prefab

			GameObject misil = GameObject.Instantiate(Resources.Load("Prefabs/Misil") as GameObject);

		

            //Hago que else misil sea hijo del avion 
            misil.transform.SetParent(this.transform);


            //Muevo el misil a la posicion 
			misil.transform.localPosition = new Vector3 (-6.85f,-2.65f,1.64f);


            // Saco al misil del avion 
            misil.transform.SetParent(null);
            audioSource.PlayOneShot(launch, 0.7F);

        }

        // mover el avion

        if (Input.GetKey(KeyCode.UpArrow)) {
			this.transform.Translate (0.0f, 0.5f, 0.0f);
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			this.transform.Translate (0.0f, -0.5f, 0.0f);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			this.transform.Translate (0.5f, 0.0f, 0.0f);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			this.transform.Translate (-0.5f, 0.0f, 0.0f);
		}

        {
           transform.Translate(Vector3.forward * Time.deltaTime * 15);
        }
   





	}
}
