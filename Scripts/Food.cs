using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {

    private AudioSource audioObj;

    private void Start()
    {
        audioObj = GameObject.Find("GameHelper").GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("SnakeMain"))
		{
            audioObj.Play();
			other.GetComponent<SnakeMovment>().AddTail();
			Destroy(gameObject);
		}
	}

}
