/*===============================================================
Product:   	 EndlessRolling
Developer:   tiki - tikicat@live.cn
Company:     tikicat
Date:        09/10/2016 09:48
================================================================*/
 
using UnityEngine;
using System.Collections;

public class ChangeMaterialOffeset : MonoBehaviour {

    // 位移的数值，越大移动的越快
    public float x;
    public float y;
    // 材质移动的位移
    Vector2 v2;

    Renderer thisRenderer;

    public bool _isIgnoreTimeScale;

    void Awake()
    {
        thisRenderer = GetComponent<Renderer>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (_isIgnoreTimeScale)
            v2 = new Vector2(v2.x + x * Time.unscaledDeltaTime, v2.y + y * Time.unscaledDeltaTime);
        else
            v2 = new Vector2(v2.x + x * Time.deltaTime, v2.y + y * Time.deltaTime);
        if (v2.x > 1)
            v2.x -= 1;
        else if (v2.x < -1)
            v2.x += 1;
        if (v2.y > 1)
            v2.y -= 1;
        else if (v2.y < -1)
            v2.y += 1;
        thisRenderer.material.mainTextureOffset = v2;
        
    }
}
