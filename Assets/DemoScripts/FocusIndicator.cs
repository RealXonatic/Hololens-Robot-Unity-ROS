using System;
using System.Collections;
using System.Linq;
using RosMessageTypes.Geometry;
using RosMessageTypes.NiryoMoveit;
using Unity.Robotics.ROSTCPConnector;
using Unity.Robotics.ROSTCPConnector.ROSGeometry;
using UnityEngine;
using System.Collections;
using Microsoft.MixedReality.Toolkit.Input;

public class FocusIndicator : MonoBehaviour, IMixedRealityFocusHandler
{
    public Color focusColor = Color.red; // Couleur lors du focus
    private Color originalColor; // Couleur originale pour restauration
    private Renderer renderer;

    // Durée du focus
    public float focusDuration = 3.0f;
    private bool isFocused = false;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        originalColor = renderer.material.color;
    }

    public void OnFocusEnter(FocusEventData eventData)
    {
        isFocused = true;
        StartCoroutine(ChangeColorOnFocus());
    }

    public void OnFocusExit(FocusEventData eventData)
    {
        isFocused = false;
        // Restauration de la couleur originale si l'utilisateur regarde ailleurs avant la fin du timer
        StopAllCoroutines();
        renderer.material.color = originalColor;
    }

    private IEnumerator ChangeColorOnFocus()
    {
        // Change la couleur pour la durée spécifiée
        renderer.material.color = focusColor;
        yield return new WaitForSeconds(focusDuration);
        
        // Retour à la couleur originale si toujours focus
        if (isFocused)
        {
            renderer.material.color = originalColor;
            isFocused = false;
        }
    }

}