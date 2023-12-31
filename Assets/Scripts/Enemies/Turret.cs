using UnityEngine;
using System.Threading.Tasks;

public class Turret : MonoBehaviour
{
    private ITurretStrategy _strategy;

    private void Update() => _strategy?.Update(Time.deltaTime);

    public async void SetPattern(ITurretStrategy strategy)
    {
        if (strategy.GetType() == _strategy?.GetType())
            return;

        if (_strategy != null) 
            await _strategy.StopMove();

        _strategy = strategy;
        await _strategy.StartMove();
    }
}