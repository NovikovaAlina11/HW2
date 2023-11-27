using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class xp : MonoBehaviour
{
    public int counter = 10;
    public GameObject Cylinder;
    public Text Message;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(UnityEngine.Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(UnityEngine.Vector3.down * 5 * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(UnityEngine.Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(UnityEngine.Vector3.up * 5 * speed * Time.deltaTime);
        }

        if (counter <= 0)
        {
            this.gameObject.SetActive(false);
            Message.text = "Sphere is deleted";
        }
        else
        {
            Message.text = counter.ToString();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        counter--;
    }
    private void OnCollisionExit(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.black;
    }
    private void OnTriggerEnter(Collider other)
    {

    }
    private void OnTriggerExit(Collider other)
    {

    }

}
