using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovingScript : MonoBehaviour
{
    [SerializeField] private float _scrollSpeed = 0.5f;
    [SerializeField] private GameObject player;

    public bool _isScrolling = true;

    private float _offset;
    private Material mat;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        PlayerScript playerScript = player.GetComponent<PlayerScript>();
        bool _isDead = playerScript.isDead;

        if(_isScrolling && !_isDead)
        {
            _offset += (Time.deltaTime * _scrollSpeed) / 10;
            mat.SetTextureOffset("_MainTex", new Vector2(_offset, 0));
        }
        else
        {
            _offset =0;
        }
    }
}
