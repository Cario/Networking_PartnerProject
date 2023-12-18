using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Move : MonoBehaviour
{
    public float speed = 20f;
    PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if(view.IsMine)
        {
            Vector3 pos = transform.position;

            if (Input.GetKey("d"))
            {
                pos.z += speed * Time.deltaTime;
            }
            if (Input.GetKey("a"))
            {
                pos.z -= speed * Time.deltaTime;
            }
            if (Input.GetKey("s"))
            {
                pos.x += speed * Time.deltaTime;
            }
            if (Input.GetKey("w"))
            {
                pos.x -= speed * Time.deltaTime;
            }
            transform.position = pos;
        }
    }
}
