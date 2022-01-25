using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
public class TestTween : MonoBehaviour
{
    public Text text;
    public string content;
    // Start is called before the first frame update    
    void Start()
    {
        text.DOText(content, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
