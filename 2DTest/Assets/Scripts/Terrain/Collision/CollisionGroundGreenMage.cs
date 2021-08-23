//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CollisionGroundGreenMage : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }

//    void OnCollisionEnter(Collision collision) {
//            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
//        foreach(ContactPoint contact in collision.contacts) {
//            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
//            //this.transform.SetPositionAndRotation(contact.point, new Quaternion());
//            //Debug.DrawRay(contact.point, contact.normal, Color.white);
//        } // for
//          //if(collision.relativeVelocity.magnitude > 2)
//          //audioSource.Play();
//    }
//    void OnCollisionSStay(Collision collision) {
//        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
//        foreach(ContactPoint contact in collision.contacts) {
//            //this.transform.SetPositionAndRotation(contact.point, new Quaternion());
//            //Debug.DrawRay(contact.point, contact.normal, Color.white);
//        } // for
//          //if(collision.relativeVelocity.magnitude > 2)
//          //audioSource.Play();
//    }
//}
