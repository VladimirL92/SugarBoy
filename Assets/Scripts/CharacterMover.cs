using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    [SerializeField] private float speedCharacter = 1;
    [SerializeField] private float forceJump = 1;

    private Rigidbody2D body;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speedCharacter;
        Vector2 offset = new Vector2(x, 0);
        body.position += offset;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(Vector2.up * forceJump);
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log(other);
    }
}
