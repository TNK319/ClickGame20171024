using UnityEngine;
using System.Collections;

public class get : MonoBehaviour
{
    Vector3 setpotion;
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    private void OnCollisionEnter(Collision other)
    {
        DestroyObject(gameObject);
    }
    // Use this for initialization
    void Start()
    {
        setpotion = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.magnitude > 10.0f)
        {
            Destroy(gameObject);    // 自分自身を削除
        }
    }
}