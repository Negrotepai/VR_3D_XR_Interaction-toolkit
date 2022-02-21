using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Grab_ColorChange : MonoBehaviour
{
    public Material GrayColor = null;
    public Material PinkColor = null;
    MeshRenderer meshRenderer = null;
    private XRGrabInteractable grabInteractable = null;
    
    // Start is called before the first frame update
    
    void Awake() {
        gameObject.GetComponent<MeshRenderer>();
        /*grabInteractable = gameObject.GetComponent<XRGrabInteractable>();
        grabInteractable.OnActivate.AddListener(SetColor(PinkColor));
        grabInteractable.OnDeactivate.AddListener(SetColor(GrayColor));
*/
    }

    public void SetColor(Material Color){
        meshRenderer.material = Color;

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
