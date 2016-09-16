using UnityEngine;
using System.Collections;

public class GunHit{

    public float damage;
    public RaycastHit rayhit;


}

public class FireGun : MonoBehaviour {

    public float delay = 0.1f;
    public LayerMask layerMask = -1;
    public float damage = 2.0f;

    private bool readyToFire = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Mouse0) && readyToFire)
        {
            Debug.Log("Gunshot");
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, layerMask)) {
                GunHit gunhit = new GunHit();
                gunhit.damage = damage;
                hit.collider.SendMessage("Damage", damage, SendMessageOptions.DontRequireReceiver);
            }
         }
	}
}
