using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadRandomHead : MonoBehaviour
{
    GameObject aiPlayer;
    public Texture2D head_texture;
    // Start is called before the first frame update
    void Start()
    {
        head_texture = Resources.Load("head_" + Random.Range(0, 11).ToString()) as Texture2D;
        this.GetComponent<RawImage>().texture = head_texture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
