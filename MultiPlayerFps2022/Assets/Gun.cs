
using UnityEngine;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update


    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

    public ParticleSystem muzzleFlash;

    public AudioSource shootSound;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {

            Shoot();
        
        }
        
    }

    void Shoot() 
    
    {
        muzzleFlash.Play();
        shootSound.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        { 
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();

            if(target !=null)
            {
                target.TakeDamage(damage);

            }
        
        }
    
    }
}
