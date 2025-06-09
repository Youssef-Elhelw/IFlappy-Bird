using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    // Start is called before the first frame update
    public MeshRenderer meshRender;
    public float animationSpeed;

    void Awake()
    {
        meshRender = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        meshRender.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
