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
        float xInput = Input.GetAxis("Horizontal"); //Input Manager�� ������ش�. (Ű�� �޴� ����)
        float zInput = Input.GetAxis("Vertical"); //p.264 ��Ʈ üũ

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
