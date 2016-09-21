using UnityEngine;
using System.Collections;

public class ItemDestroy : MonoBehaviour {
    public GameObject unitychan;
    // Use this for initialization
    void Start () {
        this.unitychan = GameObject.Find("unitychan");
    }
	
	// Update is called once per frame
	void Update ()
    {
       if (this.transform.position.z < this.unitychan.transform.position.z - 30 )
       {
          Destroy(gameObject);
       }
    }
}
