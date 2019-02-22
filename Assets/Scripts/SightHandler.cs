using UnityEngine;

public class SightHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject sightToSpawn;

    private RectTransform sight;
    private Canvas canvas;

    private void Start()
    {
        sight = Instantiate(sightToSpawn).GetComponent<RectTransform>();
        canvas = FindObjectOfType<Canvas>();
        sight.SetParent(canvas.transform);
    }

    private void Update()
    {
        sight.position = Camera.main.WorldToScreenPoint(transform.position);
        Quaternion rot = sight.rotation;
        rot.eulerAngles = rot.eulerAngles.With(z: -transform.rotation.eulerAngles.y);
        sight.rotation = rot;
    }
}