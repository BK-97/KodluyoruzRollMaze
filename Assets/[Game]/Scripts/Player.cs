using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Player : MonoBehaviour
{
    //c# events can have endless parameter
    //public delegate void TestEvent(int i,float f, bool b, string s,Player p);
    //public event TestEvent onTest;
    
    private Rigidbody rigidbody;
    public Rigidbody Rigidbody
    {
        get
        {
            if(rigidbody==null)
            {
                rigidbody = GetComponent<Rigidbody>();
            }
            return rigidbody;
        }
    }

    public DamageEvent onPlayerDamage = new DamageEvent();

    public float MoveSpeed;

    private void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Rigidbody.AddForce(input * MoveSpeed * Time.fixedDeltaTime);

        //Rigidbody.velocity = input * MoveSpeed * Time.deltaTime;
        //You can use both AddForce method and velocity method
        //velocity is more respensive than the AddForce.But velocity may cause problems.
    }
    private void OnTriggerEnter(Collider other)
    {
        ICollectable collectable = other.GetComponent<ICollectable>();
        if (collectable != null) 
        {
            collectable.Collect();
        }
    }
    public int damage;
    public void DamagePlayer()
    {
        onPlayerDamage.Invoke(damage);
    }
}

//unity events can have 4 paramaters
public class DamageEvent : UnityEvent<int> { }