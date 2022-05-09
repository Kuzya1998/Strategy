
using UnityEngine;

public class Unit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnitSelections.Instance.unitlist.Add(this.gameObject);
    }

    // Update is called once per frame
    void OnDestroy()
    {
        UnitSelections.Instance.unitlist.Remove(this.gameObject);
    }
}
