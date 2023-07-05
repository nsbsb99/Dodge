using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelController : MonoBehaviour
{
    private Rigidbody playerRigid = default;
    private float speed = 8.0f;


    // Start is called before the first frame update
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float xInput = Input.GetAxis("Horizontal"); //Input Manager가 대신해준다. (키를 받는 것을)
        float zInput = Input.GetAxis("Vertical"); //p.264 노트 체크

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3 (xSpeed,0f, zSpeed);
        playerRigid.velocity = newVelocity;
    }

    public void Die()
    {
        gameObject.SetActive(false);
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
