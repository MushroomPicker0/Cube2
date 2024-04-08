using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [HideInInspector]
    public string CharacterStatus = "Idle";
    [Header("Health stats")]
    [SerializeField] private int maxHP;
    [SerializeField] private int minHP;
    private int currentHP;
    [Header("DMG and Speed stats")]
    [SerializeField] [Range(1,20)] private int DMG;
    [SerializeField] [Range(0.1f, 20f)] public float Speed;
    private Rigidbody rb;
    private Vector3 moveVector;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.z = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + moveVector * Speed * Time.deltaTime);
    }
}
