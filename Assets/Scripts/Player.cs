using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerData _playerData;
    public int currentHealth;

    private void Awake()
    {
        _playerData = PlayerPersistance.GetData();
        currentHealth = _playerData.Health;
    }

    private void OnDestroy()
    {
        PlayerPersistance.SaveData(_playerData);
    }

    void Update()
    {
        //Something Happens To Player
        //ModifyHealth(amount);

        if (Input.GetMouseButtonDown(0))
        {
            ModifyHealth(-10);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            _playerData = PlayerPersistance.GetNewPlayerData();
        }

        currentHealth = _playerData.Health;
    }

    public void ModifyHealth(int amount)
    {
        _playerData.Health += amount;
    }
}
