using UnityEngine;
using System.Collections;

public class BloodSpawn : MonoBehaviour {

    public GameObject blood;

    void Damage(GunHit gunhit)
    {
        Instantiate(blood, gunhit.rayhit.point, Quaternion.LookRotation(gunhit.rayhit.normal));
    }

}
