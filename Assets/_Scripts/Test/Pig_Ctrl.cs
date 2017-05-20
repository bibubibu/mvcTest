using UnityEngine;
using System.Collections;

public class Pig_Ctrl : MonoBehaviour {
    public Transform ter_pos;

	// Use this for initialization
	void Start () {
        ter_pos = GameObject.FindGameObjectWithTag("TerPos").transform;
        transform.LookAt(ter_pos);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, ter_pos.position, Time.deltaTime);
	}

    public void OnClick()
    {

    }
}
