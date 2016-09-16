using UnityEngine;
using System.Collections;

public class BulletSpawn : MonoBehaviour {

    public GameObject bullet;
    public float delaytime = 8f;

    private float counter = 0;

    void OnCollitionEnter(Collider col)
    {
        if (col.gameObject.tag == "stop")
        {

            Debug.Log("Test");
            GameObject bombclone = Instantiate(GameObject.FindWithTag("bullet"), transform.position, Quaternion.identity) as GameObject;
            Destroy(bombclone);
        }
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Mouse0) && counter > delaytime)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            counter = 0;

        }

        counter++;
	
	}
}
