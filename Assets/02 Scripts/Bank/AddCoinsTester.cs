using System.Collections;
using System.Collections.Generic;
using GameArchitecture;
using UnityEngine;

public class AddCoinsTester : MonoBehaviour
{
    private BankRepository bankRepository;
    private BankInteractor bankInteractor;


    void Start()
    {
        bankRepository = new BankRepository();
        bankRepository.Initialize();

        bankInteractor = new BankInteractor();
        bankInteractor.Initialize();

        Debug.Log("Bank Initialized. Now Coins = " + bankInteractor.coins);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            bankInteractor.AddCoins(this, 5);
            Debug.Log("add coins 5 = " + bankInteractor.coins);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            bankInteractor.Spend(this, 5);
            Debug.Log("spend coins 5 = " + bankInteractor.coins);
        }
    }
}
